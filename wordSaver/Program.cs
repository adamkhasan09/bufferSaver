using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace wordSaver
{
    class Program
    {
        [STAThread] //атрибут однопоточного прилжения Single Thread Apartment
        static void Main(string[] args)
        {
            string txt = Clipboard.GetText();
            StreamWriter f = new StreamWriter("Сборник.txt");
            f.WriteLine(txt);
            f.Close();
        }
    }
}
