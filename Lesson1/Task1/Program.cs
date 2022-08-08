int a, b; //int тип целочисленных данных
         Console.WriteLine("Введите два числа : "); //Console.Writline выводит что то в окно терминала
         a = Convert.ToInt32(Console.ReadLine());
         b = Convert.ToInt32(Console.ReadLine());
         if (a > b)
         {
             Console.WriteLine("{0} наибольшее число", a);
         }
         else
         {
 
            Console.WriteLine("{0} наибольшее число ", b);
 
        }
         Console.ReadLine();
     