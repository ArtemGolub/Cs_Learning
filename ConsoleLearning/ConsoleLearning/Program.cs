using ConsoleLearning.SpecialTypes;

Action<int> printSquare = x => Console.WriteLine(x * x); /* Создаем Action где
                                                int = входное значение,
                                              никакого выхода (void), он просто выполняет действие */

void ExecuteAction(Action<int> action, int value) => action(value); /* Вызываем Action
                                                с указываемым параметром int value */

ExecuteAction(printSquare, 4); // Вызываем Action printSquare

