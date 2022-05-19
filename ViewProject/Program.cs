using System;
using LibsProject.Models;


namespace Program
{


    class Program
    {


        static void Main(string[] args)
        {
            // чтение конфигурации и т.д.
            
            


            // запуск главного меню
            string[] options = {"Добавить товар", "Реестр", "Выход"};
            Menu main = new(options, "ProductManager v0.1");
            
            main.DisplayMenuOptions();

            Console.WriteLine("\n\nНажмите на любую кнопку для выхода...");
            Console.ReadKey(true);
        }
    }
}