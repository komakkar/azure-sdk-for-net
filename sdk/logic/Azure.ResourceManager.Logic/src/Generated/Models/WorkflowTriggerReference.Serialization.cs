// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class WorkflowTriggerReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FlowName))
            {
                writer.WritePropertyName("flowName");
                writer.WriteStringValue(FlowName);
            }
            if (Optional.IsDefined(TriggerName))
            {
                writer.WritePropertyName("triggerName");
                writer.WriteStringValue(TriggerName);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static WorkflowTriggerReference DeserializeWorkflowTriggerReference(JsonElement element)
        {
            Optional<string> flowName = default;
            Optional<string> triggerName = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("flowName"))
                {
                    flowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerName"))
                {
                    triggerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new WorkflowTriggerReference(id.Value, name.Value, type.Value, flowName.Value, triggerName.Value);
        }
    }
}
