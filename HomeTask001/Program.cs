// Задача dev1
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные
 


 int[] arr = new int[10];
       
 
    Console.WriteLine("Исходный массив");
    Console.WriteLine();
    int index = 0;
    for (index = 0; index < 10; index++)
    {
        arr[index] = new Random().Next(10, 100);
        Console.Write("{0} ", arr[index]);

    }
           



// Исключение элементов нарушения возрастания

int currentElement = arr[0];
index = 1;
Console.WriteLine();   
Console.WriteLine("Массив без элементов, нарушающих порядок возрастания:");
Console.Write(currentElement);

while (index <= 9)
{
    if(arr[index]>currentElement)
    {
        Console.Write(" {0} ", arr[index]);
        currentElement = arr[index];
    }
    index++;
}
Console.WriteLine();
// Исключение элементов больше среднего арифметического массива А

index = 0;
int sum = 0;
for (int i = 0; i < 10; i++)
{
 sum = sum + arr[i];
}
double average = sum / 10;

Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов исходного массива равно ");
Console.WriteLine(average);
Console.WriteLine();
Console.WriteLine("Массив с исключенными элементами больше среднего арифметического элементов массива");
while (index <=9)
{
    if (arr[index] < average)
        
    Console.Write("{0} ", arr[index]);
    index++;
}

// Исключение четных элементов
Console.WriteLine();
Console.WriteLine("Исключили из массива четные элементы");
index = 0;
while (index <= 9)
{
    if(arr[index] % 2 != 0 )
    {
        Console.Write("{0} ", arr[index]);
    
    }
    index++;
}
Console.WriteLine();

