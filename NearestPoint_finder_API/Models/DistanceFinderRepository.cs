using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NearestPoint_finder_API.Models
{
    public class DistanceFinderRepository : IDistanceFinderRepository
    {
        MongoServer _server;
        MongoDatabase _database;
        MongoCollection<DistanceFinder> _distance;

        public DistanceFinderRepository()
            : this("")
        { 
        }
        public DistanceFinderRepository(string connection)
        {
            if (string.IsNullOrWhiteSpace(connection))
            {
                connection = "mogodb://localhost:27017";
            }

            _server = MongoServer.Create(connection);  //Create an instance of MongoServer using the connection string
            _database = _server.GetDatabase("DistanceFinder"); //Set the database name;
            _distance = _database.GetCollection<DistanceFinder>("distance"); //collection name
        }
        public IEnumerable<DistanceFinder> Find_Values()
        {
            return _distance.FindAll();
        }
        public DistanceFinder Find_Value(string id)
        {
            IMongoQuery query = Query.EQ("_id", id);

            return _distance.Find(query).FirstOrDefault(); 
        }
        public DistanceFinder Insert_Values(DistanceFinder values)
        {
            _distance.Insert(values);
            return values;
        }
        
    }
}