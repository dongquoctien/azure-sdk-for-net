// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class RestorableGremlinGraphsListResult
    {
        internal static RestorableGremlinGraphsListResult DeserializeRestorableGremlinGraphsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<RestorableGremlinGraph>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RestorableGremlinGraph> array = new List<RestorableGremlinGraph>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorableGremlinGraph.DeserializeRestorableGremlinGraph(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RestorableGremlinGraphsListResult(Optional.ToList(value));
        }
    }
}
