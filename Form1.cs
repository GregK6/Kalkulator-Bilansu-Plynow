namespace Licznik_Bilansu
{
    public partial class kalkulatorBilansuPlynow : Form
    {
        public kalkulatorBilansuPlynow()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void oblicz_Click(object sender, EventArgs e)
        {
            decimal bilans = szybkoscKroplowki.Value;

            labelWynik.Text = typBilansu.SelectedIndex.ToString();

            switch (typBilansu.SelectedIndex)
            {
                case -1: // Nie wybrane
                    labelWynik.Text = "Wybierz typ bilansu";
                    return;

                case 0: // 6h
                    bilans *= 6;
                    break;

                case 1: // 12h
                    bilans *= 12;
                    break;

                case 2: // 24h
                    bilans *= 24;
                    break;
            }

            bilans += plyny1.Value + plyny2.Value + plyny3.Value + plyny4.Value;
            bilans -= wymioty.Value;

            if (margines.Checked) {
                bilans -= 200;
            }

            if (bilans < 0) bilans = 0;

            labelWynik.Text = $"Minimalne wydalenie moczu:  {bilans} ml";
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bilans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
