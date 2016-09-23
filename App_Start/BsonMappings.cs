using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using RestService.Models;

namespace RestService.App_Start
{
    public sealed class BsonMappings
    {        
        public static void Map()
        {                        
            BsonClassMap.RegisterClassMap<Address>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);                
                cm.MapMember(c => c.Building).SetElementName("building");
                cm.MapMember(c => c.Coordinates).SetElementName("coord");
                cm.MapMember(c => c.Street).SetElementName("street");
                cm.MapMember(c => c.ZipCode).SetElementName("zipcode");                
            });

            BsonClassMap.RegisterClassMap<Grades>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
                cm.MapMember(c => c.Date).SetSerializer(new DateTimeSerializer(dateOnly: true)).SetElementName("date");
                cm.MapMember(c => c.Grade).SetElementName("grade");
                cm.MapMember(c => c.Score).SetElementName("score");                
            });

            BsonClassMap.RegisterClassMap<Restaurant>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
                cm.MapMember(c => c.Name).SetElementName("name");
                cm.MapMember(c => c.RestaurantId).SetElementName("restaurant_id");
                cm.MapMember(c => c.Borough).SetElementName("borough");
                cm.MapMember(c => c.Cuisine).SetElementName("cuisine");
                cm.MapMember(c => c.Address).SetElementName("address");                
                cm.MapMember(c => c.Grades).SetElementName("grades");
            });
        }        
    }
}