//==== Вид 1   -НЕ принемаю не каких аргументов и НЕ возвращают ============================

void Methood1()
{
    Console.WriteLine("Атор ...");
}
//Methood1();    

//========= Вид 2   -Принимает аргументы, но НЕ возвращают============================

void Methood2(string msg)
{
    Console.WriteLine(msg);
}
//Methood2("Текст сообщения");

//============ второй Вид 2.1===============================================


void Methood21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;                          // i++ Увеличения счетчика на единицу называют -инкрементом
    }                                 // i-- Уменльшение счетчика на единицу называют -деккриментом
}
//Methood21("Текс", 4);  //повторения слова Текст 4раза
//Methood21(msg: "Текс",count: 4);  // Именованое аргкменты 
//Methood21(count: 4, msg: "Текс");  // или так Именованое аргукменты 

                                      // Зациклевания программы  -исправление Ctrl +C 

//===== Вид 3   - НЕ принемает аргумент, но ВОЗВРАЩАЕТ  Могут генирировать какието случайные даные=================

int Methood3()
{
    return DateTime.Now.Year;
}

//int year = Methood3();
//Console.WriteLine(year);

//====== Вид 4   - что-то Принимоют какие-то аргументы(даные) и ВОЗВРАЩАТЬ для дольнейшей работы.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//string res = Method4(5, "Z");
//Console.WriteLine(res);            // ZZZZZ  _Z повторится count-раз.(string res = Method4(5, "Z"))

string Method41(int count, string text)
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)      // for
    {
        result = result + text;
    }
    return result;
}

//string res = Method41(5, "Z");
//Console.WriteLine(res);




