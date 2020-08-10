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
            StreamWriter f = new StreamWriter("Сборник.txt",true);
            Console.WriteLine(txt);
            if( txt.Trim(' ') != "")
            {
                f.WriteLine(txt);
                f.Close();
                succsess("11111111111111111111111111111");
               
            }
            void succsess(string msg)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(msg);
                }
            }
        }
    }
}
