using System.Collections;

namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Genaric: Hashtable
            //// Non-Generic Hashtables: Hastable

            // Hashtable phoneBook = new Hashtable();

            // phoneBook.Add("Hussein", 1111);
            // phoneBook.Add("Mahmoud", 2222);
            // phoneBook.Add("Fouad", 3333);
            // phoneBook.Add("Sara", 4444);

            // foreach (DictionaryEntry item in phoneBook)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine(phoneBook.Count); //4
            // Console.WriteLine(phoneBook.IsFixedSize); //False
            // Console.WriteLine(phoneBook.IsReadOnly); //False


            // Console.WriteLine("==========================="); 
            // foreach (var item in phoneBook.Keys)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine("===========================");
            // foreach (var item in phoneBook.Values)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine("===========================");
            // Console.WriteLine(phoneBook["Hussein"]);

            // phoneBook["Hussein2"] = 1234;
            // Console.WriteLine(phoneBook["Hussein2"]); //1234

            // phoneBook.Add("Hussein3", 5678);
            // Console.WriteLine(phoneBook["Hussein3"]);

            // Console.WriteLine("===========================");
            // Console.WriteLine();
            // Console.WriteLine(phoneBook.Contains("Hussein")); //True
            // Console.WriteLine(phoneBook.ContainsKey("Hussein")); //True
            // Console.WriteLine(phoneBook.ContainsValue(1234)); //True

            // phoneBook.Remove("Hussein3");
            // Console.WriteLine(phoneBook.ContainsKey("Hussein3")); //False

            #endregion

            #region Generic: Dictionary
            ////Dictionary
            //Dictionary<string, long> phoneBook = new Dictionary<string, long>();  // capacity here is zero

            //phoneBook.Add("Hussein", 1111);
            //phoneBook.Add("Mahmoud", 2222);
            //phoneBook.Add("Foaud", 3333);
            //phoneBook.Add("Esraa", 4444);

            //foreach (KeyValuePair<string, long> item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("===========================");
            //Console.WriteLine();

            //Console.WriteLine(phoneBook.Remove("Foaud")); //True: means suceessfuly removed
            //Console.WriteLine(phoneBook.Remove("Bolla")); //False: means failed to remove

            //Console.WriteLine(phoneBook.Remove("Esraa", out long result)); //True
            //Console.WriteLine(result); //4444

            //Console.WriteLine(phoneBook.Remove("Metwalli", out  result)); //False
            //Console.WriteLine(result); //0

            //Console.WriteLine("===========================");
            //Console.WriteLine();

            //Console.WriteLine(phoneBook.TryAdd("Hussein2", 5678)); //True
            //Console.WriteLine(phoneBook.TryGetValue("Ahmed", out result)); //False
            //Console.WriteLine(result); //0 
            #endregion

            HashSet<string> Names = new HashSet<string>();
            Names.Add("Hussein");
            Names.Add("Mahmoud");
            Names.Add("Fouad");
            Names.Add("Manar");
            Names.Add("Manar"); //ignored


            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Names.Capacity); //7
            Console.WriteLine(Names.Count); //4


        }
    }
}
