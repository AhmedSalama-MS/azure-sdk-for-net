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
    /// How the Batch service should respond when a task completes.
    /// </summary>
    public partial class ExitConditions : ITransportObjectProvider<Models.ExitConditions>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<ExitOptions> DefaultProperty;
            public readonly PropertyAccessor<IList<ExitCodeRangeMapping>> ExitCodeRangesProperty;
            public readonly PropertyAccessor<IList<ExitCodeMapping>> ExitCodesProperty;
            public readonly PropertyAccessor<ExitOptions> SchedulingErrorProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.DefaultProperty = this.CreatePropertyAccessor<ExitOptions>("Default", BindingAccess.Read | BindingAccess.Write);
                this.ExitCodeRangesProperty = this.CreatePropertyAccessor<IList<ExitCodeRangeMapping>>("ExitCodeRanges", BindingAccess.Read | BindingAccess.Write);
                this.ExitCodesProperty = this.CreatePropertyAccessor<IList<ExitCodeMapping>>("ExitCodes", BindingAccess.Read | BindingAccess.Write);
                this.SchedulingErrorProperty = this.CreatePropertyAccessor<ExitOptions>("SchedulingError", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.ExitConditions protocolObject) : base(BindingState.Bound)
            {
                this.DefaultProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.DefaultProperty, o => new ExitOptions(o).Freeze()),
                    "Default",
                    BindingAccess.Read);
                this.ExitCodeRangesProperty = this.CreatePropertyAccessor(
                    ExitCodeRangeMapping.ConvertFromProtocolCollectionAndFreeze(protocolObject.ExitCodeRanges),
                    "ExitCodeRanges",
                    BindingAccess.Read);
                this.ExitCodesProperty = this.CreatePropertyAccessor(
                    ExitCodeMapping.ConvertFromProtocolCollectionAndFreeze(protocolObject.ExitCodes),
                    "ExitCodes",
                    BindingAccess.Read);
                this.SchedulingErrorProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.SchedulingError, o => new ExitOptions(o).Freeze()),
                    "SchedulingError",
                    BindingAccess.Read);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ExitConditions"/> class.
        /// </summary>
        public ExitConditions()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal ExitConditions(Models.ExitConditions protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region ExitConditions

        /// <summary>
        /// Gets or sets how the Batch service should respond if the task fails with an exit condition not covered by any 
        /// of the other properties.
        /// </summary>
        /// <remarks>
        /// This value is used if the task exits with any nonzero exit code not listed in the <see cref="ExitCodes"/> or 
        /// <see cref="ExitCodeRanges"/> collection, or with a scheduling error if the <see cref="SchedulingError"/> property 
        /// is not present.
        /// </remarks>
        public ExitOptions Default
        {
            get { return this.propertyContainer.DefaultProperty.Value; }
            set { this.propertyContainer.DefaultProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of task exit code ranges and how the Batch service should respond to them.
        /// </summary>
        public IList<ExitCodeRangeMapping> ExitCodeRanges
        {
            get { return this.propertyContainer.ExitCodeRangesProperty.Value; }
            set
            {
                this.propertyContainer.ExitCodeRangesProperty.Value = ConcurrentChangeTrackedModifiableList<ExitCodeRangeMapping>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets a list of task exit codes and how the Batch service should respond to them.
        /// </summary>
        public IList<ExitCodeMapping> ExitCodes
        {
            get { return this.propertyContainer.ExitCodesProperty.Value; }
            set
            {
                this.propertyContainer.ExitCodesProperty.Value = ConcurrentChangeTrackedModifiableList<ExitCodeMapping>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets how the Batch service should respond if the task fails with a scheduling error.
        /// </summary>
        public ExitOptions SchedulingError
        {
            get { return this.propertyContainer.SchedulingErrorProperty.Value; }
            set { this.propertyContainer.SchedulingErrorProperty.Value = value; }
        }

        #endregion // ExitConditions

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
        Models.ExitConditions ITransportObjectProvider<Models.ExitConditions>.GetTransportObject()
        {
            Models.ExitConditions result = new Models.ExitConditions()
            {
                DefaultProperty = UtilitiesInternal.CreateObjectWithNullCheck(this.Default, (o) => o.GetTransportObject()),
                ExitCodeRanges = UtilitiesInternal.ConvertToProtocolCollection(this.ExitCodeRanges),
                ExitCodes = UtilitiesInternal.ConvertToProtocolCollection(this.ExitCodes),
                SchedulingError = UtilitiesInternal.CreateObjectWithNullCheck(this.SchedulingError, (o) => o.GetTransportObject()),
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<ExitConditions> ConvertFromProtocolCollection(IEnumerable<Models.ExitConditions> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ExitConditions> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ExitConditions(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<ExitConditions> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.ExitConditions> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ExitConditions> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ExitConditions(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<ExitConditions> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.ExitConditions> protoCollection)
        {
            IReadOnlyList<ExitConditions> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new ExitConditions(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}