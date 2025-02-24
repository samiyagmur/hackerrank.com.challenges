﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Abstract.Classes
{
   
        abstract class Book
        {

            protected String title;
            protected String author;

            public Book(String t, String a)
            {
                title = t;
                author = a;
            }
            public abstract void Display();


        }

         class MyBook : Book
        {
            private int price;

            public MyBook(string title, string author, int myPrice) : base(title, author)
            {   
                price = myPrice;
            }

            public override void Display()
            {   
                Console.WriteLine($"Title: {title}\nAuthor: {author}\nPrice: {this.price}");
            }
        }

        class Solution
        {
            static void Main(String[] args)
            {
                String title = Console.ReadLine();
                String author = Console.ReadLine();
                int price = Int32.Parse(Console.ReadLine());
                Book new_novel = new MyBook(title, author, price);
                new_novel.Display();
            }
        }
    
}
