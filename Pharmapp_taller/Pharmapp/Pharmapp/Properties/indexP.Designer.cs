namespace Pharmapp
{
    partial class indexP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indexP));
            ingresoGroup = new GroupBox();
            exitBtt = new Button();
            ingresarBtt = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ingresoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ingresoGroup
            // 
            ingresoGroup.Controls.Add(exitBtt);
            ingresoGroup.Controls.Add(ingresarBtt);
            ingresoGroup.Location = new Point(72, 268);
            ingresoGroup.Name = "ingresoGroup";
            ingresoGroup.Size = new Size(410, 122);
            ingresoGroup.TabIndex = 1;
            ingresoGroup.TabStop = false;
            ingresoGroup.Text = "Ingreso";
            // 
            // exitBtt
            // 
            exitBtt.BackColor = Color.LightBlue;
            exitBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtt.Location = new Point(224, 46);
            exitBtt.Name = "exitBtt";
            exitBtt.Size = new Size(128, 38);
            exitBtt.TabIndex = 1;
            exitBtt.Text = "Salir";
            exitBtt.UseVisualStyleBackColor = false;
            exitBtt.Click += exitBtt_Click;
            // 
            // ingresarBtt
            // 
            ingresarBtt.BackColor = Color.LightBlue;
            ingresarBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ingresarBtt.Location = new Point(60, 46);
            ingresarBtt.Name = "ingresarBtt";
            ingresarBtt.Size = new Size(129, 38);
            ingresarBtt.TabIndex = 0;
            ingresarBtt.Text = "Ingresar";
            ingresarBtt.UseVisualStyleBackColor = false;
            ingresarBtt.Click += ingresarBtt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(130, 38);
            label1.Name = "label1";
            label1.Size = new Size(325, 46);
            label1.TabIndex = 0;
            label1.Text = "Farmacia Galeras";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // indexP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ingresoGroup);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "indexP";
            Text = "PharmApp";
            Load += indexP_Load;
            ingresoGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox ingresoGroup;
        private Button exitBtt;
        private Button ingresarBtt;
        private Label label1;
        private PictureBox pictureBox1;
    }
}