// 1 
// int c = Convert.ToInt32(Console.ReadLine());
// int hour = (c / 3600) % 24;
// int  min = (c % 3600) / 60; 
// int sec = (c % 3600) % 60;
// Console.WriteLine($"{hour / 10}{hour % 10}:{min / 10}{min % 10}:{sec / 10}{sec % 10}");

// 2 
// int mags = Convert.ToInt32(Console.ReadLine());
// int magd = Convert.ToInt32(Console.ReadLine());
// int pers = Convert.ToInt32(Console.ReadLine());
// int perd = Convert.ToInt32(Console.ReadLine());
// int obshsum = mags * 100 + magd, obshsumpers = pers * 100 + perd, bakiya = obshsumpers - obshsum;
// Console.WriteLine($"{bakiya / 100} {bakiya % 10}");

// 3 
// int zarp = Convert.ToInt32(Console.ReadLine());
// int staj = Convert.ToInt32(Console.ReadLine());
// if (staj >= 5) Console.WriteLine(zarp + (zarp * 5) / 100);
// else Console.WriteLine(zarp);

// 4 
// int Fact(int c)
// {
//    int d = 1;
//    for (int i = 1; i <= c; i++)
//    {
//       d *= i;
//    }
//    return d;
// }
// int n = Convert.ToInt32(Console.ReadLine()), k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Fact(n) / (Fact(k) * (Fact(n - k))));

// 5 
// int Fact(int c)
// {
//    int d = 1;
//    for (; c > 0; c--)
//    {
//       d *= c;
//    }
//    return d;
// }
// double SumOfFactorial(int n)
// {
//    double sum = 1;
//    for (int i = 1; i <= n; i++)
//    {
//       sum += 1 / (double)Fact(i);
//    }
//    return sum;
// }
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumOfFactorial(n));

//6 
// int EvenCount(int n)
// {
//    int c = 0;
//    for (; n > 0; n /= 10)
//    {
//       if ((n % 10) % 2 == 0) c++;
//    }
//    return c;
// }
// int OddCount(int n)
// {
//    int c = 0;
//    for (; n > 0; n /= 10)
//    {
//       if ((n % 10) % 2 == 1) c++;
//    }
//    return c;
// }
// int DigitCount(int n)
// {
//    int c = 1;
//    for (; n > 9; n /= 10)
//    {
//       c++;
//    }
//    return c;
// }
// int SumDigit(int n)
// {
//    int sum = 0;
//    for (; n > 0; n /= 10)
//    {
//       sum += n % 10;
//    }
//    return sum;
// }
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Четных  {EvenCount(b)}");
// Console.WriteLine($"Нечетных {OddCount(b)}");
// Console.WriteLine($"Количество цифри {DigitCount(b)}");
// Console.WriteLine($"Сумма цифри {SumDigit(b)}");

//7 
// int a = Convert.ToInt32(Console.ReadLine()), c = 0;
// int[] array = new int[a];
// for (int i = 0; i < a; i++)
// {
//    array[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 2; i < a; i++)
// {
//    if (array[i - 1] > array[i - 2] && array[i - 1] > array[i])
//    {
//       c++;
//    }
// }
// Console.WriteLine("Количество = " + c);


//8 
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];
// for (int i = 0; i < a; i++)
// {
//    array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Array.Sort(array);
// Array.Reverse(array);
// for (int i = 0; i < a; i++)
// {
//    Console.Write(array[i] + " ");
// }
//9 
// int a = Convert.ToInt32(Console.ReadLine());
// int max = -999999, index = 0;
// int[] array = new int[a];
// for (int i = 0; i < a; i++)
// {
//    array[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < a; i++)
// {
//    if (array[i] > max)
//    {
//       max = array[i];
//       index = i;
//    }
// }
// Console.WriteLine(index);

// 10 
// int a = Convert.ToInt32(Console.ReadLine()), min = 999999;
// int[] array = new int[a];
// for (int i = 0; i < a; i++)
// {
//    array[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < a; i++)
// {
//    if (array[i] < min) min = array[i];
// }
// Console.WriteLine(min);

// 11 
// int a = Convert.ToInt32(Console.ReadLine());
// int max = -999999;
// int[] array = new int[a];
// for (int i = 0; i < a; i++)
// {
//    array[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < a; i++)
// {
//    if (array[i] > max)
//    {
//       max = array[i];
//    }
// }
// Console.WriteLine(max);

// 12 
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];
// for (int i = 0; i < a; i++)
// {
//    array[i] = Convert.ToInt32(Console.ReadLine());
// }
// int x = Convert.ToInt32(Console.ReadLine()), c = 0;
// for (int i = 0; i < a; i++)
// {
//    if (array[i] == x)
//    {
//       c++;

//    }
// }
// Console.WriteLine(c);

// 13 
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];
// for (int i = 0; i < a; i++)
// {
//    array[i] = Convert.ToInt32(Console.ReadLine());
// }
// int x = Convert.ToInt32(Console.ReadLine()), c = 0;
// for (int i = 0; i < a; i++)
// {
//    if (array[i] == x)
//    {
//       c++;
//    }
// }
// if (c > 0) Console.WriteLine("YES");
// else Console.WriteLine("NO");
