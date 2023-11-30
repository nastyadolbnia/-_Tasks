//Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
//Размер массива должен быть равен количеству цифр.

using System.Collections;

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if(a>=1&& a<=1000)
{
    string s = a.ToString();
    int DigitsNumber = s.Length;
    
    int [] myarray = new int[DigitsNumber];
    for(int i=0;i<DigitsNumber;i++)
    {
        myarray[i] = Convert.ToInt32(s.Substring(i,1));
    }

    Array.Reverse(myarray);

Console.WriteLine(string.Join("", myarray));
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}





