namespace Pharmapp.Properties
{
    partial class pharmApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pharmApp));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ingresoGroup = new GroupBox();
            pqrsBtt = new Button();
            domisBtt = new Button();
            inventarioBtt = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ingresoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(116, 49);
            label1.Name = "label1";
            label1.Size = new Size(325, 46);
            label1.TabIndex = 0;
            label1.Text = "Farmacia Galeras";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ingresoGroup
            // 
            ingresoGroup.Controls.Add(pqrsBtt);
            ingresoGroup.Controls.Add(domisBtt);
            ingresoGroup.Controls.Add(inventarioBtt);
            ingresoGroup.Location = new Point(74, 248);
            ingresoGroup.Name = "ingresoGroup";
            ingresoGroup.Size = new Size(410, 122);
            ingresoGroup.TabIndex = 1;
            ingresoGroup.TabStop = false;
            // 
            // pqrsBtt
            // 
            pqrsBtt.BackColor = Color.LightBlue;
            pqrsBtt.Location = new Point(145, 79);
            pqrsBtt.Name = "pqrsBtt";
            pqrsBtt.Size = new Size(109, 29);
            pqrsBtt.TabIndex = 2;
            pqrsBtt.Text = "PQRS";
            pqrsBtt.UseVisualStyleBackColor = false;
            pqrsBtt.Click += pqrsBtt_Click;
            // 
            // domisBtt
            // 
            domisBtt.BackColor = Color.LightBlue;
            domisBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            domisBtt.Location = new Point(221, 35);
            domisBtt.Name = "domisBtt";
            domisBtt.Size = new Size(128, 38);
            domisBtt.TabIndex = 1;
            domisBtt.Text = "Domicilios";
            domisBtt.UseVisualStyleBackColor = false;
            domisBtt.Click += domisBtt_Click;
            // 
            // inventarioBtt
            // 
            inventarioBtt.BackColor = Color.LightBlue;
            inventarioBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inventarioBtt.Location = new Point(57, 35);
            inventarioBtt.Name = "inventarioBtt";
            inventarioBtt.Size = new Size(129, 38);
            inventarioBtt.TabIndex = 0;
            inventarioBtt.Text = "Ingreso Inventario";
            inventarioBtt.UseVisualStyleBackColor = false;
            inventarioBtt.Click += inventarioBtt_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(311, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pharmApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ingresoGroup);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "pharmApp";
            Text = "PharmApp";
            Load += pharmApp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ingresoGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox ingresoGroup;
        private Button domisBtt;
        private Button inventarioBtt;
        private PictureBox pictureBox2;
        private Button pqrsBtt;
    }
}