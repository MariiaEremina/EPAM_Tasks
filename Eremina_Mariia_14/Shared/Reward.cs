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
        public int ID { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }

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

        public Reward()
        {
        }
    }
}
