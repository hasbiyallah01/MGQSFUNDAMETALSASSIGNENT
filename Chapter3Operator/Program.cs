// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// int n = 100;
// ulong a = 0, b=1;
// for(int i = 0;i<n;i++)
// {
//     Console.Write(a);
//     if(i < n - 1)
//     {
//         Console.Write(" ,");
//     }
//     ulong temp = a;
//     a = b;
//     b = temp + b;
// }
// Console.WriteLine();

//CHAPTER3
//QUESTION1
// void evenOrOdd()
// {
//     Console.WriteLine("Enter a number");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if(number % 2 == 0)
//     {
//         Console.WriteLine("the number is even");
//     }
//     else
//     {
//     Console.WriteLine("the number is odd");
//     }
// }

//QUESTION2
// void divisible()
// {
//     Console.WriteLine("Enter a number");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if(number % 5 == 0 && number%7==0)
//     {
//         Console.WriteLine("true");
//     }
//     else
//     {
//     Console.WriteLine("false");
//     }
//     Console.WriteLine("Enter a number");
//     int num=int.Parse(Console.ReadLine());
//     for(int i=1;i<=num;i++)
//     {
//         if(i %5 == 0 && i % 7 == 0)
//         {
//             Console.WriteLine($"{i} is divisible by 5 or 7");
//         }
//         else
//         {
//             Console.WriteLine($"{i} is either divisible by 5 or 7 or none");
//         }
//     }
// }

//QUESTION3
// void bitwise()
// {
    // Console.WriteLine("Enter a  number");
    // int number = Convert.ToInt32(Console.ReadLine());
    // if(number/100==7)
    // {
    //     Console.WriteLine($"The number {number} has 7 a its third digit from the left to right");
    // }
    // else
    // {
    //     Console.WriteLine($"The number {number} does not have 7 a its third digit from the left to right");
    // }
//}

//QUESTION 4
// Console.WriteLine("Enter a  number");
// int number = Convert.ToInt32(Console.ReadLine());
// bool ThirdBitSet = (number & (1 << 2)) != 0;

//QUESTION 5
//void area()
//{
//Console.WriteLine("Enter a"); 
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter b");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the height");
//double height = Convert.ToDouble(Console.ReadLine());
//double area = 0.5 * (a + b) * height;
//Console.WriteLine("The area parallelogram is");
//Console.WriteLine(area);
//}

//QUESTION 6
//void area()
//{
//Console.WriteLine("Enter the side");
//double side = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the height");
//double height = Convert.ToDouble(Console.ReadLine());
//double perimeter = 2 * (height + side);
//Console.WriteLine("The perimeter is " + perimeter);
//double area = height * side;
//Console.WriteLine("The area is " + area);
//}

//QUESTION 7
//void gravitation()
//{
// Console.WriteLine("Enter your weight on Earth (in kg)");
// double weightOnEarth= Convert.ToDouble(Console.ReadLine());
// double weightOnMoon = weightOnEarth * 0.17;
// Console.WriteLine("weight On Moon is" + weightOnMoon);
//}

//QUESTION 8
// Console.WriteLine("Enter a  number x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a  number y");
// int y = Convert.ToInt32(Console.ReadLine());
// bool Circle = (x * x + y * y) <= (5 * 5);

//QUESTION 9
//void position()
//{
// Console.WriteLine("Enter a  number x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a  number y");
// int y = Convert.ToInt32(Console.ReadLine());
// bool InsideCircle = (x * x + y * y) <= (5 * 5);
// bool InsideRectangle = x < -1 || x > 5 || y < 1 || y > 5;
// bool position = InsideCircle && InsideRectangle;
//}

//QUESTION 10
//void arrangement()
//{
// Console.WriteLine("Enter a  number a");
// int numbera = Convert.ToInt32(Console.ReadLine());
// int a = num % 10;
// Console.WriteLine("Enter a  number b");
// int numberb = Convert.ToInt32(Console.ReadLine());
// int b = (num / 10) % 10;
// Console.WriteLine("Enter a  number c");
// int numberc = Convert.ToInt32(Console.ReadLine());
// int c = (num / 100) % 10;
// Console.WriteLine("Enter a  number d");
// int numberd = Convert.ToInt32(Console.ReadLine());
// int d = (num / 1000) % 10;
// int sum = numbera + numberb + numberc + numberd;
// Console.WriteLine(sum);
// Console.WriteLine(numberd + numberc + numberb + numbera);
// Console.WriteLine(numberd + numbera + numberb + numberc);
// Console.WriteLine(numbera + numberc + numberb + numberd);
//}

//11
//void position()
//{
// System.Console.WriteLine("Enter a number");
// int number = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter index of the number you want to print");
// int position = int.Parse(Console.ReadLine());
// string realNumber = $"{number}";
// System.Console.WriteLine(realNumber[position]);
//}

//12
//void isEqual()
//{
// System.Console.WriteLine("Enter a number");
// int number = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter index of the number you want to print");
// int position = int.Parse(Console.ReadLine());
// string realNumber = $"{number}";
// bool isEqual1 = true;
// if (realNumber[position] == 1)
// {
//    System.Console.WriteLine(true); 
// }
// else
// {
//     System.Console.WriteLine(false);
// }
//}

//13
//void value()
//{
// System.Console.WriteLine("Enter a number");
// int number = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter index of the number you want to print");
// int position = int.Parse(Console.ReadLine());
// string realNumber = $"{number}";
// int value = realNumber[position];
//Console.WriteLine("value");
//}



//QUESTION 14
//void prime()
//{ 
// Console.WriteLine("Enter a number (1 < n < 100");
// double number = Convert.ToDouble(Console.ReadLine());
// if(number <= 1 || number >= 100)
// {
//       Console.WriteLine("false");
// }
// for (int i = 2; i < number; i++)
// if (number % i == 0)
// {
//     Console.WriteLine("false");
// }
// else
// {
//     Console.WriteLine("true");
// }
//}


