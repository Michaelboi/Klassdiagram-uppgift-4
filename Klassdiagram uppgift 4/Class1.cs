using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassdiagram_uppgift_4
{
    public class Animal
    {
        private string name;
        private int age;
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public class Dog : Animal
        {
            private int svanslängd;

            public int getsvanslängd()
            {
                return this.svanslängd;
            }
            public void setsvanslängd(int svanslängd)
            {
                this.svanslängd = svanslängd;
            }
            public void Bark()
            {
                Console.WriteLine("woof");
            }
        }
    }
    
}
