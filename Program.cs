
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




    public static async Task Main()
    {

        int result = await CalculateSumAsync(10, 20);
        Console.WriteLine($"Сумма: {result}");

    }


    static async Task<int> CalculateSumAsync(int a, int b)
    {
        return await Task.Run(() => a + b);
    }




}









//Task<int> sumTask = CalculateSumAsync(30, 40);
//sumTask.Wait();

//Console.WriteLine($"  {sumTask.Result}");