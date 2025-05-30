﻿using System.Configuration;

namespace KoenZomers.Tado.Api.UnitTest
{
    /// <summary>
    /// Base functionality shared by all Unit Tests
    /// </summary>
    public abstract class BaseTest
    {
        /// <summary>
        /// Username to use to connect to the Tado API
        /// </summary>
        public static string DeviceCode => ConfigurationManager.AppSettings["TadoDeviceCode"];

        /// <summary>
        /// Password to use to connect to the Tado API
        /// </summary>
        public static string AccessToken => ConfigurationManager.AppSettings["TadoAccessToken"];

        /// <summary>
        /// Id of the home as registered with Tado
        /// </summary>
        public static int HomeId => int.Parse(ConfigurationManager.AppSettings["TadoHomeId"]);

        /// <summary>
        /// Id of the zone as registered with Tado
        /// </summary>
        public static int ZoneId => int.Parse(ConfigurationManager.AppSettings["TadoZoneId"]);

        /// <summary>
        /// Id of the mobile device as registered with Tado
        /// </summary>
        public static int MobileDeviceId => int.Parse(ConfigurationManager.AppSettings["TadoMobileDeviceId"]);

        /// <summary>
        /// Id of the Tado device
        /// </summary>
        public static string DeviceId => ConfigurationManager.AppSettings["TadoDeviceId"];
    }
}