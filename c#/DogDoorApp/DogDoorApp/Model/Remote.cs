using System;
using System.Timers;

namespace DogDoorApp.Model
{
    class Remote
    {
        private readonly DogDoor _door;
        private readonly Timer _timer = new Timer(30);

        public Remote(DogDoor door)
        {
            _door = door;
            _timer.Elapsed += new ElapsedEventHandler(TimerForClosingDoor);
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing remote control button...");
            
            if (_door.IsOpen())
            {
                _door.Close();
                return;
            }
            _door.Open();
            AutoCloseDoor();
        }
        public void AutoCloseDoor()
        {
            _timer.Enabled = true;
        }

        public void TimerForClosingDoor(object sender, ElapsedEventArgs e)
        {
            _door.Close();
            _timer.Enabled = false;
        }
    }
}
