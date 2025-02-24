// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The API deployment parameters metadata. </summary>
    public partial class ApiDeploymentParameterMetadataSet
    {
        /// <summary> Initializes a new instance of ApiDeploymentParameterMetadataSet. </summary>
        internal ApiDeploymentParameterMetadataSet()
        {
        }

        /// <summary> Initializes a new instance of ApiDeploymentParameterMetadataSet. </summary>
        /// <param name="packageContentLink"> The package content link parameter. </param>
        /// <param name="redisCacheConnectionString"> The package content link parameter. </param>
        internal ApiDeploymentParameterMetadataSet(ApiDeploymentParameterMetadata packageContentLink, ApiDeploymentParameterMetadata redisCacheConnectionString)
        {
            PackageContentLink = packageContentLink;
            RedisCacheConnectionString = redisCacheConnectionString;
        }

        /// <summary> The package content link parameter. </summary>
        public ApiDeploymentParameterMetadata PackageContentLink { get; }
        /// <summary> The package content link parameter. </summary>
        public ApiDeploymentParameterMetadata RedisCacheConnectionString { get; }
    }
}
