using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class Elefante : Mamifero, IAquatico
    {
        string IAquatico.Mergulhar(Animal animal)
        {
            throw new NotImplementedException();
        }

        string IAquatico.Nadar(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
