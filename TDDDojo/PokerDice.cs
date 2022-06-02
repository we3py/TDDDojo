using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDojo
{
    public class PokerDice
    {
        public string PokerHand(int[] results)
        {
            int[] validArray = new int[] { 1, 2, 3, 4, 5, 6 };
            if(results.Length != 5)
            {
                throw new ArgumentException("Wrong length of input array!");
            }

            foreach (var validItem in validArray)
            {
                validArray.Any
            }
            
            return "";


        }
    }
}
