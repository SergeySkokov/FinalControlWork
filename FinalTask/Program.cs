/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.
*/
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
    PrintResult(text, result, count);

}
static void PrintResult(string[] printText, string[] printResult, int counter)
{
    Console.Write("[");

    for (int i = 0; i < counter; i++)
    {
        if (printText[i].Length <= 3)
        {
            printResult[i] = printText[i];
            Console.Write(printResult[i]);

            if (printResult[i].Length < counter - 1)
            {
                Console.Write(", ");
            }
            else Console.Write("]");
        }
    }
    Console.WriteLine();
}