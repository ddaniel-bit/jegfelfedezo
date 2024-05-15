using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jegfelfedezo
{
    internal class Babu
    {
        int azonosito;
        int X;
        int Y;
        List<String> blacklist;
        List<String> whitelist;

        public Babu(int azonosito, int x, int y, List<string> blacklist, List<string> whitelist)
        {
            this.azonosito = azonosito;
            X = x;
            Y = y;
            this.blacklist = blacklist;
            this.whitelist = whitelist;
        }

        public int Azonosito { get => azonosito; set => azonosito = value; }
        public int X1 { get => X; set => X = value; }
        public int Y1 { get => Y; set => Y = value; }
        public List<string> Blacklist { get => blacklist; set => blacklist = value; }
        public List<string> Whitelist { get => whitelist; set => whitelist = value; }
    }
}
