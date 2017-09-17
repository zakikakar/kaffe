using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    /// <summary>
    /// Abstract klasse som alle kaffer nedarver fra
    /// </summary>
    public abstract class Kaffe
    {
        public abstract int Pris();
        
        /// <summary>
        /// Angiver hvor stærk kaffe er. 
        /// Sættes default til "stærk"
        /// </summary>
        /// <returns></returns>
        public virtual string Styrke()
        {
            return "stærk";
        }

        /// <summary>
        /// rabat der gives på kaffen
        /// </summary>
        public int Rabat { get; set; }


        public Kaffe()
        {
            //this.Rabat = 0;
        }

        public Kaffe(int rabat)
        {
            this.Rabat = rabat;
        }


    }
}
