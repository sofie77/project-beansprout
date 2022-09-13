using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBeansprout
{
    class Patch
    {

        public IPlant plantedPlant { get; set; }

        public bool IsAvailable { get; set; }


        public void Planting(IPlant plant)
        {
            if (this.plantedPlant == null)
            {
                this.plantedPlant = plant;
                this.IsAvailable = false;

            }
            else
            {
                throw new Exception("patch contains other plant, you have to uproot to plant");
            }

        }

        public Patch()
        {
            this.IsAvailable = true;
        }


    }
}
