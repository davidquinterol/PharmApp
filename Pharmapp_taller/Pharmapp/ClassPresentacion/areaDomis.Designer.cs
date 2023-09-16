namespace Pharmapp.Properties
{
    partial class areaDomis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(areaDomis));
            label1 = new Label();
            regisDomisBtt = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(123, 47);
            label1.Name = "label1";
            label1.Size = new Size(325, 46);
            label1.TabIndex = 0;
            label1.Text = "Farmacia Galeras";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // regisDomisBtt
            // 
            regisDomisBtt.BackColor = Color.LightBlue;
            regisDomisBtt.Location = new Point(108, 43);
            regisDomisBtt.Name = "regisDomisBtt";
            regisDomisBtt.Size = new Size(127, 38);
            regisDomisBtt.TabIndex = 0;
            regisDomisBtt.Text = "Registrar Domicilio";
            regisDomisBtt.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(regisDomisBtt);
            groupBox1.Location = new Point(119, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 116);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Domicilios";
            // 
            // areaDomis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "areaDomis";
            Text = "Área de Domicilios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button regisDomisBtt;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
    }
}