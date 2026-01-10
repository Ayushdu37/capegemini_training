using System;
using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class DialingCodes
    {
        // Dictionary<int, string> DialingCode = new Dictionary<int, string>();

        public static Dictionary<int, string> GetEmptyDictionary()
        {
            Dictionary<int, string> DialingCode = new Dictionary<int, string>();

            return DialingCode;
        }
        public static Dictionary<int, string> GetExistingDictionary()
        {
            Dictionary<int, string> DialingCode = new Dictionary<int, string>();

            DialingCode.Add(1, "United States of America");
            DialingCode.Add(55, "Brazil");
            DialingCode.Add(91, "India");

            return DialingCode;
        }
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(countryCode, countryName);
            return dictionary;
        }
        public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }
        public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                return existingDictionary[countryCode];
            }
            return "";
        }
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }
        public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }
            return existingDictionary;
        }
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary,
            int countryCode)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary.Remove(countryCode);
            }
            return existingDictionary;
        }
        public static string FindLongestCountryName(
            Dictionary<int, string> existingDictionary)
        {
            string longestName = "";

            foreach (var item in existingDictionary.Values)
            {
                if (item.Length > longestName.Length)
                {
                    longestName = item;
                }
            }

            return longestName;
        }
        public static void PrintDictionary(Dictionary<int, string> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine("Code: " + item.Key + ", Country: " + item.Value);
            }
        }

    }
}