// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class OutputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(OutputDataSourceType);
            writer.WriteEndObject();
        }

        internal static OutputDataSource DeserializeOutputDataSource(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "GatewayMessageBus": return GatewayMessageBusOutputDataSource.DeserializeGatewayMessageBusOutputDataSource(element);
                    case "Microsoft.AzureFunction": return AzureFunctionOutputDataSource.DeserializeAzureFunctionOutputDataSource(element);
                    case "Microsoft.DBForPostgreSQL/servers/databases": return PostgreSQLOutputDataSource.DeserializePostgreSQLOutputDataSource(element);
                    case "Microsoft.DataLake/Accounts": return AzureDataLakeStoreOutputDataSource.DeserializeAzureDataLakeStoreOutputDataSource(element);
                    case "Microsoft.EventHub/EventHub": return EventHubV2OutputDataSource.DeserializeEventHubV2OutputDataSource(element);
                    case "Microsoft.ServiceBus/EventHub": return EventHubOutputDataSource.DeserializeEventHubOutputDataSource(element);
                    case "Microsoft.ServiceBus/Queue": return ServiceBusQueueOutputDataSource.DeserializeServiceBusQueueOutputDataSource(element);
                    case "Microsoft.ServiceBus/Topic": return ServiceBusTopicOutputDataSource.DeserializeServiceBusTopicOutputDataSource(element);
                    case "Microsoft.Sql/Server/DataWarehouse": return AzureSynapseOutputDataSource.DeserializeAzureSynapseOutputDataSource(element);
                    case "Microsoft.Sql/Server/Database": return AzureSqlDatabaseOutputDataSource.DeserializeAzureSqlDatabaseOutputDataSource(element);
                    case "Microsoft.Storage/Blob": return BlobOutputDataSource.DeserializeBlobOutputDataSource(element);
                    case "Microsoft.Storage/DocumentDB": return DocumentDbOutputDataSource.DeserializeDocumentDbOutputDataSource(element);
                    case "Microsoft.Storage/Table": return AzureTableOutputDataSource.DeserializeAzureTableOutputDataSource(element);
                    case "PowerBI": return PowerBIOutputDataSource.DeserializePowerBIOutputDataSource(element);
                    case "Raw": return RawOutputDatasource.DeserializeRawOutputDatasource(element);
                }
            }
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new OutputDataSource(type);
        }
    }
}
