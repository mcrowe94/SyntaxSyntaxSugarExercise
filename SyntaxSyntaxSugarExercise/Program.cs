using System;

namespace SyntaxSyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;   //changed to inferred typing
            string responce;

            if (answer < 9)
            {
                responce = $"{answer} is less than nine";  //string interpolation
            }
            else
            {
                responce = answer + "is greater than or equal to nine";
            }            
            var inline = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than or equal to 9";
            Console.WriteLine(responce);
            Console.WriteLine($"this is the inline if: {inline}");

            





        }


    }
}
