

namespace GuitarApp
{
    class Guitar
    {
        
        internal string SerialNumber { get; }
        internal double Price { get; set; }       
        internal GuitarSpec Spec { get; }

        public Guitar(string serialNumber,
                        double price,
                        Builder builder,
                        string model,
                        Type type,
                        Wood backWood,
                        Wood topWood)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Spec = new GuitarSpec(builder, model, type, backWood, topWood);
        }
    }
}
