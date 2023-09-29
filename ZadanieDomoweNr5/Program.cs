var digit = 98540239453;
string digitInString = digit.ToString();
char[] exe = digitInString.ToArray();

var amount1 = 0;
var amount2 = 1;
var amount3 = 2;
var amount4 = 3;
var amount5 = 4;
var amount6 = 5;
var amount7 = 6;
var amount8 = 7;
var amount9 = 8;
var amount10 = 9;

foreach (char a in exe)
{
    if (a == '0')
    {
        amount1 += 1;
        Console.WriteLine(amount1);
    }
    else if (a == '1')
    {
        amount2 += 1;
        Console.WriteLine(amount2);
    }
    else if (a == '2')
    {
        amount3 += 1;
        Console.WriteLine(amount3);
    }
    else if (a == '3')
    {
        amount4 += 1;
        Console.WriteLine(amount4);
    }
    else if (a == '4')
    {
        amount5 += 1;
        Console.WriteLine(amount5);
    }
    else if (a == '5')
    {
        amount6 += 1;
        Console.WriteLine(amount6);
    }
    else if (a == '6')
    {
        amount7 += 1;
        Console.WriteLine(amount7);
    }
    else if (a == '7')
    {
        amount8 += 1;
        Console.WriteLine(amount8);
    }
    else if (a == '8')
    {
        amount9 += 1;
        Console.WriteLine(amount9);
    }
    else if (a == '9')
    {
        amount10 += 1;
        Console.WriteLine(amount10);
    }
}  

Console.WriteLine(exe);


          