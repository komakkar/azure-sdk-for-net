// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PostgreSql.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A Class representing a ServerSecurityAlertPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ServerSecurityAlertPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetServerSecurityAlertPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServerResource" /> using the GetServerSecurityAlertPolicy method.
    /// </summary>
    public partial class ServerSecurityAlertPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerSecurityAlertPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, SecurityAlertPolicyName securityAlertPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverSecurityAlertPolicyClientDiagnostics;
        private readonly ServerSecurityAlertPoliciesRestOperations _serverSecurityAlertPolicyRestClient;
        private readonly ServerSecurityAlertPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerSecurityAlertPolicyResource"/> class for mocking. </summary>
        protected ServerSecurityAlertPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerSecurityAlertPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerSecurityAlertPolicyResource(ArmClient client, ServerSecurityAlertPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerSecurityAlertPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerSecurityAlertPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverSecurityAlertPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serverSecurityAlertPolicyApiVersion);
            _serverSecurityAlertPolicyRestClient = new ServerSecurityAlertPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverSecurityAlertPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DBforPostgreSQL/servers/securityAlertPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServerSecurityAlertPolicyData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a server&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: ServerSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerSecurityAlertPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _serverSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a server&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: ServerSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerSecurityAlertPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _serverSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a threat detection policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: ServerSecurityAlertPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerSecurityAlertPolicyResource>> UpdateAsync(WaitUntil waitUntil, ServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _serverSecurityAlertPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new PostgreSqlArmOperation<ServerSecurityAlertPolicyResource>(new ServerSecurityAlertPolicyOperationSource(Client), _serverSecurityAlertPolicyClientDiagnostics, Pipeline, _serverSecurityAlertPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a threat detection policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: ServerSecurityAlertPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServerSecurityAlertPolicyResource> Update(WaitUntil waitUntil, ServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverSecurityAlertPolicyClientDiagnostics.CreateScope("ServerSecurityAlertPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _serverSecurityAlertPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new PostgreSqlArmOperation<ServerSecurityAlertPolicyResource>(new ServerSecurityAlertPolicyOperationSource(Client), _serverSecurityAlertPolicyClientDiagnostics, Pipeline, _serverSecurityAlertPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
