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

namespace BBLevelEditor
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }






        private void buildButton_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("Resources/level.xml", null);
            writer.WriteStartElement("Bricks");
            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    string x = Convert.ToString(c.Location.X);
                    string y = Convert.ToString(c.Location.Y);
                    string hp = c.Text;
                    string colour = Convert.ToString(c.BackColor);

                    writer.WriteStartElement("Brick");
                    writer.WriteElementString("x", x);
                    writer.WriteElementString("y", y);
                    writer.WriteElementString("hp", hp);
                    writer.WriteElementString("colour", colour);

                    writer.WriteEndElement();
                }
            }
            writer.WriteEndElement();
            writer.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button108_Click(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {

        }

        private void button68_Click(object sender, EventArgs e)
        {

        }
    }
}
