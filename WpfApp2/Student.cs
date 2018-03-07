using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class BibleThump
    {
        //string _group;
        public string avtor { get; set; }
        public string izdatelstvo { get; set; }
        public string book_Name { get; set; }
        public int Age_izdania { get; set; }
        public string Address_izdania { get; set; }
        //public string Group { get { return _group; } set { _group = value; } }
        public override string ToString()
        {
            return $"Книжка {book_Name},  {Age_izdania} Года издания";
        }
    }
}
