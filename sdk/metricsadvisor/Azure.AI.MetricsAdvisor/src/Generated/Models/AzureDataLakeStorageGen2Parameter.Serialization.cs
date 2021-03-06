// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureDataLakeStorageGen2Parameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("accountName");
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("accountKey");
            writer.WriteStringValue(AccountKey);
            writer.WritePropertyName("fileSystemName");
            writer.WriteStringValue(FileSystemName);
            writer.WritePropertyName("directoryTemplate");
            writer.WriteStringValue(DirectoryTemplate);
            writer.WritePropertyName("fileTemplate");
            writer.WriteStringValue(FileTemplate);
            writer.WriteEndObject();
        }

        internal static AzureDataLakeStorageGen2Parameter DeserializeAzureDataLakeStorageGen2Parameter(JsonElement element)
        {
            string accountName = default;
            string accountKey = default;
            string fileSystemName = default;
            string directoryTemplate = default;
            string fileTemplate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileSystemName"))
                {
                    fileSystemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("directoryTemplate"))
                {
                    directoryTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileTemplate"))
                {
                    fileTemplate = property.Value.GetString();
                    continue;
                }
            }
            return new AzureDataLakeStorageGen2Parameter(accountName, accountKey, fileSystemName, directoryTemplate, fileTemplate);
        }
    }
}
