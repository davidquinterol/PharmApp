namespace Pharmapp
{
    partial class inicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicioSesion));
            label1 = new Label();
            ingresoGroup = new GroupBox();
            exitBtt = new Button();
            registrarseBtt = new Button();
            regispassTxt = new TextBox();
            regiusuarioTxt = new TextBox();
            passLabel = new Label();
            inButton = new Button();
            userLabel = new Label();
            ingresoGroup.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(130, 36);
            label1.Name = "label1";
            label1.Size = new Size(325, 46);
            label1.TabIndex = 0;
            label1.Text = "Farmacia Galeras";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ingresoGroup
            // 
            ingresoGroup.Controls.Add(exitBtt);
            ingresoGroup.Controls.Add(registrarseBtt);
            ingresoGroup.Controls.Add(regispassTxt);
            ingresoGroup.Controls.Add(regiusuarioTxt);
            ingresoGroup.Controls.Add(passLabel);
            ingresoGroup.Controls.Add(inButton);
            ingresoGroup.Controls.Add(userLabel);
            ingresoGroup.Location = new Point(79, 119);
            ingresoGroup.Name = "ingresoGroup";
            ingresoGroup.Size = new Size(410, 276);
            ingresoGroup.TabIndex = 1;
            ingresoGroup.TabStop = false;
            ingresoGroup.Text = "Ingreso";
            // 
            // exitBtt
            // 
            exitBtt.BackColor = Color.LightBlue;
            exitBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtt.Location = new Point(278, 207);
            exitBtt.Name = "exitBtt";
            exitBtt.Size = new Size(128, 38);
            exitBtt.TabIndex = 6;
            exitBtt.Text = "Salir";
            exitBtt.UseVisualStyleBackColor = false;
            exitBtt.Click += exitBtt_Click;
            // 
            // registrarseBtt
            // 
            registrarseBtt.BackColor = Color.LightBlue;
            registrarseBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            registrarseBtt.Location = new Point(144, 207);
            registrarseBtt.Name = "registrarseBtt";
            registrarseBtt.Size = new Size(128, 38);
            registrarseBtt.TabIndex = 5;
            registrarseBtt.Text = "Registrarse";
            registrarseBtt.UseVisualStyleBackColor = false;
            registrarseBtt.Click += registrarseBtt_Click_1;
            // 
            // regispassTxt
            // 
            regispassTxt.Location = new Point(141, 137);
            regispassTxt.Name = "regispassTxt";
            regispassTxt.PasswordChar = '*';
            regispassTxt.Size = new Size(211, 23);
            regispassTxt.TabIndex = 3;
            regispassTxt.UseSystemPasswordChar = true;
            // 
            // regiusuarioTxt
            // 
            regiusuarioTxt.Location = new Point(141, 57);
            regiusuarioTxt.Name = "regiusuarioTxt";
            regiusuarioTxt.Size = new Size(211, 23);
            regiusuarioTxt.TabIndex = 1;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passLabel.Location = new Point(60, 139);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(78, 17);
            passLabel.TabIndex = 2;
            passLabel.Text = "Contraseña:";
            // 
            // inButton
            // 
            inButton.BackColor = Color.LightBlue;
            inButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inButton.Location = new Point(9, 207);
            inButton.Name = "inButton";
            inButton.Size = new Size(129, 38);
            inButton.TabIndex = 4;
            inButton.Text = "Ingresar";
            inButton.UseVisualStyleBackColor = false;
            inButton.Click += ingresarBtt_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userLabel.Location = new Point(60, 65);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(57, 17);
            userLabel.TabIndex = 0;
            userLabel.Text = "Usuario:";
            // 
            // inicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(label1);
            Controls.Add(ingresoGroup);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "inicioSesion";
            Text = "Inicio de Sesión";
            ingresoGroup.ResumeLayout(false);
            ingresoGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox ingresoGroup;
        private Button registrarseBtt;
        private TextBox regispassTxt;
        private TextBox regiusuarioTxt;
        private Label passLabel;
        private Button inButton;
        private Label userLabel;
        private Button exitBtt;
    }
}