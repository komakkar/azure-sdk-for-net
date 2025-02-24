// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The file system to mount on each node. </summary>
    public partial class MountConfiguration
    {
        /// <summary> Initializes a new instance of MountConfiguration. </summary>
        public MountConfiguration()
        {
        }

        /// <summary> Initializes a new instance of MountConfiguration. </summary>
        /// <param name="azureBlobFileSystemConfiguration"> This property is mutually exclusive with all other properties. </param>
        /// <param name="nfsMountConfiguration"> This property is mutually exclusive with all other properties. </param>
        /// <param name="cifsMountConfiguration"> This property is mutually exclusive with all other properties. </param>
        /// <param name="azureFileShareConfiguration"> This property is mutually exclusive with all other properties. </param>
        internal MountConfiguration(AzureBlobFileSystemConfiguration azureBlobFileSystemConfiguration, NFSMountConfiguration nfsMountConfiguration, CifsMountConfiguration cifsMountConfiguration, AzureFileShareConfiguration azureFileShareConfiguration)
        {
            AzureBlobFileSystemConfiguration = azureBlobFileSystemConfiguration;
            NfsMountConfiguration = nfsMountConfiguration;
            CifsMountConfiguration = cifsMountConfiguration;
            AzureFileShareConfiguration = azureFileShareConfiguration;
        }

        /// <summary> This property is mutually exclusive with all other properties. </summary>
        public AzureBlobFileSystemConfiguration AzureBlobFileSystemConfiguration { get; set; }
        /// <summary> This property is mutually exclusive with all other properties. </summary>
        public NFSMountConfiguration NfsMountConfiguration { get; set; }
        /// <summary> This property is mutually exclusive with all other properties. </summary>
        public CifsMountConfiguration CifsMountConfiguration { get; set; }
        /// <summary> This property is mutually exclusive with all other properties. </summary>
        public AzureFileShareConfiguration AzureFileShareConfiguration { get; set; }
    }
}
