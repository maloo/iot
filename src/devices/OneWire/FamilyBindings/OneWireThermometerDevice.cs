﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Iot.Units;
using System.Threading.Tasks;

namespace Iot.Device.OneWire
{
    /// <summary>
    /// Represents a 1-wire thermometer device.
    /// </summary>
    public partial class OneWireThermometerDevice : OneWireDevice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OneWireThermometerDevice"/> class
        /// </summary>
        /// <param name="bus">The 1-wire bus the device is found on</param>
        /// <param name="deviceId">The id of the device</param>
        /// <param name="family">The 1-wire fmily id</param>
        protected internal OneWireThermometerDevice(OneWireBus bus, string deviceId, OneWireBus.DeviceFamily family)
            : base(bus, deviceId, family)
        {
        }

        /// <summary>
        /// Reads the current temperature of the device.
        /// Expect this function to be slow (about one second).
        /// </summary>
        /// <returns>The read temperature value.</returns>
        public Task<Temperature> ReadTemperatureAsync()
        {
            return ReadTemperatureInternalAsync();
        }
    }
}