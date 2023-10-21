// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//CHAPTER 4
//QUESTION 1
//void sum()
//{
// Console.WriteLine("Enter a number");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter a number");
// int num2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter a number");
// int num3 = int.Parse(Console.ReadLine());
// int sum = num1 + num1 + num3;
// Console.WriteLine($"Then sum of the three numbers is {sum}");
//}

//QUESTION 2
//void areaAndPerimeter()
//{
// Console.WriteLine("Enter the radius of a circle");
// double radius = double.Parse(Console.ReadLine());
// double area = (22/7f * radius * radius);
// Console.WriteLine($"The area of the circle is {area}");
// double perimeter = (2 * 22/7f * radius);
// Console.WriteLine($"The perimeter of the circle is {perimeter}");
//}

//QUESTION 3
//void info()
//{
// String Companyname = "Code Learners hub";
// Console.WriteLine($"The name of the company is {Companyname}");
// String CompanyAddress = "Opposite registry, Odo-Eran , Obantoko , Abeokuta , Ogun State";
// Console.WriteLine($"The Address of the company is {CompanyAddress}");
// String Companynumber = "08057032002";
// Console.WriteLine($"The phone number of the company is {Companynumber}");
// String faxnumber = "07031905878";
// Console.WriteLine($"The faxnumber of the company is {faxnumber}");
// String Companywebsite = "http://bit.ly/40zZ8W1";
// Console.WriteLine($"The Website of the company is {Companywebsite}");
// String Companywebmanager = "Mr Yusuf Lawal";
// Console.WriteLine($"The Webmanager of the company is {Companywebmanager}");
// String CompanyManager = "Mr Yusuf Adeyemi";
// Console.WriteLine($"The Manager of the company is {CompanyManager}");
// String Companyphonenumber= "07031905878";
// Console.WriteLine($"The Phonenumber of the company is {Companyphonenumber}");
//}

//QUESTION 4
//void conv()
//{
// int hexNum = 98765555;
// Console.WriteLine("|0*{0,-8:X}|",hexNum);
// double fractNum = 1.856;
// Console.WriteLine("|{0,-10:f2}|",fractNum);
// double fractionNum = -22/7f;
// Console.WriteLine("|{0,-10:f2}|",fractionNum);
//}

//QUESTION 5
//void multipleOfFive()
//{
//Console.WriteLine("Enter a two digit integer number1");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter a two digit integer number2");
// int num1 = int.Parse(Console.ReadLine());
// for(num++; num > 0)
// {
//  if(num <= num1 && num % 5 == 0)
//  {
//         Console.Write(num + " ");
//  }
// }
//}

//void multipleOfFive()
//{
// Console.WriteLine($"The sum of the {n} integer is: {sum}");
// Console.WriteLine("Enter num1");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter num2");
// int num2 = int.Parse(Console.ReadLine());
// int count = 0;
// for(int i = num1 + 1;i<num2;i++)
// {
//     if(i%5 ==0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"There are {count} number beteen {num1} and {num2} that have remainder of 0 when divided by 5");
//}

//QUESTION 6
//void max()
//{
// Console.WriteLine("Enter num1");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter num2");
// int num2 = int.Parse(Console.ReadLine());
// int max = num1 > num2 ? num1 : num2;
// Console.WriteLine(max);
//}

//void max()
//{
// Console.WriteLine("Enter num1");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter num2");
// int num2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Greater: {0}", (num1 + num2 + Math.Abs(num1-num2)) / 2);
// Console.WriteLine("Smaller: {0}", (num1 + num2 - Math.Abs(num1-num2)) / 2);
//}

//void max()
//{
// Console.WriteLine("Enter num1");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter num2");
// int num2 = int.Parse(Console.ReadLine());
// int max = num1 - ((num1 - num2) & ((num1 - num2) >> 31));
// Console.WriteLine(max);
//}

//QUESTION 7
//void sum()
//{
// Console.WriteLine("Enter num1");
// double num1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter num2");
// double num2 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter num3");
// double num3 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter num4");
// double num4 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter num5");
// double num5 = double.Parse(Console.ReadLine());
// if(num1>=0 && num2>=0 && num3>=0 && num4>=0 && num5>=0)
// {
//     double sum = num1 + num2 + num3 + num4 + num5;
//     Console.WriteLine(sum);
// }
// else
// {
//     Console.WriteLine("Enter another set of num");
// }
// Console.WriteLine("Enter num1");
// double num1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter num2");
// double num2 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter num3");
// double num3 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter num4");
// double num4 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter num5");
// double num5 = double.Parse(Console.ReadLine());
// if(num1>=0)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine("Enter another num1");
// }
// if(num2>=0)
// {
//     Console.WriteLine(num1 + num2);
// }
// else
// {
//     Console.WriteLine("Enter another num1");
// }
// if(num3>=0)
// {
//     Console.WriteLine(num1 + num2 + num3);
// }
// else
// {
//     Console.WriteLine("Enter another num1");
// }
// if(num4>=0)
// {
//     Console.WriteLine(num1 + num2 + num3 + num4);
// }
// else
// {
//     Console.WriteLine("Enter another num1");
// }
// if(num5>=0)
// {
//     Console.WriteLine(num1 + num2 + num3 + num4 + num5);
// }
// else
// {
//     Console.WriteLine("Enter another num1");
// }
//}

//QUESTION 8
//void largest()
//{
// int[] myArray = new int [5];
// System.Console.WriteLine("Enter number 1");
// myArray[0] = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter number 2");
// myArray[1] = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter number 3");
// myArray[2] = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter number 4");
// myArray[3] = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter number 5");
// myArray[4] = int.Parse(Console.ReadLine());
// int largest = myArray[0];
// foreach(int num in myArray)
// {
//     if(num > largest)
//     {
//         largest = num;
//     }
// }
// Console.WriteLine("The largest number is " + largest);
//}

//QUESTION 9
//void sum()
//{
// Console.WriteLine("Enter the number of integers (n) : ");
// int n = int.Parse(Console.ReadLine());
// int sum = 0;
// for(int i = 0;i<n;i++)
// {
//     Console.Write($"Enter integer {i + 1}/{n}: ");
//     int num = int.Parse(Console.ReadLine());
//     sum += num;
// }
// Console.WriteLine($"The sum of the {n} integer is: {sum}");
//}

//QUESTION 10
// void printRealNum(int n)
// {
// Console.WriteLine("Enter the number of integers (n) : ");
// int num = int.Parse(Console.ReadLine());
// if(n>=1)
// {
//     Console.WriteLine($"Number from 1 to {n}: ");
//     for(int i = 0;i<=n;i++)
//     {
//     Console.WriteLine(i);
//     }
// }
// else
// {
//     Console.WriteLine("Please enter a positive integer greater than or equal to 1");
// }
// }
// printRealNum(35);

//QUESTION 11
// void fibonacci()
// {
//     Console.Write("Enter the num you want to sumup to:");
//     int num=int.Parse(Console.ReadLine());
//     int total=0;
//     for(int i=1;i<num;i++)
//     {
//        total+=i;
//     }
// }



