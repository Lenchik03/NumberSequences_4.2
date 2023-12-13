//задача 1
//int.TryParse(Console.ReadLine(), out int n);

//double summa = 0;

//for(int i = 0; i <= n; i++)
//{
//    double formula = Math.Pow(-1, n) * 1/Math.Pow(2, n);
//    summa += formula;
//}
//Console.WriteLine(summa);

// задача 2
//int.TryParse(Console.ReadLine(), out int n);

//double summa = 0;
//double formula = 0;

//for (int i = 1; i <= n; i++)
//{

//    formula = formula + Math.Sin(i);
//    summa = summa + 1/formula;
//}
//Console.WriteLine(summa);

//задание 3
//int.TryParse(Console.ReadLine(), out int n);

//double summa = 1;

//for (int i = 1; i <= n; i++)
//{
//    double formula = 2*i / (2*i + 1);
//    summa *= formula;
//} 

//задание 4
//int.TryParse(Console.ReadLine(), out int n);

//double s = 1;
//double cos = 0;
//double sin = 0;

//for (int i = 1; i <= n; i++)
//{
//    cos = cos + Math.Cos(i);
//    sin = sin + Math.Sin(i);
//    s *= cos / sin;
//}
//Console.WriteLine(s);

//задача 5
//int.TryParse(Console.ReadLine(), out int x);
//double pow = 1;
//double fact = 1;
//double summa = 0;

//for (int i = 1; i <= 13; i++)
//{
//    pow = Math.Pow(x, i); //pow*x
//    fact = i!;
//    if (i % 2 == 1)
//    {
//        if (i % 4 == 3)
//        {
//            summa = summa - pow / fact;
//        }
//        else
//        {
//            summa = summa + pow / fact;
//        }
//    }
//}
//Console.WriteLine(summa);

//задача 6
//double.TryParse(Console.ReadLine(), out double x);
//int.TryParse(Console.ReadLine(), out int n);

//double s = 0;
//double summa = 0;

//for (int i = 0; i <= n; i++)
//{
//    x = Math.Sin(x);
//    summa += x;
//}
//Console.WriteLine(summa);

//задача 7
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int n);

//double summa = 1;

//for (int i = 1; i <= n; i++)
//{
//    double formula = a + i - 1;
//    summa *= formula;
//}
//Console.WriteLine(summa);

//задача 8
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int n);

//double p = 1;
//for  (int i = 0;  i <= n; i++)
//{
//    //p += a * (a - n) * (a - 2 * n) * (a - Math.Pow(n, 2));
//    p *= a - i * n;
//}
//Console.WriteLine(p);

//Никитина Алёна и Залевская Полина







//задача 9
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int n);

//double s = 0;

//for (int i = 1; i <= n; i++)
//{
//    double formula = 1 / Math.Pow(a, 2 * i - 2);
//    s += formula;
//}
//Console.WriteLine(s);

//задача 10
//int.TryParse(Console.ReadLine(), out int x);
//double s = 1;
//for(int i = 0; (i * 2 + 1) <= 63; i++)
//{
//    double formula1 = (x - (i * 2 + 1));
//    double formula2 = (x- Math.Pow(x, 2));
//    s *= formula1 / formula2;
//}
//Console.WriteLine(s);

//задача 11

//double s = 1;
//for (double i = 0.1; i <= 10; i += 0.1)
//{
//    double formula = 1 + Math.Sin(i);
//    s *= formula;
//}
//Console.WriteLine(s);

//задача 12
//int.TryParse(Console.ReadLine(), out int x);
//int.TryParse(Console.ReadLine(), out int n);

//double summa = 0;

//for(int i = 0; i <= n; i++)
//{
//    double formula1 = Math.Sin(Math.Pow(x, i));
//    summa += formula1;
//}
//Console.WriteLine(summa);

//задача 13
//int.TryParse(Console.ReadLine(), out int n);

//double s = 0;

//for(int i = 1; i <= n;  i++)
//{
//    double formula = 1;
//    for (int j = i; j <= i*2; j++)
//    {
//        formula = formula * j;

//    }
//    s += formula;
//}
//Console.WriteLine(s);

//задача 14
//int.TryParse(Console.ReadLine(), out int n);
//double s = 1;

//if (n > 2)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        double formula = 1 - 1 / Math.Pow(i, 2);
//        s *= formula;
//    }
//    Console.WriteLine(s);
//}
//else
//    Console.WriteLine("Error!!!");


//задача 15
//int.TryParse(Console.ReadLine(), out int n);
//double s = 1;

//    for (int i = 1; i <= n; i++)
//    {
//        double formula = 1 - 1 / i*2;
//        s *= formula;
//    }
//    Console.WriteLine(s);

//задача 16
//int.TryParse(Console.ReadLine(), out int n);
//double s = 0;

//double formula = 1;
//if (n > 1)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        formula = formula * i;
//        s += formula;
//    }
//    Console.WriteLine(s);
//}
//else
//    Console.WriteLine("Error!!!");




//задача 17
//int.TryParse(Console.ReadLine(), out int n1);
//double summa = 0;

//for (int i = 1; i <= n1; i++)
//{
//    double formula1 = 1 / Math.Pow(2 * i + 1, 2);
//    summa += formula1;
//}
//Console.WriteLine(summa);

//задача 18

//int.TryParse(Console.ReadLine(), out int x);

//double s = 0;

//for (int i = 1; i <= 11; i++)
//{
//    int n = 10;
//    double y = Math.Pow(x, n);

//    n--;
//    s += y*i;

//}
//Console.WriteLine(s);

//задача 19
//int.TryParse(Console.ReadLine(), out int p);
//int a = 1;
//int b = 1;

//for (int i = 0; i <= p; i++)
//{
//    int result = a + b;
//    a = b;
//    b = result;
//}
//Console.WriteLine(result);

//задача 20

//int.TryParse(Console.ReadLine(), out int n);

//double s = 0;
//double formula = 0;

//for (int i = 1; i <= n; i++)
//{
//    formula = 2 * i - 1;
//    s += formula;
//}
//Console.WriteLine(s);

//задача 21
//int.TryParse(Console.ReadLine(), out int n);

//double s = 0;
//double formula = 0;

//for (int i = 1; i <= n; i++)
//{
//    formula = 2 * i;
//    s += formula;
//}
//Console.WriteLine(s);

//задача 22
//int.TryParse(Console.ReadLine(), out int n);
//int.TryParse(Console.ReadLine(), out int x);

//double s = 0;
//double formula = 0;

//for (int i = 1; i <= n; i++)
//{
//    formula = Math.Pow(Math.Cos(x), i);
//    s += formula;
//}
//Console.WriteLine(s);

//задача 23
//double s = 0;
//double formula = 0;

//for (double i = 1; i <= 2; i+= 0.1)
//{
//    formula = Math.Sin(i);
//    s += formula;
//}
//Console.WriteLine(s);

//задача 24
//int.TryParse(Console.ReadLine(), out int n);
//int.TryParse(Console.ReadLine(), out int k);

//double s = 0;
//double formula = 0;

//for (int i = n; i >= 2; i--)
//{
//    formula = k * (i - 1) + Math.Sqrt(k * i);
//    s = Math.Sqrt( s + formula);
//}
//Console.WriteLine(s);

//задача 25
//int.TryParse(Console.ReadLine(), out int n);

//double s = 0;
//double formula = 0;

//for (int i = 1; i <= n; i++)
//{
//    formula = (n + 1) / n;
//    s += formula;
//}
//Console.WriteLine(s);

//задача 26
//int.TryParse(Console.ReadLine(), out int k);

//double formula = 0;
//double min = double.MaxValue;

//for (int i = 1; i <= k; i++)
//{
//    formula = Math.Sin(i) + 3 * Math.Cos(2*i);
//    if (formula < min)
//        min = formula;
//}
//Console.WriteLine(min);
