// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceTrustedAccessRoleRule
    {
        internal static ContainerServiceTrustedAccessRoleRule DeserializeContainerServiceTrustedAccessRoleRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> verbs = default;
            Optional<IReadOnlyList<string>> apiGroups = default;
            Optional<IReadOnlyList<string>> resources = default;
            Optional<IReadOnlyList<string>> resourceNames = default;
            Optional<IReadOnlyList<string>> nonResourceUrls = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    verbs = array;
                    continue;
                }
                if (property.NameEquals("apiGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiGroups = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("resourceNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceNames = array;
                    continue;
                }
                if (property.NameEquals("nonResourceURLs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nonResourceUrls = array;
                    continue;
                }
            }
            return new ContainerServiceTrustedAccessRoleRule(Optional.ToList(verbs), Optional.ToList(apiGroups), Optional.ToList(resources), Optional.ToList(resourceNames), Optional.ToList(nonResourceUrls));
        }
    }
}
