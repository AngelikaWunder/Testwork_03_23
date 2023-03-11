// See https://aka.ms/new-console-template for more information
// Написать программу, которая из имеющегося массива строк
//  формирует массив из строк, длина которых меньше или равна 3 символа.
Console.WriteLine("Введите несколько слов через запятую: ");
string text = Console.ReadLine();
string[] data = text.Split(", ");

string[] ArrayOfWordsWith3Simbols (string[] words)
{
    int count=0;
     for (int i=0; i < words.Length; i++)
     {
         if (words[i].Length < 4) count++;
     }
    string[] wordsThree = new string[count];
    int j =0;
    for (int i=0; i < words.Length; i++)
    {
        if (words[i].Length < 4)
        {
            wordsThree[j] = words[i];
            if (j < count-1) j++;
            
        }
    }
    return wordsThree;
}

string[] words3Simbols = ArrayOfWordsWith3Simbols (data);
Console.WriteLine("новый массив -> " + String.Join(", ", words3Simbols));

//for(int i=0; i < words3Simbols.Length; i++)
//{
    //Console.Write($"{words3Simbols[i]}, ");
//}



