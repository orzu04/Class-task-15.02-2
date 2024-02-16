




void Zvezda(int n)
{
    int k = n;
    int cnt = 1;

    for (int i = 0; i < n; i++)
    {
        for (int t = 0; t < k - 1; t++)
        {
            System.Console.Write(" ");
        }
        k--;
        for (int j = 0; j < cnt; j++)
        {
            System.Console.Write("*");

        }
        System.Console.WriteLine();
        cnt++;

    }


}
Zvezda(4);