using System;
using System.Collections.Generic;
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
            ViewBag.TrackerInfo = new string[] { "Serial number: " + device.deviceSerial,
                                  "Driver ID:" + device.driverId,
                                  "Speed: " + device.Speed + " KM/H",
                                  "Latitude: " + (device.latitude).ToString() ,
                                  "Longitude: " + (device.longitude).ToString()};
            ViewBag.Lat = device.latitude;
            ViewBag.Lng = device.longitude;
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