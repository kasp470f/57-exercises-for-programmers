using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg._45___Word_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../v1.txt";
            string file = File.ReadAllText(path);
            File.WriteAllText(path, file.Replace("utilize", "use"));
            
                
        }
    }
}
