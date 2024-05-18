namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Given Starting Solution
            /*
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + "is less than nine";
            }
            else 
            {
                response = answer + "is greater or equal to nine";
            }
            */

            /*
             * Given the following code, change the code to implement:
                inferred typing
                string interpolation
                and the ternary operator
             */
            #endregion

            var answer = 4;  //inferred typing
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";   //$"{answer} is less than..." is string interpolation  and Tenanary operator less than statement  using ? :
            Console.WriteLine(response);  
            Console.ReadLine();
        }
    }
}
