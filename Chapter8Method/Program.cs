// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// CHAPTER 9
//QUESTION 1
// static string Name()
// {
//     System.Console.WriteLine("Enter your name");
//     string name=Console.ReadLine() ;
//     System.Console.WriteLine("Enter Hello");
//     string name2=Console.ReadLine();
//     return name+" "+ name2;
// }

//QUESTION 2
// static int GetMaximum()
// {
//     System.Console.WriteLine("Enter your number");
//     int num=int.Parse(Console.ReadLine());
//         System.Console.WriteLine("Enter your number");
//     int num2=int.Parse(Console.ReadLine());
//         System.Console.WriteLine("Enter your number");
//     int num3=int.Parse(Console.ReadLine());
//     if (num>num2&&num>num3)
//     return num;
// }
  
//QUESTION 3
// static void Number()
// {
//   System.Console.WriteLine("Enter your number");
// int number= int.Parse(Console.ReadLine());
// if (number%100==1)
// {
//   System.Console.WriteLine("ONE");
// }
//  if (number%1000==1)
// {
//   System.Console.WriteLine("ONE");
// }
//  if (number%10==1)
// {
//   System.Console.WriteLine("ONE");
// }
//  if (number%100==2)
// {
//   System.Console.WriteLine("TWO");
// }
// if (number%1000==2)
// {
//   System.Console.WriteLine("TWO");
// }
// if (number%10==2)
// {
//   System.Console.WriteLine("TWO");
// }
//  if (number%100==3)
// {
//   System.Console.WriteLine("THREE");
// }
// if (number%1000==3)
// {
//   System.Console.WriteLine("THREE");
// }
// if (number%10==3)
// {
//   System.Console.WriteLine("THREE");
// }
//  if (number%10==4)
// {
//   System.Console.WriteLine("FOUR");
// }
// if (number%100==4)
// {
//   System.Console.WriteLine("FOUR");
// }
// if (number%1000==4)
// {
//   System.Console.WriteLine("FOUR");
// }
//  if (number%100==5)
// {
//   System.Console.WriteLine("FIVE");
// }

//  if (number%10==5)
// {
//   System.Console.WriteLine("FIVE");
// }

//  if (number%1000==5)
// {
//   System.Console.WriteLine("FIVE");
// }

//  if (number%100==6)
// {
//   System.Console.WriteLine("SIX");
// }
// if (number%10==6)
// {
//   System.Console.WriteLine("SIX");
// }
// if (number%1000==6)
// {
//   System.Console.WriteLine("SIX");
// }
//  if (number%100==7)
// {
//   System.Console.WriteLine("SEVEN");
// }
// if (number%10==7)
// {
//   System.Console.WriteLine("SEVEN");
// }
// if (number%1000==7)
// {
//   System.Console.WriteLine("SEVEN");
// }
//  if (number%100==8)
// {
//   System.Console.WriteLine("EIGHT");
// }
// if (number%10==8)
// {
//   System.Console.WriteLine("EIGHT");
// }
// if (number%1000==8)
// {
//   System.Console.WriteLine("EIGHT");
// }
//  if (number%100==9)
// {
//   System.Console.WriteLine("NINE");
// }
// if (number%10==9)
// {
//   System.Console.WriteLine("NINE");
// }
// if (number%1000==9)
// {
//   System.Console.WriteLine("NINE");
// }
//  if (number%100==0)
// {
//   System.Console.WriteLine("ZERO");
// }
//  if (number%10==0)
// {
//   System.Console.WriteLine("ZERO");
// }
//  if (number%1000==0)
// {
//   System.Console.WriteLine("ZERO");
// }
//  }

//QUESTION 4
// static void countOccurrences()
// { 
//   int max=int.MinValue;
// int occur=0;
//  int []arr = {1, 2, 2, 8, 3, 4, 7 ,8 ,8 };
//   int n = arr.Length;
// for (int i = 0; i < n; i++)
// {int res = 0;
//  int x = arr[i];
// for (int j = 1; j < n; j++)
// {
//    if (x == arr[j])
//    {
//       res++;}
//       if (res>max)
//       {
//         max=res;
//         occur=x;
//       }
//    }
// } 
// System.Console.WriteLine( max);
// }

//QUESTION 5
// static void Nums()
// {
//      Console.WriteLine("Enter the numbers you want to enter");
//      int times=int.Parse(Console.ReadLine());
//   int [] array=new int [times];
//   for (int i = 0; i < array.Length; i++)
//   {
//      Console.WriteLine("Enter the numbers you want to enter");
//      int num=int.Parse(Console.ReadLine());
//      array[i]=num;
//   }
//     for (int i=0,j=1,k=2;k<array.Length;i++,j++,k++)
//     {
//        if (array[i]>array[j] && array[i]>array[k] )
//        {
//           Console.WriteLine(array[i]);
//        }
//     }
// }

//QUESTION 6
// static void Next()
// {
// int []nums={3,2,1,4,5,6,7};
// for (int i = 0; i < nums.Length; i++)
// { 
//   for (int j = 0; j <  nums.Length; j++)
//   {
//     for (int k = 0; k <  nums.Length; k++)
//     {
//       if (nums[i]>nums[j]&&nums[i]>nums[k])
//       {
//         System.Console.WriteLine(nums[i]);
//       }
//     }
//   }
// }
//}

// QUESTION 7
// static void Num()
// {
// System.Console.WriteLine("Enter the number of numbers");
// int num=int.Parse(Console.ReadLine());
// int []array=new int [num];
// int[] reversedarray = new int[num];
// int length=array.Length;
// for (int i = 0; i < array.Length; i++)
// { 
//   System.Console.WriteLine("Enter the number of numbers");
//   int num2=int.Parse(Console.ReadLine());
//   array[i]=num2;
// reversedarray[length - i - 1] = array[i];
// }
// for (int j = 0; j < length; j++)
// {
// System.Console.Write(reversedarray[j] + " "); 
// }
//}

//QUESTIONS 8
// long SumBigNumber()
// {
//     Console.WriteLine("Enter many number do u want to add");
//     int lenght=int.Parse(Console.ReadLine());
//     long [] sumArray=new long[lenght];
//     long sum=0;
//     for (int i = 0; i < lenght; i++)
//     {
//         Console.WriteLine("Enter many number do u want to add");
//        sumArray[i]=int.Parse(Console.ReadLine());
//        sum+=sumArray[i];
//     }
//     return sum;
// }

//QUESTIONS 9
// static void Nums()
// {
//     int [] array={1,2,3,6,5,7,8};
//     for (int i = 0; i < array.Length; i++)
//     {
//       for (int j = 0; j < array.Length; j++)
//       {
//          if (array[i]>array[j])
//          {
//            int x=array[i];
//            array[i]=array[j];
//            array[j]=x;
//          }
//       }
//     }
// foreach (var item in array)
// {
//   System.Console.WriteLine(item);
// }
// }

//QUESTION 10
// static void Factorial()
// {
//  int Fibonacci=1; 
//   System.Console.WriteLine("Enter your number");
//   int number=int.Parse(Console.ReadLine());
//   for (int i = 1; i <= number; i++)
//   {
//     Fibonacci*=i;
//   }
//   System.Console.WriteLine($"The sum of the Fibonacci sequence is {Fibonacci }");
// }

//QUESTION 11
//static void Multitasking()
// {
//    System.Console.WriteLine("Enter 1 for reversed \n Enter 2 for average \n Enter 3 for linear equation");
//    int response=int.Parse(Console.ReadLine());
//    switch (response)
//    {
//       case 1:
//       System.Console.WriteLine("Enter the number of numbers");
//       int num=int.Parse(Console.ReadLine());
//       int []array=new int [num];
//       int[] reversedarray = new int[num];
//       int length=array.Length;
//       for (int i = 0; i < array.Length; i++)
//       { 
//         Console.WriteLine("Enter the number of numbers");
//         int nums2=int.Parse(Console.ReadLine());
//         array[i]=nums2;
//        reversedarray[length - i - 1] = array[i];
//         for (int j = 0; j < length; j++)
//          {
//            System.Console.Write(reversedarray[j] + " "); 
//          }
//        break;
// case 3:
// System.Console.WriteLine("Enter the value of a");
// double a=int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the value of b");
// double b=int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the value of c");
// double c=int.Parse(Console.ReadLine());
// double formula1=Math.Pow(b,2);
// double formula3=4*a*c;
// double formula=formula1+formula3;
//  double sqrt=Math.Sqrt(formula);
// double division=2*c;
// double answer=b+sqrt/division;
// System.Console.WriteLine($"The answer for the quadratic equation is {answer}");
// break;
// case 2:
// int sum =0;
// System.Console.WriteLine("Enter the number of time to input");
// int num2=int .Parse(Console.ReadLine());
// for (int i = 0; i < num2; i++)
// {
//   System.Console.WriteLine("Enter your number");
//   int nums=int.Parse(Console.ReadLine());
//   sum+=nums;
// }
// System.Console.WriteLine(sum/2);
//   break;
//     default:
//     System.Console.WriteLine("WRONG INPUT");
//     break;;
//   }
//   }