using System;

namespace DotComGameApp.Model
{
    class DotComBackground
    {       
        int[] locationCells;
        int numOfHits = 0;

        public void SetLocationCells(int[] locs)
        {
            locationCells = locs;
        }
        public string CheckYourself(string stringGuess)
        {
            int guess = Int32.Parse(stringGuess);
            string result = "miss";
            foreach (int cell in locationCells)
            {
                if (guess == cell)
                {
                    result = "hit";
                    numOfHits++;
                    break;
                }        
            } // out of the loop
            if (numOfHits ==locationCells.Length)
            {
                result = "kill";
            }
            Console.WriteLine(result);
            return result;
        } // close method 
    }
}

