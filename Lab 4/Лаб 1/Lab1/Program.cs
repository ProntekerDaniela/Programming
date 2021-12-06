using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    public class ClassCompany
    {
        public int Id { get; set; }
        public string Name_of_company { get; set; }
    }
    public class Company
    {
        public string Name_of_company { get; set; }
        public int Number_of_employees { get; set; }
        public string Product_name { get; set; }
        public string Country { get; set; }
       
    }
    class Program
    {
        static async void Main(string[] args)
        {
            await Task.Run(() => { 
            var classCompany = new List<ClassCompany>()
            {
                new ClassCompany()
                {
                    Id = 1,
                    Name_of_company = "ТОВ «ЕПАМ СИСТЕМЗ»"
                },
                new ClassCompany()
                {
                    Id = 2,
                    Name_of_company = "ПІІ «ТОЙОТА-УКРАЇНА»"
                },
                new ClassCompany()
                {
                    Id = 3,
                    Name_of_company = "ТОВ «БАЙЄР»"
                },
                new ClassCompany()
                {
                    Id = 4,
                    Name_of_company = "ТОВ «ІНФОПУЛЬС УКРАЇНА»"
                },
                new ClassCompany()
                {
                    Id = 5,
                    Name_of_company = "ПАТ «СЛОВ'ЯНСЬКІ ШПАЛЕРИ -КФТП»"
                },
            };
            var company = new List<Company>()
            {
                new Company()
                {
                    Name_of_company = "ТОВ «ЕПАМ СИСТЕМЗ»",
                    Number_of_employees = 60000,
                    Product_name = "Комп’ютерне програмування",
                    Country = "Україна"

                },
                new Company()
                {
                    Name_of_company = "ПІІ «ТОЙОТА-УКРАЇНА»",
                    Number_of_employees = 10500,
                    Product_name = "Торгiвля автомобiлями та легковими автотранспортними засобами",
                    Country = "Україна"
                },
                new Company()
                {
                    Name_of_company = "ТОВ «БАЙЄР»",
                    Number_of_employees = 12300,
                    Product_name = "Оптова торгiвля хiмiчними продуктами",
                    Country = "Україна"
                },
                new Company()
                {
                    Name_of_company = "ТОВ «ІНФОПУЛЬС УКРАЇНА»",
                    Number_of_employees = 45000,
                    Product_name = "Комп’ютерне програмування",
                    Country = "Україна"
                },
                new Company()
                {
                    Name_of_company = "ПАТ «СЛОВ'ЯНСЬКІ ШПАЛЕРИ -КФТП»",
                    Number_of_employees = 26000,
                    Product_name = "Виробництво шпалер",
                    Country = "Україна"
                }
            };
            var c = company[1];
            var info = company
                .Join(classCompany,
                    c => c.Name_of_company,
                    n => n.Id,
                    (c, n) => new
                    {
                        Name_of_company = c.Name_of_company,
                        Number_of_employees = n.Name_of_company,
                        Product_name = c.Product_name,
                        Country = c.Country
                    });
            
            ReadWriteAsync();
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(info));
            Console.ReadKey();
            }
        }
    }
}
