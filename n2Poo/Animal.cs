using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2Poo
{
    // ||
    class Animal
    {
        private string nome, alimentacao;
        private char sexo;
        private bool venenoso, terrestre;
        private DateTime dt_nasc;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (value.Length == 0)
                    throw new Exception("Digite um nome");
                else
                    nome = value;
            }
        }

        public DateTime Dt_nasc
        {
            get
            {
                return dt_nasc;
            }

            set
            {
                try
                {
                    if (Convert.ToDateTime(value) > DateTime.Now)
                        throw new Exception("Digite uma data de nascimento válida");
                    else
                        dt_nasc = value;
                }
                catch
                {
                    throw new Exception("Digite a data de nascimento corretamente");
                }                
            }
        }

        public string Alimentacao
        {
            get
            {
                return alimentacao;
            }

            set
            {
                alimentacao = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public bool Venenoso
        {
            get
            {
                return venenoso;
            }

            set
            {
                venenoso = value;
            }
        }

        public bool Terrestre
        {
            get
            {
                return terrestre;
            }

            set
            {
                terrestre = value;
            }
        }
    }
}
