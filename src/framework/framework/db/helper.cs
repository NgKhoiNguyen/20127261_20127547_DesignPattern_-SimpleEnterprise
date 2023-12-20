using System;
using System.Collections.Generic;
using System.IO;

namespace framework.db
{
    public static class DatabaseHelper
    {
        public static string[] ReadTextFromFile(string filePath)
        {
            string[] lines = new string[0];

            try
            {
                // Read all lines from the file
                lines = File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file not found, permission issues)
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return lines;
        }
        public static string CreateConnectionStr(string[] list)
        {
            string res = "";
            for (int i = 0; i < list.Length; i++)
            {
                res = res + list[i] + ";";
            }
            return res;
        }

    }
}
