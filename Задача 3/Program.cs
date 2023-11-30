//Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива

//заправшиваем длину массива

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());

//задаем массив

double [] array = new double[size];
Random rand = new Random();

//заполняем массив

for (int i=0;i<size;i++)
{
    double x = rand.NextDouble()*10;
    if (x != Math.Truncate(x)&&x!=0)
    {
        array[i] = Math.Round(x,2);
    }
    else
    { 
        i--;
    }
}
//выводим массив

foreach(double element in array)
{
    Console.Write($"{element}\t ");
}
Console.WriteLine();

//Находим максимальный и минимальный элемент

double max = array[0];
double min = array[0];
for (int i=1;i<size;i++)
{
    if(array[i]>max)
    {
    max=array[i];
    }
}

for (int i=1;i<size;i++)
{
    if(array[i]<min)
    {
        min=array[i];
    }
}

//Ищем разницу

double diff =Math.Round((max-min),2);

//Выводим результат

Console.WriteLine($"Разница между элементами составляет {diff}");