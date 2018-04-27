using Hashground.Classes;

namespace Hashground.Models
{
    class Shipment
    {
        public long shipmentId;
        public int averageTemperature;
        public string origination;
        public Vegetable vegetable; //fucked that naming up

        public Shipment(long ShipmentId, int AverageTemperature, string Origination, Vegetable Vegetable)
        {
            shipmentId = ShipmentId;
            averageTemperature = AverageTemperature;
            origination = Origination;
            vegetable = Vegetable;
        }
    }
}
