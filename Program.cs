// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


using System.Globalization;

string [] CreateArray (int size)// Функция заполнение массива пользователем
{
    string [] array = new string [size];// Создание массива размепром size
    for (int i = 0; i < array.Length; i++) //Перебор массива и заполнение пользователем его
    {
        Console.WriteLine($"Введите строку для элемента массива: {i+1}");
        array [i] = Console.ReadLine();
    }
    return array;//Возвращаем заполненый массив
}

int Memory (string [] array) //Функция для подсчета размера ногово массива
{
    int memory = 0;//счетчик размера
    for (int i = 0; i < array.Length; i++)
    {
        string str = array [i];
        if (str.Length <= 3)//если длина строки меньше или равна 3 символам, то увеличиваем счетчик размера
        {
            memory++;
        }
    }
    return memory;//возращаем счетчик
}

string [] WritingToNewArray (string [] array, string [] newarray) //Заполняем новый массив
{
    int j = 0; // переменныя для перебора нового массива
    for (int i = 0; i < array.Length; i++) //перебор основного массива
    {
        string str = array [i];
        if (str.Length <= 3) // Если символов в строке меньше или равно 3, то записываем в новый массив
        {
            newarray[j] = str;
            j++;
        }
    }
    return newarray;
}

void PrintArray (string [] array) // функция вывода массива через запятую
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write (array[i] + ", ");
    }
    Console.WriteLine ();

}




Console.Write ("Введите длину массива:");//Запрос размера массива
int size = Convert.ToInt32( Console.ReadLine ());
string [] array = CreateArray (size);// Создание массива размером size
Console.WriteLine ("Вы ввели следующий массив:");
PrintArray (array);// Выводим введенный массив
string [] newarray = new string [Memory(array)]; //новый массив с размером = результату функции Memory
Console.WriteLine ("Результат:"); //Вывод результата
PrintArray (WritingToNewArray(array, newarray));
