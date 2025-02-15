// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlVmStorageConfigurationSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlDataSettings))
            {
                writer.WritePropertyName("sqlDataSettings"u8);
                writer.WriteObjectValue(SqlDataSettings);
            }
            if (Optional.IsDefined(SqlLogSettings))
            {
                writer.WritePropertyName("sqlLogSettings"u8);
                writer.WriteObjectValue(SqlLogSettings);
            }
            if (Optional.IsDefined(SqlTempDBSettings))
            {
                writer.WritePropertyName("sqlTempDbSettings"u8);
                writer.WriteObjectValue(SqlTempDBSettings);
            }
            if (Optional.IsDefined(IsSqlSystemDBOnDataDisk))
            {
                writer.WritePropertyName("sqlSystemDbOnDataDisk"u8);
                writer.WriteBooleanValue(IsSqlSystemDBOnDataDisk.Value);
            }
            if (Optional.IsDefined(DiskConfigurationType))
            {
                writer.WritePropertyName("diskConfigurationType"u8);
                writer.WriteStringValue(DiskConfigurationType.Value.ToString());
            }
            if (Optional.IsDefined(StorageWorkloadType))
            {
                writer.WritePropertyName("storageWorkloadType"u8);
                writer.WriteStringValue(StorageWorkloadType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SqlVmStorageConfigurationSettings DeserializeSqlVmStorageConfigurationSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlStorageSettings> sqlDataSettings = default;
            Optional<SqlStorageSettings> sqlLogSettings = default;
            Optional<SqlTempDBSettings> sqlTempDBSettings = default;
            Optional<bool> sqlSystemDBOnDataDisk = default;
            Optional<SqlVmDiskConfigurationType> diskConfigurationType = default;
            Optional<SqlVmStorageWorkloadType> storageWorkloadType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlDataSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlDataSettings = SqlStorageSettings.DeserializeSqlStorageSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlLogSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlLogSettings = SqlStorageSettings.DeserializeSqlStorageSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlTempDbSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlTempDBSettings = SqlTempDBSettings.DeserializeSqlTempDBSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlSystemDbOnDataDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlSystemDBOnDataDisk = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("diskConfigurationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskConfigurationType = new SqlVmDiskConfigurationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageWorkloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageWorkloadType = new SqlVmStorageWorkloadType(property.Value.GetString());
                    continue;
                }
            }
            return new SqlVmStorageConfigurationSettings(sqlDataSettings.Value, sqlLogSettings.Value, sqlTempDBSettings.Value, Optional.ToNullable(sqlSystemDBOnDataDisk), Optional.ToNullable(diskConfigurationType), Optional.ToNullable(storageWorkloadType));
        }
    }
}
