// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

void InputArray(int[] array)
{
      for (int i = 0; i < array.Length; i++)
          array[i] = new Random().Next(0, 100);
         
}

void ReleaseArray(int[] array)
{
      int max = array[0], min = array[0];
      
      for (int i = 0; i < array.Length; i++)

      while (i < array.Length)
{
      if (max < array[i])
      max = array[i];
      if (min > array[i])
      min = array[i];
      i = i + 1;
}

       Console.WriteLine($"max = {max}");
       Console.WriteLine($"min = {min}");
       Console.WriteLine($"Разница между max и min = {max - min}");
}

void PrintArray(int[] array)
{
  Console.WriteLine($"[{string.Join(",", array)}]");
}

Console.Write($"n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
InputArray(array);
PrintArray(array);
ReleaseArray(array);

