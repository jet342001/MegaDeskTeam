using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk
{
    public class DatabaseHandler
    {
        public static string GetAllQuotes()
        {
            string message = "";
            string[] rows = System.IO.File.ReadAllLines(@"quotes.txt");
            for (int i = 0; i <= rows.Length - 1; i++)
            {
                message += rows[i] + "\r\n";
            }
            return message;
        }

        public static string GetLastQuote()
        {
            string data = "width,depth,surface_material,num_drawers,rush_days,first_name,last_name,total_price";
            string[] rows = System.IO.File.ReadAllLines(@"quotes.txt");
            return data += rows[rows.Length - 1];
        }

        public static string FindQuotes(string surfaceMaterialType)
        {
            string message = "";
            string[] rows = System.IO.File.ReadAllLines(@"quotes.txt");
            for (int i = 1; i <= rows.Length - 1; i++)
            {
                if (rows[i].Contains(surfaceMaterialType)){
                message += rows[i] + "\r\n";
            }
            }
            return message;
        }
    }
}
