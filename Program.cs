// Задача3: Напишите програму, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// Например: 5 -> 2, 4; 8 -> 2, 4, 6, 8



Console.WriteLine("Введите число");                         //Вводим любое число
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();                                        //Создаем пустую строку для выделения ответа
int start = 1;


while(start <= number)                                      //Ищет четные числа и записывает
{
    if(start % 2 == 0)
    Console.WriteLine(start);
    start++;
}