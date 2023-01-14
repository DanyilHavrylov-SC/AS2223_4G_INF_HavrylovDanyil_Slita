using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_HavrylovDanyil_SlitaLibrary
{
    class Gift
    {
        string description, color;
        double weight, volume;
        public Gift(string description, string color, double weight, double volume)
        {
            this.description = description;
            this.color = color;
            this.weight = weight;
            this.volume = volume;
        }
    }
}
