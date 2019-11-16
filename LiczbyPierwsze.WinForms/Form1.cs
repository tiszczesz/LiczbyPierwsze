using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiczbyPierwsze.Main;

namespace LiczbyPierwsze.WinForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGener_Click(object sender, EventArgs e) {
            int dolny = Convert.ToInt32(tbDolny.Text);
            int gorny = Convert.ToInt32(tbGorny.Text);
            PrimaryNumbers pn = new PrimaryNumbers();
            var liczby = pn.ShowPrimaryNumbers(dolny, gorny);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ilość liczb pierwszych: " + liczby.Count);
            foreach (int i in liczby) {
                sb.Append(i.ToString() + " ");
            }

            tbWynik.Text = sb.ToString();
            lbWynik.Text = liczby.Count.ToString();
        }
    }
}
