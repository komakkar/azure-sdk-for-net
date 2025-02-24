// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Properties controlling TLS Certificate Validation. </summary>
    public partial class BackendTlsProperties
    {
        /// <summary> Initializes a new instance of BackendTlsProperties. </summary>
        public BackendTlsProperties()
        {
        }

        /// <summary> Initializes a new instance of BackendTlsProperties. </summary>
        /// <param name="validateCertificateChain"> Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for this backend host. </param>
        /// <param name="validateCertificateName"> Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for this backend host. </param>
        internal BackendTlsProperties(bool? validateCertificateChain, bool? validateCertificateName)
        {
            ValidateCertificateChain = validateCertificateChain;
            ValidateCertificateName = validateCertificateName;
        }

        /// <summary> Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for this backend host. </summary>
        public bool? ValidateCertificateChain { get; set; }
        /// <summary> Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for this backend host. </summary>
        public bool? ValidateCertificateName { get; set; }
    }
}
