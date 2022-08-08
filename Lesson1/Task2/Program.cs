int a, b, c; 
         Console.WriteLine("Введите три числа : "); 
         a = Convert.ToInt32(Console.ReadLine());
         b = Convert.ToInt32(Console.ReadLine());
         c = Convert.ToInt32(Console.ReadLine());
 int max;
 if (a >= b)
 {
    if (c >= a)
    {
       max = c;
    }
    else
    {
       max = a;
    }
 }
 else
 {
    if (c >= b)
    {
       max = c;
    }
    else
    {
       max = b;
    }
            
             
         }
Console.Write("Максимальное число = " );
Console.WriteLine(max);

