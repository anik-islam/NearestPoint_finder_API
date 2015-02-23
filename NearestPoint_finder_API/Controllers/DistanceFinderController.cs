using NearestPoint_finder_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NearestPoint_finder_API.Controllers
{
    public class DistanceFinderController : ApiController
    {
        private static readonly IDistanceFinderRepository _distance = new DistanceFinderRepository();
        public IQueryable<DistanceFinder> GET()
        {
            return _distance.Find_Values().AsQueryable(); 
        }
        public DistanceFinder GET(string id)
        {
            DistanceFinder distance = _distance.Find_Value(id);
            if (distance == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound); 
            }
            return distance;
        }

        public DistanceFinder Post(DistanceFinder value)
        {
            DistanceFinder distance = _distance.Insert_Values(value);
            return distance;
        }
    }
}
