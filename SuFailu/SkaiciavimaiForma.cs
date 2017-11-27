using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuFailu
{
    public partial class SkaiciavimaiForma : Form
    {
        public SkaiciavimaiForma(List<Darbuotojas> darbuotojai)
        {
            InitializeComponent();
            textBox1.Text = Vidurkis(darbuotojai).ToString();
        }

        public double Vidurkis(List<Darbuotojas> darbuotojai)
        {
            double vid_vidurkis = 0;
            foreach (var Atlyginimas in darbuotojai)
            {
                vid_vidurkis += Atlyginimas.Alga;
            }

            return vid_vidurkis / darbuotojai.Count();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
