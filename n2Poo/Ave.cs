using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    class Ave : Animal
    {
        private bool rapina;
        private string p_coloracao;
        private int qtd_patas, altitude, vel_voo;

        public bool Rapina
        {
            get
            {
                return rapina;
            }

            set
            {
                rapina = value;
            }
        }

        public string P_coloracao
        {
            get
            {
                return p_coloracao;
            }

            set
            {
                p_coloracao = value;
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
                if (qtd_patas < 2)
                    throw new Exception("Digite um número de patas válido");
                else
                    qtd_patas = value;
            }
        }

        public int Altitude
        {
            get
            {
                return altitude;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Altitude de voo inválida");
                else
                    altitude = value;
            }
        }

        public int Vel_voo
        {
            get
            {
                return vel_voo;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Digite uma velocidade válida");
                else
                    vel_voo = value;
            }
        }
    }
}
