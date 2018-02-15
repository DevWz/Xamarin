using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HelloWorld.Models
{
    public class Autor : INotifyPropertyChanged
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

        string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(nome)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
