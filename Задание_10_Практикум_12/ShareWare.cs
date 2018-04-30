using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Задание_10_Практикум_12
{
    public class ShareWare : Software
    {
        string Creator;
        DateTime DateOfInstall;
        DateTime License;
        double LastDays;

        public ShareWare(string Name, string Creator, DateTime DateOfInstall, DateTime License)
        {
            this.Creator = Creator;
            this.DateOfInstall = DateOfInstall;
            this.Name = Name;
            this.License = License;
            this.LastDays = DateOfInstall.Subtract(License).TotalDays;
        }

        public override void Show()
        {
            Console.WriteLine("Name: {0}\nCreator: {1}\nDateOfInstall: {2}\nLicense: {3}\n",
                Name, Creator, DateOfInstall, License);
        }
        
        public override bool isLicenseOver()
        {
            if (DateOfInstall.Subtract(License).TotalDays <= 0)
            {
                Console.WriteLine("Buy now complete edition!");
                return true;
            }
            else
                Console.WriteLine("You have {0} days", DateOfInstall.Subtract(License).TotalDays);
            return false;
        }

        public static void isLicenseOverMas(ShareWare[] shareWare)
        {
            for (int i = 0; i < shareWare.Length; i++)
                if (shareWare[i].DateOfInstall.Subtract(shareWare[i].License).TotalDays >= 0)
                    shareWare[i].Show();
        }
    }
}
