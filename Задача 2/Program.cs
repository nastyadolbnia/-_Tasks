//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

//запрашиваем размер массива

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());

//задаем массив

int [] array = new int[size];
Random rand = new Random();

//заполняем массив

for(int i=0;i<size;i++)
{
    array[i] = rand.Next(1,11);
}

//выводим массив

for(int i=0;i<size;i++)
{
    Console.Write($"{array[i]}\t");
}

Console.WriteLine();

//ищем кол-во четных чисел

int count = 0;
for(int i=0;i<size;i++)
{
    if(array[i]%2==0)
    {
        count ++;
    }    
}

//выводим кол-во

Console.WriteLine("Количество четных чисел в диапазоне " + count);
