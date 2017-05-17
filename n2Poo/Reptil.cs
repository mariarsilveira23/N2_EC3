using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class Reptil : Animal
    {
        private int qtd_patas;
        private bool patas;
        private string cor_pele;

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
                    qtd_patas = value;
            }
        }        

        public bool Patas
        {
            get
            {
                return patas;
            }

            set
            {
                patas = value;
            }
        }

        public string Cor_pele
        {
            get
            {
                return cor_pele;
            }

            set
            {
                if (value.Length == 0)
                    throw new Exception("Digite a cor do pele");
                else
                    cor_pele = value;
            }
        }

    }

}
