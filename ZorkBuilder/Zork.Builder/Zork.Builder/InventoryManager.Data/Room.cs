using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace InventoryManager.Data
{
   public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        public string Neighbors { get; set; }

        public override string ToString()
        {
            return Name;
        }


    }
}
