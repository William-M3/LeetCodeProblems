Reverse(-123);

Console.WriteLine(Int32.MaxValue);


int Reverse(int x)
{

    int reverseNumber = 0;

    while (x != 0)
    {
        reverseNumber = (reverseNumber * 10) + (x % 10);
        if (reverseNumber % 10 != x % 10)
            return 0;
        x = x / 10;
    }

    return reverseNumber;
}
