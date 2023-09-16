namespace Pharmapp.Properties
{
    partial class registroInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroInventario));
            label1 = new Label();
            listBoxPresenta = new ListBox();
            exitBtt = new Button();
            concentracionTxt = new TextBox();
            numidLabel = new Label();
            tipoidLabel = new Label();
            productoTxt = new TextBox();
            estanteTxt = new TextBox();
            segundoapeLabel = new Label();
            segundonomLabel = new Label();
            codProductoTxt = new TextBox();
            fechaInvTxt = new TextBox();
            primerapeLabel = new Label();
            guardarInBtt = new Button();
            primernomLabel = new Label();
            cantidadTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            errorProv = new ErrorProvider(components);
            dateTime = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 23);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Registro de Inventario:\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // listBoxPresenta
            // 
            listBoxPresenta.FormattingEnabled = true;
            listBoxPresenta.ItemHeight = 15;
            listBoxPresenta.Items.AddRange(new object[] { "Seleccione", "Tabletas", "Jarabe", "Polvo", "Gotas" });
            listBoxPresenta.Location = new Point(259, 237);
            listBoxPresenta.Name = "listBoxPresenta";
            listBoxPresenta.Size = new Size(211, 19);
            listBoxPresenta.TabIndex = 5;
            // 
            // exitBtt
            // 
            exitBtt.BackColor = Color.LightBlue;
            exitBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtt.Location = new Point(283, 395);
            exitBtt.Name = "exitBtt";
            exitBtt.Size = new Size(128, 38);
            exitBtt.TabIndex = 10;
            exitBtt.Text = "Salir";
            exitBtt.UseVisualStyleBackColor = false;
            exitBtt.Click += exitBtt_Click;
            // 
            // concentracionTxt
            // 
            concentracionTxt.Location = new Point(259, 270);
            concentracionTxt.Name = "concentracionTxt";
            concentracionTxt.Size = new Size(211, 23);
            concentracionTxt.TabIndex = 6;
            // 
            // numidLabel
            // 
            numidLabel.AutoSize = true;
            numidLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numidLabel.Location = new Point(83, 272);
            numidLabel.Name = "numidLabel";
            numidLabel.Size = new Size(96, 17);
            numidLabel.TabIndex = 42;
            numidLabel.Text = "Concentración:";
            // 
            // tipoidLabel
            // 
            tipoidLabel.AutoSize = true;
            tipoidLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tipoidLabel.Location = new Point(83, 233);
            tipoidLabel.Name = "tipoidLabel";
            tipoidLabel.Size = new Size(87, 17);
            tipoidLabel.TabIndex = 40;
            tipoidLabel.Text = "Presentación:";
            // 
            // productoTxt
            // 
            productoTxt.Location = new Point(259, 188);
            productoTxt.Name = "productoTxt";
            productoTxt.Size = new Size(211, 23);
            productoTxt.TabIndex = 4;
            // 
            // estanteTxt
            // 
            estanteTxt.Location = new Point(259, 101);
            estanteTxt.Name = "estanteTxt";
            estanteTxt.Size = new Size(211, 23);
            estanteTxt.TabIndex = 2;
            // 
            // segundoapeLabel
            // 
            segundoapeLabel.AutoSize = true;
            segundoapeLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            segundoapeLabel.Location = new Point(83, 190);
            segundoapeLabel.Name = "segundoapeLabel";
            segundoapeLabel.Size = new Size(114, 17);
            segundoapeLabel.TabIndex = 38;
            segundoapeLabel.Text = "Nombre producto:";
            // 
            // segundonomLabel
            // 
            segundonomLabel.AutoSize = true;
            segundonomLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            segundonomLabel.Location = new Point(83, 103);
            segundonomLabel.Name = "segundonomLabel";
            segundonomLabel.Size = new Size(105, 17);
            segundonomLabel.TabIndex = 34;
            segundonomLabel.Text = "Número estante:";
            // 
            // codProductoTxt
            // 
            codProductoTxt.Location = new Point(259, 145);
            codProductoTxt.Name = "codProductoTxt";
            codProductoTxt.Size = new Size(211, 23);
            codProductoTxt.TabIndex = 3;
            // 
            // fechaInvTxt
            // 
            fechaInvTxt.Location = new Point(259, 58);
            fechaInvTxt.Name = "fechaInvTxt";
            fechaInvTxt.Size = new Size(211, 23);
            fechaInvTxt.TabIndex = 1;
            // 
            // primerapeLabel
            // 
            primerapeLabel.AutoSize = true;
            primerapeLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            primerapeLabel.Location = new Point(83, 147);
            primerapeLabel.Name = "primerapeLabel";
            primerapeLabel.Size = new Size(107, 17);
            primerapeLabel.TabIndex = 36;
            primerapeLabel.Text = "Código producto:";
            // 
            // guardarInBtt
            // 
            guardarInBtt.BackColor = Color.LightBlue;
            guardarInBtt.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            guardarInBtt.Location = new Point(131, 395);
            guardarInBtt.Name = "guardarInBtt";
            guardarInBtt.Size = new Size(129, 38);
            guardarInBtt.TabIndex = 9;
            guardarInBtt.Text = "Guardar";
            guardarInBtt.UseVisualStyleBackColor = false;
            guardarInBtt.Click += guardarInBtt_Click;
            // 
            // primernomLabel
            // 
            primernomLabel.AutoSize = true;
            primernomLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            primernomLabel.Location = new Point(83, 60);
            primernomLabel.Name = "primernomLabel";
            primernomLabel.Size = new Size(174, 17);
            primernomLabel.TabIndex = 32;
            primernomLabel.Text = "Fecha realización inventario:";
            // 
            // cantidadTxt
            // 
            cantidadTxt.Location = new Point(259, 311);
            cantidadTxt.Name = "cantidadTxt";
            cantidadTxt.Size = new Size(211, 23);
            cantidadTxt.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 313);
            label2.Name = "label2";
            label2.Size = new Size(124, 17);
            label2.TabIndex = 58;
            label2.Text = "Cantidad disponible:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 356);
            label3.Name = "label3";
            label3.Size = new Size(139, 17);
            label3.TabIndex = 60;
            label3.Text = "Fecha de vencimiento:";
            // 
            // errorProv
            // 
            errorProv.ContainerControl = this;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(259, 356);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(211, 23);
            dateTime.TabIndex = 61;
            dateTime.ValueChanged += dateTime_ValueChanged;
            // 
            // registroInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 450);
            Controls.Add(dateTime);
            Controls.Add(label3);
            Controls.Add(cantidadTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxPresenta);
            Controls.Add(exitBtt);
            Controls.Add(concentracionTxt);
            Controls.Add(numidLabel);
            Controls.Add(tipoidLabel);
            Controls.Add(productoTxt);
            Controls.Add(estanteTxt);
            Controls.Add(segundoapeLabel);
            Controls.Add(segundonomLabel);
            Controls.Add(codProductoTxt);
            Controls.Add(fechaInvTxt);
            Controls.Add(primerapeLabel);
            Controls.Add(guardarInBtt);
            Controls.Add(primernomLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "registroInventario";
            Text = "Registro de Inventario";
            ((System.ComponentModel.ISupportInitialize)errorProv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void guardarInBtt_Click(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion
        private Label label1;
        private ListBox listBoxPresenta;
        private Button exitBtt;
        private TextBox concentracionTxt;
        private Label numidLabel;
        private Label tipoidLabel;
        private TextBox productoTxt;
        private TextBox estanteTxt;
        private Label segundoapeLabel;
        private Label segundonomLabel;
        private TextBox codProductoTxt;
        private TextBox fechaInvTxt;
        private Label primerapeLabel;
        private Button guardarInBtt;
        private Label primernomLabel;
        private TextBox cantidadTxt;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProv;
        private DateTimePicker dateTime;
    }
}