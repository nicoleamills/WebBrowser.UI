﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;
using System.Globalization;


namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        // add history items to the database
        public static void AddItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date);
        }

        // get history items from the database
        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        // Delete item from db
        public static void DeleteHistory(string item)
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string checkItem = string.Format("[{0}] {1} ({2})", row.Date, row.Title, row.URL);

                // Check if database match item
                if (checkItem == item)
                {
                    adapter.Delete(row.Id, row.URL, row.Title, row.Date.ToString());
                }
            }
        }

        // Clear history from db
        public static void ClearHistory()
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                adapter.Delete(row.Id, row.URL, row.Title, row.Date.ToString());
            }
        }

    }
}
