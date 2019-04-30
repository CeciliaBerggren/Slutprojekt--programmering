using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slutprojekt2
{
    public partial class Form1 : Form
    {
        bool turn = true; //true= X tur, False= Y tur
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X"; 
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false; //gör så att man inte kan trycka på de rutorna som redan är tagna

            kolla_vinnare();
        }

        private void kolla_vinnare() //kollar om det finns en vinnare
        {
            bool vunnit = false;

            //horisontella kombinationer för vinst
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
                vunnit = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                vunnit = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                vunnit = true;


            if (vunnit)//skriver ut vem som vann spelet
            {
                string vinnare = "";
                if (turn)
                    vinnare = "O";
                else
                    vinnare = "X";

                MessageBox.Show(vinnare + " Vann!");
            }

        }
    }
}
