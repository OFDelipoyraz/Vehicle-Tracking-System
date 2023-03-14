using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje1.Models
{
    public class Vehicle
    {
        [BsonId]
        public ObjectId id { get; set; }
        [BsonElement("Date")]
        public DateTime Date { get; set; }
        [BsonElement("Lat")]
        public string Lat { get; set; }
        [BsonElement("Lng")]
        public string Lng { get; set; }
        [BsonElement("ID")]
        public int ID { get; set; }
    }
}
