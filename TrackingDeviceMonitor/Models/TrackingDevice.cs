using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingDeviceMonitor.Models
{
    public class TrackingDevice
    {
        public string driverId { get; set; }

        public int maxSpeed { get; set; }

        public string deviceSerial { get; set; }

        public string firmWareVersion { get; set; }

        public double latitude { get; set; }

        public double longitude { get; set; }

        public string heading { get; set; }

        public string EW { get; set; }

        public string NS { get; set; }

        public string GpsDateTime { get; set; }

        public int Speed
        {
            get; set;
        }
    }
}