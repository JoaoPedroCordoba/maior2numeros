double n1, n2;

Console.WriteLine("Digite o primeiro número..:");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo numero número..:");
n2 = Convert.ToDouble(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O maior número é {n1}");
}
else 
{
    Console.WriteLine($"O maior número é {n2}");
}

