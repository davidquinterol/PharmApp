namespace Pharmapp.Properties
{
    partial class areaPQRS
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(areaPQRS));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            situacionTxt = new TextBox();
            emailTxt = new TextBox();
            direccionTxt = new TextBox();
            contactoTxt = new TextBox();
            usuarioIDTxt = new TextBox();
            nombreTxt = new TextBox();
            PButton = new RadioButton();
            QButton = new RadioButton();
            FButton = new RadioButton();
            exitBtt = new Button();
            guardarDomisBtt = new Button();
            dateTime = new DateTimePicker();
            errorProv = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(-4, 22);
            label1.Name = "label1";
            label1.Size = new Size(581, 31);
            label1.TabIndex = 0;
            label1.Text = "Ingresa la información para completar la PQRS: ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 86);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 13;
            label2.Text = "Nombre completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 123);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 14;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 165);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 15;
            label4.Text = "Télefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 204);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 16;
            label5.Text = "Dirección y barrio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 245);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 17;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 280);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 18;
            label7.Text = "Recurso:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(98, 315);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 19;
            label8.Text = "Fecha:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(98, 352);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 20;
            label9.Text = "Situación presentada:";
            // 
            // situacionTxt
            // 
            situacionTxt.Location = new Point(271, 349);
            situacionTxt.Name = "situacionTxt";
            situacionTxt.Size = new Size(211, 23);
            situacionTxt.TabIndex = 10;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(271, 242);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(211, 23);
            emailTxt.TabIndex = 5;
            // 
            // direccionTxt
            // 
            direccionTxt.Location = new Point(271, 201);
            direccionTxt.Name = "direccionTxt";
            direccionTxt.Size = new Size(211, 23);
            direccionTxt.TabIndex = 4;
            // 
            // contactoTxt
            // 
            contactoTxt.Location = new Point(271, 162);
            contactoTxt.Name = "contactoTxt";
            contactoTxt.Size = new Size(211, 23);
            contactoTxt.TabIndex = 3;
            // 
            // usuarioIDTxt
            // 
            usuarioIDTxt.Location = new Point(271, 120);
            usuarioIDTxt.Name = "usuarioIDTxt";
            usuarioIDTxt.Size = new Size(211, 23);
            usuarioIDTxt.TabIndex = 2;
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(271, 78);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(211, 23);
            nombreTxt.TabIndex = 1;
            // 
            // PButton
            // 
            PButton.AutoSize = true;
            PButton.Location = new Point(271, 280);
            PButton.Name = "PButton";
            PButton.Size = new Size(68, 19);
            PButton.TabIndex = 6;
            PButton.TabStop = true;
            PButton.Text = "Petición";
            PButton.UseVisualStyleBackColor = true;
            // 
            // QButton
            // 
            QButton.AutoSize = true;
            QButton.Location = new Point(345, 280);
            QButton.Name = "QButton";
            QButton.Size = new Size(56, 19);
            QButton.TabIndex = 7;
            QButton.TabStop = true;
            QButton.Text = "Queja";
            QButton.UseVisualStyleBackColor = true;
            // 
            // FButton
            // 
            FButton.AutoSize = true;
            FButton.Location = new Point(407, 280);
            FButton.Name = "FButton";
            FButton.Size = new Size(85, 19);
            FButton.TabIndex = 8;
            FButton.TabStop = true;
            FButton.Text = "Felicitación";
            FButton.UseVisualStyleBackColor = true;
            // 
            // exitBtt
            // 
            exitBtt.BackColor = Color.LightBlue;
            exitBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtt.Location = new Point(287, 400);
            exitBtt.Name = "exitBtt";
            exitBtt.Size = new Size(128, 38);
            exitBtt.TabIndex = 22;
            exitBtt.Text = "Salir";
            exitBtt.UseVisualStyleBackColor = false;
            exitBtt.Click += exitBtt_Click;
            // 
            // guardarDomisBtt
            // 
            guardarDomisBtt.BackColor = Color.LightBlue;
            guardarDomisBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            guardarDomisBtt.Location = new Point(135, 400);
            guardarDomisBtt.Name = "guardarDomisBtt";
            guardarDomisBtt.Size = new Size(129, 38);
            guardarDomisBtt.TabIndex = 21;
            guardarDomisBtt.Text = "Guardar";
            guardarDomisBtt.UseVisualStyleBackColor = false;
            guardarDomisBtt.Click += guardarDomisBtt_Click;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(271, 309);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(211, 23);
            dateTime.TabIndex = 23;
            // 
            // errorProv
            // 
            errorProv.ContainerControl = this;
            // 
            // areaPQRS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(570, 450);
            Controls.Add(dateTime);
            Controls.Add(exitBtt);
            Controls.Add(guardarDomisBtt);
            Controls.Add(FButton);
            Controls.Add(QButton);
            Controls.Add(PButton);
            Controls.Add(nombreTxt);
            Controls.Add(usuarioIDTxt);
            Controls.Add(contactoTxt);
            Controls.Add(direccionTxt);
            Controls.Add(emailTxt);
            Controls.Add(situacionTxt);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "areaPQRS";
            Text = "areaPQRS";
            ((System.ComponentModel.ISupportInitialize)errorProv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox situacionTxt;
        private TextBox emailTxt;
        private TextBox direccionTxt;
        private TextBox contactoTxt;
        private TextBox usuarioIDTxt;
        private TextBox nombreTxt;
        private RadioButton PButton;
        private RadioButton QButton;
        private RadioButton FButton;
        private Button exitBtt;
        private Button guardarDomisBtt;
        private DateTimePicker dateTime;
        private ErrorProvider errorProv;
    }
}