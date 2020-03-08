using System;
using System.Threading;
using System.Threading.Tasks;
using SharpDX.DirectInput;

namespace Android_Photo_Booth
{
    internal sealed class JoystickObserver : IDisposable
    {
        private bool _disposed;
        private Task ObserverTask { get; set; }
        private CancellationTokenSource CancellationTokenSource { get; set; }

        public JoystickObserver(JoystickInfo joystickInfo)
        {
            JoystickInfo = joystickInfo;
        }

        public JoystickInfo JoystickInfo { get; }

        public event EventHandler<JoystickUpdate> OnJoystickUpdate;

        public void Start()
        {
            CancellationTokenSource = new CancellationTokenSource();

            ObserverTask = Task.Run(() => PollJoystick(CancellationTokenSource.Token), CancellationTokenSource.Token);
        }

        private async void PollJoystick(CancellationToken cancellationToken)
        {
            var joystick = JoystickInfo.Joystick;

            try
            {
                joystick.Properties.BufferSize = 128;
                joystick.Acquire();

                while (true)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }

                    joystick.Poll();
                    JoystickUpdate[] updates = joystick.GetBufferedData();

                    foreach (JoystickUpdate update in updates)
                    {
                        OnJoystickUpdate?.Invoke(this, update);
                    }

                    await Task.Delay(1, cancellationToken);
                }
            }
            catch (OperationCanceledException)
            {
            }
            finally
            {
                joystick?.Unacquire();
            }
        }

        public void Stop()
        {
            CancellationTokenSource?.Cancel();
            ObserverTask?.Wait(500);

            CancellationTokenSource = null;
            ObserverTask = null;
        }

        ~JoystickObserver()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                Stop();
            }

            _disposed = true;
        }
    }
}