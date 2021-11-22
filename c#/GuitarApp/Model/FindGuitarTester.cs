using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    class FindGuitarTester
    {
        public static void TestErin()
        { 
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.kunal, "Stratocastor", Type.electric, Wood.Alder, Wood.Alder);
            List<Guitar> guitars = inventory.Search(whatErinLikes);
            if (guitars.Count > 0)
            {
                string msgSuccess = "Erin, you might like these guitars: ";
                foreach (Guitar guitar in guitars)
                {
                    GuitarSpec spec = guitar.Spec;
                    msgSuccess +=   "\nWe have a " +
                        Enumerations.GetEnumDescription(spec.Builder) + " " + spec.Model + " " +
                        Enumerations.GetEnumDescription(spec.Type) + " guitar:\n    " +
                        Enumerations.GetEnumDescription(spec.BackWood) + " back and sides,\n    " +
                        Enumerations.GetEnumDescription(spec.TopWood) + " top.\nYou can have it for only $" +
                        guitar.Price + "!\n---------------------------------------------";
                }
                Console.WriteLine(msgSuccess);
                Console.ReadKey();
            }
            else
            {
                string msgFail = "Sorry, Erin, we have nothing for you.";
                Console.WriteLine(msgFail);
                Console.ReadKey();
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            // Add Guitars to the inventory ...
            inventory.AddGuitar("V12345", 1345.55, Builder.Fender, "Stratocastor", Type.electric, Wood.Alder, Wood.Adirondack);
            inventory.AddGuitar("A21457", 900.55, Builder.Collings, "OakTown Goove", Type.acoustic, Wood.Brazilian_Rosewood, Wood.Cedar);
            inventory.AddGuitar("V95693", 1499.95, Builder.Fender, "Stratocastor", Type.electric, Wood.Alder, Wood.Alder);
            inventory.AddGuitar("X54321", 430.54, Builder.kunal, "Stratocastor Light", Type.electric, Wood.Indian_Rosewood, Wood.Maple);
            inventory.AddGuitar("X99876", 2000.00, Builder.PRS, "Stratocastor FeatherWeight", Type.electric, Wood.Sitka, Wood.Cocobolo);
            inventory.AddGuitar("V9512", 1549.95, Builder.kunal, "Stratocastor", Type.electric, Wood.Alder, Wood.Alder);
        }
    }
}
