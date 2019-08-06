using System;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running;

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("StopWatch is allready running1");

            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("StopWatch is not running1");

            _stopTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetInterval()
        {
            return _stopTime - _startTime; ;
        }
    }
}