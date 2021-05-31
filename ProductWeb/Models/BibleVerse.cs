using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Models
{
    public class BibleVerse
    {

        string book;
        string chapter;
        string verse;
        string text;

        public string Book
        {
            get { return book; }
            set { book = value; }
        }
        public string Chapter
        {
            get { return chapter; }
            set { chapter = value; }
        }
        public string Verse
        {
            get { return verse; }
            set { verse = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }
}
