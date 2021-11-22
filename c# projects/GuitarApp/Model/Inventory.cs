
using System.Collections.Generic;

namespace GuitarApp
{
    class Inventory
    {
        private List<Guitar> _guitars;

        public Inventory()
        {
            _guitars = new List<Guitar>();
        }


        public void AddGuitar(string serialNumber,
                                double price,
                                Builder builder,
                                string model,
                                Type type,
                                Wood backWood,
                                Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            _guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            for (int i = 0; i < _guitars.Count; i++)
            {
                Guitar guitar = _guitars[i];
                if (guitar.SerialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            for (int i = 0; i < _guitars.Count; i++)
            {
                Guitar guitar = _guitars[i];
                GuitarSpec guitarSpec = guitar.Spec;
             
                if (searchSpec.Builder != guitarSpec.Builder) { continue; }
                if (!StringsMatch(searchSpec.Model, guitarSpec.Model)) { continue; }
                if (searchSpec.Type != guitarSpec.Type) { continue; }
                if (searchSpec.BackWood != guitarSpec.BackWood) { continue; }
                if (searchSpec.TopWood != guitarSpec.TopWood) { continue; }

                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }


        private bool StringsMatch(string stringA, 
                                  string stringB)
        {
            if (!string.IsNullOrEmpty(stringA) &&
                !string.IsNullOrEmpty(stringB) &&
                string.Compare(stringA, stringB) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
