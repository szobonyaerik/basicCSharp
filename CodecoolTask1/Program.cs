using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecoolTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CircleValues();

            //LowestNumber(4, 76, 32);

            //ValidTriangle();

            //PosOrMinus();

            //Calculator();

            //IgazVagyHamis();

            //NumberMiddle();

            //Cube();

            //Sides();

            //Deci();

            //divisionBy9();

            //Digits();

            //Company();

            //Language();

            //Password();

            //Month();

            //MiddleTemp();

            //Coffee();

            Console.WriteLine( Task56( ));



            Console.ReadLine();
        }
        static void CircleValues()
        {
            Console.Write("Enter a radius value: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double CircleSurface = 2 * radius * 3.14;
            double CircleVolume = radius * radius * 3.14;
            double SphereSurface = 4 * radius * radius * 3.14;
            double SphereVolume = 4 * radius * radius * radius * 3.14 / 3;

            Console.WriteLine("The circle surface is {0}, the circle volume is {1}, the sphere surface is {2} and the sphere volume is {3}", CircleSurface, CircleVolume, SphereSurface, SphereVolume);

        }
        static void LowestNumber(int a, int b, int c)
        {
            if (a >= b && a >= c && b >= c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }
            else if (a >= b && a >= c && c >= b)
            {
                Console.WriteLine("{0}, {1}, {2}", a, c, b);
            }
            else if (b >= a && b >= c && c >= a)
            {
                Console.WriteLine("{0}, {1}, {2}", b, c, a);
            }
            else if (b >= a && b >= c && a >= c)
            {
                Console.WriteLine("{0}, {1}, {2}", b, a, c);
            }
            else if (c >= a && c >= b && a >= b)
            {
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            }
        }
        static void ValidTriangle()
        {
            Console.Write("Enter a value: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a value: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a value: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Valid Triangle");
            }
            else
            {
                Console.WriteLine("Not a valid triangle");
            }


        }
        static void PosOrMinus()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            if (num1 < 0)
            {
                Console.WriteLine("The number is negativ");
            }
            else
            {
                Console.WriteLine("The number is positiv");
            }


        }
        static void Calculator()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double plus = num1 + num2;
            double minus = Math.Abs(num1 - num2);
            double div = num1 / num2;
            double multi = num1 * num2;

            Console.WriteLine("The sum of the two number is {0}, the deduction of the two number is {1}," +
                " the division of the number is {2} and the multiplication of the two number is {3}!"
                ,plus, minus, div, multi);

        }
        static void IgazVagyHamis()
        {
            Console.Write("Enter a true or false value: ");
            string value = Console.ReadLine();

            if ( value == "true")
            {
                Console.WriteLine("IGAZ");
            }else
            {
                Console.WriteLine("HAMIS");
            }
        }
        static void NumberMiddle()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double middle = (num1 + num2) / 2;

            Console.WriteLine(middle);
        }
        static void Cube()
        {
            Console.Write("Enter a value: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a value: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a value: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double aDiagonal = Math.Sqrt(a * a + b * b);
            double bDiagonal = Math.Sqrt(a * a + c * c);
            double cDiagonal = Math.Sqrt(c * c + b * b);

            double bodyDiagonal = Math.Sqrt(c * c + bDiagonal * bDiagonal);

            double surface = 2 * (a * b + b * c + a * c);
            double volume = a * b * c;

            Console.WriteLine("The diagonals are {0}, {1}, {2}," +
                " the body diagonal is {3}, the surface is {4}, and the volume is {5}"
                ,aDiagonal, bDiagonal, cDiagonal, bodyDiagonal, surface, volume);
        }
        static void Sides()
        {
            Console.Write("Enter a value: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a value: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a value: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double aSide = 2 * (c + b);
            double bSide = 2 * (a + c);
            double cSide = 2 * (a + b);

            double finalValue = 0;

            
            double [] sideValues = { aSide, bSide, cSide };

            for (int i = 0; i < sideValues.Length; i++)
            {
                if (sideValues[i] > finalValue)
                {
                    finalValue = sideValues[i];
                }

            }
            Console.WriteLine(finalValue);

        }
        static void Deci()
        {
            Console.Write("Enter the deci value: ");
            double deciValue = Convert.ToDouble(Console.ReadLine());

            double hektoValue = deciValue / 1000;
            double literValue = deciValue / 10;

            Console.WriteLine("The value you gave is {0} dl, {1} hectoliter, and {2} liter."
                , deciValue,hektoValue,literValue);
        }
        static void divisionBy9()
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            double finalDiv = Convert.ToDouble(num1);
            double sum = 0;

            while ( num1 > 0)
            {
                sum += num1 % 10;
                num1 = num1 / 10;
            }
            if (sum % 9 == 0)
            {
                Console.WriteLine("The number can be divided by 9.");
            }else
            {
                Console.WriteLine("The number cannot be divided be 9.");
            }

            double final = finalDiv / 9;
            Console.WriteLine(final);

            
        }
        static void Digits()
        {
            Console.Write("Enter a number: ");
            string num1 = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                sum++;
            }
            Console.Write("The number has {0} digits.",sum);
        }
        static void Company()
        {
            Console.Write("Enter the income: ");
            int income = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the outlay: ");
            int outlay = Convert.ToInt32(Console.ReadLine());

            int final = income - outlay;

            if ( income > outlay)
            {
                Console.WriteLine("The company was succesful.");
            }else if (income == outlay)
            {
                Console.WriteLine("The company was zero.");
            }else
            {
                Console.WriteLine("The company lost money.");
            }
            Console.WriteLine("The final money was {0}", final);
        }
        static void Language()      
        {
            
            Console.Write("Do you speak english? (y, n)");
            string english = Console.ReadLine();

            Console.Write("Do you speak hungarian? (y, n)");
            string hungarian = Console.ReadLine();

            Console.Write("Do you speak german? (y, n)");
            string german = Console.ReadLine();

            if (english == "y")
            {
                Console.WriteLine("HI");
            }else if ( german == "y")
            {
                Console.WriteLine("Guten Tag");
            }else if(hungarian == "y")
            {
                Console.WriteLine("Szia");
            }else
            {
                Console.WriteLine("Sorry");
            }
        }
        static void Password()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();         

            int count = 1;

            bool enter = true;

            while (enter)
            {
                Console.Write("Try to enter your password: ");
                string passwordTry = Console.ReadLine();
                if ( passwordTry == password)
                {
                    Console.WriteLine("You can enter");
                    enter = false;
                }else if( count == 3)
                {
                    enter = false;
                    Console.WriteLine("Invalid password");
                }else
                {
                    count++;
                }

            }


        }
        static void Month()
        {
            Console.Write("Enter a month number: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());

            int [] winter = { 1, 2, 12 };
            int[] spring = { 3, 4, 5 };
            int[] summer = { 6, 7, 8 };
            int[] autum = { 9, 10, 11 };
            
            if (winter.Contains(monthNum))
            {
                Console.WriteLine("This is a winter month");
            }else if(spring.Contains(monthNum))
            {
                Console.WriteLine("This is a spring month");
            }else if(summer.Contains(monthNum))
            {
                Console.WriteLine("This a a summer month");
            }else
            {
                Console.WriteLine("This is an autum month");
            }
            

            
        }
        static void MiddleTemp()
        {
            double i = 1;
            double number = 1;
            double sum = 0;

            while(i <= 12)
            {
                Console.Write("Enter the {0} month average temp: ",number);
                double monthTemp = Convert.ToDouble(Console.ReadLine());
                sum += monthTemp;
                number++;
                i++;

            }
            double final = sum / 12;

            Console.WriteLine("The average year temperature is {0}",final);
        }
        static void Coffee()
        {

            int basicValue = 100;

            Console.Write("Do you want a double coffee? (y/n)");
            string doubleCoffee = Console.ReadLine();

            Console.Write("Do you want a coffee cream? (y/n)");
            string coffeeCream = Console.ReadLine();

            Console.Write("Do you want a glass? (y/n)");
            string coffeeGlass = Console.ReadLine();

            if (doubleCoffee == "y")
            {
                basicValue += 20;
            }else if( coffeeCream == "y")
            {
                basicValue += 50;
            }else if(coffeeGlass == "n")
            {
                basicValue -= 10;
            }
            Console.WriteLine("Put in {0}", basicValue);

        }
        static double Task56()
        {
            double result = 0;

            Console.Write("Enter a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            MathClass t1 = new MathClass(number1, number2, op);

            if(t1.op == "+")
            {
                result = t1.number1 + t1.number2;
            }else if(t1.op == "-")
            {
                result = Math.Abs(t1.number1 - number2);
            }else if(t1.op == "/")
            {
                result = t1.number1 / t1.number2;
            }else if(t1.op == "*")
            {
                result = t1.number1 * t1.number2;
            }
            return result;
        }
        


        
        


        

    }
}
