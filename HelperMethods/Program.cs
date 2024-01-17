string [] pallets = {"B14", "A11", "B12", "A13"};

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets){
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets){
    Console.WriteLine($"--{pallet}");
}

//clearing values at index 0 and 2 of array elements
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets) {
    Console.WriteLine($"-- {pallet}");
}

//resizing an array (adding more elements)
Console.WriteLine("");
//increasing array from 4 elements to 6 in total
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 .. count: {pallets.Length}");

//new elements
pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets) {
    Console.WriteLine($"-- {pallet}");
}

//resizing array, removing elements
Console.WriteLine("");
//removes the elements from the end of the aray (right to left) until there are 3 remaining 
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}