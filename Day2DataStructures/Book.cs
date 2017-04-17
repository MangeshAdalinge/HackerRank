﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysChallengeHackerRank
{
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book()
        { }
        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }
}
