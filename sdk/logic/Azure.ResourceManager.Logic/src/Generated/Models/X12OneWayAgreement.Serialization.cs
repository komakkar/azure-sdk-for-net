// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12OneWayAgreement : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("senderBusinessIdentity");
            writer.WriteObjectValue(SenderBusinessIdentity);
            writer.WritePropertyName("receiverBusinessIdentity");
            writer.WriteObjectValue(ReceiverBusinessIdentity);
            writer.WritePropertyName("protocolSettings");
            writer.WriteObjectValue(ProtocolSettings);
            writer.WriteEndObject();
        }

        internal static X12OneWayAgreement DeserializeX12OneWayAgreement(JsonElement element)
        {
            BusinessIdentity senderBusinessIdentity = default;
            BusinessIdentity receiverBusinessIdentity = default;
            X12ProtocolSettings protocolSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("senderBusinessIdentity"))
                {
                    senderBusinessIdentity = BusinessIdentity.DeserializeBusinessIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("receiverBusinessIdentity"))
                {
                    receiverBusinessIdentity = BusinessIdentity.DeserializeBusinessIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("protocolSettings"))
                {
                    protocolSettings = X12ProtocolSettings.DeserializeX12ProtocolSettings(property.Value);
                    continue;
                }
            }
            return new X12OneWayAgreement(senderBusinessIdentity, receiverBusinessIdentity, protocolSettings);
        }
    }
}
