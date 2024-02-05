﻿using System;
using System.Collections.Generic;
using System.Linq;
using Plugin.BLE.Abstractions.Extensions;

namespace Plugin.BLE.Abstractions
{
    /// <summary>
    /// Provides a list of known services.
    /// Source: https://developer.bluetooth.org/gatt/services/Pages/ServicesHome.aspx
    /// </summary>
    public static class KnownServices
    {
        private static readonly Dictionary<Guid, KnownService> LookupTable;

        static KnownServices()
        {
            LookupTable = Services.ToDictionary(s => s.Id, s => s);
        }

        /// <summary>
        /// Look up a known service via its Id.
        /// </summary>
        public static KnownService Lookup(Guid id)
        {
            return LookupTable.ContainsKey(id) ? LookupTable[id] : new KnownService("Unknown Service", Guid.Empty);
        }

        /// <summary>
        /// The list of known services.
        /// </summary>
        public static IReadOnlyList<KnownService> Services { get; } = new List<KnownService>
        {
            new KnownService("Alert Notification Service",    GuidExtension.UuidFromPartial(0x1811)),
            new KnownService("Battery Service",               GuidExtension.UuidFromPartial(0x180f)),
            new KnownService("Blood Pressure",                GuidExtension.UuidFromPartial(0x1810)),
            new KnownService("Current Time Service",          GuidExtension.UuidFromPartial(0x1805)),
            new KnownService("Cycling Power",                 GuidExtension.UuidFromPartial(0x1818)),
            new KnownService("Cycling Speed and Cadence",     GuidExtension.UuidFromPartial(0x1816)),
            new KnownService("Device Information",            GuidExtension.UuidFromPartial(0x180a)),
            new KnownService("Fitness Machine Service",       GuidExtension.UuidFromPartial(0x1826)),
            new KnownService("Generic Access",                GuidExtension.UuidFromPartial(0x1800)),
            new KnownService("Generic Attribute",             GuidExtension.UuidFromPartial(0x1801)),
            new KnownService("Glucose",                       GuidExtension.UuidFromPartial(0x1808)),
            new KnownService("Health Thermometer",            GuidExtension.UuidFromPartial(0x1809)),
            new KnownService("Heart Rate",                    GuidExtension.UuidFromPartial(0x180d)),
            new KnownService("Human Interface Device",        GuidExtension.UuidFromPartial(0x1812)),
            new KnownService("Immediate Alert",               GuidExtension.UuidFromPartial(0x1802)),
            new KnownService("Link Loss",                     GuidExtension.UuidFromPartial(0x1803)),
            new KnownService("Location and Navigation",       GuidExtension.UuidFromPartial(0x1819)),
            new KnownService("Next DST Change Service",       GuidExtension.UuidFromPartial(0x1807)),
            new KnownService("Phone Alert Status Service",    GuidExtension.UuidFromPartial(0x180e)),
            new KnownService("Reference Time Update Service", GuidExtension.UuidFromPartial(0x1806)),
            new KnownService("Running Speed and Cadence",     GuidExtension.UuidFromPartial(0x1814)),
            new KnownService("Scan Parameters",               GuidExtension.UuidFromPartial(0x1813)),
            new KnownService("TX Power",                      GuidExtension.UuidFromPartial(0x1804)),

            new KnownService("TI SensorTag Smart Keys",           Guid.ParseExact("0000ffe0-0000-1000-8000-00805f9b34fb", "d")),
            new KnownService("TI SensorTag Infrared Thermometer", Guid.ParseExact("f000aa00-0451-4000-b000-000000000000", "d")),
            new KnownService("TI SensorTag Accelerometer",        Guid.ParseExact("f000aa10-0451-4000-b000-000000000000", "d")),
            new KnownService("TI SensorTag Humidity",             Guid.ParseExact("f000aa20-0451-4000-b000-000000000000", "d")),
            new KnownService("TI SensorTag Magnometer",           Guid.ParseExact("f000aa30-0451-4000-b000-000000000000", "d")),
            new KnownService("TI SensorTag Barometer",            Guid.ParseExact("f000aa40-0451-4000-b000-000000000000", "d")),
            new KnownService("TI SensorTag Gyroscope",            Guid.ParseExact("f000aa50-0451-4000-b000-000000000000", "d")),
            new KnownService("TI SensorTag Test",                 Guid.ParseExact("f000aa60-0451-4000-b000-000000000000", "d")),
            new KnownService("TI SensorTag Connection Control",   Guid.ParseExact("f000ccc0-0451-4000-b000-000000000000", "d")),
            new KnownService("TI SensorTag OvertheAir Download",  Guid.ParseExact("f000ffc0-0451-4000-b000-000000000000", "d")),

            new KnownService("TXRX_SERV_UUID RedBearLabs Biscuit Service", Guid.ParseExact("713d0000-503e-4c75-ba94-3148f18d941e", "d")),
        }.AsReadOnly();
    }
}