using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        //shortcut for declairng variables prop tab tab
        public int PhoneID { get; set; }
        public double MSRP { get; set; }
        public DateTime DateReleased { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public int ScreenSize { get; set; }
        //string PhoneId, PhoneName, Manufacturer, MSRP;
        //int ScreenSize;
        //DateTime

        public Phone()
        {
            DateReleased = DateTime.Now;
            PhoneName = "";
            Manufacturer = "";
        }
    }
}