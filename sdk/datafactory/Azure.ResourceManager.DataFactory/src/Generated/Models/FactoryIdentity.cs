// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Identity properties of the factory resource. </summary>
    public partial class FactoryIdentity
    {
        /// <summary> Initializes a new instance of FactoryIdentity. </summary>
        /// <param name="identityType"> The identity type. </param>
        public FactoryIdentity(FactoryIdentityType identityType)
        {
            IdentityType = identityType;
            UserAssignedIdentities = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of FactoryIdentity. </summary>
        /// <param name="identityType"> The identity type. </param>
        /// <param name="principalId"> The principal id of the identity. </param>
        /// <param name="tenantId"> The client tenant id of the identity. </param>
        /// <param name="userAssignedIdentities"> List of user assigned identities for the factory. </param>
        internal FactoryIdentity(FactoryIdentityType identityType, Guid? principalId, Guid? tenantId, IDictionary<string, BinaryData> userAssignedIdentities)
        {
            IdentityType = identityType;
            PrincipalId = principalId;
            TenantId = tenantId;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> The identity type. </summary>
        public FactoryIdentityType IdentityType { get; set; }
        /// <summary> The principal id of the identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The client tenant id of the identity. </summary>
        public Guid? TenantId { get; }
        /// <summary> List of user assigned identities for the factory. </summary>
        public IDictionary<string, BinaryData> UserAssignedIdentities { get; }
    }
}
