Console.Clear();
Console.WriteLine();
Console.WriteLine("> Introdu un numar:");
Console.Write("> ");
string? input = Console.ReadLine();

if (string.IsNullOrEmpty(input) || input.Any(c => c < '0' || c > '9'))
{
    Console.WriteLine("> Te rog sa introduci un numar intreg pozitiv.");
    return;
}

int[] aparitii = new int[10];
foreach (char cifra in input)
{
    aparitii[cifra - '0']++;
}

Console.WriteLine();
Console.WriteLine("> Cifra | Aparitii");
Console.WriteLine("> ----- | --------");
for (int cifra = 0; cifra < aparitii.Length; cifra++)
{
    if (aparitii[cifra] > 0)
    {
        Console.WriteLine($"> {cifra,5} | {aparitii[cifra],8}");
    }
}
