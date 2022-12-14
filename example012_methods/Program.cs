//Вид 1
void Method1()
{
    Console.WriteLine(" Автор ");
}

Method1();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("asdasd");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("tekst",4);
Method21(count: 4, msg: " new tekst");

//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

Console.WriteLine(Method3());

//Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = "";
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = "";
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "qwerty ");
Console.WriteLine(res);

for(int i =2;i<=10;i++){
    for(int j =2;j<=10;j++){
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

// Задача

string text = " - Я думаю Бла бла бла "
            + " Чего то кого ТОООО";

string Replace(string text, char oldValue, char newValue){
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++) {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
Console.WriteLine(Replace(text,' ','-'));

