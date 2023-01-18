using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeUsersLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FakeUser fakeUser = new FakeUser(FakeUser.Egender.Female);
            Console.WriteLine("Имена и данные людей (женские):");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Name:\t{fakeUser.GetFullName(),-35}\tPhone:\t{fakeUser.GetPhone()}\tPasport:\t{fakeUser.GetPasport()}\tEmail:\t{fakeUser.GetEmail()}");
            }
            Console.WriteLine();

            fakeUser.Gender = FakeUser.Egender.Animal;
            Console.WriteLine("Имена животных:");
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{fakeUser.GetFName(),-12}\t");
                if (i % 5 == 0) Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            fakeUser.Gender = FakeUser.Egender.Thing;
            Console.WriteLine("Названия предметов:");
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{fakeUser.GetFName(),-12}\t\t");
                if (i % 5 == 0) Console.WriteLine();
            }

            Console.WriteLine("Emails:");
            List<string> listEmails = fakeUser.GetEmails(10);
            foreach (var item in listEmails)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
