using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace HelloWorld.ViewModels
{
    public class BooksViewModel
    {
        public ICommand Carregar { get; set; }
        public ObservableCollection<Models.Book> Books { get; set; }

        public BooksViewModel()
        {

            Books = new ObservableCollection<Models.Book>();
            Books.Add(new Models.Book { Id = 1, Titulo = "Title 1" });

            Carregar = new Xamarin.Forms.Command(() =>
            {
                Books.Add(new Models.Book { Id = Books.Count + 1, Titulo = $"Title {Books.Count + 1}" });
            });
        }
    }
}
