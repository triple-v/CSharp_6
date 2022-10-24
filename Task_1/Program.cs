// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел, которое будет проверяться: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] CreationArray(int number)
{
  int[] array = new int[number];
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"Введите число {i + 1}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
  }
  return array;
}
int CoutingPositiveNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) count++;
  }
  return count;
}
void PrintArray(int[] array1)
{
  Console.Write("[");
  for (int i = 0; i < array1.Length; i++)
  {
    if (i < array1.Length - 1) Console.Write($"{array1[i]},");
    else Console.Write(array1[i]);
  }
  Console.Write("]");
}
int[] array = CreationArray(number);
int count = CoutingPositiveNumbers(array);
PrintArray(array);
Console.WriteLine($" Количество положительных элементов = {count} ");