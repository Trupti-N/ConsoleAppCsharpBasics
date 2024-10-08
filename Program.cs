// See https://aka.ms/new-console-template for more information

//int[] numArray = new int[5] { 10, 50, 20, 40, 60 };

//foreach(int item in numArray)
//{
//    Console.WriteLine("Read the number is {0}" , item);
//}
//Console.ReadKey();


//int num;
//Console.WriteLine("please enter a num");
//num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Table of {0} is:", num);
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("{0} x {1} = {2}",num, i, i * num);
//}
//Console.ReadKey();

//throw


//try
//{
//    int num1 = 2, num2 = 0, result = 0;
//    if (num2 == 0)
//    {
//        throw new DivideByZeroException();
//    }
//    else
//    {
//        result = num1 / num2;
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

//int[] Array1 = new int[5] { 50, 10, 20, 98, 55 };

//Console.Write("Elements of Array is:");

//for(int i = 0; i < Array.Length; i++)
//{
//    Console.Write("{0}", Array[i]);
//}
//Console.ReadKey();

//Array.Sort(Array1);

//foreach(int item in Array1)
//{
//    Console.WriteLine("{0}  ", Array1[item]);
//}


//int num1, num2;
//Console.WriteLine("enter a number");
//num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("enter a number");
//num2 = Convert.ToInt32(Console.ReadLine());

//int result = num1 + num2;
//Console.WriteLine("sum of {0} , {1} is: {2}", num1,num2,result);

//int num1;
//Console.WriteLine("enter a num");
//num1= Convert.ToInt32(Console.ReadLine());
//for(int i = 1; i <= 10; i++)
//{
//    int result = num1 * i;
//    Console.WriteLine("table of {0} * {1} is {2}", num1, i, result);
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}
//Console.WriteLine("break");

//for (int i = 0; i < 10; i++)
//{
//    if (i <= 5)
//        continue;
//    Console.WriteLine(i);
//}

// find Area
//int sideLength;
//Console.WriteLine("enter length");
//sideLength = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("area of squre is: {sideLength} x {1} = {2}", sideLength, sideLength, sideLength * sideLength);
//int area = sideLength * sideLength;
//Console.WriteLine($"Area of square is : {area}");


// to Swap Numbers with second variable

//int num1, num2;
//Console.WriteLine("enter num1");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter num2");
//num2 = Convert.ToInt32(Console.ReadLine());

//int temp = num1;
//num1 = num2;
//num2 = temp;
//Console.WriteLine($"swap numbers are {num1} and {num2}");

//to Swap Numbers without any third variable

//int num1, num2;
//Console.WriteLine("enter num1");
//num1=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter num2");
//num2 =Convert.ToInt32(Console.ReadLine());
//num1=num1+num2;
//num2=num1-num2;
//num1 = num1 - num2;
//Console.WriteLine($"{num1}and{num2}");

//Write a program to Calculate the Sum of all numbers. 

//int num, temp, sum = 0;
//Console.WriteLine("enter num");
//num =Convert.ToInt32(Console.ReadLine());
//while (num > 0)
//{
//    temp = num % 10;
//    sum = sum + temp;
//    num = num / 10;
//}
//Console.WriteLine($"sum of digits are{sum}");


//ARRAY 

//int[] arr = new int[] { 25, 50, 48, 96 };

//Array.Sort(arr);
//Console.WriteLine("sorted array is:");
//for(int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine($"{arr.GetValue(i)}");
//}

//int[] newArr = new int[4];
//Array.Copy(arr, newArr, arr.Length);
//for(int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(newArr.GetValue(i));
//}

//int index = Array.IndexOf(arr, 50);
//Console.WriteLine(index);

using ConsoleAppCsharpBasics;

ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
obj1.Display();
//ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
ParameterizedConstructor obj2 = new ParameterizedConstructor(obj1);
obj2.Display();
Console.ReadKey();