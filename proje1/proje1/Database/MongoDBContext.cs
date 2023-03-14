using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace proje1.Database
{
    public class MongoDBContext
    {
        MongoClient client;
        public IMongoDatabase database;

        public MongoDBContext()
        {
            var client = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            database = client.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
        }
    }
}