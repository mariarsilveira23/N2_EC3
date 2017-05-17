using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class CisneNegro : Ave, ITerrestre, IAquatico, IVoador
    {
        string ITerrestre.Andar(Animal animal)
        {
            throw new NotImplementedException();
        }

        string ITerrestre.Correr(Animal animal)
        {
            throw new NotImplementedException();
        }

        string IAquatico.Mergulhar(Animal animal)
        {
            throw new NotImplementedException();
        }

        string IAquatico.Nadar(Animal animal)
        {
            throw new NotImplementedException();
        }

        string ITerrestre.Rastejar(Animal animal)
        {
            throw new NotImplementedException();
        }
    {
    }
string IVoador.Voar(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
