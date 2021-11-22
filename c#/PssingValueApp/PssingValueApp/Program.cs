using System;


namespace PssingValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int score = 100;
            //Console.WriteLine("Value before method call:"+score);
            //updatescore(score);
            //Console.WriteLine("Value after method call::" + score);

            int[] manyScores = { 70, 80, 90, 100 };//manyscore contains address of heap and ot the values
            UpdateManyScoresToZero(manyScores);
            foreach(int s in manyScores)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        private static void UpdateManyScoresToZero(int[] manyScores)
        {
            for(int i=0;i<manyScores.Length;i++)
            {
                manyScores[i] = 0;
            }
        }
        
        private static void updatescore(int  pscore)
        {
            pscore = 0;
            Console.WriteLine("val:" +pscore);
        }
    }
}
