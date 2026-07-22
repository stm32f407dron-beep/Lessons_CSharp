
//исполняемый класс
public class Program
{

    /*
     * 
     * Main объявлен как async Task → значит, внутри можно использовать await.

       Вызов CalculateSumAsync(10, 20) возвращает объект Task<int>.

       Оператор await «раскрывает» задачу и возвращает результат (int).

       В итоге в переменной result хранится число 30.


                             📌 Сравнение способов ожидания

      Способ	                             Что возвращает	                  Блокирует поток	Где использовать
      await task	                         Результат (T)	                  ❌ Нет	UI, асинхронный код
      task.Result	                         Результат (T)	                   ✅ Да	Консоль, тесты (но осторожно)
      task.Wait()	                         void (только ждёт)	               ✅ Да	редко, в консоли
      task.GetAwaiter().GetResult()	         Результат (T)                     ✅ Да	низкоуровневый доступ






     * 
     * 
     * 
     */




    public static  Task Main()
    {

        Task<int> sumTask =  CalculateSumAsync(10, 20);
        Console.WriteLine($"Сумма: {sumTask.Result}");
        // возвращаем завершённую задачу
        return Task.CompletedTask;

    }


    static  Task<int> CalculateSumAsync(int a, int b)
    {
        Func<int> func = delegate () { return a + b; };
        //Task.Run — это метод, который запускает делегат (функцию) в отдельном потоке из пула потоков (ThreadPool).
        //Он принимает делегат Action или Func<T> и возвращает объект Task или Task<T>.
        // Внутри создаётся задача, которая выполняется асинхронно.
        return  Task.Run(func);
        //или так : return await Task.Run(delegate() { return a + b; });

    }




}









//Task<int> sumTask = CalculateSumAsync(30, 40);
//sumTask.Wait();

//Console.WriteLine($"  {sumTask.Result}");