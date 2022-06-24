using static System.Console;
using System.Threading;

namespace LabOne
{
    internal class Program
    {
        static void Main()
        {
            string name = Tools.GetName();

            NumberAnalyzer player = new NumberAnalyzer(name);

            Tools.Exit(name);
        }


    }
}