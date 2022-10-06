//Conditions
#region task1 
//int a, b;
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine(a + b);
//}
//else if (a == b) 
//{
//    Console.WriteLine(a * b);
//  }
//else {
//    Console.WriteLine(a - b);
//}
#endregion
#region task2
//int x, y;
//x = Convert.ToInt32(Console.ReadLine());
//y = Convert.ToInt32(Console.ReadLine());
//if (x > 0 && y > 0)
//{
//    Console.WriteLine("first quadrant!");
//}
//else if (x < 0 && y < 0)
//{
//    Console.WriteLine("third quadrant!");
//}
//else if (x>0 && y < 0)
//{
//    Console.WriteLine("fourth quadrant!");
//}
//else if (x < 0 && y > 0)
//{
//    Console.WriteLine("second quadrant!");
//}
#endregion
#region task3
//int a, b, c;
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//c = Convert.ToInt32(Console.ReadLine());
//if (a <= b && b <= c)
//{
//    Console.WriteLine(a + "<" + b + "<" + c);
//}
//else if (a <= c && c <= b)
//{
//    Console.WriteLine(a + "<" + c + "<" + b);
//}
//else if (b <= c && c <= a)
//{
//    Console.WriteLine(b + "<" + c + "<" + a);
//}
//else if (b <= a && a <=c )
//{
//    Console.WriteLine(b+ "<" + a + "<" + c);
//}
//else if ( c <= b && b <= a)
//{
//    Console.WriteLine(c + "<" + b + "<" + a);
//}
//else if (c <= a && a <=b)
//{
//    Console.WriteLine(c + "<" + a + "<" + b);
//}
#endregion
#region task4
//double a, b, c, d,x1, x2;
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//c = Convert.ToInt32(Console.ReadLine());
//d = b * b - 4 * a * c;
//if (d > 0)
//{

//    x1 = (-b + Math.Sqrt(d)) / 2 * a;
//    x2 = (-b - Math.Sqrt(d)) / 2 * a;
//    Console.WriteLine(x1 + "and" + x2);
//}
//else
//{
//    Console.WriteLine("0");
//}
#endregion
#region task 5
//int  num;
//num = Convert.ToInt32(Console.ReadLine());
//if (num >= 10 && num <= 19)
//{
//    switch (num)
//    {
//        case 10:
//            Console.WriteLine("ten");
//            break;
//        case 11:
//            Console.WriteLine("eleven");
//            break;
//        case 12:
//            Console.WriteLine("twelve");
//            break;
//        case 13:
//            Console.WriteLine("thirteen");
//            break;
//        case 14:
//            Console.WriteLine("fourteen");
//            break;
//        case 15:
//            Console.WriteLine("fifthteen");
//            break;
//        case 16:
//            Console.WriteLine("sixteen");
//            break;
//        case 17:
//            Console.WriteLine("seventeen");
//            break;
//        case 18:
//            Console.WriteLine("eighteen");
//            break;
//        case 19:
//            Console.WriteLine("nineteen");
//            break;

//    }
//}
//else
//{
//    int a = num / 10;
//    int b = num % 10;
//    switch (a)
//    {
//        case 2:
//            Console.Write("twenty");
//            break;
//        case 3:
//            Console.Write("thirty");
//            break;
//        case 4:
//            Console.Write("forty");
//            break;
//        case 5:
//            Console.Write("fifty");
//            break;
//        case 6:
//            Console.Write("sixty");
//            break;
//        case 7:
//            Console.Write("seventy");
//            break;
//        case 8:
//            Console.Write("eighty");
//            break;
//        case 9:
//            Console.Write("ninety");
//            break;



//    }
//    switch (b)
//    {
//        case 1:
//            Console.WriteLine("one");
//            break;
//        case 2:
//            Console.WriteLine("two");
//            break;
//        case 3:
//            Console.WriteLine("three");
//            break;
//        case 4:
//            Console.WriteLine("four");
//            break;
//        case 5:
//            Console.WriteLine("five");
//            break;
//        case 6:
//            Console.WriteLine("six");
//            break;
//        case 7:
//            Console.WriteLine("seven");
//            break;
//        case 8:
//            Console.WriteLine("eight");
//            break;
//        case 9:
//            Console.WriteLine("nine");
//            break;
//    }

//}
#endregion
#region task 6
//int x, y, r;
//x = Convert.ToInt32(Console.ReadLine());
//y = Convert.ToInt32(Console.ReadLine());
//r = Convert.ToInt32(Console.ReadLine());
//if (x * x + y * y > r * r)
//{
//    Console.WriteLine("outside in circle:");
//        }
//else
//{
//    Console.WriteLine("inside in circe:");
//}
#endregion
#region task7.1
//int num1;
//Console.Write("input 3 digit number: ");
//num1 = Convert.ToInt32(Console.ReadLine());
//int a = num1 / 100;
//int b = (a / 10) % 10;
//int c = b % 10; 
//int sum = a + b + c;
//if (num1 * num1 == sum * sum * sum)
//{
//    Console.WriteLine("its equeal!");
//} else
//{
//    Console.WriteLine("its not equal!");
//}
#endregion
#region task7.2
//int num = Convert.ToInt32(Console.ReadLine());

//int first1 = num / 1000;
//int first2 = (num / 10) % 10;
//int last1 = (num %100) /10;
//int last2 = num % 10;
//int sum1 = first1 + first2;
//int sum2 = last1 + last2;
//if (sum1 == sum2)
//{
//    Console.WriteLine("its equal");
//}else
//{
//    Console.WriteLine("its not equeal");
//}
#endregion
#region task7.3
//int num = Convert.ToInt32(Console.ReadLine());
//int a = num / 100;
//int b = (num / 10) % 10;
//int c = num %10;
//if (a == b || b ==c || a == c)
//{
//    Console.WriteLine("yes");

//}else
//{
//    Console.WriteLine("no");
//}
#endregion
#region task7.4
//decimal num = Convert.ToDecimal(Console.ReadLine());
//decimal num2 = num * 1000;
//if (num2 % 10 < 1 || (num2 / 10) % 10 < 1 || (num2 / 100) % 10<1 )
//{
//    Console.WriteLine("contains 0");

//}else
//{
//    Console.WriteLine("not contains!");
//}
#endregion

//Cycles
#region task1
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32((Console.ReadLine()));
//int result = 1;
//for (int i = 1; i <= b; i++)
//{
//    result = result * a;


//}
//Console.WriteLine(result);
#endregion
#region task2
//int a = Convert.ToInt32(Console.ReadLine());
//int res=0;
//for (int i = 1; i <= 1000; i++)
//{
//    if (i % a == 0)
//    {
//        res++;

//    }
//}
//Console.WriteLine(res);
#endregion
#region task3
//int a = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i < a; i++)
//{
//    if (i * i < a)
//    {
//        Console.WriteLine(i);
//    }

//}
#endregion
#region task4
//int res =0;
//int a = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i < a; ++i)
//{
//    if (a % i == 0)
//    {
//        res = i;
//    }
//}
//Console.WriteLine(res);
#endregion
#region task5
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = a; i <= b; i++)
//{
//    if (i % 7 == 0)
//    {
//        sum = sum + i;
//    }
//}
//Console.WriteLine(sum);
#endregion
#region task6
//int a = 0, b = 1, n, fibon;
//n = convert.toint32(console.readline());
//console.write(a + " " + b + " ");
//for (int i = 2; i < n; i++)
//{
//    fibon = a + b;
//    console.write(fibon + " ");
//    a = b;
//    b = fibon;
//}
#endregion