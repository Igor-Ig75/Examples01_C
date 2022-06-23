//int numberA = 45;
//int numberB = 23;
//Console.WriteLine(numberA + numberB); первый вариан 
//int result = numberA + numberB; второй вариан
//Console.WriteLine(result);
int numberA = new Random() .Next(1, 10); // 1 2 3 4...9
Console.WriteLine(numberA);
int numberB = new Random() .Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);