using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDatos.Modelos
{
    public class Item
    {
        public string title { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public List<string> categories { get; set; }
    }

    public class Channel
    {
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public List<Item> item { get; set; }
    }

    public class RootObject
    {
        public Channel channel { get; set; }
    }
}
