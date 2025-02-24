// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Billing information related properties of a server. </summary>
    public partial class FlexibleServersSku
    {
        /// <summary> Initializes a new instance of FlexibleServersSku. </summary>
        /// <param name="name"> The name of the sku, e.g. Standard_D32s_v3. </param>
        /// <param name="tier"> The tier of the particular SKU, e.g. GeneralPurpose. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public FlexibleServersSku(string name, FlexibleServersSkuTier tier)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Tier = tier;
        }

        /// <summary> The name of the sku, e.g. Standard_D32s_v3. </summary>
        public string Name { get; set; }
        /// <summary> The tier of the particular SKU, e.g. GeneralPurpose. </summary>
        public FlexibleServersSkuTier Tier { get; set; }
    }
}
