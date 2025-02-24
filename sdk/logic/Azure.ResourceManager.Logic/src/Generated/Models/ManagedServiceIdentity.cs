// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> Managed service identity properties. </summary>
    public partial class ManagedServiceIdentity
    {
        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        /// <param name="identityType"> Type of managed service identity. The type &apos;SystemAssigned&apos; includes an implicitly created identity. The type &apos;None&apos; will remove any identities from the resource. </param>
        public ManagedServiceIdentity(ManagedServiceIdentityType identityType)
        {
            IdentityType = identityType;
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        /// <param name="identityType"> Type of managed service identity. The type &apos;SystemAssigned&apos; includes an implicitly created identity. The type &apos;None&apos; will remove any identities from the resource. </param>
        /// <param name="tenantId"> Tenant of managed service identity. </param>
        /// <param name="principalId"> Principal Id of managed service identity. </param>
        /// <param name="userAssignedIdentities"> The list of user assigned identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. </param>
        internal ManagedServiceIdentity(ManagedServiceIdentityType identityType, Guid? tenantId, Guid? principalId, IDictionary<string, UserAssignedIdentity> userAssignedIdentities)
        {
            IdentityType = identityType;
            TenantId = tenantId;
            PrincipalId = principalId;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> Type of managed service identity. The type &apos;SystemAssigned&apos; includes an implicitly created identity. The type &apos;None&apos; will remove any identities from the resource. </summary>
        public ManagedServiceIdentityType IdentityType { get; set; }
        /// <summary> Tenant of managed service identity. </summary>
        public Guid? TenantId { get; }
        /// <summary> Principal Id of managed service identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The list of user assigned identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
