// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше "0" ввёл пользователь.

Console.WriteLine("Введите числа (если хотите завершить ввод нажмите точку): ");
string numbers = Console.ReadLine(); 
int count = 0; // счётчик
while (numbers != ".") // пока не будет введена точка
{
    if (Convert.ToInt32(numbers) > 0) // число больше ноля или нет
        count++; // прибавляем счётчик
    numbers = Console.ReadLine(); // ввод нового числа после проверки
}
Console.Write(count); // вывод решения