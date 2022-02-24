int a;
int b;
int c;
bool Prime;

Console.WriteLine("Hello! Please enter two positive integers. The first one should be smaller than the second.");
Console.WriteLine("Then, I'll show you all the prime numbers between them!");

Console.Write("Please enter the first integer  : ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second integer : ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
        {
c = a;
a = b;
b = c;
}

for (int x = a + 1; x < b; x++)
{
    Prime = true;
    if (x%2 ==0 && x!=2)
    {
        Prime=false;
    }
    for (int z = 3; z < Math.Sqrt(x) && Prime == true; z+=2)
    {
        if (x % z == 0)
        { Prime = false; 
        }

   }
if (Prime == true)
    { Console.Write(" " + x);
    }
}
Console.ReadKey();
   