using System;
using System.ComponentModel;

namespace assignment_03
{
    internal class assignment03
    {
        static void Main(string[] args) // Corrected the method name to "Main"
        {
            #region ex01
            // Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            int number = 0;
            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion
            #region ex02
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.


            if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
            #endregion
            #region ex03
            //Write a program that takes 3 integers from the user then prints the max element and the min element.

            Console.Write("Enter the 1st number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the 3rd number: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = num1;
            int min = num1;

            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            // Find the minimum
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }
            Console.WriteLine("Max Element: " + max);
            Console.WriteLine("Min Element: " + min);
            #endregion
            #region ex04
            // Write a program that allows the user to insert an integer number then check If a number is even or odd.


            Console.Write("Enter an integer: ");
            int number_ = int.Parse(Console.ReadLine());

            if (number_ % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            #endregion
            #region ex05

            //  Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            Console.Write("Enter a character: ");
            char character = char.Parse(Console.ReadLine());
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            #endregion
            #region ex07
            // Write a program that allows the user to insert an integer then 
            // print a multiplication table up to 12.

                        // i did it super static which is not so practical so i searched for a way to use loop for better answer 

                        Console.Write("Enter an integer: ");
            int numberr = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numberr} x 1 = {numberr * 1}");
            Console.WriteLine($"{numberr} x 2 = {numberr * 2}");
            Console.WriteLine($"{numberr} x 3 = {numberr * 3}");
            Console.WriteLine($"{numberr} x 4 = {numberr * 4}");
            Console.WriteLine($"{numberr} x 5 = {numberr * 5}");
            Console.WriteLine($"{numberr} x 6 = {numberr * 6}");
            Console.WriteLine($"{numberr} x 7 = {numberr * 7}");
            Console.WriteLine($"{numberr} x 8 = {numberr * 8}");
            Console.WriteLine($"{numberr} x 9 = {numberr * 9}");
            Console.WriteLine($"{numberr} x 10 = {numberr * 10}");
            Console.WriteLine($"{numberr} x 11 = {numberr * 11}");
            Console.WriteLine($"{numberr} x 12 = {numberr * 12}");

            // using loop 
            for(int i = 1; i <= 12; i++)
            {Console.WriteLine($"{number} x {i} = {number * i}");
            }

            #endregion
            #region ex09

            //9- Write a program that takes two integers then prints the power.

            Console.Write("Enter two integers: ");
            int first_number = int.Parse(Console.ReadLine());
            int sec_number = int.Parse(Console.ReadLine());+
            first_number * int sec_number = int.Parse(Console.ReadLine());
            // dont know how think about it 
            #endregion
            #region ex10
            // 10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            int marks1, marks2, marks3, marks4, marks5;

            Console.WriteLine("Enter Marks of five subjects:");

            Console.Write("Subject 1: ");
            marks1 = int.Parse(Console.ReadLine());

            Console.Write("Subject 2: ");
            marks2 = int.Parse(Console.ReadLine());

            Console.Write("Subject 3: ");
            marks3 = int.Parse(Console.ReadLine());

            Console.Write("Subject 4: ");
            marks4 = int.Parse(Console.ReadLine());

            Console.Write("Subject 5: ");
            marks5 = int.Parse(Console.ReadLine());

            int totalMarks = marks1 + marks2 + marks3 + marks4 + marks5;
            int averageMarks = totalMarks / 5;
            int percentage = totalMarks / 5;

            Console.WriteLine("Total marks = " + totalMarks);
            Console.WriteLine("Average Marks = " + averageMarks);
            Console.WriteLine("Percentage = " + percentage);
            #endregion
            #region ex11
            // 11- Write a program to input the month number and print the number of days in that month.

            Console.Write("Enter Month Number : ");
            int monthNumber = int.Parse(Console.ReadLine());

            if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 ||monthNumber == 8 || monthNumber == 10 || monthNumber == 12)
            {
                Console.WriteLine("Days in Month: 31");
            }
            else if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
            {
                Console.WriteLine("Days in Month: 30");
            }
            else if (monthNumber == 2)
            {
                Console.WriteLine("Days in Month: 28");
            }
            else
            {
                Console.WriteLine("Invalid Month Number!");
            }
            #endregion
            #region ex17
            //17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.



            double x1, y1, x2, y2, x3, y3;

            Console.WriteLine("Enter coordinates of three points:");

            Console.Write("Enter x1: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter y1: ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x2: ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter y2: ");
            y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter x3: ");
            x3 = double.Parse(Console.ReadLine());

            Console.Write("Enter y3: ");
            y3 = double.Parse(Console.ReadLine());


            //idk how to check whether these points lie on a single straight line. but we will use if for sure



            #endregion
            #region ex18

            // Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.
            // A worker's efficiency level is determined as follows: 

            Console.Write("Enter time taken to complete the task: ");
            double time = double.Parse(Console.ReadLine());

            if (time >= 2 && time < 3)
            {
                Console.WriteLine("Highly Efficient");
            }
            else if (time >= 3 && time < 4)
            {
                Console.WriteLine("Increase Speed");
            }
            else if (time >= 4 && time < 5)
            {
                Console.WriteLine("Provide Training");
            }
            else if (time >= 5)
            {
                Console.WriteLine("Leave Company");
            }
            #endregion
            #region ex21
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            int a = 10;
            int b = a;  

            b = 20;  

            Console.WriteLine("Value of a: " + a);  // Prints 10
            Console.WriteLine("Value of b: " + b);  // Prints 20

            #endregion
            #region ex22
            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            int numbers1 = [1, 2, 3] ;
            int numbers2 = numbers1;  

            numbers2 = 100;  

            Console.WriteLine("First element of numbers1: " + numbers1);  // Prints 100
            Console.WriteLine("First element of numbers2: " + numbers2);  // Prints 100
                                                                          // Changes both arrays

            #endregion
            #region ex23
            //Which of the following statements is correct about the C#.NET code snippet given below?
            int d = Convert.ToInt32(!(30 < 20));
            //  true converts to 1 so 
            // b) A value 1 will be assigned to d.


            #endregion
            #region ex24
            // Which of the following is the correct output for the C# code given below?
            // d) 6 1         the answer 


            #endregion
            #region ex25
            // What will be the output of the C# code given below?

            // Prints: 7 7    the answer is       d)  7 7 
            #endregion
        }
    }
}
