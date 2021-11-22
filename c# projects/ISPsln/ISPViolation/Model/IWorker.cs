using System;


namespace ISPViolation.Model
{
    interface IWorker
    {
        void StartWork();
        void StopWork();
        void StartEat();
        void StopEat();
    }
}
