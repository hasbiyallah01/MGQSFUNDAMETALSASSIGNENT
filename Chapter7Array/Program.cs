// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//CHAPTER 7
//QUESTION 1
// int [] array=new int[20];
// int total=0;
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine("Enter your number");
//     int num=int.Parse(Console.ReadLine());
//     array[i]=num;
// }
// foreach (var item in array)
// {
//     total=item*5;
//     Console.WriteLine(total);
// }

//QUESTION 2
// Console.WriteLine("ENTER THE LENGHT FOR ARRAY 1");
// int lenght=int.Parse(Console.ReadLine());
// Console.WriteLine("ENTER THE LENGHT FOR ARRAY 2");
// int lenght2=int.Parse(Console.ReadLine());
// int [] array=new int[lenght];
// int [] array2=new int[lenght2];
// for (int i = 0; i < lenght; i++)
// {
//     Console.WriteLine("Enter your number");
//     int num=int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter your number for array2");
//     int num2=int.Parse(Console.ReadLine());
//     array[i]=num;
//     array2[i]=num2;
//     if (array[i]==array2[i])
//     {
//         Console.WriteLine("They are equal");
//     }
// }

//4
// int[] arrayOfNumber = {1,1,2,3,2,2,2,1};
// int count = 0; 
// for (int i = 0; i < arrayOfNumber.Length; i++)
// {
//     if (arrayOfNumber[i] == arrayOfNumber[i+1])
//     {
//         count++;
//     }
// }
// System.Console.WriteLine($"{arrayNumber[i]} "+count);


//QUESTION 9
//  int max=int.MinValue;
//  int [] num={2,2,3,4,5,6,7};
//  for (int i = 0; i < num.Length; i++)
//  {
//     for (int j = 1; j < num.Length; j++)
//     {   
//         int sum=num[i]+num[j];
//         if (sum>max)
//         {
//             max=sum;
//             System.Console.WriteLine($"The ones with the greatest sum are {num[i]} and {num[j]} which is {sum}");
//         }
//     }
//  }

//QUESTION 10
//int repitition=0;
//int [] num={11,11,3,4,5,17,7};
// for (int i = 0; i < num.Length; i++)
// {
//    for (int j = 1; j < num.Length; j++)
//    {   
//        int count=0;
//        if (num[i]==num[j])
//        { 
//            if (repitition != num[i])
//            {
//                 count++;
//                 repitition=num[i];
//                 Console.WriteLine($"The most occuring is {num[i]} which appaers {count} number of times");
//            }
//         }
//     }
// }

//QUESTION 11
// int max=22;
//  int [] num={11,11,3,4,5,17,7};
//  for (int i = 0; i < num.Length; i++)
//  {
//     for (int j = 1; j < num.Length; j++)
//     {   
//         int sum=num[i]+num[j];
//         if (sum==max)
//         {
//             max=sum;
//             System.Console.WriteLine($"The ones which  sum up to be 22 are {num[i]} and {num[j]} ");
//         }
//     }
//  }

//QUESTION 12
// Console.WriteLine("Enter your number of rows");
// int rows=int.Parse(Console.ReadLine());
// Console.WriteLine("Enter your number of columns");
// int columns=int.Parse(Console.ReadLine());
// int [,] Arrays=new int [rows,columns];
// for (int i = 0; i < Arrays.GetLength(0); i++)
// {
//     for (int j = 0; j < Arrays.GetLength(1); j++)
//     {
//        Console.WriteLine($"Enter the number at row{i+1},column{j+1}"); 
//        int num=int.Parse(Console.ReadLine());
//        Arrays[i,j]=num;
//     }
// }
// for(int i=0;i<Arrays.GetLength(0);i++)
// {
//     for (int j = 0; j < Arrays.GetLength(1); j++)
//     {
//         Console.Write(Arrays[i,j] + " ");   
//     }
//     Console.WriteLine();
// }


//QUESTION 13
// Console.WriteLine("Enter the number of rows of your array:");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the number of columns of your array:");
// int columns = int.Parse(Console.ReadLine());
// int[,] myArray = new int[rows,columns];

// for(int i = 0; i < myArray.GetLength(0); i++)
// {
//     for(int j = 0; j < myArray.GetLength(1); j++)
//     {
//        Console.WriteLine($"Enter value at row {i+1},column {j+1}");
//        myArray[i,j] = int.Parse(Console.ReadLine());
//     }
// }
// int sum = 0;
// for(int i = 0; i < myArray.GetLength(0); i++)
// {
//     for(int j = 0; j < myArray.GetLength(1); j++)
//     {
//         sum += myArray[i,j];
//     }
// }
// Console.WriteLine();
// Console.Write("The sum of the array is "+sum);

//QUESTION 14
// string[,] myArray = new string[3,4]{{"ha","fifi","ho","hi"},{"fo","ha","hi","xx"},{"xxx","ho","ha","xx"}};
// int count = 0;
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         if (myArray[i,j] == "ha")
//         {
//             count++;
//         }
//     }
// }
// System.Console.WriteLine($"(ha) has the largest number of occuring times and it occured {count} times in the array");

//15


// 16
// System.Console.WriteLine("Enter the length of array");
// int length = int.Parse(Console.ReadLine());
// int[] myArray = new int [length];
// for (int i = 0; i < length; i++)
// {
//     System.Console.WriteLine($"Enter number at index {i}");
//     myArray[i] = int.Parse(Console.ReadLine());
// }
// Array.Sort(myArray);
// int count = 0;
// for (int i = 0; i < length; i++)
// {
//     if (myArray[i] == 0 || myArray[i] == 1)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine($"We have {count} binary numbers in the array");

// 17
// System.Console.WriteLine("Enter the length of array");
// int length = int.Parse(Console.ReadLine());
// int[] myArray = new int [length];
// for (int i = 0; i < length; i++)
// {
//     System.Console.WriteLine($"Enter number at index {i}");
//     myArray[i] = int.Parse(Console.ReadLine());
// }
// Array.Sort(myArray);
// foreach (int number in myArray)
// {
//     System.Console.Write(number +" ");
// }


//QUESTION 18          
//   int []array={2,5,4,6,7,8,9};
//   Array.Sort(array);
//   foreach (var item in array)
//   {
//      System.Console.WriteLine(item);
//   }

//QUESTION 19   

//QUESTION 20
// Console.WriteLine("Enter the number of times to enter");
// int no=int.Parse(Console.ReadLine());
// int [] array=new int [no];
// Console.WriteLine("Enter the sum you wanna to enter");
// int sum=int.Parse(Console.ReadLine());
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine("Enter your numbers");
//     array[i]=int.Parse(Console.ReadLine());
// }
// for (int j = 0; j < array.Length; j++)
// {
//     for (int k = 1; k < array.Length; k++)
//     {
//         if (array[j]+array[k]==sum)
//         {
//             Console.WriteLine($"The ones who sum up to be {sum} are {array[j]} and {array[k]}");
//         }
//     }
// }

//QUESTION 21
// Console.WriteLine("Enter the sum you wanna to enter");
// int max=int.Parse(Console.ReadLine());
// int [] num={11,11,3,4,5,17,7};
// for (int i = 0; i < num.Length; i++)
// {
//     for (int j = 1; j < num.Length; j++)
//     {   
//         int sum=num[i]+num[j];
//         if (sum==max)
//         {
//             max=sum;
//             Console.WriteLine($"The ones which  sum up to be {max} are {num[i]} and {num[j]} ");
//         }
//         else
//         {
//             Console.WriteLine($"The sum {num[i]} and {num[j]} is not possible");
//         }
//     }
// }

//QUESTION 22
// int min=int.MaxValue;
// int [] array={1,2,3,6,5,7,8};
//   for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]<min)
// {
//     min=array[i];
//     System.Console.WriteLine($"THe minimum value is {min}");
// }
//     for (int j = 0; j < array.Length; j++)
//     {
//        if (array[i]<array[j])
//        {
//         int x=array[i];
//         array[i]=array[j];
//         array[j]=x;
//        }
//     }
//   }
// foreach (var item in array)
// {
//   System.Console.WriteLine(item);
// }

//QUESTION 23
// Console.WriteLine("Enter the number of times to enter");
// int no=int.Parse(Console.ReadLine());
// int [] array=new int [no];
// for (int i = 0; i < array.Length; i++)
// {
// Console.WriteLine("Enter your numbers");
// array[i]=int.Parse(Console.ReadLine());
// }
// for (int j = 0; j < array.Length; j++)
// {
//    for (int k = 1; k < array.Length; k++)
//    {
//         Console.WriteLine($"The sub sets are {array[j]},{ array[k]}");
//    }
// }

//QUESTION 24
//System.Console.WriteLine("Enter the number of times to enter");
//int no=int.Parse(Console.ReadLine());
//int [] array=new int [no];
//for (int i = 0; i < array.Length; i++)
//{
//     System.Console.WriteLine("Enter your numbers");
//     array[i]=int.Parse(Console.ReadLine());
//}
// for (int j = 0; j < array.Length; j++)
// {
//    for (int k = 1; k < array.Length; k++)
//    {
//     if (array[j]!=array[k])
//     {
//         System.Console.WriteLine($"The sub sets are {array[j]},{ array[k]}");
//     }
//    }
// }

//25
// int[,] myArray = new int[5,6]{{1,3,2,2,2,4},{3,3,3,2,4,4},{4,3,1,2,3,3},{4,3,1,3,3,1},{4,3,3,3,1,1}};
// int count = 0;
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         if (myArray[i,j] == 3)
//         {
//             count++;
//         }
//     }
// }
// System.Console.WriteLine($"3 has the largest number of occuring times and it occured {count} times in the array");
