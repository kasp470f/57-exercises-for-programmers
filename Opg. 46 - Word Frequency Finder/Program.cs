using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Opg._46___Word_Frequency_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArr = File.ReadAllText(@"../../Text.txt").Split(new char[] { ',', '!', '?', ' ', '.', '"', '[', ']', '{', '}', ';', ':', '(', ')', '\n', '\b', '-', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var distinctArray = textArr.Distinct().ToArray();
            Array.Sort(textArr);
            int count = 0;

            foreach (string item in distinctArray)
            {
                count = Regex.Matches(string.Join(" ", textArr), String.Format("{0} ", item)).Count;
                Console.WriteLine("{0}: {1}",  item, new String('*', count));
            }
        }
    }
}
