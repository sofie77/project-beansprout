using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBeansprout
{
    public interface IPlant
    {
        string Type { get; set; }
        void Grow();

    }

}
