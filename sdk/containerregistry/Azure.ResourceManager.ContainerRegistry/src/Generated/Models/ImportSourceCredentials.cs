// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The ImportSourceCredentials. </summary>
    public partial class ImportSourceCredentials
    {
        /// <summary> Initializes a new instance of ImportSourceCredentials. </summary>
        /// <param name="password"> The password used to authenticate with the source registry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="password"/> is null. </exception>
        public ImportSourceCredentials(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Password = password;
        }

        /// <summary> The username to authenticate with the source registry. </summary>
        public string Username { get; set; }
        /// <summary> The password used to authenticate with the source registry. </summary>
        public string Password { get; }
    }
}
