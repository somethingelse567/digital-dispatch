﻿using System.Collections.Generic;

namespace bing_maps_test.Models
{
    public class Locations
    {
        public int LocationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Locations(int locid, string title, string desc, double latitude, double longitude)
        {
            this.LocationId = locid;
            this.Title = title;
            this.Description = desc;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
    public class LocationLists
    {
        public IEnumerable<Locations> LocationList { get; set; }
    }
}
