using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSpotsAPI.Models
{
    public class TopSpot
    {
        // classes need to have properties and methods.
        //{ get; set; } --- property. can be get/got, or set.
        public string Name { get; set; }
        public string Description { get; set; }
        public double[] Location { get; set; }
    }
}