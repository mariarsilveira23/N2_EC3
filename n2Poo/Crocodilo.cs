using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class Crocodilo : Reptil, ITerrestre, IAquatico, IOviparo
    {
        string ITerrestre.Andar(Animal animal)
        {
            throw new NotImplementedException();
        }

        string IOviparo.BotarOvo(Animal animal)
        {
            throw new NotImplementedException();
        }

        string IOviparo.ChocarOvo(Animal animal)
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
    }
}
