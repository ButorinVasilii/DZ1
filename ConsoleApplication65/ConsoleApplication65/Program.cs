using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication65
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var text = Clipboard.GetText();
            Console.WriteLine(text);
            Console.Read();

        }
    }
}
