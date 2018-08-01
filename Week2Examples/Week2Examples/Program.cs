using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------- Task 1 --------------------------*/
            //Display some meaningfull instructions to the console so the user knows what they need to do.
            Console.WriteLine("Welcome to Week2");
            Console.Write("Task 1 - Please enter your name: ");
            //take the users name as an input and store it in a string variable called name
            string name = Console.ReadLine();


            //Output to the console the sentence Hello (name). Any of the following would work.
            Console.WriteLine("Hello {0}", name);
            //or
            Console.WriteLine($"Hello {name}");
            //or
            Console.WriteLine("Hello " + name);//concantination


            //Ask for the users age
            Console.Write("Could you please enter your age: ");
            //Store the users age in a integer variable called age.
            int age = int.Parse(Console.ReadLine());


            //Ask for the users gender
            Console.Write($"Ok {name}, could you please enter your gender: ");
            //Store the users gender in a string variable called gender.
            string gender = Console.ReadLine();


            //Ask for the users address
            Console.Write("Please enter your address: ");
            //Store the users address in a string variable called address.
            string address = Console.ReadLine();


            //Display all of the user information back to them.
            Console.WriteLine("Ok, here is the information that i gathered:");
            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Address: {0}", address);


            //let the user know that this part of the application has finished.
            Console.WriteLine("Task 1 complete - Press enter to continue...");
            Console.ReadLine();


            //Clear the screen.
            Console.Clear();
            /*---------------------- End of Task 1 ----------------------*/





            /*------------------------- Task 2 --------------------------*/
            //Ask the user to input 2 numbers and store the in variables called num1 and num2
            Console.WriteLine("Task 3 - Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());


            //Add the 2 numbers together and display the result to the user.
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));


            //Subtract num1 from num2 and display the result to the user.
            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));


            //Mutliply the 2 numbers together and display the result to the user.
            Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1 * num2));


            //Divide num1 by num2 and display the result to the user.
            Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));


            //let the user know that this part of the application has finished.
            Console.WriteLine("Task 2 complete - Press enter to continue...");
            Console.ReadLine();


            //Clear the screen.
            Console.Clear();
            /*---------------------- End of Task 2 ----------------------*/





            /*------------------------- Task 3 --------------------------*/
            //Display some meaningfull instructions to the console so the user knows what they need to do.
            Console.Write("Task 3 - Please enter your first name: ");
            string fname = Console.ReadLine();
            Console.Write("Please enter your second name: ");
            string lname = Console.ReadLine();


            //Display the full name together to the user. Any of the following 4 examples would work.
            Console.WriteLine("Hello {0} {1}", fname, lname);
            //or
            Console.WriteLine($"Hello {fname} {lname}");
            //or
            Console.WriteLine("Hello " + fname + " " + lname);//concantination
            //or
            string fullName = fname + " " + lname;//concantination
            Console.WriteLine("Hello " + fullName);//concantination


            //let the user know that the application has finished.
            Console.WriteLine("Task 3 complete - Press enter to exit the application...");
            Console.ReadLine();
            /*---------------------- End of Task 3 ----------------------*/
        }
    }
}
