using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Задание_10_Практикум_12
{

    public class Commercial : Software
    {

        string Creator;
        decimal Price;
        DateTime DateOfInstall;
        int TermOfUse;
        double LastDays;

        public Commercial(string Name, string Creator, decimal Price, DateTime DateOfInstall, int TermOfUse)
        {
            this.Creator = Creator;
            this.DateOfInstall = DateOfInstall;
            this.Name = Name;
            this.Price = Price;
            this.TermOfUse = TermOfUse;
            this.LastDays = this.DateOfInstall.AddDays(this.TermOfUse).Subtract(DateTime.Now).TotalDays;
        }

        public override void Show()
        {
            Console.WriteLine("Name: {0}\nCreator: {1}\nPrice: {2}\nDateOfInstall: {3}\nTermOfUse: {4}\n",
                Name, Creator, Price, DateOfInstall, TermOfUse);
        }

        public override bool isLicenseOver()
        {
            if (DateTime.Now >= DateOfInstall.AddDays(TermOfUse))
            {
                Console.WriteLine("Buy now complete edition!");
                return true;
            }
            else
                Console.WriteLine("You have {0} days", (DateOfInstall.AddDays(TermOfUse).Subtract(DateTime.Now)).TotalDays);
            return false;
        }

        public static void isLicenseOverMas(Commercial[] commercial)
        {
            for (int i = 0; i < commercial.Length; i++)
                if (DateTime.Now >= commercial[i].DateOfInstall.AddDays(commercial[i].TermOfUse))
                    commercial[i].Show();
        }
    }
}
