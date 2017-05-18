using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace n2Poo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter(@"teste.xml", null);

            writer.WriteStartDocument();
            writer.WriteStartElement("Animal");
            writer.WriteElementString("Nome", "Gustavo Ferreira");
            writer.WriteElementString("Idade", "3 anos");
            writer.WriteElementString("Especie", "Mamífero");
            writer.WriteElementString("Nome", "Mary");
            writer.WriteElementString("Idade", "2 anos");
            writer.WriteElementString("Especie", "Reptil");
            writer.WriteEndElement();
            writer.Close();
            MessageBox.Show("Arquivo XML gerado com sucesso.");

            Lista lstXML = new Lista();

            XmlDocument oXML = new XmlDocument();

            XmlTextReader reader = new XmlTextReader(@"teste.xml");

            string ArquivoXML = @"teste.xml";
            //carrega o arquivo XML
            oXML.Load(ArquivoXML);

            //Lê o filho de um Nó Pai específico 
            for(int cont1 = 0; cont1 < animais.qtd; cont1++)
            {
                for(int cont2 = 0; cont2 < qtd.propriedades; cont2++)
                {
                    string nomeAluno = oXML.SelectSingleNode("Animal").ChildNodes[0].InnerText;
                    string idadeAluno = oXML.SelectSingleNode("Animal").ChildNodes[1].InnerText;
                    string emailAluno = oXML.SelectSingleNode("Animal").ChildNodes[2].InnerText;
                }
            }
            

            lstXML.InserirNoInicio(nomeAluno);
            lstXML.InserirNoInicio(idadeAluno);
            lstXML.InserirNoInicio(emailAluno);

            foreach (var num in lstXML)
            {
                MessageBox.Show(num.ToString());
            }


        }
    }
}
