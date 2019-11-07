using System.Collections.Generic;
using InventoryManager.Data;

namespace InventoryManager.Data
{
    public class World
    {
        public List<Room> Rooms { get; set; }

        public List<Item> Items { get; set; }
    }
}
