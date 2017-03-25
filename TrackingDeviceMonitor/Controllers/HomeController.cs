using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackingDeviceMonitor.Models;

namespace TrackingDeviceMonitor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TrackingDevice device = getDevice();
            DeviceTrackingServiceReference.WCFServiceClient client = new DeviceTrackingServiceReference.WCFServiceClient();
            DeviceTrackingServiceReference.TrackingDevice d = client.getTrackingDevice("4CE04604EG");
            Debug.WriteLine("route = " + d.Speed);
            ViewBag.TrackerInfo = new string[] { "Serial number: " + d.DeviceSerial,
                                  "Driver ID:" + d.DriverId,
                                  "Speed: " + d.Speed.ToString() + " KM/H",
                                  "Latitude: " + (d.latitude).ToString() ,
                                  "Longitude: " + (d.longitude).ToString(),
                                  "Heading: " + d.NS + d.EW + " at a " + d.heading.ToString() + " degrees",
                                  "Time Updated: " + (d.GpsDateTime).ToString()};
            ViewBag.Lat = d.latitude;
            ViewBag.Lng = d.longitude;
            ViewBag.poly = d.CompleteRoute;
            string[] end = d.Destination.Split(',');
            string[] start = d.Source.Split(',');
            ViewBag.sLat = start[0];
            ViewBag.sLng = start[1];
            ViewBag.eLat = end[0];
            ViewBag.eLng = end[1];

            return View();
        }

        private TrackingDevice getDevice()
        {
            TrackingDevice device = new TrackingDevice();
            device.deviceSerial = "XD9872364239";
            device.driverId = "123456789";
            device.latitude = 24.958047;
            device.longitude = 46.734460;
            device.Speed = 120;
            return device;
        }



    }
}