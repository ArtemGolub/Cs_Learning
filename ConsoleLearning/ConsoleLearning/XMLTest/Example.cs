/// <summary>
/// Этот класс демонстрирует работу XML-комментариев.
/// </summary>
public class Example
{
    /// <summary>
    /// Суммирует два числа.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Сумма двух чисел.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Возвращает имя пользователя.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <returns>Имя пользователя.</returns>
    /// <exception cref="ArgumentException">Выбрасывается, если userId меньше 1.</exception>
    public string GetUserName(int userId)
    {
        if (userId < 1)
        {
            throw new ArgumentException("Идентификатор пользователя должен быть больше 0.");
        }

        return "User Name"; // Заглушка
    }
}