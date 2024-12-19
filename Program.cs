namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Casting 
            #region Implicit And Explicit Casting

            #region Example 01
            //int X = 10000; // 4 Bytes 
            //long Y = X; // 8 Bytes - Implicit Casting 
            //Console.WriteLine(Y); // 10000

            //long A = 10000;
            ////int B = A; // Invalid Implicitly 
            //int B = (int) A; // Explicit Casting Using Casting Operator
            //Console.WriteLine(B); // 10000


            //long C = 100000000000;
            //int D = (int) C; // Explicit Casting - Unsafe Casting [Might Loss Data] 
            //Console.WriteLine(D); // 1215752192 due to overflow

            //checked
            //{
            //	long E = 100000000000;
            //	int F = (int)E; // Explicit Casting - Unsafe Casting [Might Loss Data] 
            //	unchecked
            //	{
            //		Console.WriteLine(F); // System.OverflowException
            //	}
            //}
            #endregion

            #region Example 02

            //int X = 10; // 4 bytes
            //decimal Y = X; // 16 Bytes  [Implicit Casting]
            //Console.WriteLine(Y); // 10



            //decimal K = 10.100M;
            //int M = (int)K; // Explicit Casting [May Cause Loss Of Data]
            //Console.WriteLine(M); // 10

            #endregion

            #endregion

            #region Parse()
            //Console.WriteLine("Please Enter Your Data");

            //Console.Write("Name : ");
            //string? Name = Console.ReadLine();

            //Console.Write("Age : ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Salary : ");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();
            //Console.WriteLine("Name is " + Name + " Age is " + Age + " Salary is " + Salary);

            #endregion


            #region Convert 

            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name : ");
            //string? Name =  Console.ReadLine();

            //Console.Write("Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Salary : ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            // Console.WriteLine("Name is " + Name + " Age is " + Age + " Salary is " + Salary);

            #endregion
            #endregion

            #region Operators 

            #region Unary Operators [ ++ , -- ]
            //int X = 10;

            ////1. ++
            //// 1.1 PreFix [Increment and Then Print]
            //Console.WriteLine(++X); // 11
            //Console.WriteLine(X); // 11

            //// 1.2 PostFix [Print and Then Increment]
            //Console.WriteLine(X++); // 10 
            //Console.WriteLine(X); // 11


            ////2. --
            //// 2.1 PreFix [Decrement and Then Print]
            //Console.WriteLine(--X); // 9
            //Console.WriteLine(X); // 9

            //// 2.2 PostFix [Print and Then Decrement]
            //Console.WriteLine(X--); // 10 
            //Console.WriteLine(X); // 9
            #endregion

            #region Binary | Arithmetic Operators [+ , - , * , / , %]

            //int sumResult, subResult, mulResult, divResult, modResult;
            //int number01 = 6, number02 = 2;
            //sumResult = number01 + number02; // 8 
            //subResult = number01 - number02; // 4
            //mulResult = number01 * number02; // 12
            //divResult = number01 / number02; // 3
            //modResult = number01 % number02; // 0

            #endregion

            #region Assignment Operators [= , += , -= , *= , /= , %=]

            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2

            #endregion

            #region Relational | Comparsion Operators [== , != , < , > , <=, >=]
            //int X = 10, Y = 10;

            //Console.WriteLine(X == Y); // True
            //Console.WriteLine(X != Y); // False 
            //Console.WriteLine(X > Y); // False 
            //Console.WriteLine(X < Y); // False
            //Console.WriteLine(X >= Y); // True 
            //Console.WriteLine(X <= Y); // True

            #endregion

            #region Logical Operators [! , && , ||]
            //// Short Circuit
            //Console.WriteLine(!true); // False
            //Console.WriteLine(false && true); // False
            //Console.WriteLine(false || true); // True 

            #endregion

            #region BitWise Operator [& , | , ^ , ~ , << , >> ]
            //// Long Circuit
            //Console.WriteLine(false & true); // False
            //Console.WriteLine(true | false); // True 
            //Console.WriteLine(false ^ true); // True 
            #endregion

            #region Terany Operator [Conditional Operator] [?:]

            //int X = 10, Y = 5;

            //string Message = X > Y ? "X > Y" : "X < Y";

            //Console.WriteLine(Message);
            #endregion

            #region Operators Priority and Associativity
            // unary
            //()
            //* % /
            // + _

            #endregion
            #endregion

            #region String Formatting 
            //// Equation : 10 + 5 = 15
            //int X = 10, Y = 5 , result;
            //result = X + Y;
            //string message;
            //// 1. String Interpolation
            //message = $"Equation : {X} + {Y} = {result}";
            //Console.WriteLine(message);

            //// 2. String.Format Method
            //message = string.Format("Equation : {0} + {1} = {2}" , X , Y ,result);
            //Console.WriteLine(message);

            //// 3. Composite Formatting
            //Console.WriteLine("Equation :x {0} + {1} = {2}" , X , Y , result);

            //// 4. String Concatenation
            //message =  "Equation : " + X + " + " + Y + " = " + result;
            //Console.WriteLine(message);


            //// File Path 
            //// D:\Cycle 43 .Net\Group 06\C#\Session 03\Day03 Solution\Demo\Demo.csproj

            //string filePath = "D:\\Cycle 43 .Net\\Group 06\\C#\\Session 03\\Day03 Solution\\Demo\\Demo.csproj";
            //filePath = @"D:\Cycle 43 .Net\Group 06\C#\Session 03\Day03 Solution\Demo\Demo.csproj";
            //Console.WriteLine(filePath);

            //Console.WriteLine("Aliaa\tTarek\nBackend Instructor");
            ////Aliaa   Tarek
            ////Backend Instructor
            #endregion

            #region Control Statements 
            #region 1. Conditional Statements

            #region Example 01 [Year Quarter] - [If,Switch With Numeric type using Constant Pattern]
            //Console.Write("Please Enter A Month Number  : ");

            //int monthNumber =int.Parse(Console.ReadLine());

            #region if else
            //if (monthNumber == 1)
            //	Console.WriteLine("Hello January");
            //else if (monthNumber == 2)
            //	Console.WriteLine("Hello February");
            //else if (monthNumber == 3)
            //	Console.WriteLine("Hello March");
            //else
            //	Console.WriteLine("invaild"); 
            #endregion

            #region switch 

            //switch (monthNumber)
            //{
            //	case 1:
            //		Console.WriteLine("Hello Jan");
            //		break;
            //	case 2:
            //		Console.WriteLine("Hello Feb");
            //		break;
            //	case 3:
            //		Console.WriteLine("Hello March");
            //		break;
            //	default:
            //		Console.WriteLine("invaild");
            //		break;
            //}
            #endregion

            //Console.ReadKey();
            #endregion


            #endregion

            #region Example 03 [Student Name] - [If,Switch With String type]
            /// name = Omar => Hello Omar 
            /// name = May => Hello May 
            /// name = Aliaa => Hello Aliaa 

            //Console.Write("Enter Student Name : ");
            //string name = Console.ReadLine() ?? "No Name Entered";

            #region if else 
            //if(name == "Omar")
            //	Console.WriteLine("Hello Omar");
            //else if(name == "May")
            //	Console.WriteLine("Hello May");
            //else if(name == "Aliaa")
            //	Console.WriteLine("Hello Aliaa");
            #endregion
            #region switch 
            //// No Jump Table Will Be Created
            //// Compiler will generate a sequence of string comparisons
            //switch (name)
            //{
            //	case "Omar":
            //		Console.WriteLine("Hello Omar");
            //		break;
            //	case "May":
            //		Console.WriteLine("Hello May");
            //		break;
            //	case "Aliaa":
            //		Console.WriteLine("Hello Aliaa");
            //		break;
            //}
            #endregion
            #endregion

            #region Example 04 [Budget] - [Switch With Goto]
            /// Budget is 1000 => Option 01
            /// Budget is 2000 => Option 01 , Option 02
            /// Budget is 3000 => Option 01 , Option 02 , Option 03

            //Console.Write("Please Enter Your Budget : ");
            //int.TryParse(Console.ReadLine(), out int Budget);

            //switch(Budget)
            //{
            //	case 1000:
            //		Console.WriteLine("Option 01");
            //		break;
            //	case 2000:
            //		Console.WriteLine("Option 02");
            //		goto case 1000;
            //	case 3000:
            //		Console.WriteLine("Option 03");
            //		goto case 2000;
            //}

            #endregion

            #endregion

        }
    }
}
