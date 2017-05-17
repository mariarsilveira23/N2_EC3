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
            writer.WriteStartElement("Faculdade");
            writer.WriteElementString("Materia", "Eng. Computação");
            writer.WriteElementString("Materia", "Eng. Alimentação");
            writer.WriteElementString("Materia", "Eng. Mecânica");
            writer.WriteEndElement();
            writer.Close();
            MessageBox.Show("Arquivo XML gerado com sucesso.");
        }
    }
}
