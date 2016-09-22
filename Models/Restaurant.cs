using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RestService.Models
{
    [BsonIgnoreExtraElements]
    public sealed class Restaurant
    {        
        public ObjectId Id { get; set; }
        //public string restaurant_id { get; set; }        
        public string name { get; set; }
        //public Address Address { get; set; }
        //public string Borough { get; set; }
        //public string Cuisine { get; set; }
        //public IList<Grades> Grades { get; set; }
    }

    public sealed class Address
    {
        public string Building { get; set; }
        public decimal[] Coord { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }

    public sealed class Grades {
        public DateTime Date { get; set; }
        public string Grade { get; set; }
        public int Score { get; set; }        
    }
}