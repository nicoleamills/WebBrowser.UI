using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        // add bookmark items to database
        public static void AddItem(BookmarksItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        // get bookmark items from databases
        public static List<BookmarksItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarksItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarksItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        // Delete bookmark
        public static void DeleteBookmark(string item)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string checkItem = string.Format(string.Format("{0} ({1})", row.Title, row.URL));

                // Check if database matches selected item
                if (checkItem == item)
                {
                    adapter.Delete(row.Id, row.URL, row.Title);
                }
            }

        }


    }
}
