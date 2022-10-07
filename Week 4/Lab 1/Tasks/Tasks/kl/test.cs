using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.kl
{
    internal class Book
    {
        public string author;
        public int pages;
        public List<String> chapter=new List<string>();
        public int bookmark;
        public int price;
        public bool available;
        public Book() { }

        public Book(string author, int pages, List<string> chapter, int bookmark, int price,bool available)
        {
            this.author = author;
            this.pages = pages;
            this.chapter = chapter;
            this.bookmark = bookmark;
            this.price = price;
            this.available=available;
        }
        public string getChapter(int chapter_num)
        {
            return chapter[chapter_num - 1];
        }
        public int get_bookmark()
        {
            return bookmark;
        }
        public void set_bookmark(int page)
        {
            bookmark=page;
        }
        public bool is_available()
        {
            return available;
        }
        public int get_price()
        {
            return price;
        }
        public void set_price(int price)
        {
            this.price = price;
        }
    }
    

}
