﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceGeofenceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceGeofenceQueryModel : AlipayObject
    {
        /// <summary>
        /// 一组地理围栏的唯一标识, 通常一条公交线路.
        /// </summary>
        [JsonProperty("route_code")]
        public string RouteCode { get; set; }
    }
}
