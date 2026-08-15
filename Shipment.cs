using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_OOP05
{
    public partial class Shipment
    {
        #region Shipment
        //public static int TotalShipmentsCreated;

        //static Shipment()
        //{
        //    TotalShipmentsCreated = 0;
        //    Console.WriteLine("Shipment System Initialized");
        //}

        //public static int GetTotalShipmentsCreated()
        //{
        //    return TotalShipmentsCreated;
        //}

        //public string TrackingCode;
        //public string ShipmentType;
        //public double Weight;
        //public DeliveryAddress DeliveryAddress;

        //public Shipment(string trackingCode, string shipmentType, double weight, DeliveryAddress deliveryAddress)
        //{
        //    TrackingCode = trackingCode;
        //    ShipmentType = shipmentType;
        //    Weight = weight;
        //    DeliveryAddress = deliveryAddress;
        //    TrackingStatus = "Pending";
        //    TotalShipmentsCreated++;
        //}

        //public Shipment()
        //{
        //    TrackingCode = "";
        //    ShipmentType = "";
        //    DeliveryAddress = new DeliveryAddress();
        //    TrackingStatus = "Pending";
        //}

        //public double EstimatedCost()
        //{
        //    double baseRate = ShipmentType switch
        //    {
        //        "Express" => 15.0,
        //        "International" => 25.0,
        //        _ => 5.0
        //    };

        //    return baseRate + (Weight * 2.5);
        //}

        //public Shipment CopyShipment()
        //{
        //    return new Shipment(TrackingCode, ShipmentType, Weight, DeliveryAddress);
        //}

        //public Shipment ShallowCopy()
        //{
        //    return (Shipment)MemberwiseClone();
        //}

        //public Shipment DeepCopy()
        //{
        //    Shipment copy = (Shipment)MemberwiseClone();
        //    copy.DeliveryAddress = new DeliveryAddress(DeliveryAddress.City, DeliveryAddress.Street);
        //    return copy;
        //}

        //public void PrintShipment()
        //{
        //    Console.WriteLine($"Tracking Code   : {TrackingCode}");
        //    Console.WriteLine($"Shipment Type   : {ShipmentType}");
        //    Console.WriteLine($"Weight          : {Weight} KG");
        //    Console.WriteLine($"Delivery City   : {DeliveryAddress.City}");
        //    Console.WriteLine($"Estimated Cost  : {EstimatedCost():0.00}");
        //    Console.WriteLine($"Tracking Status : {TrackingStatus}");
        //}

        //partial void OnTrackingStatusChanged(string newStatus)
        //{
        //    Console.WriteLine($"Tracking status changed to: {newStatus}");
        //}
        #endregion
    }
}
