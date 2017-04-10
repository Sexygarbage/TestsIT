using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Classes;
using TestApplication.Helpers;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new PaidService[]{ new FixedHourlyCostPaidService("service1", "Google Orkut", 11),
                                    new FixedHourlyCostPaidService("service2", "Google Voice", 9.4),
                                    new FixedMonthlyCostPaidService("service5", "YouTube", 8064),
                                    new FixedHourlyCostPaidService("service3", "Mandrill", 11.2),
                                    new FixedHourlyCostPaidService("service4", "Google Finance", 7.8),
                                    new FixedMonthlyCostPaidService("service7", "Google Building Maker", 5347),
                                    new FixedMonthlyCostPaidService("service6", "LinkedIn", 6863),
                                };
            //1.Вывести id, name и среднемесячные затраты для всех элементов массива. Вывод должен
            //быть упорядочен по убыванию среднемесячных затрат. При совпадении суммы затрат –
            //упорядочивать данные по названию сервиса(в алфавитном порядке от "a" до "z").

            //var newArray = from n in array
            //               orderby n.calculateAverageMonthlyCosts() descending, n.name ascending
            //               select n;

            Func<PaidService,double> lambdaCalculateAverageMonthlyCosts = a => a.calculateAverageMonthlyCosts();

            var newArray = array
                .OrderByDescending(lambdaCalculateAverageMonthlyCosts)
                .ThenBy(a => a.name);

            foreach (var item in newArray)
                Console.WriteLine(item);

            //{
            //    var newArray = array;


            //    foreach (var item in newArray)
            //        Console.WriteLine(item);
            //}

            //2.Вывести первые 5 значений свойства name элементов из упорядоченного списка в пункте(1).
            foreach (var item in newArray.Take(5))
                Console.WriteLine(item.name);
            array.Count();
            //3.Вывести последние 3 значения свойства id элементов из упорядоченного списка в пункте(1).
            foreach (var item in newArray.Skip(newArray.Count() - 3))
                Console.WriteLine(item.id);
            //4.Сравнить среднемесячные затраты на сервисы YouTube и Mandrill.Вывести сравниваемые
            //сервисы в порядке убывания затрат или два сервиса в одну строку через слеш(/), если
            //затраты равны.
          
            Console.WriteLine("==============================================");
            Console.Write(zad4(array, lambdaCalculateAverageMonthlyCosts));

        }

        public static StringBuilder zad4(PaidService[] array, Func<PaidService, double> selector)
        {
            var output = new StringBuilder();

            var groupResult = array
                .GroupBy(selector)
                .Where(z => z.Count() > 1);

            if (groupResult.Count() < 1)
            {
                foreach (var itemGroupByDescending in array.OrderByDescending(selector))
                    output.AppendLine(itemGroupByDescending.name);                
            }
            else
            {                
                foreach (var itemGroupByCalculateAverageMonthlyCosts in groupResult)
                {
                    foreach (var item in itemGroupByCalculateAverageMonthlyCosts)
                        output.Append(item.name + " / ");
                    output.Append("\n");
                }
                output.Replace(" / \n", "\n");
            }
            return output;
        }
    }

   
}
