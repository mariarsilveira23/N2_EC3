using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    public class ComparadorCodigo : IComparer
    {
        public int Compare(object x, object y)
        {
            string codigoX = ((Animal)x).Nome;
            string codigoY = (y as Animal).Nome;

            //return codigoX.CompareTo(codigoY);

            if (codigoX.CompareTo(codigoY) > 0 )
                return 1;
            else if (codigoX.CompareTo(codigoY) == 0)
                return 0;
            else
                return -1;

            //return (((Funcionario)x).Codigo).CompareTo(((Funcionario)y).Codigo);
        }
    }
}
