int number = 4519566;
string numberToString = number.ToString();
char[] letters = numberToString.ToArray();
// int[] numbers = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

int[] numbers = new int[10]; 

foreach (char letter in letters)
{
    numbers[int.Parse(letter.ToString())] = numbers[int.Parse(letter.ToString())] + 1;
}

Console.WriteLine(number+":");
Console.WriteLine("");
for (int index = 0; index < numbers.Length; index++)
{
    Console.WriteLine(index + " => " + numbers[index]);
}