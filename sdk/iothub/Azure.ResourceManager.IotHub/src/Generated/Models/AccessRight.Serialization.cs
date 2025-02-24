// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    internal static partial class AccessRightExtensions
    {
        public static string ToSerialString(this AccessRight value) => value switch
        {
            AccessRight.RegistryRead => "RegistryRead",
            AccessRight.RegistryWrite => "RegistryWrite",
            AccessRight.ServiceConnect => "ServiceConnect",
            AccessRight.DeviceConnect => "DeviceConnect",
            AccessRight.RegistryReadRegistryWrite => "RegistryRead, RegistryWrite",
            AccessRight.RegistryReadServiceConnect => "RegistryRead, ServiceConnect",
            AccessRight.RegistryReadDeviceConnect => "RegistryRead, DeviceConnect",
            AccessRight.RegistryWriteServiceConnect => "RegistryWrite, ServiceConnect",
            AccessRight.RegistryWriteDeviceConnect => "RegistryWrite, DeviceConnect",
            AccessRight.ServiceConnectDeviceConnect => "ServiceConnect, DeviceConnect",
            AccessRight.RegistryReadRegistryWriteServiceConnect => "RegistryRead, RegistryWrite, ServiceConnect",
            AccessRight.RegistryReadRegistryWriteDeviceConnect => "RegistryRead, RegistryWrite, DeviceConnect",
            AccessRight.RegistryReadServiceConnectDeviceConnect => "RegistryRead, ServiceConnect, DeviceConnect",
            AccessRight.RegistryWriteServiceConnectDeviceConnect => "RegistryWrite, ServiceConnect, DeviceConnect",
            AccessRight.RegistryReadRegistryWriteServiceConnectDeviceConnect => "RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessRight value.")
        };

        public static AccessRight ToAccessRight(this string value)
        {
            if (string.Equals(value, "RegistryRead", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryRead;
            if (string.Equals(value, "RegistryWrite", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryWrite;
            if (string.Equals(value, "ServiceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.ServiceConnect;
            if (string.Equals(value, "DeviceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.DeviceConnect;
            if (string.Equals(value, "RegistryRead, RegistryWrite", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryReadRegistryWrite;
            if (string.Equals(value, "RegistryRead, ServiceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryReadServiceConnect;
            if (string.Equals(value, "RegistryRead, DeviceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryReadDeviceConnect;
            if (string.Equals(value, "RegistryWrite, ServiceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryWriteServiceConnect;
            if (string.Equals(value, "RegistryWrite, DeviceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryWriteDeviceConnect;
            if (string.Equals(value, "ServiceConnect, DeviceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.ServiceConnectDeviceConnect;
            if (string.Equals(value, "RegistryRead, RegistryWrite, ServiceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryReadRegistryWriteServiceConnect;
            if (string.Equals(value, "RegistryRead, RegistryWrite, DeviceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryReadRegistryWriteDeviceConnect;
            if (string.Equals(value, "RegistryRead, ServiceConnect, DeviceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryReadServiceConnectDeviceConnect;
            if (string.Equals(value, "RegistryWrite, ServiceConnect, DeviceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryWriteServiceConnectDeviceConnect;
            if (string.Equals(value, "RegistryRead, RegistryWrite, ServiceConnect, DeviceConnect", StringComparison.InvariantCultureIgnoreCase)) return AccessRight.RegistryReadRegistryWriteServiceConnectDeviceConnect;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessRight value.");
        }
    }
}
