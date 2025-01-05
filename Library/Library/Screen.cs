using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Screen
{
    public void MainScreen()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Виберіть дію:\r\n" +
            "1 - Додати книгу\r\n" +
            "2 - Пошук книг\r\n" +
            "3 - Сортування книг\r\n" +
            "4 - Групування книг\r\n" +
            "5 - Статистика\r\n" +
            "6 - Показати всі книги\r\n" +
            "0 - Вихід");
    }
}
