using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysChallengeHackerRank
{
    class MyBook : Book
    {
        int price = 0;
        public MyBook(string mbTitle, string mbAuthor, int mbPrice)
        {
            base.title = mbTitle;
            base.author = mbAuthor;
            price = mbPrice;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }

}
