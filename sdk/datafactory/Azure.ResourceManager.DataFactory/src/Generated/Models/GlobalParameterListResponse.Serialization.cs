// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class GlobalParameterListResponse
    {
        internal static GlobalParameterListResponse DeserializeGlobalParameterListResponse(JsonElement element)
        {
            IReadOnlyList<DataFactoryGlobalParameterData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DataFactoryGlobalParameterData> array = new List<DataFactoryGlobalParameterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryGlobalParameterData.DeserializeDataFactoryGlobalParameterData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GlobalParameterListResponse(value, nextLink.Value);
        }
    }
}
