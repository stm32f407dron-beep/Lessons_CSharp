
//исполняемый класс
public class Program
{
    private static Button button  = new Button(); // статическое поле
    
    public static void Main()
    {

        
        // Подписываемся на событие Click через экземпляр
        button.Click += Button_Click;
       

        // "Нажимаем" кнопку
        button.Press();
        
    }
    // Оставляем нестатическим
    public static void Button_Click(object sender, ButtonClickEventArgs e)
    {
        Console.WriteLine($"Сообщение: {e.Message}, Время: {e.ClickTime}, Отправитель: {sender}");

        if (button == sender) { Console.WriteLine($"button являеться sender"); } else {Console.WriteLine($"button не являеться sender"); }
      

    }
}




// класс Button — это источник событий. 
public class Button
{
    // Делегат описывает метод-обработчик
    public delegate void ClickEventHandler(object sender, ButtonClickEventArgs e);

    // Событие, основанное на делегате
    public event ClickEventHandler? Click;

    // Метод, который "нажимает" кнопку
    public void Press()
    {
        // Вместо EventArgs.Empty передаём свои данные
        Click?.Invoke(this, new ButtonClickEventArgs());
    }
}






// Класс ButtonClickEventArgs — это просто контейнер для данных события.
public class ButtonClickEventArgs 
{
    public string Message { get; } = "Триггер";
    public DateTime ClickTime { get; }

    public ButtonClickEventArgs()
    {
       
        ClickTime = DateTime.Now;
    }
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


