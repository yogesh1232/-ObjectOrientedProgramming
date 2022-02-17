//main method
using ObjectOrientedProgram.NewFolder;

const string INVENTORY_JSON = @"C:\Users\sanjay\source\repos\ObjectOrientedProgramming\ObjectOrientedProgram\ObjectOrientedProgram\NewFolder\Inventory.json";
InventoryManager inventoryManager = new InventoryManager();
inventoryManager.DisplayData(INVENTORY_JSON);
