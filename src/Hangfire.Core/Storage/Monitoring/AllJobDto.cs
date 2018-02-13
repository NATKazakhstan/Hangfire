namespace Hangfire.Storage.Monitoring
{
    using System;

    using Hangfire.Common;

    public class AllJobDto
    {
        public Job Job { get; set; }
        public bool InEnqueuedState { get; set; }
        public bool InProcessingState { get; set; }
        public bool InFailedState { get; set; }
        public bool InScheduledState { get; set; }
        public bool InSucceededState { get; set; }
        public string ServerId { get; set; }
        public string StateName { get; set; }
    }
}