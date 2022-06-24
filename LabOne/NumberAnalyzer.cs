using static System.Console;

namespace LabOne
{
    internal class NumberAnalyzer
    {
        public NumberAnalyzer(string name)
        {

            do
            {
                int number = Tools.GetNumber(name);
                Tools.PrintOut(number);
            } while(Tools.TryAgain());
        }
    }
}
