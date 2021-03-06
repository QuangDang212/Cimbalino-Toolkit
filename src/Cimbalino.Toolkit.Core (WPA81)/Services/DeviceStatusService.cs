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

#if WINDOWS_PHONE_APP
using System;
using Windows.Devices.Input;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Windows.System;
#else
using System;
using Windows.Devices.Input;
using Windows.Security.ExchangeActiveSyncProvisioning;
#endif

namespace Cimbalino.Toolkit.Services
{
    /// <summary>
    /// Represents an implementation of the <see cref="IDeviceStatusService"/>.
    /// </summary>
    public class DeviceStatusService : IDeviceStatusService
    {
        private readonly EasClientDeviceInformation _easClientDeviceInformation;
        private readonly KeyboardCapabilities _keyboardCapabilities;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceStatusService"/> class.
        /// </summary>
        public DeviceStatusService()
        {
            _easClientDeviceInformation = new EasClientDeviceInformation();
            _keyboardCapabilities = new KeyboardCapabilities();
        }

        /// <summary>
        /// Gets the memory usage of the current application in bytes.
        /// </summary>
        /// <value>The memory usage of the current application in bytes.</value>
        public long ApplicationCurrentMemoryUsage
        {
            get
            {
#if WINDOWS_PHONE_APP
                return (long)MemoryManager.AppMemoryUsage;
#else
                throw new NotSupportedException();
#endif
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
#if WINDOWS_PHONE_APP
                return (long)MemoryManager.AppMemoryUsageLimit;
#else
                throw new NotSupportedException();
#endif
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
                throw new NotSupportedException();
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
#if WINDOWS_PHONE_APP
                return _easClientDeviceInformation.SystemFirmwareVersion;
#else
                throw new NotSupportedException();
#endif
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
#if WINDOWS_PHONE_APP
                return _easClientDeviceInformation.SystemHardwareVersion;
#else
                throw new NotSupportedException();
#endif
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
                return _easClientDeviceInformation.SystemManufacturer;
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
                return _easClientDeviceInformation.SystemProductName;
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
                throw new NotSupportedException();
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
                return false;
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
                throw new NotSupportedException();
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
                return _keyboardCapabilities.KeyboardPresent != 0;
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
                throw new NotSupportedException();
            }
        }
    }
}