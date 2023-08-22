namespace MayınTarlası
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
            lblSüreGöster = new Label();
            lblKalanSüre = new Label();
            tbMayınAl = new TextBox();
            tbSüreAl = new TextBox();
            btnBaşlat = new Button();
            lblSüre = new Label();
            lblMayın = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelTarla = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblSüreGöster
            // 
            lblSüreGöster.BackColor = SystemColors.GradientActiveCaption;
            lblSüreGöster.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSüreGöster.Location = new Point(541, 78);
            lblSüreGöster.Name = "lblSüreGöster";
            lblSüreGöster.Size = new Size(184, 75);
            lblSüreGöster.TabIndex = 100;
            lblSüreGöster.Text = "00:00";
            lblSüreGöster.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKalanSüre
            // 
            lblKalanSüre.BackColor = SystemColors.ActiveCaption;
            lblKalanSüre.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKalanSüre.Location = new Point(541, 35);
            lblKalanSüre.Name = "lblKalanSüre";
            lblKalanSüre.Size = new Size(184, 43);
            lblKalanSüre.TabIndex = 101;
            lblKalanSüre.Text = "Kalan Süre";
            // 
            // tbMayınAl
            // 
            tbMayınAl.BackColor = SystemColors.GradientActiveCaption;
            tbMayınAl.Location = new Point(541, 262);
            tbMayınAl.Name = "tbMayınAl";
            tbMayınAl.Size = new Size(184, 31);
            tbMayınAl.TabIndex = 102;
            // 
            // tbSüreAl
            // 
            tbSüreAl.BackColor = SystemColors.GradientActiveCaption;
            tbSüreAl.Location = new Point(541, 356);
            tbSüreAl.Name = "tbSüreAl";
            tbSüreAl.Size = new Size(186, 31);
            tbSüreAl.TabIndex = 103;
            // 
            // btnBaşlat
            // 
            btnBaşlat.BackColor = SystemColors.ScrollBar;
            btnBaşlat.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaşlat.ForeColor = SystemColors.WindowText;
            btnBaşlat.Location = new Point(549, 440);
            btnBaşlat.Name = "btnBaşlat";
            btnBaşlat.Size = new Size(181, 55);
            btnBaşlat.TabIndex = 104;
            btnBaşlat.Text = "Başlat";
            btnBaşlat.UseVisualStyleBackColor = false;
            btnBaşlat.Click += btnBaşlat_Click;
            // 
            // lblSüre
            // 
            lblSüre.BackColor = SystemColors.ActiveCaption;
            lblSüre.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSüre.Location = new Point(541, 310);
            lblSüre.Name = "lblSüre";
            lblSüre.Size = new Size(184, 43);
            lblSüre.TabIndex = 105;
            lblSüre.Text = "Süre";
            // 
            // lblMayın
            // 
            lblMayın.BackColor = SystemColors.ActiveCaption;
            lblMayın.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMayın.Location = new Point(541, 216);
            lblMayın.Name = "lblMayın";
            lblMayın.Size = new Size(184, 43);
            lblMayın.TabIndex = 106;
            lblMayın.Text = "Mayın Sayısı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(731, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 107;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(731, 319);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 108;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(731, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 109;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panelTarla
            // 
            panelTarla.Location = new Point(25, 21);
            panelTarla.Name = "panelTarla";
            panelTarla.Size = new Size(464, 457);
            panelTarla.TabIndex = 110;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 524);
            Controls.Add(panelTarla);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblMayın);
            Controls.Add(lblSüre);
            Controls.Add(btnBaşlat);
            Controls.Add(tbSüreAl);
            Controls.Add(tbMayınAl);
            Controls.Add(lblKalanSüre);
            Controls.Add(lblSüreGöster);
            Name = "Form1";
            Text = "Mayın Tarlası Oyunu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSüreGöster;
        private Label lblKalanSüre;
        private Button btnBaşlat;
        private Label lblSüre;
        private Label lblMayın;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        public TextBox tbMayınAl;
        public TextBox tbSüreAl;
        private FlowLayoutPanel panelTarla;
    }
}