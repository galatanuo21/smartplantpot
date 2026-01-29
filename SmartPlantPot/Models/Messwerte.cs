using System.Text.Json.Serialization;

namespace SmartPlantPot.Models
{
    public class Messwerte
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        public string Geraete_Id { get; set; }
        public DateTime Timestamp { get; set; }
        public double Humidity { get; set; }
    }
}
