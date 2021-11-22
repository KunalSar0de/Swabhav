
namespace GuitarApp
{
    class GuitarSpec
    {
        internal Builder Builder { get; }
        internal string Model { get; }
        internal Type Type { get; }
        internal Wood BackWood { get; }
        internal Wood TopWood { get; }


        public GuitarSpec(Builder builder,
                        string model,
                        Type type,
                        Wood backWood,
                        Wood topWood)
        {
            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
        }
    }
}
