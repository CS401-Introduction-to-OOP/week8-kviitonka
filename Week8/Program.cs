using Week8;

Letter l1 = new Letter("FH643789", 0.1);
Letter l2 = new Letter("RYH76458", 0.05);
Parcel p1 = new Parcel("TH563470", 2, "30x20x30");
Parcel p2 = new Parcel("UG984534", 5, "40x40x40");
l1.PrintInfo();
p1.PrintInfo();
CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
myCargo.AddItem(l1);
myCargo.AddItem(l2);
myCargo.AddItem(p1);
myCargo.AddItem(p2);
Console.WriteLine(myCargo.GetTotalCost());