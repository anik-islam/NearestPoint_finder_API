using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearestPoint_finder_API.Models
{
    public class DistanceFinder
    {
        [BsonId] 
        public string Id { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }



    }
}