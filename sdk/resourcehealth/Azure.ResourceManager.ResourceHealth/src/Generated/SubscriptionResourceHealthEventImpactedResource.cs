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

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A Class representing a SubscriptionResourceHealthEventImpactedResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SubscriptionResourceHealthEventImpactedResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSubscriptionResourceHealthEventImpactedResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionEventResource" /> using the GetSubscriptionResourceHealthEventImpactedResource method.
    /// </summary>
    public partial class SubscriptionResourceHealthEventImpactedResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionResourceHealthEventImpactedResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string eventTrackingId, string impactedResourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics;
        private readonly ImpactedResourcesRestOperations _subscriptionResourceHealthEventImpactedResourceImpactedResourcesRestClient;
        private readonly EventImpactedResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceHealthEventImpactedResource"/> class for mocking. </summary>
        protected SubscriptionResourceHealthEventImpactedResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionResourceHealthEventImpactedResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionResourceHealthEventImpactedResource(ArmClient client, EventImpactedResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceHealthEventImpactedResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceHealthEventImpactedResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionResourceHealthEventImpactedResourceImpactedResourcesApiVersion);
            _subscriptionResourceHealthEventImpactedResourceImpactedResourcesRestClient = new ImpactedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionResourceHealthEventImpactedResourceImpactedResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ResourceHealth/events/impactedResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EventImpactedResourceData Data
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
        /// Gets the specific impacted resource in the subscription by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionResourceHealthEventImpactedResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("SubscriptionResourceHealthEventImpactedResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionResourceHealthEventImpactedResourceImpactedResourcesRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionResourceHealthEventImpactedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specific impacted resource in the subscription by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionResourceHealthEventImpactedResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionResourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("SubscriptionResourceHealthEventImpactedResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionResourceHealthEventImpactedResourceImpactedResourcesRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionResourceHealthEventImpactedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
