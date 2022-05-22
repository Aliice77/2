using System;

namespace session1
{
    class Program
    {

        static void Main(string[] args)
        {
            string a= " ";
            string b="      ";

            for (int i=0;i<5;i++)
            {
                a+="* ";
                
                Console.WriteLine(b.Substring(i)+a);
            }
          
        }
    }
    
}
