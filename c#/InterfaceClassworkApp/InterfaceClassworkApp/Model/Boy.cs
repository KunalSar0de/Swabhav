using System;


namespace InterfaceClassworkApp.Model
{
    class Boy : IManner, IEmotion
    {
        public void Cry()
        {
            Console.WriteLine("Boy crying");
        }

        public void Depart()
        {
            Console.WriteLine("Boy depart");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy Laught");
        }

        public void Wish()
        {
            Console.WriteLine("Boy Wish");
        }
    }
}
