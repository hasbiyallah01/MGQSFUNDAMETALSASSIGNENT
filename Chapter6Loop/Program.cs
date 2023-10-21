// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//CHAPTER 6
//QUESTION 1
// Console.WriteLine("Enter an integer number");
// int num = int.Parse(Console.ReadLine());
// for(int i = 1; i <= num; i++)
// {
//      Console.Write(i + " ");
// }

//QUESTION 2
// Console.WriteLine("Enter a number");
// int num=int.Parse(Console.ReadLine());
// for(int i=1;i<=num;i++)
// {
//     if(i % 3 == 0 && i % 7 == 0)
//     {
//         Console.WriteLine($"{i} is divisible by 3 or 7");
//     }
//     else
//     {
//         Console.WriteLine($"{i} is either divisible by 3 or 7 or none");
//     }
// }

//QUESTION 3
// Console.WriteLine("Enter the number of numbers you want to input : ");
// String input = Console.ReadLine();
// if (input.Length == 0)
// {
//     Console.WriteLine("Invalid input");
// }
// int smallest = int.MaxValue;
// int largest = int.MinValue;
// for(int i = 0; i < input.Length;i++)
// {
//     if(i<smallest)
//     {
//         smallest=input[i];
//     }
//     if(i>largest)
//     {
//         largest=input[i];
//     }
// }
// Console.WriteLine(smallest);
// Console.WriteLine(largest);

//QUESTION 4

// QUESTION 5;
//   int Fibonacci=0; 
//   System.Console.WriteLine("Enter your number");
//   int number=int.Parse(Console.ReadLine());
//   for (int i = 0; i <= number; i++)
//   {
//     Fibonacci+=i;
//   }
//   System.Console.WriteLine($"The sum of the Fibonacci sequence is {Fibonacci }");

//QUESTION 6
// try
// {
//    int productN=1;
//    int productK=1;
//    System.Console.WriteLine("Enter your numbers for N!");
//    int numbers =int.Parse(Console.ReadLine());
//    System.Console.WriteLine("Enter the numbers for K!");
//    int number=int.Parse(Console.ReadLine());
//    for (int i = 0; i <= numbers; i++)
//    {
//     productN*=i;
//    }
//    for (int j = 0; j <= number; j++)
//    {
//     productK*=j;
//    }
//      System.Console.WriteLine($"N!/K!=:{productN/ productK}");  
// }
// catch (System.DivideByZeroException ex)
// {

//     Console.WriteLine(ex.Message);
// }

//QUESTION 7
// try
// {
//     int ProductN=1;
// int ProductK=1;
//    System.Console.WriteLine("Enter N ");
//    int N=int.Parse(Console.ReadLine());
//    System.Console.WriteLine("Enter K");
//    int K=int.Parse(Console.ReadLine());
//    for (int i = 1; i <= N; i++)
//    {
//     ProductN*=i;
//    }
//    for (int j = 1; j <= K; j++)
//    {
//     ProductK*=j;
//    }
//    int formula=ProductN*ProductK/(ProductN-ProductK);
//    System.Console.WriteLine(formula);
//    }
// catch (System.Exception ex)
// {
//   System.Console.WriteLine(ex.Message);  
// }

//QUESTION 8
// try
// {
// int n=1;
// int n2=1;
// int n3=1;
// System.Console.WriteLine("Enter the value for n");
// int num=int .Parse(Console.ReadLine());
// for (int i = 1; i <= 2*n; i++)
// {
//     n*=i;
// }
// for (int j = 1; j <=n+1 ; j++)
// {
//    n2*=j; 
// }
// for (int k = 1; k <= n; k++)
// {
//     n3*=k;
// }    
// double formula= n!/n2*n3;
// System.Console.Write($"The answer = {formula}");
// }
// catch (System.DivideByZeroException ex)
// {
//     System.Console.WriteLine(ex.Message);
// }

//QUESTION 9
// double factorial=1;
// double sum=1;
// System.Console.WriteLine("Enter the value for n");
// double n=int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the value for x");
// double x=int.Parse(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//    factorial*=i;
//  double power=Math.Pow(x,i);
// double division=factorial/power;
// sum+=division;
// }
// System.Console.WriteLine($"The answer is {sum }");

//10
// System.Console.WriteLine("Enter a number");
// int number = int.Parse(Console.ReadLine());
// for (int i = 1; i <= number; i++)
// {
//     for (int j = 0; j < number; j++)
//     {
//         System.Console.Write(i+j + " ");
//     }
//     System.Console.WriteLine();
// }

//11
// System.Console.WriteLine("Enter a number");
// int number = int.Parse(Console.ReadLine());
// int product = 1;
// int count = 0;
// string factorial = "";
// for (int i = 1; i <= number; i++)
// {
//     product *= i;
//     factorial = $"{product}";
// }
// System.Console.WriteLine(factorial);
// for (int j = factorial.Length - 1; j >= 0; j--)
// {
//     if (factorial[j] == 0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine($"The factorial of {number} has {count} zero(s)");


//QUESTION 12
// Console.Write("Enter a decimal number: ");
// int decimalNumber = int.Parse(Console.ReadLine());
// string binaryNumber = " ";
// Console.WriteLine("Binary representation: " + binaryNumber);
// if (decimalNumber == 0)
// {
//     Console.WriteLine("0");
// }
// while (decimalNumber > 0)
// {
//     int remainder = decimalNumber % 2;
//     binaryNumber = remainder + binaryNumber;
//     decimalNumber = decimalNumber / 2;
// }
// Console.WriteLine(binaryNumber);

//QUESTION 13
// Console.Write("Enter a binary number: ");
// string binaryNumber = Console.ReadLine();
// int decimalNumber = 0;
// for (int i = binaryNumber.Length - 1, power = 0; i >= 0; i--, power++)
// {
//     if (binaryNumber[i] == '1')
//     {
//         decimalNumber += (int)Math.Pow(2, power);
//     }
// }
// Console.WriteLine("Decimal representation: " + decimalNumber);

//QUESTION 14
// Console.Write("Enter a decimal number: ");
// int decimalNumber = int.Parse(Console.ReadLine());
// string hexadecimalNumber = " ";
// if (decimalNumber == 0)
// {
//         Console.WriteLine("0");
// }
// string hexChars = "0123456789ABCDEF";
// while (decimalNumber > 0)
// {
//     int remainder = decimalNumber % 16;
//     hexadecimalNumber = hexChars[remainder] + hexadecimalNumber;
//     decimalNumber /= 16;
// }
// Console.WriteLine("Hexadecimal equivalent: " + hexadecimalNumber);

//QUESTION 15
// Console.Write("Enter a hexadecimal number: ");
// string hexString = Console.ReadLine();
// try
// {
//     int decimalValue = Convert.ToInt32(hexString, 16);
//     Console.WriteLine("Decimal equivalent: " + decimalValue);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Invalid hexadecimal input");
// }

//QUESTION 16
// Console.Write("Enter a positive integer N: ");
// int N = int.Parse(Console.ReadLine());
// if (N < 1)
// {
// Console.WriteLine("Please enter a positive integer.");
// }
// else
// {
//     Random random = new Random();
//     int[] numbers = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         numbers[i] = i + 1;
//     }
//     for (int i = N - 1; i > 0; i--)
//     {
//         int j = random.Next(0, i + 1);
//         int temp = numbers[i];
//         numbers[i] = numbers[j];
//         numbers[j] = temp;
//     }
//     Console.WriteLine("Numbers from 1 to N in random order:");
//     foreach (int number in numbers)
//     {
//         Console.Write(number + " ");
//     }
// }

//QUESTION 17
// Console.Write("Enter the first number: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Enter the second number: ");
// int number2 = int.Parse(Console.ReadLine());
// int gcd = FindGCD(number1, number2);
// int lcm = FindLCM(number1, number2, gcd);
// Console.WriteLine("GCD of {0} and {1} is: {2}", number1, number2, gcd);
// Console.WriteLine("LCM of {0} and {1} is: {2}", number1, number2, lcm);
// static int FindGCD(int a, int b)
// {
//     while (b != 0)
//     {
//         int temp = b;
//         b = a % b;
//         a = temp;
//     }
//     return a;
// }
// static int FindLCM(int a, int b, int gcd)
// {
//     return Math.Abs(a * b) / gcd;
// }

//QUESTION 18
// int n = 4; 
// int[,] matrix = GenerateSpiralMatrix(n);

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// static int[,] GenerateSpiralMatrix(int n)
// {
// int[,] matrix = new int[n, n];
// int left = 0, right = n - 1, top = 0, bottom = n - 1;
// int current = 1;

// while (left <= right && top <= bottom)
// {
//     for (int i = left; i <= right; i++)
//     {
//         matrix[top, i] = current++;
//     }
//     top++;

//     for (int i = top; i <= bottom; i++)
//     {
//         matrix[i, right] = current++;
//     }
//     right--;

//     for (int i = right; i >= left; i--)
//     {
//         matrix[bottom, i] = current++;
//     }
//     bottom--;
//     for (int i = bottom; i >= top; i--)
//     {
//         matrix[i, left] = current++;
//     }
//     left++;
// }
// return matrix;
// }

