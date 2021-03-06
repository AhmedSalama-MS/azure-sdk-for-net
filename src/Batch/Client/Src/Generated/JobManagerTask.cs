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
    /// Represents an Azure Batch JobManager task. 
    /// </summary>
    public partial class JobManagerTask : ITransportObjectProvider<Models.JobManagerTask>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<IList<ApplicationPackageReference>> ApplicationPackageReferencesProperty;
            public readonly PropertyAccessor<string> CommandLineProperty;
            public readonly PropertyAccessor<TaskConstraints> ConstraintsProperty;
            public readonly PropertyAccessor<string> DisplayNameProperty;
            public readonly PropertyAccessor<IList<EnvironmentSetting>> EnvironmentSettingsProperty;
            public readonly PropertyAccessor<string> IdProperty;
            public readonly PropertyAccessor<bool?> KillJobOnCompletionProperty;
            public readonly PropertyAccessor<IList<ResourceFile>> ResourceFilesProperty;
            public readonly PropertyAccessor<bool?> RunElevatedProperty;
            public readonly PropertyAccessor<bool?> RunExclusiveProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor<IList<ApplicationPackageReference>>("ApplicationPackageReferences", BindingAccess.Read | BindingAccess.Write);
                this.CommandLineProperty = this.CreatePropertyAccessor<string>("CommandLine", BindingAccess.Read | BindingAccess.Write);
                this.ConstraintsProperty = this.CreatePropertyAccessor<TaskConstraints>("Constraints", BindingAccess.Read | BindingAccess.Write);
                this.DisplayNameProperty = this.CreatePropertyAccessor<string>("DisplayName", BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor<IList<EnvironmentSetting>>("EnvironmentSettings", BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor<string>("Id", BindingAccess.Read | BindingAccess.Write);
                this.KillJobOnCompletionProperty = this.CreatePropertyAccessor<bool?>("KillJobOnCompletion", BindingAccess.Read | BindingAccess.Write);
                this.ResourceFilesProperty = this.CreatePropertyAccessor<IList<ResourceFile>>("ResourceFiles", BindingAccess.Read | BindingAccess.Write);
                this.RunElevatedProperty = this.CreatePropertyAccessor<bool?>("RunElevated", BindingAccess.Read | BindingAccess.Write);
                this.RunExclusiveProperty = this.CreatePropertyAccessor<bool?>("RunExclusive", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.JobManagerTask protocolObject) : base(BindingState.Bound)
            {
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor(
                    ApplicationPackageReference.ConvertFromProtocolCollectionAndFreeze(protocolObject.ApplicationPackageReferences),
                    "ApplicationPackageReferences",
                    BindingAccess.Read);
                this.CommandLineProperty = this.CreatePropertyAccessor(
                    protocolObject.CommandLine,
                    "CommandLine",
                    BindingAccess.Read | BindingAccess.Write);
                this.ConstraintsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Constraints, o => new TaskConstraints(o)),
                    "Constraints",
                    BindingAccess.Read | BindingAccess.Write);
                this.DisplayNameProperty = this.CreatePropertyAccessor(
                    protocolObject.DisplayName,
                    "DisplayName",
                    BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor(
                    EnvironmentSetting.ConvertFromProtocolCollection(protocolObject.EnvironmentSettings),
                    "EnvironmentSettings",
                    BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor(
                    protocolObject.Id,
                    "Id",
                    BindingAccess.Read | BindingAccess.Write);
                this.KillJobOnCompletionProperty = this.CreatePropertyAccessor(
                    protocolObject.KillJobOnCompletion,
                    "KillJobOnCompletion",
                    BindingAccess.Read | BindingAccess.Write);
                this.ResourceFilesProperty = this.CreatePropertyAccessor(
                    ResourceFile.ConvertFromProtocolCollection(protocolObject.ResourceFiles),
                    "ResourceFiles",
                    BindingAccess.Read | BindingAccess.Write);
                this.RunElevatedProperty = this.CreatePropertyAccessor(
                    protocolObject.RunElevated,
                    "RunElevated",
                    BindingAccess.Read | BindingAccess.Write);
                this.RunExclusiveProperty = this.CreatePropertyAccessor(
                    protocolObject.RunExclusive,
                    "RunExclusive",
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JobManagerTask"/> class.
        /// </summary>
        /// <param name='id'>The id of the task.</param>
        /// <param name='commandLine'>The command line of the task.</param>
        public JobManagerTask(
            string id,
            string commandLine)
        {
            this.propertyContainer = new PropertyContainer();
            this.Id = id;
            this.CommandLine = commandLine;
        }

        internal JobManagerTask(Models.JobManagerTask protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region JobManagerTask

        /// <summary>
        /// Gets or sets a list of application packages that the Batch service will deploy to the compute node before running 
        /// the command line.
        /// </summary>
        public IList<ApplicationPackageReference> ApplicationPackageReferences
        {
            get { return this.propertyContainer.ApplicationPackageReferencesProperty.Value; }
            set
            {
                this.propertyContainer.ApplicationPackageReferencesProperty.Value = ConcurrentChangeTrackedModifiableList<ApplicationPackageReference>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the command line of the task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment 
        /// variable expansion. If you want to take advantage of such features, you should invoke the shell in the command 
        /// line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux.
        /// </remarks>
        public string CommandLine
        {
            get { return this.propertyContainer.CommandLineProperty.Value; }
            set { this.propertyContainer.CommandLineProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the execution constraints for this JobManager task.
        /// </summary>
        public TaskConstraints Constraints
        {
            get { return this.propertyContainer.ConstraintsProperty.Value; }
            set { this.propertyContainer.ConstraintsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the display name of the JobManager task.
        /// </summary>
        public string DisplayName
        {
            get { return this.propertyContainer.DisplayNameProperty.Value; }
            set { this.propertyContainer.DisplayNameProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a set of environment settings for the JobManager task.
        /// </summary>
        public IList<EnvironmentSetting> EnvironmentSettings
        {
            get { return this.propertyContainer.EnvironmentSettingsProperty.Value; }
            set
            {
                this.propertyContainer.EnvironmentSettingsProperty.Value = ConcurrentChangeTrackedModifiableList<EnvironmentSetting>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the id of the task.
        /// </summary>
        public string Id
        {
            get { return this.propertyContainer.IdProperty.Value; }
            set { this.propertyContainer.IdProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether to terminate all tasks in the job and complete the job when the job 
        /// manager task completes.
        /// </summary>
        public bool? KillJobOnCompletion
        {
            get { return this.propertyContainer.KillJobOnCompletionProperty.Value; }
            set { this.propertyContainer.KillJobOnCompletionProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download to the compute node before running the command 
        /// line.
        /// </summary>
        public IList<ResourceFile> ResourceFiles
        {
            get { return this.propertyContainer.ResourceFilesProperty.Value; }
            set
            {
                this.propertyContainer.ResourceFilesProperty.Value = ConcurrentChangeTrackedModifiableList<ResourceFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets whether to run the task in elevated mode.
        /// </summary>
        public bool? RunElevated
        {
            get { return this.propertyContainer.RunElevatedProperty.Value; }
            set { this.propertyContainer.RunElevatedProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether the Job Manager task requires exclusive use of the compute node where it runs.
        /// </summary>
        public bool? RunExclusive
        {
            get { return this.propertyContainer.RunExclusiveProperty.Value; }
            set { this.propertyContainer.RunExclusiveProperty.Value = value; }
        }

        #endregion // JobManagerTask

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.JobManagerTask ITransportObjectProvider<Models.JobManagerTask>.GetTransportObject()
        {
            Models.JobManagerTask result = new Models.JobManagerTask()
            {
                ApplicationPackageReferences = UtilitiesInternal.ConvertToProtocolCollection(this.ApplicationPackageReferences),
                CommandLine = this.CommandLine,
                Constraints = UtilitiesInternal.CreateObjectWithNullCheck(this.Constraints, (o) => o.GetTransportObject()),
                DisplayName = this.DisplayName,
                EnvironmentSettings = UtilitiesInternal.ConvertToProtocolCollection(this.EnvironmentSettings),
                Id = this.Id,
                KillJobOnCompletion = this.KillJobOnCompletion,
                ResourceFiles = UtilitiesInternal.ConvertToProtocolCollection(this.ResourceFiles),
                RunElevated = this.RunElevated,
                RunExclusive = this.RunExclusive,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}