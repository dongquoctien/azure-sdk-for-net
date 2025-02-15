// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GraphServices.Models
{
    public partial class GraphServicesAccountResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("appId"u8);
            writer.WriteStringValue(AppId);
            writer.WriteEndObject();
        }

        internal static GraphServicesAccountResourceProperties DeserializeGraphServicesAccountResourceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GraphServicesProvisioningState> provisioningState = default;
            string appId = default;
            Optional<string> billingPlanId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new GraphServicesProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingPlanId"u8))
                {
                    billingPlanId = property.Value.GetString();
                    continue;
                }
            }
            return new GraphServicesAccountResourceProperties(Optional.ToNullable(provisioningState), appId, billingPlanId.Value);
        }
    }
}
