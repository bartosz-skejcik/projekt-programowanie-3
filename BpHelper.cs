using System;
using System.Collections.Generic;
using static ProjektNr3_Paczesny_72541.Form1;

namespace ProjektNr3_Paczesny_72541
{
    public class BpHelper
    {
        // Checks if there is a combination of denominations that can be used to withdraw the specified amount and return the combination
        
        // public struct bpDenomination
        // {
        //     public ushort bpValue;
        //     public ushort bpQuantity;
        // }
        public static bpDenomination[] bpGetWithdrawCombination(ushort bpAmount, bpDenomination[] bpDenominationValues)
        {
            // Create a list to store the result
            List<bpDenomination> result = new List<bpDenomination>();

            // Sort the denominations in descending order
            Array.Sort(bpDenominationValues, (a, b) => b.bpValue.CompareTo(a.bpValue));

            foreach (var denomination in bpDenominationValues)
            {
                if (bpAmount == 0)
                    break;

                // Calculate the number of denominations needed
                ushort count = (ushort)(bpAmount / denomination.bpValue);

                if (count > 0)
                {
                    // Add the denomination to the result
                    result.Add(new bpDenomination { bpValue = denomination.bpValue, bpQuantity = count });

                    // Subtract the amount
                    bpAmount -= (ushort)(count * denomination.bpValue);
                }
            }

            // Return the result as an array
            return result.ToArray(); 
        }
    }
}