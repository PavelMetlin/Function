
int FindQuarter(int x, int y);
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;

    return 0;
}
System.Console.WriteLine(quarter);
System.Console.WriteLine(FindQuarter(-19,7));
System.Console.WriteLine(FindQuarter(-1,7));
System.Console.WriteLine(FindQuarter(-9,-7));
System.Console.WriteLine(FindQuarter(-5,4));