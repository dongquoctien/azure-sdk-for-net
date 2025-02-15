// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class RolloutCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("identity"u8);
            writer.WriteObjectValue(Identity);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("buildVersion"u8);
            writer.WriteStringValue(BuildVersion);
            if (Optional.IsDefined(ArtifactSourceId))
            {
                writer.WritePropertyName("artifactSourceId"u8);
                writer.WriteStringValue(ArtifactSourceId);
            }
            writer.WritePropertyName("targetServiceTopologyId"u8);
            writer.WriteStringValue(TargetServiceTopologyId);
            writer.WritePropertyName("stepGroups"u8);
            writer.WriteStartArray();
            foreach (var item in StepGroups)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RolloutCreateOrUpdateContent DeserializeRolloutCreateOrUpdateContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Identity identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string buildVersion = default;
            Optional<string> artifactSourceId = default;
            string targetServiceTopologyId = default;
            IList<StepGroup> stepGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    identity = Identity.DeserializeIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("buildVersion"u8))
                        {
                            buildVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("artifactSourceId"u8))
                        {
                            artifactSourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetServiceTopologyId"u8))
                        {
                            targetServiceTopologyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("stepGroups"u8))
                        {
                            List<StepGroup> array = new List<StepGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StepGroup.DeserializeStepGroup(item));
                            }
                            stepGroups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RolloutCreateOrUpdateContent(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, buildVersion, artifactSourceId.Value, targetServiceTopologyId, stepGroups);
        }
    }
}
