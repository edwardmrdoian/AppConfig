using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AppConfig.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppConfig.Controllers
{
    public class BookController : Controller
    {
        private readonly List<Book> books;
        public BookController()
        {
            books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Name = "Book1",
                    Price =10,
                    Picture="https://images.unsplash.com/photo-1511108690759-009324a90311?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=334&q=80",
                    Author = "Author1",
                    Genre = "Genre1"
                },
                new Book()
                {
                    Id = 2,
                    Name = "Book2",
                    Picture="https://images.unsplash.com/photo-1535398089889-dd807df1dfaa?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=80",
                    Price =12,
                    Author = "Author2",
                    Genre = "Genre2"
                },
                new Book()
                {
                    Id = 3,
                    Name = "Book3",
                    Picture="https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=334&q=80",
                    Price =15,
                    Author = "Author3",
                    Genre = "Genre3"
                }
            };
        }
        public IActionResult Index()
        {           
            return View(books);
        }

       public IActionResult BookDetail(int id)
       {
            Book book = books.Where(x => x.Id == id).FirstOrDefault();
            return View(book);
       }
    }
}