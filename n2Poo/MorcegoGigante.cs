using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class MorcegoGigante : Mamifero, IVoador
    {
        string IVoador.Voar(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
