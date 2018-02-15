using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloWorld.Models
{
    public class Book : INotifyPropertyChanged
    {

        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(id)));
            }
        }

        string titulo;
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(titulo)));
            }
        }

        Autor autor;
        public Autor Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(autor)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;



    }
}
