using System;

namespace DogDoorApp.Model
{
    class DogDoor
    {
        private bool _open;
        public DogDoor()
        {
            _open = false;    
        }
        public void Open()
        {
            Console.WriteLine("-->The dog door is open");
            _open = true;
        }
        public void Close()
        {
            Console.WriteLine("-->The dog door is closed");
            _open = false;
        }
        public bool IsOpen()
        {
            return _open;
        }
    }
}
