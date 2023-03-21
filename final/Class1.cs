using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class Class1
    {
        string _name;
        string _date;
        string Artist;
        string _ArtStyle;

        public Class1(string name, string date, string artist, string artStyle)
        {
            _name = name;
            _date = date;
            Artist = artist;
            _ArtStyle = artStyle;
        }

        public string Name { get => _name; set => _name = value; }
        public string Date { get => _date; set => _date = value; }
        public string Artist1 { get => Artist; set => Artist = value; }
        public string ArtStyle { get => _ArtStyle; set => _ArtStyle = value; }
    }
}
