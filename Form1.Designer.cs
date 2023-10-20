namespace Procesos_estocasticos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            /*
            ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            */
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            b_inicio = new Button();
            pictureBox1 = new PictureBox();
            Tiempo1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            timer7 = new System.Windows.Forms.Timer(components);
            timer8 = new System.Windows.Forms.Timer(components);
            timer9 = new System.Windows.Forms.Timer(components);
            timer10 = new System.Windows.Forms.Timer(components);
            Tiempo2 = new System.Windows.Forms.Timer(components);
            Tiempo3 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            Elementos_Filas = new TextBox();
            Maquina = new DataGridView();
            Carretilla1 = new DataGridViewTextBoxColumn();
            Carretilla2 = new DataGridViewTextBoxColumn();
            Carretilla3 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            //chart1 = new Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maquina).BeginInit();
            //((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // b_inicio
            // 
            b_inicio.BackColor = SystemColors.ControlLightLight;
            b_inicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b_inicio.ForeColor = SystemColors.ActiveBorder;
            b_inicio.Location = new Point(524, 213);
            b_inicio.Margin = new Padding(3, 2, 3, 2);
            b_inicio.Name = "b_inicio";
            b_inicio.Size = new Size(143, 29);
            b_inicio.TabIndex = 0;
            b_inicio.Text = "Iniciar";
            b_inicio.UseVisualStyleBackColor = false;
            b_inicio.Click += b_inicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Trebol;
            pictureBox1.Location = new Point(351, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Tiempo1
            // 
            Tiempo1.Interval = 1000;
            Tiempo1.Tick += timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Trebol;
            pictureBox2.Location = new Point(524, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(143, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Trebol;
            pictureBox3.Location = new Point(695, 9);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(143, 112);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Tiempo2
            // 
            Tiempo2.Interval = 1000;
            Tiempo2.Tick += Tiempo2_Tick;
            // 
            // Tiempo3
            // 
            Tiempo3.Interval = 1000;
            Tiempo3.Tick += Tiempo3_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 154);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese cuantos elementos quiere.";
            label1.Click += label1_Click;
            // 
            // Elementos_Filas
            // 
            Elementos_Filas.Location = new Point(524, 172);
            Elementos_Filas.Name = "Elementos_Filas";
            Elementos_Filas.Size = new Size(138, 23);
            Elementos_Filas.TabIndex = 5;
            // 
            // Maquina
            // 
            Maquina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Maquina.Columns.AddRange(new DataGridViewColumn[] { Carretilla1, Carretilla2, Carretilla3 });
            Maquina.Location = new Point(967, 131);
            Maquina.Name = "Maquina";
            Maquina.RowTemplate.Height = 25;
            Maquina.Size = new Size(17, 21);
            Maquina.TabIndex = 6;
            Maquina.Visible = false;
            // 
            // Carretilla1
            // 
            Carretilla1.HeaderText = "Carretilla1";
            Carretilla1.Name = "Carretilla1";
            // 
            // Carretilla2
            // 
            Carretilla2.HeaderText = "Carretilla2";
            Carretilla2.Name = "Carretilla2";
            // 
            // Carretilla3
            // 
            Carretilla3.HeaderText = "Carretilla3";
            Carretilla3.Name = "Carretilla3";
            // 
            // button1
            // 
            button1.Location = new Point(524, 260);
            button1.Name = "button1";
            button1.Size = new Size(143, 23);
            button1.TabIndex = 7;
            button1.Text = "Graficar_Funcion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chart1
            // 
            /*
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(673, 182);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 224);
            chart1.TabIndex = 8;
            chart1.Text = "chart1";
            chart1.Click += this.chart1_Click;
            */
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1044, 418);
           // Controls.Add(chart1);
            Controls.Add(button1);
            Controls.Add(Maquina);
            Controls.Add(Elementos_Filas);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(b_inicio);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maquina).EndInit();
            //((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_inicio;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer Tiempo1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Timer Tiempo2;
        private System.Windows.Forms.Timer Tiempo3;
        private Label label1;
        private TextBox Elementos_Filas;
        private DataGridView Maquina;
        private DataGridViewTextBoxColumn Carretilla1;
        private DataGridViewTextBoxColumn Carretilla2;
        private DataGridViewTextBoxColumn Carretilla3;
        private Button button1;
        private System.CodeDom.CodeTypeReference chart1;
    }
}