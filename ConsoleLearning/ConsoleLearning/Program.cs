using System.Text;

StringBuilder ref1 = new StringBuilder("object1");
Console.WriteLine(ref1);
// Объект StringBuilder, на который ссылается ref1, теперь пригоден для сборки мусора


StringBuilder ref2 = new StringBuilder("object2");  
StringBuilder ref3 = ref2; /* Объект StringBuilder, на которые ссылается ref2,
                                    пока еще НЕ пригоден для сборки мусора */
Console.WriteLine(ref3);