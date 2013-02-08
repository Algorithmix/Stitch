using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stitch
{
    class Shred
    {
        public string Path;
        public int Offset;
        public Shred(string path, int offset)
        {
            this.Path = path;
            this.Offset = offset;
        }
    }
}
