namespace TelaDeCadastro.telas
{
    partial class CadastroVendaTela
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
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarCadastroVenda = new System.Windows.Forms.Button();
            this.btnVerValorTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(15, 151);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(138, 20);
            this.txtNomeVendedor.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nome do Vendedor";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(107, 309);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(138, 20);
            this.txtValorTotal.TabIndex = 26;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(15, 272);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(138, 20);
            this.txtPrecoUnitario.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Preço Unitario";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "U",
            "Kg",
            "M"});
            this.cmbUnidade.Location = new System.Drawing.Point(15, 194);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(138, 21);
            this.cmbUnidade.TabIndex = 23;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(15, 234);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(138, 20);
            this.txtQuantidade.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Unidade";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(15, 110);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(138, 20);
            this.txtNomeProduto.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome do Produto";
            // 
            // btnSalvarCadastroVenda
            // 
            this.btnSalvarCadastroVenda.Location = new System.Drawing.Point(15, 346);
            this.btnSalvarCadastroVenda.Name = "btnSalvarCadastroVenda";
            this.btnSalvarCadastroVenda.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCadastroVenda.TabIndex = 17;
            this.btnSalvarCadastroVenda.Text = "Salvar";
            this.btnSalvarCadastroVenda.UseVisualStyleBackColor = true;
            this.btnSalvarCadastroVenda.Click += new System.EventHandler(this.btnSalvarCadastroVenda_Click);
            // 
            // btnVerValorTotal
            // 
            this.btnVerValorTotal.Location = new System.Drawing.Point(15, 307);
            this.btnVerValorTotal.Name = "btnVerValorTotal";
            this.btnVerValorTotal.Size = new System.Drawing.Size(90, 23);
            this.btnVerValorTotal.TabIndex = 16;
            this.btnVerValorTotal.Text = "Ver valor total";
            this.btnVerValorTotal.UseVisualStyleBackColor = true;
            this.btnVerValorTotal.Click += new System.EventHandler(this.btnVerValorTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Cadastro de Venda";
            // 
            // CadastroVendaTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvarCadastroVenda);
            this.Controls.Add(this.btnVerValorTotal);
            this.Name = "CadastroVendaTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroVendaTela";
            this.Load += new System.EventHandler(this.CadastroVendaTela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarCadastroVenda;
        private System.Windows.Forms.Button btnVerValorTotal;
        private System.Windows.Forms.Label label1;
    }
}