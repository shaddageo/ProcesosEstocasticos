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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // b_inicio
            // 
            b_inicio.BackColor = SystemColors.ControlLightLight;
            b_inicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b_inicio.ForeColor = SystemColors.ActiveBorder;
            b_inicio.Location = new Point(599, 181);
            b_inicio.Name = "b_inicio";
            b_inicio.Size = new Size(163, 39);
            b_inicio.TabIndex = 0;
            b_inicio.Text = "Iniciar";
            b_inicio.UseVisualStyleBackColor = false;
            b_inicio.Click += b_inicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Trebol;
            pictureBox1.Location = new Point(401, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 149);
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
            pictureBox2.Location = new Point(599, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(163, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Trebol;
            pictureBox3.Location = new Point(794, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(163, 149);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1193, 558);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(b_inicio);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
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
    }
}