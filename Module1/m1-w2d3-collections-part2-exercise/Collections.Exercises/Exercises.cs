using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ExerciseProblems
{
    public class Exercises
    {
        /*
	    * Dictionary/Dictionary Exercises
	    */

        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * animalGroupName("giraffe") → "Tower"
         * animalGroupName("") -> "unknown"         
         * animalGroupName("walrus") -> "unknown"
         * animalGroupName("Rhino") -> "Crash"
         * animalGroupName("rhino") -> "Crash"
         * animalGroupName("elephants") -> "unknown"
         * 
         */
        public string AnimalGroupName(string animalName)
        {
            string result = "";

            Dictionary<string, string> animalKey = new Dictionary<string, string>();

            animalKey.Add("rhino", "Crash");
            animalKey.Add("giraffe", "Tower");
            animalKey.Add("elephant", "Herd");
            animalKey.Add("lion", "Pride");
            animalKey.Add("crow", "Murder");
            animalKey.Add("pigeon", "Kit");
            animalKey.Add("flamingo", "Pat");
            animalKey.Add("deer", "Herd");
            animalKey.Add("dog", "Pack");
            animalKey.Add("crocodile", "Float");

            result = (animalKey.ContainsKey(animalName.ToLower())) ? animalKey[animalName.ToLower()] : "unknown";

            return result;
        }

        /*
         * Given an string item number (a.k.a. SKU), return the discount percentage if the item is on sale.
         * If the item is not on sale, return 0.00.
         * 
         * If the item number is empty or null, return 0.00.
         * 
         * "KITCHEN4001" -> 0.20
         * "GARAGE1070" -> 0.15
         * "LIVINGROOM"	-> 0.10
         * "KITCHEN6073" -> 0.40
         * "BEDROOM3434" -> 0.60
         * "BATH0073" -> 0.15
         * 
         * The item number should be case insensitive so "kitchen4001", "Kitchen4001", and "KITCHEN4001"
         * should all return 0.20.
         *  
         * isItOnSale("kitchen4001") → 0.20
         * isItOnSale("") → 0.00
         * isItOnSale("GARAGE1070") → 0.15
         * isItOnSale("dungeon9999") → 0.00 
         * 
         */
        public double IsItOnSale(string itemNumber)
        {
            double result = 0.00;
            Dictionary<string, double> discountKey = new Dictionary<string, double>();

            discountKey.Add("kitchen4001", 0.20);
            discountKey.Add("garage1070", 0.15);
            discountKey.Add("livingroom", 0.10);
            discountKey.Add("kitchen6073", 0.40);
            discountKey.Add("bedroom3434", 0.60);
            discountKey.Add("bath0073", 0.15);

            result = (discountKey.ContainsKey(itemNumber.ToLower())) ? discountKey[itemNumber.ToLower()] : 0.00;

            return result;
        }

        /*
         * Modify and return the given Dictionary as follows: 
            if "Peter" has more than 0 money, transfer half of it to "Paul",
         * but only if Paul has less than $10s.
         * 
         * Note, monetary amounts are specified in cents: 
            penny=1, nickel=5, ... $1=100, ... $10=1000, ...
         * 
         * robPeterToPayPaul({"Peter": 2000, "Paul": 99}) → {"Peter": 1000, "Paul": 1099}
         * robPeterToPayPaul({"Peter": 2000, "Paul": 30000}) → {"Peter": 2000, "Paul": 30000}
         * 
         */
        public Dictionary<string, int> RobPeterToPayPaul(Dictionary<string, int> peterPaul)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();
            result = peterPaul;

            if ((peterPaul["Peter"] > 0) && (peterPaul["Paul"] < 1000))
            {
                result["Peter"] = result["Peter"] / 2;
                result["Paul"] = result["Paul"] + result["Peter"];
            }


            return result;

        }

        /*
         * Modify and return the given Dictionary as follows: 
         if "Peter" has $50 or more, AND "Paul" has $100 or more,
         * then create a new "PeterPaulPartnership" worth a 
         combined contribution of a quarter of each partner's
         * current worth.
         * 
         * peterPaulPartnership({"Peter": 50000, "Paul": 100000}) → {"Peter": 37500, "Paul": 75000, "PeterPaulPartnership": 37500}
         * peterPaulPartnership({"Peter": 3333, "Paul": 1234567890}) → {"Peter": 3333, "Paul": 1234567890}
         * 
         */
        public Dictionary<string, int> PeterPaulPartnership(Dictionary<string, int> peterPaul)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            result = peterPaul;

            if ((peterPaul["Peter"] > 5000) && (peterPaul["Paul"] > 10000))
            {
                result["Peter"] = ((peterPaul["Peter"] / 4) * 3);
                result["Paul"] = ((peterPaul["Paul"] / 4) * 3);
                result["PeterPaulPartnership"] = (peterPaul["Paul"] / 4) + (peterPaul["Paul"] / 4);
            }


            return result;
        }

        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> 
         where for every different string in the array, 
         * there is a key of its first character with the value of its last character.
         *
         * beginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * beginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * beginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (string word in words)
            {

                result[word.First().ToString()] = word.Last().ToString();
            }

            return result;
        }

        /*
         * Given an array of strings, 
         return a Dictionary<string, int> with a key for each different string, 
         with the value the 
         * number of times that string appears in the array.
         * 
         * ** A CLASSIC **
         * 
         * wordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * wordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * wordCount([]) → {}
         * wordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         * 
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (result.ContainsKey(word))
                {
                    result[word] = ++result[word];
                }
                else
                {
                    result[word] = 1;
                }
            }

            return result;
        }

        /*
         * Given an array of int values, return a Dictionary<int, int> 
         with a key for each int, with the value the 
         * number of times that int appears in the array.
         * 
         * ** The lesser known cousin of the the classic wordCount **
         * 
         * intCount([1, 99, 63, 1, 55, 77, 63, 99, 63, 44]) → {1: 2, 44: 1, 55: 1, 63: 3, 77: 1, 99:2}
         * intCount([107, 33, 107, 33, 33, 33, 106, 107]) → {33: 4, 106: 1, 107: 3}
         * intCount([]) → {}
         * 
         */
        public Dictionary<int, int> IntCount(int[] ints)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            foreach (int i in ints)
            {
                if (result.ContainsKey(i))
                {
                    result[i] = ++result[i];
                }
                else
                {
                    result[i] = 1;
                }
            }

            return result;
        }

        /*
         * Given an array of strings, return a Dictionary<string, Boolean> 
         where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         * 
         * wordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * wordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * wordMultiple(["c", "c", "c", "c"]) → {"c": true}
         * 
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> result = new Dictionary<string, bool>();

            foreach (string word in words)
            {
                if (result.ContainsKey(word))
                {
                    result[word] = true;
                }
                else
                {
                    result[word] = false;
                }
            }

            return result;
        }

        /*
         * Given two Dictionarys, Dictionary<string, int>, merge the two into a new Dictionary,
         Dictionary<string, int> where keys in Dictionary2, 
         * and their int values, are added to the int values of matching keys in 
         Dictionary1. Return the new Dictionary.
         * 
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *  
         * consolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         * 
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int>
            mainWarehouse, Dictionary<string, int> remoteWarehouse)
        {
            Dictionary<string, int> unioned = new Dictionary<string, int>();
            unioned = mainWarehouse;

            foreach (string remoteSKU in remoteWarehouse.Keys)
            {
                if (unioned.ContainsKey(remoteSKU))
                {
                    unioned[remoteSKU] = unioned[remoteSKU] + remoteWarehouse[remoteSKU];
                }
                else
                {
                    unioned.Add(remoteSKU, remoteWarehouse[remoteSKU]);
                }
            }
            return unioned;
        }

        /*
         * Just when you thought it was safe to get back in the water --- last2Revisited!!!!
         * 
         * Given an array of strings, for each string,
         the count of the number of times that a substring length 2 appears 
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1. 
         * 
         * We don't count the end substring, but the substring may overlap a 
         prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. 
         The third pair at position 2 is the
         * end substring, which we don't count.  
         * 
         * Return Dictionary<string, int>, where the key is string from the array,
         and its last2 count.
         *  
         * last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         * 
         */
        public Dictionary<string, int> Last2Revisted(string[] words)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string last2 = word.Substring(word.Length - 2, 2);

                result[word] = 0;

                for (int i = 0; i < word.Length - 2; i++)
                {
                    if (word.IndexOf(last2, i) == i)
                    {
                        result[word] = ++result[word];
                    }
                }


            }

            return result;
        }

    }
}
