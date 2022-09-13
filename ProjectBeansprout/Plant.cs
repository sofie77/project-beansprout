using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBeansprout
{
    class Plant
    {
        public string colour = "green";
        public void grow()
        {
            Console.WriteLine("growing");
        }
        public int count()
        {
            return 1;
        }
    }
}
