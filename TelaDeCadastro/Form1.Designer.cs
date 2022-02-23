namespace TelaDeCadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtProcurarCliente = new System.Windows.Forms.TextBox();
            this.btnProcurarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.btnMostrarVenda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 134);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1074, 420);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPF";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data de Nascimento";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sexo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(934, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.Location = new System.Drawing.Point(1015, 23);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 21;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(32, 22);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(107, 15);
            this.lblPesquisa.TabIndex = 22;
            this.lblPesquisa.Text = "Pesquise o cliente";
            // 
            // txtProcurarCliente
            // 
            this.txtProcurarCliente.Location = new System.Drawing.Point(272, 19);
            this.txtProcurarCliente.MaxLength = 50;
            this.txtProcurarCliente.Name = "txtProcurarCliente";
            this.txtProcurarCliente.Size = new System.Drawing.Size(200, 20);
            this.txtProcurarCliente.TabIndex = 23;
            // 
            // btnProcurarCliente
            // 
            this.btnProcurarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarCliente.Location = new System.Drawing.Point(478, 18);
            this.btnProcurarCliente.Name = "btnProcurarCliente";
            this.btnProcurarCliente.Size = new System.Drawing.Size(89, 23);
            this.btnProcurarCliente.TabIndex = 24;
            this.btnProcurarCliente.Text = "Procurar";
            this.btnProcurarCliente.UseVisualStyleBackColor = true;
            this.btnProcurarCliente.Click += new System.EventHandler(this.btnProcurarCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrarVenda);
            this.groupBox1.Controls.Add(this.cmbTipoPesquisa);
            this.groupBox1.Controls.Add(this.lblPesquisa);
            this.groupBox1.Controls.Add(this.btnProcurarCliente);
            this.groupBox1.Controls.Add(this.txtProcurarCliente);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 82);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbTipoPesquisa
            // 
            this.cmbTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPesquisa.FormattingEnabled = true;
            this.cmbTipoPesquisa.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Data Nascimento"});
            this.cmbTipoPesquisa.Location = new System.Drawing.Point(145, 19);
            this.cmbTipoPesquisa.Name = "cmbTipoPesquisa";
            this.cmbTipoPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPesquisa.TabIndex = 25;
            this.cmbTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPesquisa_SelectedIndexChanged);
            // 
            // btnMostrarVenda
            // 
            this.btnMostrarVenda.Location = new System.Drawing.Point(888, 18);
            this.btnMostrarVenda.Name = "btnMostrarVenda";
            this.btnMostrarVenda.Size = new System.Drawing.Size(180, 23);
            this.btnMostrarVenda.TabIndex = 26;
            this.btnMostrarVenda.Text = "Mostrar venda";
            this.btnMostrarVenda.UseVisualStyleBackColor = true;
            this.btnMostrarVenda.Click += new System.EventHandler(this.btnMostrarVenda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtProcurarCliente;
        private System.Windows.Forms.Button btnProcurarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoPesquisa;
        private System.Windows.Forms.Button btnMostrarVenda;
    }
}

