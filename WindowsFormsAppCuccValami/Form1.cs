using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCuccValami
{
    public partial class Form1 : Form
    {
        int sorokSzama = 3;
        int oszlopokSzema = 6;
        int buttonSize = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzema; j++)
                {
                    Button button=new Button();
                    button.SetBounds(j*buttonSize,i*buttonSize,buttonSize,buttonSize);
                    button.Text = (i * oszlopokSzema + j).ToString();
                    button.Click += (o, ev) =>
                    {
                        Button gomb = (Button)o;
                        gomb.BackColor=Color.Red;
                        MessageBox.Show(gomb.Text);
                    };
                    tarolo.Controls.Add(button);                   
                }
            }
        }
    }
}
