// Написать программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// ["hello","2", "world", ":)"] -> ["2", ":)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


Console.WriteLine("Enter a string array separated by space");
string[] arr = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string [] newarray = GetArray(arr);
Console.WriteLine($"[{String.Join(",", newarray)}]"); 

string [] GetArray(string[] inArray)
{
    string[] stringArray = new string[SizeNewArray(inArray)];
    int count =0;
    foreach(var element in inArray)
    {
        if(element.Length<4)
        {
            stringArray[count]= element; 
            count++;
        }
        
    }
    return stringArray;
}

int SizeNewArray (string[] inArray)
{
    int size = 0;
    foreach(var element in inArray )
    {
        if(element.Length<4)
        {
            size++;
        }
    }
    return size;
}
