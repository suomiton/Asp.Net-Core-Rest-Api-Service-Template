using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace RestService.Models
{
    public class Restaurant
    {
        [JsonIgnore]
        public ObjectId Id { get; set; }
        public string RestaurantId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Borough { get; set; }
        public string Cuisine { get; set; }
        public IList<Grades> Grades { get; set; }

        public Restaurant()
        {
            this.Address = new Address();
            this.Grades = new List<Grades>();
        }
    }

    public class Address
    {
        public string Building { get; set; }
        public double[] Coordinates { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }

    public sealed class Grades
    {
        public DateTime Date { get; set; }
        public string Grade { get; set; }
        public object Score { get; set; }
    }
}