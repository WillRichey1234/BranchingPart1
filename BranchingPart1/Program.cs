using System;

namespace BranchingPart1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            string myValue = superSecretFormula();
            Console.WriteLine(myValue);
            Console.ReadLine();
        }
        //naming convention allows anyone who reads the code know that this
        //is a private variable, use this for helper methods
        private static string superSecretFormula()

        {
            //some cool stugg here
            return "Hello World!";
            // reuturn is the command to deliver it to the code that actually called it

        }
    }
}
