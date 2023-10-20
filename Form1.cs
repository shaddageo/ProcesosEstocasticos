namespace Procesos_estocasticos
{
    public partial class Form1 : Form
    {
        int t = 0, t2 = 0, t3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void b_inicio_Click(object sender, EventArgs e)
        {
            Tiempo1.Enabled = true;
            Tiempo2.Enabled = true;
            Tiempo3.Enabled = true;
            b_inicio.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = t + 1;
            if (t == 1) pictureBox1.Image = Properties.Resources.Corazon;
            if (t == 2) pictureBox1.Image = Properties.Resources.Diamante;
            if (t == 3) pictureBox1.Image = Properties.Resources.cosarara;
            if (t == 4)
            {
                pictureBox1.Image = Properties.Resources.Trebol;
                t = 0;
            }

        }

        private void Tiempo2_Tick(object sender, EventArgs e)
        {
            t2 = t2 + 1;
            if (t2 == 1) pictureBox2.Image = Properties.Resources.Corazon;
            if (t2 == 2) pictureBox2.Image = Properties.Resources.Diamante;
            if (t2 == 3) pictureBox2.Image = Properties.Resources.cosarara;
            if (t2 == 4)
            {
                pictureBox1.Image = Properties.Resources.Trebol;
                t2 = 0;
            }
        }

        private void Tiempo3_Tick(object sender, EventArgs e)
        {
            t3 = t3 + 1;
            if (t3 == 1) pictureBox3.Image = Properties.Resources.Corazon;
            if (t3 == 2) pictureBox3.Image = Properties.Resources.Diamante;
            if (t3 == 3) pictureBox3.Image = Properties.Resources.cosarara;
            if (t3 == 4)
            {
                pictureBox1.Image = Properties.Resources.Trebol;
                t3 = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tiempo1.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Tiempo2.Enabled = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tiempo3.Enabled = false;
            revisar();
            b_inicio.Visible = true;

        }
        private void revisar()
        {
            if (t == t2 && t2 == t3) MessageBox.Show("Ganaste");
            else MessageBox.Show("Perdiste");
        }
    }
}