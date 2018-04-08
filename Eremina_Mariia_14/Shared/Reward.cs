using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Reward
    {
        private static int id = 0;
        
        public string Title { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }

        public Reward (string title)
        {
            Title = title;
            Description = null;
            ID = id;
            id++;
        }

        public Reward(string title, string description)
        {
            Title = title;
            Description = description;
            ID = id;
            id++;
        }

        public Reward(string title, string description, int Id)
        {
            Title = title;
            Description = description;
            ID = Id;
            //id++;
        }

        public Reward(string title, int Id)
        {
            Title = title;
            Description = null;
            ID = Id;
            //id++;
        }

        public Reward()
        {
        }
    }
}
