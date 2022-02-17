//main method
using ObjectOrientedProgram.NewFolder;

const string INVENTORY_JSON = @"C:\Users\sanjay\source\repos\ObjectOrientedProgramming\ObjectOrientedProgram\ObjectOrientedProgram\NewFolder\Inventory.json";
InventoryMain main = new InventoryMain();
 main.DisplayData(INVENTORY_JSON);