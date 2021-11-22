using System;


namespace CustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new KunalException();
            throw new KunalException("custom exception creates");
        }
    }
}
