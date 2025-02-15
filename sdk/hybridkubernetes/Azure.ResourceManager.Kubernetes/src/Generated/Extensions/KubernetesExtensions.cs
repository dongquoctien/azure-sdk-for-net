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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Kubernetes
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Kubernetes. </summary>
    public static partial class KubernetesExtensions
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
        /// API to enumerate registered connected K8s clusters under a Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kubernetes/connectedClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConnectedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConnectedClusterResource> GetConnectedClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetConnectedClustersAsync(cancellationToken);
        }

        /// <summary>
        /// API to enumerate registered connected K8s clusters under a Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kubernetes/connectedClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConnectedClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConnectedClusterResource> GetConnectedClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetConnectedClusters(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ConnectedClusterResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ConnectedClusterResources and their operations over a ConnectedClusterResource. </returns>
        public static ConnectedClusterCollection GetConnectedClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetConnectedClusters();
        }

        /// <summary>
        /// Returns the properties of the specified connected cluster, including name, identity, properties, and additional cluster details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Kubernetes/connectedClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Kubernetes cluster on which get is called. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ConnectedClusterResource>> GetConnectedClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetConnectedClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties of the specified connected cluster, including name, identity, properties, and additional cluster details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Kubernetes/connectedClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedCluster_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Kubernetes cluster on which get is called. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ConnectedClusterResource> GetConnectedCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetConnectedClusters().Get(clusterName, cancellationToken);
        }

        #region ConnectedClusterResource
        /// <summary>
        /// Gets an object representing a <see cref="ConnectedClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectedClusterResource.CreateResourceIdentifier" /> to create a <see cref="ConnectedClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectedClusterResource" /> object. </returns>
        public static ConnectedClusterResource GetConnectedClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConnectedClusterResource.ValidateResourceId(id);
                return new ConnectedClusterResource(client, id);
            }
            );
        }
        #endregion
    }
}
