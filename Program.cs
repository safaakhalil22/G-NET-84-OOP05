namespace G_NET_84_OOP05
{
    class Program
    {
        #region Program
        //static Shipment shipment1 = null!;
        //static Shipment shipment2 = null!;
        //static Shipment shipment3 = null!;

        //static void Main(string[] args)
        //{
        //    DeliveryUtilities.PrintSystemTitle("Smart Delivery Management System");
        //    Console.WriteLine();

        //    CreateShipments_Demo();
        //    ObjectCopying_Demo();
        //    ShallowCopy_Demo();
        //    DeepCopy_Demo();
        //    ExtensionMethods_Demo();
        //    TrackingStatus_Demo();
        //    StaticUtilities_Demo();
        //    PartialMethod_Demo();

        //    DeliveryUtilities.PrintSystemTitle("Assignment Completed");

        //    Console.WriteLine("\nPress any key to exit...");
        //    Console.ReadKey();
        //}

        //#region Creating Shipments

        //static void CreateShipments_Demo()
        //{
        //    DeliveryUtilities.PrintSystemTitle("Creating Shipments...");
        //    Console.WriteLine();

        //    shipment1 = new Shipment("SH001", "Standard", 3, new DeliveryAddress("Cairo", "Tahrir St"));
        //    shipment1.UpdateTrackingStatus("In Transit");
        //    Console.WriteLine("Standard Shipment Created");

        //    shipment2 = new Shipment("SH002", "Express", 2, new DeliveryAddress("Alexandria", "Corniche St"));
        //    shipment2.UpdateTrackingStatus("Out For Delivery");
        //    Console.WriteLine("Express Shipment Created");

        //    shipment3 = new Shipment("SH003", "International", 8, new DeliveryAddress("Giza", "Haram St"));
        //    shipment3.UpdateTrackingStatus("Delivered");
        //    Console.WriteLine("International Shipment Created");

        //    Console.WriteLine();
        //    Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
        //    Console.WriteLine();
        //}

        //#endregion

        //#region Object Copying

        //static void ObjectCopying_Demo()
        //{
        //    DeliveryUtilities.PrintSystemTitle("Object Copying");
        //    Console.WriteLine();

        //    Shipment assigned = shipment1;

        //    Console.WriteLine($"Original Shipment  : {shipment1.TrackingCode}");
        //    Console.WriteLine($"Assigned Shipment  : {assigned.TrackingCode}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Same Object : {ReferenceEquals(shipment1, assigned)}");
        //    Console.WriteLine();
        //}

        //#endregion

        //#region Shallow Copy

        //static void ShallowCopy_Demo()
        //{
        //    DeliveryUtilities.PrintSeparator();
        //    Console.WriteLine("Shallow Copy");
        //    DeliveryUtilities.PrintSeparator();
        //    Console.WriteLine();

        //    Shipment shallowCopy = shipment1.ShallowCopy();

        //    Console.WriteLine($"Original Shipment Address : {shipment1.DeliveryAddress.City}");
        //    Console.WriteLine($"Copied Shipment Address   : {shallowCopy.DeliveryAddress.City}");
        //    Console.WriteLine();
        //    Console.WriteLine("Changing copied shipment address...");
        //    Console.WriteLine();

        //    shallowCopy.DeliveryAddress.City = "Giza";

        //    Console.WriteLine($"Original Shipment Address : {shipment1.DeliveryAddress.City}");
        //    Console.WriteLine($"Copied Shipment Address   : {shallowCopy.DeliveryAddress.City}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(shipment1.DeliveryAddress, shallowCopy.DeliveryAddress)}");
        //    Console.WriteLine();

        //    shipment1.DeliveryAddress.City = "Cairo";
        //}

        //#endregion

        //#region Deep Copy

        //static void DeepCopy_Demo()
        //{
        //    DeliveryUtilities.PrintSeparator();
        //    Console.WriteLine("Deep Copy");
        //    DeliveryUtilities.PrintSeparator();
        //    Console.WriteLine();

        //    Shipment deepCopy = shipment1.DeepCopy();

        //    Console.WriteLine($"Original Shipment Address : {shipment1.DeliveryAddress.City}");
        //    Console.WriteLine($"Copied Shipment Address   : {deepCopy.DeliveryAddress.City}");
        //    Console.WriteLine();
        //    Console.WriteLine("Changing copied shipment address...");
        //    Console.WriteLine();

        //    deepCopy.DeliveryAddress.City = "Giza";

        //    Console.WriteLine($"Original Shipment Address : {shipment1.DeliveryAddress.City}");
        //    Console.WriteLine($"Copied Shipment Address   : {deepCopy.DeliveryAddress.City}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(shipment1.DeliveryAddress, deepCopy.DeliveryAddress)}");
        //    Console.WriteLine();
        //}

        //#endregion

        //#region Extension Methods

        //static void ExtensionMethods_Demo()
        //{
        //    DeliveryUtilities.PrintSystemTitle("Extension Methods");
        //    Console.WriteLine();

        //    Console.WriteLine(shipment1.GetSummary());
        //    Console.WriteLine(shipment2.GetSummary());
        //    Console.WriteLine(shipment3.GetSummary());
        //    Console.WriteLine();

        //    Console.WriteLine($"SH001 Is Delivered : {shipment1.IsDelivered()}");
        //    Console.WriteLine($"SH003 Is Delivered : {shipment3.IsDelivered()}");
        //    Console.WriteLine();
        //}

        //#endregion

        //#region Tracking Status

        //static void TrackingStatus_Demo()
        //{
        //    DeliveryUtilities.PrintSystemTitle("Tracking Status");
        //    Console.WriteLine();

        //    shipment1.UpdateTrackingStatus("Out For Delivery");
        //    Console.WriteLine();
        //}

        //#endregion

        //#region Static Utilities

        //static void StaticUtilities_Demo()
        //{
        //    DeliveryUtilities.PrintSystemTitle("Static Utilities");
        //    Console.WriteLine();

        //    DeliveryUtilities.PrintSeparator();
        //    Console.WriteLine("Delivery Center");
        //    DeliveryUtilities.PrintSeparator();
        //    Console.WriteLine();

        //    Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
        //    Console.WriteLine();
        //}

        //#endregion

        //#region Partial Method

        //static void PartialMethod_Demo()
        //{
        //    DeliveryUtilities.PrintSystemTitle("Partial Method");
        //    Console.WriteLine();

        //    shipment1.UpdateTrackingStatus("Delivered");
        //    Console.WriteLine();
        //}

        //#endregion
        #endregion
    }
}
