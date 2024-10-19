string enterNumOne;
int numOne;

string enterNumTwo;
int NumTwo;

int total;

Console.Write("enter Number One: ");
enterNumOne = Console.ReadLine();
numOne = int.Parse(enterNumOne);

Console.Write("calculator + | - | * | / : ");
string enterCalculator = Console.ReadLine();

Console.Write("enter Number Two: ");
enterNumTwo = Console.ReadLine();
 NumTwo = int.Parse(enterNumTwo);


if(enterCalculator == "+")
{
    total = numOne + NumTwo;
    Console.WriteLine(numOne + " " + enterCalculator + " " + NumTwo + " = " + total);
}
else if (enterCalculator == "-")
{
    total = numOne - NumTwo;
    Console.WriteLine(numOne + " " + enterCalculator + " " + NumTwo + " = " + total);
}
else if (enterCalculator == "")
{
    total = numOne * NumTwo;
    Console.WriteLine(numOne + " " + enterCalculator + " " + NumTwo + " = " + total);
}

else if (enterCalculator == "/")
{
    total = numOne / NumTwo;
    Console.WriteLine(numOne + " " + enterCalculator + " " + NumTwo + " = " + total);
}