using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class Dingo : Mamifero, ITerrestre
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
