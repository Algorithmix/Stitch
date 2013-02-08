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
