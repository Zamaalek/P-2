using System.Collections;
using System.Resources;

namespace P_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_imie_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            var imie = rb.Text;
            label_komunikat.Text = $"Czeœæ, jestem {rb.Text}!";
            label_komunikat.ForeColor = rb.ForeColor;
            if (imie == "Agnieszka")
                pictureBox.Image = Properties.Resources.Agnieszka;
            else if (imie == "Magda")
                pictureBox.Image = Properties.Resources.Magda;
            else if (imie == "Karolina")
                pictureBox.Image = Properties.Resources.Karolina;
            else if (imie == "Iwona")
                pictureBox.Image = Properties.Resources.Iwona;
        }
    }
}
