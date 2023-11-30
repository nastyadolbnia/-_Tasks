//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// Запросили длиину массива

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

//обозначаем массив
int [] array = new int [size];
Random rand = new Random();

//заполняем массив

for(int i=0;i<size;i++)
{
    array[i] = rand.Next(1,100);
}

//выводим массив

for(int i=0;i<size;i++)
{
    Console.Write($"{array[i]}\t");
}

Console.WriteLine();

//находим кол-во
int count = 0;
for(int i=0;i<size;i++)
{
    if ((array[i] >= 20) && (array[i] <= 90))
    {
        count ++;
    }
}

//выводим кол-во элементов
Console.WriteLine("Количество элементов в диапазоне " + count);
 