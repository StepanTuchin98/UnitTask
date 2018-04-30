using System;
using System.IO;

namespace Задание_10_Практикум_12
{
    public class Free : Software
    {
        
        string Creator;
        public Free(string Name, string Creator)
        {
            this.Name = Name;
            this.Creator = Creator;
        }
        public override void Show()
        {
            Console.WriteLine("Name: {0}\nCreator: {1}\n", Name, Creator);
        }
        public override bool isLicenseOver()
        {
            Console.WriteLine("Not yet!");
            return true;
        }
        public static void isLicenseOverMas(Free[] free)
        {
            for (int i = 0; i < free.Length; i++)
                free[i].Show();
        }
        
    }
}
