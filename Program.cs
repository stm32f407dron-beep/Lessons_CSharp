
//исполняемый класс
using System.Diagnostics;

public class Program
{
    private static Dictionary<string, int> dict = new();// статическое поле
    
    public static void Main()
    {
        dict.Add("one", 1);
        Console.WriteLine(dict["one"]); // Вывод: 1
        dict["two"] = 2;
        dict["three"] = 3;
        Console.WriteLine(dict["two"]); // Вывод: 2

        Console.WriteLine( $"ключ three  c паролем {dict["three"]}"); // Вывод: 3

        if (dict.TryGetValue("one", out int value))
        {
            Console.WriteLine($"Ключ 'one' найден - {value}");
        }

        //работа с указателями
        int x = 10;
        Console.WriteLine($"Значение x до вызова Pointer: {x}");
        Pointer(x);
        Console.WriteLine($"Введите новое значение для x: {x}");
        Pointer_out(out x);
        Console.WriteLine($"Значение x после вызова Pointer_out: {x}");

        if (dict.TryGetValue("two", out int oneValue)) {Console.WriteLine($"Ключ 'one' найден - {oneValue}"); }


    }

    public static void Pointer(int y) { y = 5; }

    public static void Pointer_out( out int y) { y = 15; }
    // Оставляем нестатическим

}














//Button — источник событий.

//ButtonClickEventArgs — контейнер данных события.

//Program.Button_Click — подписчик, который реагирует.

//Вызов Press() инициирует событие, и управление передаётся подписчику.





//🔎 Краткий механизм работы
//Источник события — класс Button.

//Он содержит событие Click.

//В методе Press() вызывает Click?.Invoke(...).

//Аргументы события — класс ButtonClickEventArgs.

//Это контейнер с данными (сообщение, время).

//Создаётся при вызове события и передаётся подписчику.

//Подписчик — метод Button_Click в классе Program.

//Подписывается на событие через button.Click += Button_Click;.

//Получает уведомление, когда событие вызывается.

//В параметрах получает sender (источник — объект Button) и e (данные события).

//Исполняемый класс — Program.

//Создаёт объект Button.

//Подписывается на событие.

//Вызывает Press(), что инициирует событие.


