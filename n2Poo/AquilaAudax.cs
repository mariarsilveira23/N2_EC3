using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class AquilaAudax : Ave, IOviparo, IVoador
    {
        string IOviparo.BotarOvo(Animal animal)
        {
            throw new NotImplementedException();
        }

        string IOviparo.ChocarOvo(Animal animal)
        {
            throw new NotImplementedException();
        }

        string IVoador.Voar(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
