using System;
using CollectionApp.Model;
using System.Collections;
using System.Collections.Generic;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();
            Case2();
            Console.ReadLine();
        }

        private static void Case1()
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("Earphone", 100, 2));
            basket.Add(new LineItem("MousePad", 50, 5));
            basket.Add(new LineItem("Android Phone", 5000, 1));

            double _price = DisplayBucket(basket);
            Console.WriteLine("Final Total count: " + _price);
        }

        public static void Case2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("Earphone", 100, 2));
            basket.Add(new LineItem("MousePad", 50, 5));
            basket.Add(new LineItem("Android Phone", 5000, 1));
            double _price = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("Product : {0}\t\tPrice : {1}\t\tQuentity : {2}\t\t Total : {3}", item.ProductName, item.Price, item.Que,item.TotalPrice());
                _price += item.Price;
            }
            Console.WriteLine("\nFinal Price: {0}",_price);
        }

        private static double DisplayBucket(ArrayList basket)
        {
            for (int i = 0; i < basket.Count; i++)
                Console.WriteLine("Product : {0}\t\tPrice : {1}\t\tQuentity : {2}\t\t Total : {3}", ((LineItem)basket[i]).ProductName, ((LineItem)basket[i]).Price, ((LineItem)basket[i]).Que, ((LineItem)basket[i]).TotalPrice());
            double _price = 0;
            for (int i = 0; i < basket.Count; i++)
            {
                _price += ((LineItem)basket[i]).Price;
            }
            return _price;
        }
    }
}
