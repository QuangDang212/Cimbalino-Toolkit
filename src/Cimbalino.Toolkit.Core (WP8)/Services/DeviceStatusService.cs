﻿// ****************************************************************************
// <copyright file="DeviceStatusService.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2014
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <project>Cimbalino.Toolkit.Core</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

using System;
using Microsoft.Phone.Info;

namespace Cimbalino.Toolkit.Services
{
    /// <summary>
    /// Represents an implementation of the <see cref="IDeviceStatusService"/>.
    /// </summary>
    public class DeviceStatusService : IDeviceStatusService
    {
        /// <summary>
        /// Gets the memory usage of the current application in bytes.
        /// </summary>
        /// <value>The memory usage of the current application in bytes.</value>
        public long ApplicationCurrentMemoryUsage
        {
            get
            {
                return DeviceStatus.ApplicationCurrentMemoryUsage;
            }
        }

        /// <summary>
        /// Gets the maximum amount of memory that your application process can allocate.
        /// </summary>
        /// <value>
        /// The maximum amount of memory that your application process can allocate.
        /// </value>
        public long ApplicationMemoryUsageLimit
        {
            get
            {
                return DeviceStatus.ApplicationMemoryUsageLimit;
            }
        }

        /// <summary>
        /// Gets the peak memory usage of the current application in bytes.
        /// </summary>
        /// <value>The peak memory usage of the current application in bytes.</value>
        public long ApplicationPeakMemoryUsage
        {
            get
            {
                return DeviceStatus.ApplicationPeakMemoryUsage;
            }
        }

        /// <summary>
        /// Gets the firmware version running on the device.
        /// </summary>
        /// <value>The firmware version running on the device.</value>
        public string DeviceFirmwareVersion
        {
            get
            {
                return DeviceStatus.DeviceFirmwareVersion;
            }
        }

        /// <summary>
        /// Gets the hardware version running on the device.
        /// </summary>
        /// <value>The hardware version running on the device.</value>
        public string DeviceHardwareVersion
        {
            get
            {
                return DeviceStatus.DeviceHardwareVersion;
            }
        }

        /// <summary>
        /// Gets the device manufacturer name.
        /// </summary>
        /// <value>The device manufacturer name.</value>
        public string DeviceManufacturer
        {
            get
            {
                return DeviceStatus.DeviceManufacturer;
            }
        }

        /// <summary>
        /// Gets the device name.
        /// </summary>
        /// <value>The device name.</value>
        public string DeviceName
        {
            get
            {
                return DeviceStatus.DeviceName;
            }
        }

        /// <summary>
        /// Gets the physical RAM size of the device in bytes.
        /// </summary>
        /// <value>The physical RAM size of the device in bytes.</value>
        public long DeviceTotalMemory
        {
            get
            {
                return DeviceStatus.DeviceTotalMemory;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the device is a low memory device (less than 256 MB of memory installed).
        /// </summary>
        /// <value>
        /// true if the device is a low memory device (less than 256 MB of memory installed); otherwise, false.
        /// </value>
        public bool IsLowMemoryDevice
        {
            get
            {
                return DeviceTotalMemory <= 268435456;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the user has deployed the physical hardware keyboard of the device.
        /// </summary>
        /// <value>true if the keyboard is deployed; otherwise, false.</value>
        public virtual bool IsKeyboardDeployed
        {
            get
            {
                return DeviceStatus.IsKeyboardDeployed;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the device contains a physical hardware keyboard.
        /// </summary>
        /// <value>
        /// true if the device contains a physical hardware keyboard; otherwise, false.
        /// </value>
        public virtual bool IsKeyboardPresent
        {
            get
            {
                return DeviceStatus.IsKeyboardPresent;
            }
        }

        /// <summary>
        /// Gets the a value indicating whether the device is currently running on battery power or is plugged in to an external power supply.
        /// </summary>
        /// <value>
        /// true if the device is currently running on battery power or is plugged in to an external power supply; otherwise, false.
        /// </value>
        public DeviceStatusServicePowerSource PowerSource
        {
            get
            {
                switch (DeviceStatus.PowerSource)
                {
                    case Microsoft.Phone.Info.PowerSource.Battery:
                        return DeviceStatusServicePowerSource.Battery;
                    
                    case Microsoft.Phone.Info.PowerSource.External:
                        return DeviceStatusServicePowerSource.External;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}