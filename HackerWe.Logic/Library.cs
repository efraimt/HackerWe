using HackerWe.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace HackerWe.Logic
{
    public static class Library
    {
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<Client> Clients { get; set; } = new List<Client>();

        public static List<Borowing> Borowings { get; set; } = new List<Borowing>();

        static Library()
        {

        }

        public static void SaveBooks()
        {
            var s = "";
            foreach (var book in Library.Books)
            {
                s += book.ToCSV() + Environment.NewLine;

            }
            File.WriteAllText(@"D:\Documents\b.csv",s);
        }

        public static void SaveBooksAsJSON()
        {
            var jsonSTR = JsonSerializer.Serialize(Library.Books);

            File.WriteAllText(@"books.json", jsonSTR);
        }

        public static void ReadBooksFromJSON()
        {
            var jsonSTR =File.ReadAllText(@"books.json");
            Library.Books = JsonSerializer.Deserialize<List<Book>>(jsonSTR);
        }


    }
}
