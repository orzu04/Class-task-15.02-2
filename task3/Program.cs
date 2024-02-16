

void Revers (int n)
{
    if(n==0)
    {
        System.Console.WriteLine();
    }
    else 
    {
       
        System.Console.Write($"{n%10} ");
        n/=10;
        Revers(n);
    }
}
Revers(811);
