using System;
using System.IO;

namespace Задание_10_Практикум_12
{
    public abstract class Software : IComparable
    {
        public string Name;

        public abstract void Show();

        public abstract bool isLicenseOver();

        public string getName() { return this.Name; }

        public void setName(string Name) { this.Name = Name; }

        public int CompareTo(object obj)
        {
            Software b = (Software)obj;
            if (this.Name == b.Name)
            {
                return 0;
            }
            else
            {
                if (this.Name.CompareTo(b.Name) < 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

    }
}
