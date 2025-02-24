// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class AddParticipantsResponse
    {
        internal static AddParticipantsResponse DeserializeAddParticipantsResponse(JsonElement element)
        {
            Optional<string> operationId = default;
            CallingOperationStatusDto status = default;
            Optional<string> operationContext = default;
            Optional<CallingOperationResultDetailsDto> resultDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new CallingOperationStatusDto(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationContext"))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resultDetails = CallingOperationResultDetailsDto.DeserializeCallingOperationResultDetailsDto(property.Value);
                    continue;
                }
            }
            return new AddParticipantsResponse(operationId.Value, status, operationContext.Value, resultDetails.Value);
        }
    }
}
