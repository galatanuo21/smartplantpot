namespace SmartPlantPot.Models
{
    public class Messwerte
    {
        public int Id { get; set; }
        public string Geraete_Id { get; set; }
        public DateTime Timestamp { get; set; }
        public double Humidity { get; set; }
    }
}
