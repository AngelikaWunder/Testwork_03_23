// See https://aka.ms/new-console-template for more information
// Написать программу, которая из имеющегося массива строк
//  формирует массив из строк, длина которых меньше или равна 3 символа.
Console.WriteLine("Введите несколько слов через запятую: ");
string text = Console.ReadLine();
string[] data = text.Split(", ");


for(int i=0; i < data.Length; i++)
{
    Console.Write($"{data[i]}, ");
}



