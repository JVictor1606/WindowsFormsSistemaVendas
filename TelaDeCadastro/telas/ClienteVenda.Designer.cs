namespace TelaDeCadastro.telas
{
    partial class ClienteVenda
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
            this.listViewClienteVenda = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeDados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCpfDados = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascimentoDados = new System.Windows.Forms.MaskedTextBox();
            this.rdbSexoDados = new System.Windows.Forms.RadioButton();
            this.rdbFemininoDados = new System.Windows.Forms.RadioButton();
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.btnAdicionarVenda = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClienteVenda
            // 
            this.listViewClienteVenda.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewClienteVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1});
            this.listViewClienteVenda.HideSelection = false;
            this.listViewClienteVenda.HotTracking = true;
            this.listViewClienteVenda.HoverSelection = true;
            this.listViewClienteVenda.Location = new System.Drawing.Point(12, 169);
            this.listViewClienteVenda.Name = "listViewClienteVenda";
            this.listViewClienteVenda.Size = new System.Drawing.Size(594, 269);
            this.listViewClienteVenda.TabIndex = 0;
            this.listViewClienteVenda.UseCompatibleStateImageBehavior = false;
            this.listViewClienteVenda.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id do cliente ";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Produto";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Unidade";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantidade";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Preço Unitario";
            this.columnHeader7.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendas do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dados do Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome do Cliente";
            // 
            // txtNomeDados
            // 
            this.txtNomeDados.Location = new System.Drawing.Point(113, 20);
            this.txtNomeDados.Name = "txtNomeDados";
            this.txtNomeDados.Size = new System.Drawing.Size(179, 20);
            this.txtNomeDados.TabIndex = 1;
            this.txtNomeDados.TextChanged += new System.EventHandler(this.txtNomeDados_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexo";
            // 
            // txtCpfDados
            // 
            this.txtCpfDados.Location = new System.Drawing.Point(113, 49);
            this.txtCpfDados.Mask = " 000,000,000-00";
            this.txtCpfDados.Name = "txtCpfDados";
            this.txtCpfDados.Size = new System.Drawing.Size(90, 20);
            this.txtCpfDados.TabIndex = 10;
            this.txtCpfDados.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpfDados_MaskInputRejected);
            // 
            // txtDataNascimentoDados
            // 
            this.txtDataNascimentoDados.Location = new System.Drawing.Point(432, 20);
            this.txtDataNascimentoDados.Mask = "00/00/0000";
            this.txtDataNascimentoDados.Name = "txtDataNascimentoDados";
            this.txtDataNascimentoDados.Size = new System.Drawing.Size(85, 20);
            this.txtDataNascimentoDados.TabIndex = 11;
            this.txtDataNascimentoDados.ValidatingType = typeof(System.DateTime);
            this.txtDataNascimentoDados.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDataNascimentoDados_MaskInputRejected);
            // 
            // rdbSexoDados
            // 
            this.rdbSexoDados.AutoSize = true;
            this.rdbSexoDados.Checked = true;
            this.rdbSexoDados.Location = new System.Drawing.Point(350, 50);
            this.rdbSexoDados.Name = "rdbSexoDados";
            this.rdbSexoDados.Size = new System.Drawing.Size(73, 17);
            this.rdbSexoDados.TabIndex = 12;
            this.rdbSexoDados.TabStop = true;
            this.rdbSexoDados.Tag = "M";
            this.rdbSexoDados.Text = "Masculino";
            this.rdbSexoDados.UseVisualStyleBackColor = true;
            this.rdbSexoDados.CheckedChanged += new System.EventHandler(this.rdbSexoDados_CheckedChanged);
            // 
            // rdbFemininoDados
            // 
            this.rdbFemininoDados.AutoSize = true;
            this.rdbFemininoDados.Location = new System.Drawing.Point(429, 50);
            this.rdbFemininoDados.Name = "rdbFemininoDados";
            this.rdbFemininoDados.Size = new System.Drawing.Size(67, 17);
            this.rdbFemininoDados.TabIndex = 13;
            this.rdbFemininoDados.Text = "Feminino";
            this.rdbFemininoDados.UseVisualStyleBackColor = true;
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.Controls.Add(this.rdbFemininoDados);
            this.groupBoxDados.Controls.Add(this.rdbSexoDados);
            this.groupBoxDados.Controls.Add(this.txtDataNascimentoDados);
            this.groupBoxDados.Controls.Add(this.txtCpfDados);
            this.groupBoxDados.Controls.Add(this.label6);
            this.groupBoxDados.Controls.Add(this.label5);
            this.groupBoxDados.Controls.Add(this.label4);
            this.groupBoxDados.Controls.Add(this.txtNomeDados);
            this.groupBoxDados.Controls.Add(this.label3);
            this.groupBoxDados.Location = new System.Drawing.Point(12, 28);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(763, 119);
            this.groupBoxDados.TabIndex = 3;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "groupBox1";
            this.groupBoxDados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAdicionarVenda
            // 
            this.btnAdicionarVenda.Location = new System.Drawing.Point(612, 169);
            this.btnAdicionarVenda.Name = "btnAdicionarVenda";
            this.btnAdicionarVenda.Size = new System.Drawing.Size(107, 23);
            this.btnAdicionarVenda.TabIndex = 4;
            this.btnAdicionarVenda.Text = "Adicionar venda";
            this.btnAdicionarVenda.UseVisualStyleBackColor = true;
            this.btnAdicionarVenda.Click += new System.EventHandler(this.btnAdicionarVenda_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Valor Total";
            this.columnHeader1.Width = 80;
            // 
            // ClienteVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionarVenda);
            this.Controls.Add(this.groupBoxDados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewClienteVenda);
            this.Name = "ClienteVenda";
            this.Text = "ClienteVenda";
            this.Load += new System.EventHandler(this.ClienteVenda_Load);
            this.groupBoxDados.ResumeLayout(false);
            this.groupBoxDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewClienteVenda;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCpfDados;
        private System.Windows.Forms.MaskedTextBox txtDataNascimentoDados;
        private System.Windows.Forms.RadioButton rdbSexoDados;
        private System.Windows.Forms.RadioButton rdbFemininoDados;
        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.Button btnAdicionarVenda;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}