using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ProjectBeansprout
{
    class Patches
    {

        public IList<Plant> plantedVeg;
        public IList<Patch> plantablePatches;



        public Patches()
        {
            plantedVeg = new List<Plant>();
            plantablePatches = new List<Patch>();
        }
       /* public bool Plant(Plant item)
        {
            if(plantedVeg.Count <= 8)
            { 
                plantedVeg.Add(item);
                Console.WriteLine("planted");
            }else
            {
                Console.WriteLine("patches are full, you must uproot to fit more");
            }
           
        }*/


        //get count of available patches
        public int findPatchCount(Plant plant)
        {
            return this.plantablePatches.Count(plant => plant.IsAvailable);
        }

        public int count()
        {
            var count = 0;

            foreach (var item in plantedVeg)
            {
                count++;

            }
            return count;
        }
    }
}
