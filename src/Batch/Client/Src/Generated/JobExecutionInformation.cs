//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about the execution of an Azure Batch job.
    /// </summary>
    public partial class JobExecutionInformation : IPropertyMetadata
    {
        private readonly DateTime? endTime;
        private readonly string poolId;
        private readonly JobSchedulingError schedulingError;
        private readonly DateTime startTime;
        private readonly string terminateReason;

        #region Constructors

        internal JobExecutionInformation(Models.JobExecutionInformation protocolObject)
        {
            this.endTime = protocolObject.EndTime;
            this.poolId = protocolObject.PoolId;
            this.schedulingError = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.SchedulingError, o => new JobSchedulingError(o).Freeze());
            this.startTime = protocolObject.StartTime;
            this.terminateReason = protocolObject.TerminateReason;
        }

        #endregion Constructors

        #region JobExecutionInformation

        /// <summary>
        /// Gets the completion time of this job.
        /// </summary>
        public DateTime? EndTime
        {
            get { return this.endTime; }
        }

        /// <summary>
        /// Gets the pool Id of this job.
        /// </summary>
        public string PoolId
        {
            get { return this.poolId; }
        }

        /// <summary>
        /// Gets the error encountered by the Batch service in scheduling the job.
        /// </summary>
        public JobSchedulingError SchedulingError
        {
            get { return this.schedulingError; }
        }

        /// <summary>
        /// Gets the creation time of the job.
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime; }
        }

        /// <summary>
        /// Gets the reason for job moving to completed state.
        /// </summary>
        public string TerminateReason
        {
            get { return this.terminateReason; }
        }

        #endregion // JobExecutionInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}