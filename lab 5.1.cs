//Первым делом - по правилам оформлениям лаб из гитлаба у вас все лабы находятся в одном репозитории, а не каждая лаба в отдельном
//и в этом одном репозитории есть ветка main, ветка develop и ветка для каждого подпункта (main, develop, lab5.1, lab5.2, lab5.3).
//Ты делаешь коммиты только в ветки заданий, а когда уже готово сливаешь сначала в develop потом в main, коммитить в main нельзя.

//Эту лабу я приму как есть, для следующих уже так не прокатит, нужно учиться пользоваться гитом
using System;

namespace Task1
{
    public static class Program
    {
        public static void Main()
        {
            //Значение по умолчанию для previousInput в условии задания дано как double.NaN
            double previousInput = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();
                
                //Делать проверки заранее необязательно, но это не страшно
                bool isInt = int.TryParse(input, out int intNumber);
                bool isDouble = double.TryParse(input, out double doubleNumber);
                if (isInt)
                {
                    Console.WriteLine((char)intNumber);
                    previousInput = intNumber;
                    //Этот break ломает всю логику, после ввода целого числа ввод не должен прекращаться
                    //Здесь правильное ключевое слово continue, хотя и оно не обязательно, ведь ни в один else мы больше не попадем
                    break;
                }
                else if (isDouble)
                {
                    if (doubleNumber == previousInput)
                    {
                        Console.WriteLine("Введенное число равно предыдущему");
                        //То же что про предыдущий break
                        break;
                    }
                    previousInput = doubleNumber;
                }
                else if (input == "q")
                    //А здесь break правильно
                    break;
                //Кстати лучше написать фигурные скобки, по стандарту ты их ставишь либо везде либо нигде

            }

        }
    }
}

