
// // Задача
// // Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// // Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// // возрастания
// // элементы, больше 8
// // знакочередования


int[] arr = new int[10];
       
 
    Console.WriteLine("Исходный массив");
    Console.WriteLine();
    int index = 0;
    for (index = 0; index < 10; index++)
    {
        arr[index] = new Random().Next(-50, 50);
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

// элементы, больше 8
Console.WriteLine("Массив с элементами меньше 8");
index = 0;

while (index <= 9)
{
    if(arr[index] < 8)
    {
        Console.Write(" {0} ", arr[index]);
        currentElement = arr[index];
    }
    index++;
}
Console.WriteLine();

// Массив без элементов, которые нарушают порядок знакочередования
Console.WriteLine("Массив без элементов, которые нарушают порядок знакочередования");
index = 0;
Console.Write(" {0} ", arr[index]);
while (index < 9)
{
    if(arr[index] >= 0)
    {
        index++;
        if(arr[index]<= 0)
        {
            Console.Write(" {0} ", arr[index]);
            
        }
    }
    else
    {
        index++;
        if(arr[index] >= 0)
        {
            Console.Write(" {0} ", arr[index]);
        }
        

    }    
}

Console.WriteLine();

