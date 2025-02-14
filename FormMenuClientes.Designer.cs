namespace menu_clientes
{
    partial class FormMenuClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.btEditarCliente = new System.Windows.Forms.Button();
            this.btGerarPDF = new System.Windows.Forms.Button();
            this.btGerarFicha = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btGerarFicha);
            this.groupBox1.Controls.Add(this.btGerarPDF);
            this.groupBox1.Controls.Add(this.btEditarCliente);
            this.groupBox1.Controls.Add(this.btAddCliente);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btAddCliente
            // 
            this.btAddCliente.BackColor = System.Drawing.Color.Transparent;
            this.btAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddCliente.FlatAppearance.BorderSize = 0;
            this.btAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCliente.Image = ((System.Drawing.Image)(resources.GetObject("btAddCliente.Image")));
            this.btAddCliente.Location = new System.Drawing.Point(8, 16);
            this.btAddCliente.Name = "btAddCliente";
            this.btAddCliente.Size = new System.Drawing.Size(48, 48);
            this.btAddCliente.TabIndex = 2;
            this.btAddCliente.UseVisualStyleBackColor = false;
            this.btAddCliente.Click += new System.EventHandler(this.btAddCliente_Click);
            // 
            // btEditarCliente
            // 
            this.btEditarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditarCliente.Enabled = false;
            this.btEditarCliente.FlatAppearance.BorderSize = 0;
            this.btEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btEditarCliente.Image")));
            this.btEditarCliente.Location = new System.Drawing.Point(68, 16);
            this.btEditarCliente.Name = "btEditarCliente";
            this.btEditarCliente.Size = new System.Drawing.Size(48, 48);
            this.btEditarCliente.TabIndex = 3;
            this.btEditarCliente.UseVisualStyleBackColor = false;
            // 
            // btGerarPDF
            // 
            this.btGerarPDF.BackColor = System.Drawing.Color.Transparent;
            this.btGerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGerarPDF.FlatAppearance.BorderSize = 0;
            this.btGerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btGerarPDF.Image")));
            this.btGerarPDF.Location = new System.Drawing.Point(128, 16);
            this.btGerarPDF.Name = "btGerarPDF";
            this.btGerarPDF.Size = new System.Drawing.Size(48, 48);
            this.btGerarPDF.TabIndex = 4;
            this.btGerarPDF.UseVisualStyleBackColor = false;
            // 
            // btGerarFicha
            // 
            this.btGerarFicha.BackColor = System.Drawing.Color.Transparent;
            this.btGerarFicha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGerarFicha.Enabled = false;
            this.btGerarFicha.FlatAppearance.BorderSize = 0;
            this.btGerarFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGerarFicha.Image = ((System.Drawing.Image)(resources.GetObject("btGerarFicha.Image")));
            this.btGerarFicha.Location = new System.Drawing.Point(188, 16);
            this.btGerarFicha.Name = "btGerarFicha";
            this.btGerarFicha.Size = new System.Drawing.Size(48, 48);
            this.btGerarFicha.TabIndex = 5;
            this.btGerarFicha.UseVisualStyleBackColor = false;
            // 
            // FormMenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::menu_clientes.Properties.Resources.backGradiente1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de clientes";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGerarFicha;
        private System.Windows.Forms.Button btGerarPDF;
        private System.Windows.Forms.Button btEditarCliente;
        private System.Windows.Forms.Button btAddCliente;
    }
}