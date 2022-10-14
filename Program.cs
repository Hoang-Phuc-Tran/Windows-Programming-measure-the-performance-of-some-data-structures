/*
 * Project:	    A - 03 : DATA STRUCTURES
 * Author:	    Hoang Phuc Tran - 8789102
                 Bumsu Yi - 8110678
 * Date:		October 10, 2022
 * Description: An application, as part of an HTML file, will prompt the user to enter a 
 name, then prompt the user to choose an animal from the dropdown list. After that, it will
  display an image and information about the animal.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A03_DataStructures
{
    /*
     Comment Class 
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            const int VALID_MAX = 700;
            const int INVALID_MAX = 500;

            // Create an array, dictionary and hastable to contain elements
            ArrayList array = new ArrayList();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            Hashtable hashTable = new Hashtable();

            int[] dataSets = { 100000, 5000000};

            // Loop through dataSets to test 10,000 elements and 5,000,000 elements
            foreach (int numberOfElement in dataSets)
            {
                Console.WriteLine("Processing....");
                array.Clear();
                dictionary.Clear();
                hashTable.Clear();

                for (int i = 0; i < numberOfElement; i++)
                {
                    // get current date and time
                    DateTime now = DateTime.Now;
                    now.ToString("F");


                    // create new guid
                    string guid = Guid.NewGuid().ToString();
                    // concatenated with the current date and time
                    string combine = guid + now;

                    // store it
                    array.Add(guid);
                    dictionary.Add(guid, combine);
                    hashTable.Add(guid, combine);
                }

                




            }
        }
    }
}
