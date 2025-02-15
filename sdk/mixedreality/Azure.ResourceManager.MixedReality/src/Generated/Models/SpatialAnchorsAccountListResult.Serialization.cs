// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MixedReality;

namespace Azure.ResourceManager.MixedReality.Models
{
    internal partial class SpatialAnchorsAccountListResult
    {
        internal static SpatialAnchorsAccountListResult DeserializeSpatialAnchorsAccountListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SpatialAnchorsAccountData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SpatialAnchorsAccountData> array = new List<SpatialAnchorsAccountData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnchorsAccountData.DeserializeSpatialAnchorsAccountData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SpatialAnchorsAccountListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
