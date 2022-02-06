using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * задача состоит в том чтобы создать программу для ввода заголовка и текста
 * по госту пользователем и выдачу документа в выбранном формате.
 * с использованием паттерна стратегия.
 * 
 *Гост заголовка: Заголовок должен быть расположен по середине и быть размером 25px и выделен жирным, шрифт open sans
 *Гост текста: текст выровнен по левому краю, шрифт arial
 */


namespace Strategy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentClass doc;
            string head_str="Заголовок"; ;
            string text_str="Какой то текст через программу";
            string choise="1";
            Console.WriteLine("Введите заголовок:");
            head_str = Console.ReadLine();
            Console.WriteLine("Введите текст:");
            text_str = Console.ReadLine();
            Console.WriteLine("В каком формате хотите получить документ?");
            Console.WriteLine("1. docx");
            Console.WriteLine("2. pdf");
            choise = Console.ReadLine();
            doc = new DocumentClass(head_str, text_str, choise);
            doc.Start();
            Console.ReadKey();
        }
    }
}
