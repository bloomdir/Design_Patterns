using Strategy1.Services;
using Strategy1.Services.HairCut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy1.Peaples
{
    internal class Man:Human
    {
        public Man()
        {
            IHairCutBehaviour hair_cut = new YesHairCut();
            
        }
    }
}
