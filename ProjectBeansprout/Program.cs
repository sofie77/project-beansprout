using System;

namespace ProjectBeansprout
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrot mypal = new Carrot();
            Patches mypatch = new Patches();


            mypatch.plant(mypal);
            mypatch.plant(mypal);

            // why is it not throwing expeption when its over 8???? halp



        }
    }
}
