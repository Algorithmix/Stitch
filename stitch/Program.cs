using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace stitch
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime begin = new DateTime(2013, 1, 1, 0,0,0);
            DateTime end = new DateTime(2013, 1, 4, 0, 0, 0);
            long elapsedTicks = end.Ticks - begin.Ticks;
            List<string> pictures = new List<string>();
            for (int ii = 1; ii < 11; ii++)
            {
                pictures.Add(@"C:\Users\jeff\Dropbox\Algorthmics-TestDrive\PDFRequirement\Full2"+@"\image"+ii+".png");
            }
            Bitmap bitmap = Stitcher.Combine(pictures.ToArray());
            bitmap.Save("bitmap.jpg");
        }
    }
}
