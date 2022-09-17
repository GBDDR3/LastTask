string[] array = { "Hello", "-2", "Rostov", "Pig", "Leto" };
string[] newArray = new string[array.Length];
int n = 3; // длина искомого элемента

string[] FillArray(string[] array, string[] array2, int n)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}
string [] result = FillArray(array, newArray, n);

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

PrintArray(result);