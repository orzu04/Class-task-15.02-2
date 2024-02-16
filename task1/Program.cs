

void Numb(int n)
{

   if(n==0)
   {
      System.Console.WriteLine();
   }

   else 
   {
    System.Console.Write($"{n} ");
    n--;
       Numb(n);
   }

}


Numb(5);


