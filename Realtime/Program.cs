using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parminent employee= new Parminent();
            var ListOfAvalibleItems = employee.ShowOnlyPeminentEmp();
            User user = new User();
            user.Id = 100;
            user.Name = "Chinna";

            if (user.Id == 10 && user.Name.ToLower() == "raghav")
            {
                CommonClass.DisplayResult(ListOfAvalibleItems);
            }
            else
            {
                Console.WriteLine("Items doesn't exit in store.");
            }
            Console.ReadLine();
        }
    }
}
