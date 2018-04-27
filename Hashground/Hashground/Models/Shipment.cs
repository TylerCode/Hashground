using Hashground.Classes;

namespace Hashground.Models
{
    class Shipment
    {
        public long shipmentId;
        public int averageTemperature;
        public string origination;
        public Vegetable vegetable; //fucked that naming up
        private char delimiter = '|';

        public Shipment(long ShipmentId, int AverageTemperature, string Origination, Vegetable Vegetable)
        {
            shipmentId = ShipmentId;
            averageTemperature = AverageTemperature;
            origination = Origination;
            vegetable = Vegetable;
        }

        public string Encode()
        {
            return shipmentId.ToString() + delimiter + averageTemperature.ToString() + delimiter + origination + delimiter + vegetable.name + delimiter + vegetable.quantity.ToString();
        }

        public void Decode(string inputString)
        {
            string[] data = inputString.Split(delimiter);
            int quantityParsed;

            long.TryParse(data[0], out shipmentId);
            int.TryParse(data[1], out averageTemperature);
            origination = data[2];
            int.TryParse(data[4], out quantityParsed);
            vegetable = new Vegetable(data[3], quantityParsed);
        }
    }
}
