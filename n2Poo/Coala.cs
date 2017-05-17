using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class Coala : Mamifero, ITerrestre
    {
        string ITerrestre.Andar(Animal animal)
        {
            throw new NotImplementedException();
        }

        string ITerrestre.Correr(Animal animal)
        {
            throw new NotImplementedException();
        }

        string ITerrestre.Rastejar(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
