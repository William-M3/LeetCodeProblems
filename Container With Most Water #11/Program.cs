
Console.WriteLine(MaxArea([1, 1]));

int MaxArea(int[] height)
{
    int MaxArea = 0;
    int currentArea;
    unsafe
    {
        fixed (int* p1 = &height[0])
        {
            fixed (int* p2 = &height[height.Length - 1])
            {
                int* ptrStart = p1;
                int* ptrFinal = p2;
                for (int i = 0; i < height.Length; i++)
                {
                    if(*ptrStart > *ptrFinal)
                    {
                        currentArea = *ptrFinal * (height.Length - 1 - i);
                        ptrFinal--;
                    }
                    else
                    {
                       currentArea = *ptrStart * (height.Length - 1 - i);
                       ptrStart++;
                    }
                    if (MaxArea < currentArea)
                    {
                        MaxArea = currentArea;
                    }
                }
            }
        }
    }
    return MaxArea;
}
