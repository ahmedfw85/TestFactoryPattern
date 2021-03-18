using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryPattern
{
    static class Factory
    {
        public static Position Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new Manager();
                case 1:
                    return new Clerk();
                default:
                    return new Programmer();
            }
        }
    }
}
