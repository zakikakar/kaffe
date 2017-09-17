using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class SortKaffe : Kaffe

    {
        public override int Pris()
        {
            int prismedrabat = 20 - Rabat;

            if (prismedrabat <= 0)
                throw new ArgumentException("Uppss du gav for meget rabat");

            return prismedrabat;
        }

        public SortKaffe()
            :base()
        {
        }

        public SortKaffe(int rabat)
            :base(rabat)
        {

        }

    }
}
