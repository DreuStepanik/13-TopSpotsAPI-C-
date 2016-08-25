using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotsAPIController : ApiController
    {
        public IEnumerable<TopSpot> Get()
        // TopSpot is the class.
        {
            // GET /api/TopSpots
            TopSpot[] topspots = JsonConvert.DeserializeObject<TopSpot[]>(File.ReadAllText(@"c:\dev\13-TopSpotsAPI\TopSpotsAPI\topspots.json"));
            return topspots;
        }
    
    }
}
