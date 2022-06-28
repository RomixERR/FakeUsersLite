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
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Name:\t{fakeUser.GetFullName(),-35}\tPhone:\t{fakeUser.GetPhone()}\tPasport:\t{fakeUser.GetPasport()}");
            }
            Console.ReadKey();
        }
    }
}
