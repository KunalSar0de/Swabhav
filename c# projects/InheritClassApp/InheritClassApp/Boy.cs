using System;


namespace InheritClassApp
{
    class Boy:Man
    {
        public void Jump()
        {
            Console.WriteLine("Boy is Jumping");
        }
        public override void Play()
        {
            Console.WriteLine("Boy is Playing");
        }
    }
}
