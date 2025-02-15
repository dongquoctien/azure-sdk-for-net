// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseDataConnectionListResult
    {
        internal static SynapseDataConnectionListResult DeserializeSynapseDataConnectionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapseDataConnectionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SynapseDataConnectionData> array = new List<SynapseDataConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseDataConnectionData.DeserializeSynapseDataConnectionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SynapseDataConnectionListResult(Optional.ToList(value));
        }
    }
}
