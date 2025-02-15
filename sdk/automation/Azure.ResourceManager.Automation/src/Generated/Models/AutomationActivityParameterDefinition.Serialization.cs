// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationActivityParameterDefinition
    {
        internal static AutomationActivityParameterDefinition DeserializeAutomationActivityParameterDefinition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<bool> isMandatory = default;
            Optional<bool> isDynamic = default;
            Optional<long> position = default;
            Optional<bool> valueFromPipeline = default;
            Optional<bool> valueFromPipelineByPropertyName = default;
            Optional<bool> valueFromRemainingArguments = default;
            Optional<string> description = default;
            Optional<IReadOnlyList<AutomationActivityParameterValidationSet>> validationSet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isMandatory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isMandatory = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDynamic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDynamic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    position = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("valueFromPipeline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valueFromPipeline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("valueFromPipelineByPropertyName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valueFromPipelineByPropertyName = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("valueFromRemainingArguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valueFromRemainingArguments = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AutomationActivityParameterValidationSet> array = new List<AutomationActivityParameterValidationSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomationActivityParameterValidationSet.DeserializeAutomationActivityParameterValidationSet(item));
                    }
                    validationSet = array;
                    continue;
                }
            }
            return new AutomationActivityParameterDefinition(name.Value, type.Value, Optional.ToNullable(isMandatory), Optional.ToNullable(isDynamic), Optional.ToNullable(position), Optional.ToNullable(valueFromPipeline), Optional.ToNullable(valueFromPipelineByPropertyName), Optional.ToNullable(valueFromRemainingArguments), description.Value, Optional.ToList(validationSet));
        }
    }
}
