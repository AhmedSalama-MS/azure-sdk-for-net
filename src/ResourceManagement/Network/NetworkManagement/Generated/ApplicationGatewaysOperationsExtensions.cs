namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure;
    using Models;

    public static partial class ApplicationGatewaysOperationsExtensions
    {
            /// <summary>
            /// The delete applicationgateway operation deletes the specified
            /// applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            public static void Delete(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).DeleteAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete applicationgateway operation deletes the specified
            /// applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete applicationgateway operation deletes the specified
            /// applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            public static void BeginDelete(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginDeleteAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete applicationgateway operation deletes the specified
            /// applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get applicationgateway operation retreives information about the
            /// specified applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            public static ApplicationGateway Get(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).GetAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get applicationgateway operation retreives information about the
            /// specified applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ApplicationGateway> GetAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ApplicationGateway> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            public static ApplicationGateway CreateOrUpdate(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).CreateOrUpdateAsync(resourceGroupName, applicationGatewayName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ApplicationGateway> CreateOrUpdateAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ApplicationGateway> result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            public static ApplicationGateway BeginCreateOrUpdate(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, applicationGatewayName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ApplicationGateway> BeginCreateOrUpdateAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ApplicationGateway> result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The List ApplicationGateway opertion retrieves all the applicationgateways
            /// in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static ApplicationGatewayListResult List(this IApplicationGatewaysOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ApplicationGateway opertion retrieves all the applicationgateways
            /// in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayListResult> ListAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ApplicationGatewayListResult> result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The List applicationgateway opertion retrieves all the applicationgateways
            /// in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static ApplicationGatewayListResult ListAll(this IApplicationGatewaysOperations operations)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List applicationgateway opertion retrieves all the applicationgateways
            /// in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayListResult> ListAllAsync( this IApplicationGatewaysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ApplicationGatewayListResult> result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Start(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).StartAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task StartAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StartWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginStart(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginStartAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginStartAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Stop(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).StopAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task StopAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StopWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginStop(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginStopAsync(resourceGroupName, applicationGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginStopAsync( this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The List ApplicationGateway opertion retrieves all the applicationgateways
            /// in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static ApplicationGatewayListResult ListNext(this IApplicationGatewaysOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ApplicationGateway opertion retrieves all the applicationgateways
            /// in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayListResult> ListNextAsync( this IApplicationGatewaysOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ApplicationGatewayListResult> result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The List applicationgateway opertion retrieves all the applicationgateways
            /// in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static ApplicationGatewayListResult ListAllNext(this IApplicationGatewaysOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListAllNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List applicationgateway opertion retrieves all the applicationgateways
            /// in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ApplicationGatewayListResult> ListAllNextAsync( this IApplicationGatewaysOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ApplicationGatewayListResult> result = await operations.ListAllNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}