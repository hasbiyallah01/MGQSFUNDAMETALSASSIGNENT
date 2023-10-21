// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//CHAPTER 5
//QUESTION 1
// Console.WriteLine("Enter num1");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter num2");
// int num2 = int.Parse(Console.ReadLine());
// int num3 = 0;
// if(num1 > num2)
// {
//     num3 = num1;
//     num1 = num2;
//     num2 = num3;
//     Console.WriteLine($"The first number is :{num1}");
//     Console.WriteLine($"The second number is :{num2}");
// }
// else
// {
//     Console.WriteLine($"The first number is :{num1}");
//     Console.WriteLine($"The second number is :{num2}");
//}

//QUESTION 2
// Console.WriteLine("Enter a real number");
// double sign = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter a real number");
// double sign1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter a real number");
// double sign2 = double.Parse(Console.ReadLine());
// if(sign<0 && sign1<0 && sign2<0 )
// {
//     Console.WriteLine("The result is :-");
// }
// else if((sign>0 && sign1<0 && sign2<0) || (sign<0 && sign1>0 && sign2<0) || (sign<0 && sign1<0 && sign2>0))
// {
//     Console.WriteLine("The result is :+");
// }
// else if((sign>0 && sign1>0 && sign2>0) || (sign==0 || sign1==0 || sign2==0))
// {
//     Console.WriteLine("The result is :+");
// }
// else if((sign>0 && sign1>0 && sign2<0) || (sign<0 && sign1>0 && sign2>0) || (sign>0 && sign1<0 && sign2>0))
// {
//     Console.WriteLine("The result is :-");
// }
// else
// {
//     Console.WriteLine("Invalid Input");
// }


//QUESTION 3
// Console.WriteLine("Enter a real number");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter a real number");
// int num2= int.Parse(Console.ReadLine());
// Console.WriteLine("Enter a real number");
// int num3 = int.Parse(Console.ReadLine());
// if(num1>num2 && num1>num3)
// {
//     Console.WriteLine($"{num1} is the greatest");
// }
// if(num2>num1 && num2>num3)
// {
//     Console.WriteLine($"{num2} is the greatest");
// }
// if(num3>num2 && num3>num1)
// {
//     Console.WriteLine($"{num3} is the greatest");
// }
// else
// {
//     Console.WriteLine("Invalid Input");
// }

//QUESTION 4
// Console.WriteLine("Enter a real number");
// double num1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter a real number");
// double num2= double.Parse(Console.ReadLine());
// Console.WriteLine("Enter a real number");
// double num3 = double.Parse(Console.ReadLine());
// double num4 = 0;
// if(num1<num2)
// {
//     num4 = num1;
//     num1 = num2;
//     num2 = num4;
// }
// if(num2 < num3)
// {
//     num4 = num2;
//     num2 = num3;
//     num3 = num4;
// }
// if(num1 < num2)
// {
//     num4 = num1;
//     num1 = num2;
//     num2 = num4;
// }
// else
// {
//     Console.WriteLine("Enter different real numbers");
// }
// Console.WriteLine("Sorted numbers in descending order: " + num1 + ", " + num2 + ", " + num3);

//QUESTION 5
// Console.WriteLine("Enter any digit between (0-9)");
// int digit = int.Parse(Console.ReadLine());
// switch(digit)
// {
//     case 0:
//       Console.WriteLine("Zero");
//     break;
//     case 1:
//       Console.WriteLine("One");
//     break;
//     case 2:
//       Console.WriteLine("Two");
//     break;
//     case 3:
//       Console.WriteLine("Three");
//     break;
//     case 4:
//       Console.WriteLine("Four");
//     break;
//     case 5:
//       Console.WriteLine("Five");
//     break;
//     case 6:
//       Console.WriteLine("Six");
//     break;
//     case 7:
//       Console.WriteLine("Seven");
//     break;
//     case 8:
//       Console.WriteLine("Eight");
//     break;
//     case 9:
//       Console.WriteLine("Nine");
//     break;
//     default:
//        Console.WriteLine("Invalid Input");
//     break;
// }

//QUESTION 6
// Console.WriteLine("Enter the co-efficient of x^2");
// double a = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter the co-efficient of x");
// double b= double.Parse(Console.ReadLine());
// Console.WriteLine("Enter the constant c of the quadratic equation");
// double c = double.Parse(Console.ReadLine());
// double d = ((b*b) - (4*a*c));
// double e = 2 *a;
// if(d > 0)
// {
//     double root1 = (-b + Math.Sqrt(d))/e;
//     double root2 = (-b - Math.Sqrt(d))/e;
//     Console.WriteLine($"Two distinct real roots:Root1 = {root1}, Root2 = {root2}");
// }
// else if(d == 0)
// {
//     double root = -b / e;
//     Console.WriteLine($"One real root is: {root}");
// }
// else
// {
//     Console.WriteLine("No real root. The roots are complex. ");
// }

//QUESTION 7
// System.Console.WriteLine("Enter number 1");
// int number1 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter number 2");
// int number2 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter number 3");
// int number3 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter number 4");
// int number4 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter number 5");
// int number5 = int.Parse(Console.ReadLine());
// if (number1 > number2 && number1 > number3 && number1 > number4 && number1 > number5)
// {
//     System.Console.WriteLine("The first number is the greatest");
// }
// else if(number2 > number1 && number2 > number3 && number2 > number4 && number2 > number5)
// {
//    System.Console.WriteLine("The second number is the greatest"); 
// } 
// else if(number3 > number1 && number3 > number2 && number3 > number4 && number3 > number5)
// {
//    System.Console.WriteLine("The third number is the greatest"); 
// } 
// else if(number4 > number1 && number4 > number2 && number4 > number3 && number4 > number5)
// {
//    System.Console.WriteLine("The fourth number is the greatest"); 
// } 
// else if(number5 > number1 && number5 > number2 && number5 > number3 && number5 > number4)
// {
//    System.Console.WriteLine("The fifth number is the greatest"); 
// } 
// else
// {
//     System.Console.WriteLine("They are all equal");
// }


//QUESTION 8
//Console.WriteLine("Enter any of the ffg string , int , double");
// String type = (Console.ReadLine());
// switch (type)
// {
//     case "int":
//     Console.WriteLine("Enter a number of int type");
//     int num = int.Parse(Console.ReadLine());
//     Console.WriteLine(++num);
//     break;
//     case "double":
//     Console.WriteLine("Enter a number of double type");
//     double num1 = double.Parse(Console.ReadLine());
//     Console.WriteLine(++num);
//     break;
//     case "string":
//     Console.WriteLine("Enter a string input");
//     string input = (Console.ReadLine());
//     Console.WriteLine("The result is " + input + "*");
//     break;
//     default:
//     Console.WriteLine("You have enter an invalid data type");
//     break; 
// }



//QUESTION 10
// Console.WriteLine("Enter your score beteen 0-9");
// int score=Convert.ToInt32(Console.ReadLine ());
// if((score >= 1) && (score <= 3))
// {
//    Console.WriteLine("your grade is " + score*10);
// }
// else if((score <= 6) && (score >= 4))
// {
//    Console.WriteLine("your grade is "+ score*100);
// }
// else if((score <= 9) && (score >=7))
// {
//    Console.WriteLine("your grade is "+ score*1000);
// }
// else
// {
//    Console.WriteLine("Invalid input");
// }

//11
// System.Console.WriteLine("Enter a number");
// string number = Console.ReadLine();
// int lengthOfNumber = number.Length;
// switch (lengthOfNumber)
// {
//     case 1:
//     {

//     }
//     break;
//     case 2:
//     {
        
//     }
//     break;
//     case 3:
//     {
        
//     }
//     break;
//     default:
//     {
//         System.Console.WriteLine("Number out of range");
//     }
//     break;
// }
