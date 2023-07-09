namespace Pharmapp.Properties
{
    partial class registroPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroPersona));
            label2 = new Label();
            exitBtt = new Button();
            regispassTxt = new TextBox();
            segundonomLabel = new Label();
            regiusuarioTxt = new TextBox();
            guardarBtt = new Button();
            primernomLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(48, 87);
            label2.Name = "label2";
            label2.Size = new Size(495, 31);
            label2.TabIndex = 0;
            label2.Text = "Formulario de registro, ingrese sus datos:\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // exitBtt
            // 
            exitBtt.BackColor = Color.LightBlue;
            exitBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtt.Location = new Point(201, 138);
            exitBtt.Name = "exitBtt";
            exitBtt.Size = new Size(126, 38);
            exitBtt.TabIndex = 3;
            exitBtt.Text = "Salir";
            exitBtt.UseVisualStyleBackColor = false;
            exitBtt.Click += exitBtt_Click;
            // 
            // regispassTxt
            // 
            regispassTxt.Location = new Point(152, 90);
            regispassTxt.Name = "regispassTxt";
            regispassTxt.Size = new Size(209, 23);
            regispassTxt.TabIndex = 1;
            // 
            // segundonomLabel
            // 
            segundonomLabel.AutoSize = true;
            segundonomLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            segundonomLabel.Location = new Point(19, 96);
            segundonomLabel.Name = "segundonomLabel";
            segundonomLabel.Size = new Size(78, 17);
            segundonomLabel.TabIndex = 34;
            segundonomLabel.Text = "Contraseña:";
            // 
            // regiusuarioTxt
            // 
            regiusuarioTxt.Location = new Point(152, 37);
            regiusuarioTxt.Name = "regiusuarioTxt";
            regiusuarioTxt.Size = new Size(209, 23);
            regiusuarioTxt.TabIndex = 0;
            // 
            // guardarBtt
            // 
            guardarBtt.BackColor = Color.LightBlue;
            guardarBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            guardarBtt.Location = new Point(41, 138);
            guardarBtt.Name = "guardarBtt";
            guardarBtt.Size = new Size(127, 38);
            guardarBtt.TabIndex = 2;
            guardarBtt.Text = "Guardar";
            guardarBtt.UseVisualStyleBackColor = false;
            guardarBtt.Click += guardarBtt_Click;
            // 
            // primernomLabel
            // 
            primernomLabel.AutoSize = true;
            primernomLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            primernomLabel.Location = new Point(19, 43);
            primernomLabel.Name = "primernomLabel";
            primernomLabel.Size = new Size(57, 17);
            primernomLabel.TabIndex = 32;
            primernomLabel.Text = "Usuario:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(exitBtt);
            groupBox1.Controls.Add(regispassTxt);
            groupBox1.Controls.Add(segundonomLabel);
            groupBox1.Controls.Add(regiusuarioTxt);
            groupBox1.Controls.Add(guardarBtt);
            groupBox1.Controls.Add(primernomLabel);
            groupBox1.Location = new Point(99, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 200);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // registroPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "registroPersona";
            Text = "Formulario de Registro ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button exitBtt;
        private TextBox regispassTxt;
        private Label segundonomLabel;
        private TextBox regiusuarioTxt;
        private Button guardarBtt;
        private Label primernomLabel;
        private GroupBox groupBox1;
    }
}