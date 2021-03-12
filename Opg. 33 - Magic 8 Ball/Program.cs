using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg._33___Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> eightBallAnswers = new List<string>();
            eightBallAnswers.Add("Yes");
            eightBallAnswers.Add("No");
            eightBallAnswers.Add("Maybe");
            eightBallAnswers.Add("Ask again later");

            Random random = new Random();

            Console.WriteLine("What's your question?");
            Console.ReadLine();
            Console.WriteLine(eightBallAnswers[random.Next(0, 4)]);
        }
    }
}
