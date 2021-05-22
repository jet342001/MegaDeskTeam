using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk
{
    public class DatabaseHandler
    {
        public static List<DeskQuote> filteredDeskQuotes;
        public static List<string> rushOrderPrices;
        public static List<DeskQuote> existingDeskQuotes;

        public static string StoreJsonQuote(DeskQuote deskQuote)
        {
            // THIS STORES THE QUOTE IN THE QUOTES.JSON FILE
            // IT IS ALREADY ADDED IN THE ADD QUOTES
            List<DeskQuote> deskQuotes = GetAllJsonQuotes();

            deskQuotes.Add(deskQuote);
            string json = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);
            File.WriteAllText(@"quotes.json", json);
            return json;
        }

        public static List<DeskQuote> GetAllJsonQuotes()
        {
            // THIS RETURNS A LIST OF ALL THE DESKQUOTES IN THE FILE QUOTES.JSON
            List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(File.ReadAllText(@"quotes.json"));
            if ((deskQuotes == null) || (deskQuotes.Count == 0))
            {
                return new List<DeskQuote>();
            }
            return deskQuotes;
        }

        public static DeskQuote GetLastDeskQuote()
        {
            // GETS THE LAST DESK QUOTE ADDED TO THE QUOTES.JSON FILE
            // THIS CAN BE USED IN THE DISPLAY QUOTE VIEW BECAUSE THE LAST QUOTE WILL BE THE ONE YOU WANT TO SHOW
            List<DeskQuote> deskQuotes = GetAllJsonQuotes();
            if (deskQuotes.Count > 0)
            {
                return deskQuotes[deskQuotes.Count - 1];
            }
            DeskQuote deskQuote = new DeskQuote();
            return deskQuote;
        }

        public static List<DeskQuote> SearchDeskQuotes(string surfaceMaterialType) 
        {
            // THIS RETURNS A LIST OF QUOTES FILTERED TO THE STRING SURFACE MATERIAL TYPE
            // IT WILL NEED TO BE UPDATED FOR THE SURFACE MATERIAL TYPE ENUM WHEN YOU CREATE IT
            // BUT THAT SHOULD BE EASY
            List <DeskQuote> deskQuotes = GetAllJsonQuotes();
            foreach (DeskQuote deskQuote in deskQuotes)
            {
                if (deskQuote.desk.GetSurfaceMaterial() == surfaceMaterialType)
                {
                    filteredDeskQuotes.Add(deskQuote);
                }   
            }
            return filteredDeskQuotes;
        }

        public static List<string> GetRushOrderPrices()
        {
            // NEED TO ADD RUSHORDERPRICES.TXT FILE TO PROJECT
            // NOT SURE IF WE WANT TO USE AN ENUM FOR THE PRICES
            // NOT SURE THE WAY WE NEED THE DATA RETURNED
            // RIGHT NOW IT IS RETURNING A LIST OF STRINGS WITH THE STRING BEING THE PRICE
            string[] rows = System.IO.File.ReadAllLines(@"rushOrderPrices.txt");
            for (int i = 0; i <= rows.Length - 1; i++)
            {
                rushOrderPrices.Add(rows[i]);
            }
            return rushOrderPrices;
        }
    }
}
