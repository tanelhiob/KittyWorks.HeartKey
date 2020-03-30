using System;
using System.Text.Json.Serialization;

namespace KittyWorks.HeartKey.Models
{
    public class Heartbeat
    {
        [JsonPropertyName("activities-heart")]
        public ActivitiesHeart[] ActivitiesHeart { get; set; }
    }
    
    public class ActivitiesHeart
    {
        public DateTimeOffset DateTime { get; set; }
        public Value Value { get; set; }
    }

    public class Value
    {
        public object[] CustomHeartRateZones { get; set; }
        public Heartratezone[] HeartRateZones { get; set; }
        public int RestingHeartRate { get; set; }
    }

    public class Heartratezone
    {
        public float CaloriesOut { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public int Minutes { get; set; }
        public string Name { get; set; }
    }
}
