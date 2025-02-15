// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RestSourceConverter))]
    public partial class RestSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RequestMethod))
            {
                writer.WritePropertyName("requestMethod"u8);
                writer.WriteObjectValue(RequestMethod);
            }
            if (Optional.IsDefined(RequestBody))
            {
                writer.WritePropertyName("requestBody"u8);
                writer.WriteObjectValue(RequestBody);
            }
            if (Optional.IsDefined(AdditionalHeaders))
            {
                writer.WritePropertyName("additionalHeaders"u8);
                writer.WriteObjectValue(AdditionalHeaders);
            }
            if (Optional.IsDefined(PaginationRules))
            {
                writer.WritePropertyName("paginationRules"u8);
                writer.WriteObjectValue(PaginationRules);
            }
            if (Optional.IsDefined(HttpRequestTimeout))
            {
                writer.WritePropertyName("httpRequestTimeout"u8);
                writer.WriteObjectValue(HttpRequestTimeout);
            }
            if (Optional.IsDefined(RequestInterval))
            {
                writer.WritePropertyName("requestInterval"u8);
                writer.WriteObjectValue(RequestInterval);
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns"u8);
                writer.WriteObjectValue(AdditionalColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static RestSource DeserializeRestSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> requestMethod = default;
            Optional<object> requestBody = default;
            Optional<object> additionalHeaders = default;
            Optional<object> paginationRules = default;
            Optional<object> httpRequestTimeout = default;
            Optional<object> requestInterval = default;
            Optional<object> additionalColumns = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestMethod = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("requestBody"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestBody = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalHeaders = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("paginationRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    paginationRules = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("httpRequestTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    httpRequestTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("requestInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestInterval = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalColumns = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RestSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, requestMethod.Value, requestBody.Value, additionalHeaders.Value, paginationRules.Value, httpRequestTimeout.Value, requestInterval.Value, additionalColumns.Value);
        }

        internal partial class RestSourceConverter : JsonConverter<RestSource>
        {
            public override void Write(Utf8JsonWriter writer, RestSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RestSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRestSource(document.RootElement);
            }
        }
    }
}
