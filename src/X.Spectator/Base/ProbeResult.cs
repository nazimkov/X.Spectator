using System;

namespace X.Spectator.Base
{
    public struct ProbeResult
    {
        /// <summary>
        /// Probe name
        /// </summary>
        public string ProbeName { get; set; }
        public DateTime Time { get; set; }
        public bool Success { get; set; }
        public string Data { get; set; }
        public Exception Exception { get; set; }

        public override string ToString() => $"{Time}: {Success}";
    }
}