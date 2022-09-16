string[] testText = { "hello", "a", "how are u?", "I", "^_^" };
string[] tempText;
string[] resultText;
tempText = new string[testText.Length];
int count = 0;
for (int i = 0; i < testText.Length; i++)
{
    if (testText[i].Length <= 3)
    {
        tempText[count] = testText[i];
        count++;
    }
}
resultText = new string[count];
for (int i = 0; i < resultText.Length; i++)
{
    resultText[i] = tempText[i];
}
for (int i = 0; i < resultText.Length; i++)
{
    Console.Write($"{tempText[i]} , ");
}
