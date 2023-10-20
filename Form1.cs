namespace Procesos_estocasticos
{
    public partial class Form1 : Form
    {
        static float resultado_probabilidad, division;
        static int valores_repetidos = 0;
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
            //b_inicio.Visible = false;
            int elementos_fila;
            Random aleat = new Random();

            elementos_fila = int.Parse(Elementos_Filas.Text);

            if (elementos_fila <= 5)
            {
                MessageBox.Show("Porfavor ingrese un valor mayor o igual a 5", "Error en elementos de Carretilla",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                    for (int j = 0; j < elementos_fila; j++)
                    {
                        Maquina.Rows.Add(aleat.Next(1, elementos_fila), aleat.Next(1, elementos_fila), aleat.Next(1, elementos_fila));
                    }
                
                    division = 1f / elementos_fila; //Frecuencia relativa
                    resultado_probabilidad = (float)Math.Pow(division, 3); //Resultado
                    MessageBox.Show(resultado_probabilidad.ToString(), "El resultado de la probabilidad es",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                    for (int j = 0; j < 2; j++)
                    {
                        for (int i = 0; i < elementos_fila; i++)
                        {
                            for (int l = j + 1; l < 2; l++)
                            {
                                for (int k = 0; k < elementos_fila; k++)
                                {
                                    if (Maquina.Rows[i].Cells[j].Value != null && Maquina.Rows[k].Cells[l].Value != null &&
                                        Maquina.Rows[i].Cells[j].Value.Equals(Maquina.Rows[k].Cells[l].Value))
                                    {
                                        /*MessageBox.Show("Se encontró un valor repetido en la columna " + (j + 1) + " y columna " + (l + 1) + ": " + Maquina.Rows[i].Cells[j].Value, "Resultado",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                                        valores_repetidos++;
                                       // MessageBox.Show("Los valores repetidos: " + valores_repetidos.ToString(), )
                                    }
                                }
                            }
                        }
                    }
                
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor, porcentaje;
            valor = 1 * (resultado_probabilidad) + 2 * (resultado_probabilidad) + 3 * (resultado_probabilidad); //Distribución masa de probabilidad
            porcentaje = valor * 100;
            MessageBox.Show(porcentaje.ToString(), "Promedio",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}