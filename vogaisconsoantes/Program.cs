/* 
2 - Faça um vetor de caracteres de 10 posições e imprima os seguintes itens:
A) Somente as vogais
B) Somente as consoantes
*/

char[] word = new char[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite a {i + 1}ª letra: ");
    word[i] = Console.ReadLine().First();
}

Console.WriteLine("\n\nVogais: ");

for (int i = 0; i < 10; i++)
{
    bool isVowel =
        (word[i] == 'a' || word[i] == 'A') ||
        (word[i] == 'e' || word[i] == 'E') ||
        (word[i] == 'i' || word[i] == 'I') ||
        (word[i] == 'o' || word[i] == 'O') ||
        (word[i] == 'u' || word[i] == 'U');

    if (isVowel)
        Console.Write($"{word[i]} ");
}

Console.WriteLine("\n\nConsoantes: ");

for (int i = 0; i < 10; i++)
{
    bool isConsonant = !(
            (word[i] == 'a' || word[i] == 'A') ||
            (word[i] == 'e' || word[i] == 'E') ||
            (word[i] == 'i' || word[i] == 'I') ||
            (word[i] == 'o' || word[i] == 'O') ||
            (word[i] == 'u' || word[i] == 'U')
        );

    if (isConsonant)
        Console.Write($"{word[i]} ");
}