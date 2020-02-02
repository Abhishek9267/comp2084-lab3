using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PhoneApplication.Models
{
    public class Phone
    {
        //shortcut for declairng variables prop tab tab
        [Key]
        public int PhoneID { get; set; }
        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }
        public double MSRP { get; set; }
        public DateTime Founded { get; set; }
        public string PhoneName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int ScreenSize { get; set; }
        //string PhoneId, PhoneName, Manufacturer, MSRP;
        //int ScreenSize;
        //DateTime

        public Phone()
        {
            Founded = DateTime.Now;
            PhoneName = "";
           
        }
    }
}