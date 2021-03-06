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
    /// The network configuration for a pool.
    /// </summary>
    public partial class NetworkConfiguration : ITransportObjectProvider<Models.NetworkConfiguration>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<string> SubnetIdProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.SubnetIdProperty = this.CreatePropertyAccessor<string>("SubnetId", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.NetworkConfiguration protocolObject) : base(BindingState.Bound)
            {
                this.SubnetIdProperty = this.CreatePropertyAccessor(
                    protocolObject.SubnetId,
                    "SubnetId",
                    BindingAccess.Read);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConfiguration"/> class.
        /// </summary>
        public NetworkConfiguration()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal NetworkConfiguration(Models.NetworkConfiguration protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region NetworkConfiguration

        /// <summary>
        /// Gets or sets the ARM resource identifier of the virtual network subnet which the compute nodes of the pool will 
        /// join.
        /// </summary>
        /// <remarks>
        /// The virtual network must be in the same region and subscription as the Azure Batch account, and the specified 
        /// subnet should have enough spare IP addresses to accommodate the number of nodes in the pool. This property can 
        /// only be specified for pools created with a <see cref="CloudPool.CloudServiceConfiguration"/>.
        /// </remarks>
        public string SubnetId
        {
            get { return this.propertyContainer.SubnetIdProperty.Value; }
            set { this.propertyContainer.SubnetIdProperty.Value = value; }
        }

        #endregion // NetworkConfiguration

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
        Models.NetworkConfiguration ITransportObjectProvider<Models.NetworkConfiguration>.GetTransportObject()
        {
            Models.NetworkConfiguration result = new Models.NetworkConfiguration()
            {
                SubnetId = this.SubnetId,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}