using System;
using System.Collections.Generic;

namespace WebAppTourist.Models
{
    public partial class RouteAttraction
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int AttractionId { get; set; }

        public Attraction Attraction { get; set; }
        public Route Route { get; set; }
    }
}
