// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Redis.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Redis
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Redis. </summary>
    public static partial class RedisExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Checks that the redis cache name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cache/CheckNameAvailability
        /// Operation Id: Redis_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability Redis operation. The only supported resource type is &apos;Microsoft.Cache/redis&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response> CheckRedisNameAvailabilityAsync(this SubscriptionResource subscriptionResource, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckRedisNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the redis cache name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cache/CheckNameAvailability
        /// Operation Id: Redis_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability Redis operation. The only supported resource type is &apos;Microsoft.Cache/redis&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response CheckRedisNameAvailability(this SubscriptionResource subscriptionResource, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckRedisNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Gets all Redis caches in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cache/redis
        /// Operation Id: Redis_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<RedisResource> GetRedisAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetRedisAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all Redis caches in the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cache/redis
        /// Operation Id: Redis_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<RedisResource> GetRedis(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetRedis(cancellationToken);
        }

        /// <summary>
        /// For checking the ongoing status of an operation
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/asyncOperations/{operationId}
        /// Operation Id: AsyncOperationStatus_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location at which operation was triggered. </param>
        /// <param name="operationId"> The ID of asynchronous operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static async Task<Response<OperationStatus>> GetAsyncOperationStatusAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetAsyncOperationStatusAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// For checking the ongoing status of an operation
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/asyncOperations/{operationId}
        /// Operation Id: AsyncOperationStatus_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location at which operation was triggered. </param>
        /// <param name="operationId"> The ID of asynchronous operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static Response<OperationStatus> GetAsyncOperationStatus(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetAsyncOperationStatus(location, operationId, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of RedisResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of RedisResources and their operations over a RedisResource. </returns>
        public static RedisCollection GetRedis(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetRedis();
        }

        /// <summary>
        /// Gets a Redis cache (resource description).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}
        /// Operation Id: Redis_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<RedisResource>> GetRedisAsync(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetRedis().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Redis cache (resource description).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}
        /// Operation Id: Redis_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<RedisResource> GetRedis(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetRedis().Get(name, cancellationToken);
        }

        #region RedisResource
        /// <summary>
        /// Gets an object representing a <see cref="RedisResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisResource.CreateResourceIdentifier" /> to create a <see cref="RedisResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RedisResource" /> object. </returns>
        public static RedisResource GetRedisResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RedisResource.ValidateResourceId(id);
                return new RedisResource(client, id);
            }
            );
        }
        #endregion

        #region RedisFirewallRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="RedisFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="RedisFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RedisFirewallRuleResource" /> object. </returns>
        public static RedisFirewallRuleResource GetRedisFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RedisFirewallRuleResource.ValidateResourceId(id);
                return new RedisFirewallRuleResource(client, id);
            }
            );
        }
        #endregion

        #region RedisPatchScheduleResource
        /// <summary>
        /// Gets an object representing a <see cref="RedisPatchScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisPatchScheduleResource.CreateResourceIdentifier" /> to create a <see cref="RedisPatchScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RedisPatchScheduleResource" /> object. </returns>
        public static RedisPatchScheduleResource GetRedisPatchScheduleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RedisPatchScheduleResource.ValidateResourceId(id);
                return new RedisPatchScheduleResource(client, id);
            }
            );
        }
        #endregion

        #region RedisLinkedServerWithPropertiesResource
        /// <summary>
        /// Gets an object representing a <see cref="RedisLinkedServerWithPropertiesResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisLinkedServerWithPropertiesResource.CreateResourceIdentifier" /> to create a <see cref="RedisLinkedServerWithPropertiesResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RedisLinkedServerWithPropertiesResource" /> object. </returns>
        public static RedisLinkedServerWithPropertiesResource GetRedisLinkedServerWithPropertiesResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RedisLinkedServerWithPropertiesResource.ValidateResourceId(id);
                return new RedisLinkedServerWithPropertiesResource(client, id);
            }
            );
        }
        #endregion

        #region RedisPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="RedisPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RedisPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="RedisPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RedisPrivateEndpointConnectionResource" /> object. </returns>
        public static RedisPrivateEndpointConnectionResource GetRedisPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RedisPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new RedisPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion
    }
}
