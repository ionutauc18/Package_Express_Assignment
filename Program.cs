using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this line of code will type the introductory sentence "Welcome to Package Express. Please follow the instructions below."
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // this line of code will print the following request "Please enter the package weight:"
            Console.WriteLine("Please enter the package weight:");
            // this line of code will let the user input the weight of the package using an integer data type
            int weight = Convert.ToInt32(Console.ReadLine());
            // this line of code is an "if" statement with the following condition that integer variable "weight" is greater than 50
            if (weight > 50) 
            {
                // this line of code display will print "Package too heavy to be shipped via Package Express. Have a good day." if the weight typed by the user is greater than 50 and the program ends.
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            // this line of code is an "else" statement where if weight is less than 50 continue with the program
            else
            {
                // this line of code will print the following request "Please enter the package width:"
                Console.WriteLine("Please enter the package width:");
            }
            // this line of code will let the user input the width of the package using an integer data type 
            int width = Convert.ToInt32(Console.ReadLine());
            // this line of code will print the following request "Please enter the package height:"
            Console.WriteLine("Please enter the package height:");
            // this line of code will let the user input the height of the package using an integer data type
            int height = Convert.ToInt32(Console.ReadLine());
            // this line of code will print the following request "Please enter the package lenght:"
            Console.WriteLine("Please enter the package lenght:");
            // this line of code will let the user input the length of the package using an integer data type
            int length = Convert.ToInt32(Console.ReadLine());
            // this line of code adds up together the "width" , "height" and "length" 
            int total = width + height + length;
            //  this line of code is an "if" statement with the following condition that integer variable "total" is greater than 50
            if (total > 50)
            {
                // this line of code will print the message "Package too big to be shipped via Package Express. Have a good day." if the integer variable "total" is greater than 50 and the program ends.
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            }
            // this line of code is an "else" statement where if integer variable "total" is less than 50 continue with the program 
            else
            {
                // this line of code will multiply the integer variables "height" , "width" and "length"
                int multi = height * width * length;
                // this line of code will multiply the integer variables "multi" and "weight"
                int multiWeight = multi * weight;
                // this line of code will divide the integer variable "multiWeight" to decimal variable "100.00" with "m" as a requiere character for decimal data types giving the total price of the service
                decimal totalPrice = multiWeight / 100.00m;
                // this line of code will print the message "Your estimated total for shipping this package is: "  concatenating with the string data type "$" and decimal variable "totalPrice" 
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + totalPrice);
                // this line of code will print the following sentence "Thank you!"
                Console.WriteLine("Thank you!");
            }
            // this line of code displays the user input
            Console.ReadLine(); 
        }
    }
}
