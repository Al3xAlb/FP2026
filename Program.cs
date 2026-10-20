// Sterge textul afisat anterior in terminal.
Console.Clear();
// Afiseaza o linie goala pentru a separa continutul.
Console.WriteLine();
// Afiseaza instructiunea si trece la linia urmatoare.
Console.WriteLine("> Introdu un numar:");
// Afiseaza promptul fara sa treaca la o linie noua.
Console.Write("> ");
// Citeste textul introdus de la tastatura; poate fi null daca nu exista input.
string? input = Console.ReadLine();

// Verifica daca inputul lipseste sau contine caractere care nu sunt cifre.
if (string.IsNullOrEmpty(input) || input.Any(c => c < '0' || c > '9'))
{
    // Anunta utilizatorul ca trebuie sa introduca cifre de la 0 la 9.
    Console.WriteLine("> Te rog sa introduci un numar intreg pozitiv.");
    // Opreste programul deoarece inputul nu este valid.
    return;
}

// Creeaza un vector cu 10 elemente, cate unul pentru fiecare cifra de la 0 la 9.
int[] aparitii = new int[10];
// Parcurge fiecare caracter din numarul introdus.
foreach (char cifra in input)
{
    // Transforma caracterul-cifra in index si creste contorul corespunzator.
    aparitii[cifra - '0']++;
}

// Afiseaza o linie goala inaintea tabelului.
Console.WriteLine();
// Afiseaza antetul tabelului: cifra si numarul de aparitii.
Console.WriteLine("> Cifra | Aparitii");
// Afiseaza separatorul de sub antet.
Console.WriteLine("> ----- | --------");
// Parcurge toate cifrele posibile, de la 0 la 9.
for (int cifra = 0; cifra < aparitii.Length; cifra++)
{
    // Afiseaza doar cifrele care au aparut cel putin o data.
    if (aparitii[cifra] > 0)
    {
        // Aliniaza cifra si numarul ei de aparitii in coloanele tabelului.
        Console.WriteLine($"> {cifra,5} | {aparitii[cifra],8}");
    }
}

/*
0123456789
0000000000
0100000000
0110000000
0111000000
0111100000
0112100000
0122100000
0222100000*/
