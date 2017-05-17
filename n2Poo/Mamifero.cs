using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class Mamifero : Animal
    {
        private int qtd_mamas, qtd_patas;
        private bool pelo, marsupial;
        private string cor_pelo;

        public int Qtd_mamas
        {
            get
            {
                return qtd_mamas;
            }

            set
            {
                if (value < 2)
                    throw new Exception("Número de mamas inválido");
                else
                    qtd_mamas = value;
            }
        }

        public int Qtd_patas
        {
            get
            {
                return qtd_patas;
            }

            set
            {
                if (value < 2)
                    throw new Exception("Número de patas inválido");
                else
                    qtd_mamas = value;
            }
        }

        public bool Pelo
        {
            get
            {
                return pelo;
            }

            set
            {
                pelo = value;
            }
        }

        public bool Marsupial
        {
            get
            {
                return marsupial;
            }

            set
            {
                marsupial = value;
            }
        }

        public string Cor_pelo
        {
            get
            {
                return cor_pelo;
            }

            set
            {
                if (value.Length == 0)
                    throw new Exception("Digite a cor do pelo/pele");
                else
                    cor_pelo = value;
            }
        }

    }
}
