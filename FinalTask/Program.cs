TextArray();

static void TextArray()
{
    string[] text = { "Hello", "2", "Hi", "Too", "World" };
    int count = 1;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3) count++;
    }
    string[] result = new string[count];
    PrintResult(text, result);

}
static void PrintResult(string[] printText, string[] printResult)
{
    Console.Write("[");

    for (int i = 0; i < printResult.Length; i++)
    {
        if (printText[i].Length <= 3)
        {
            printResult[i] = printText[i];
            Console.Write(printResult[i]);
            if (i + 1 != printResult.Length) Console.Write(", ");
            else Console.Write("]");
        }
    }
    Console.WriteLine();
}