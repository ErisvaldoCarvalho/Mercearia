namespace UIWinFormsApp
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeContasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeContasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeNotasFiscaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixaKardexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasBancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.produtosToolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem.Text = "Usuários";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Grupos de usuários";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDeContasAReceberToolStripMenuItem,
            this.controleDeContasAPagarToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // controleDeContasAReceberToolStripMenuItem
            // 
            this.controleDeContasAReceberToolStripMenuItem.Name = "controleDeContasAReceberToolStripMenuItem";
            this.controleDeContasAReceberToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.controleDeContasAReceberToolStripMenuItem.Text = "Controle de contas a receber";
            // 
            // controleDeContasAPagarToolStripMenuItem
            // 
            this.controleDeContasAPagarToolStripMenuItem.Name = "controleDeContasAPagarToolStripMenuItem";
            this.controleDeContasAPagarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.controleDeContasAPagarToolStripMenuItem.Text = "Controle de contas a pagar";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDVToolStripMenuItem,
            this.devoluçõesToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // pDVToolStripMenuItem
            // 
            this.pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            this.pDVToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pDVToolStripMenuItem.Text = "PDV";
            // 
            // devoluçõesToolStripMenuItem
            // 
            this.devoluçõesToolStripMenuItem.Name = "devoluçõesToolStripMenuItem";
            this.devoluçõesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.devoluçõesToolStripMenuItem.Text = "Devoluções";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaDeNotasFiscaisToolStripMenuItem,
            this.devoluçõesToolStripMenuItem1});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // entradaDeNotasFiscaisToolStripMenuItem
            // 
            this.entradaDeNotasFiscaisToolStripMenuItem.Name = "entradaDeNotasFiscaisToolStripMenuItem";
            this.entradaDeNotasFiscaisToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.entradaDeNotasFiscaisToolStripMenuItem.Text = "Entrada de notas fiscais";
            // 
            // devoluçõesToolStripMenuItem1
            // 
            this.devoluçõesToolStripMenuItem1.Name = "devoluçõesToolStripMenuItem1";
            this.devoluçõesToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.devoluçõesToolStripMenuItem1.Text = "Devoluções";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixaKardexToolStripMenuItem,
            this.dREToolStripMenuItem,
            this.orçamentosToolStripMenuItem,
            this.contasAReceberToolStripMenuItem,
            this.contasAPagarToolStripMenuItem,
            this.fluxoDeCaixaToolStripMenuItem,
            this.contasBancosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // fixaKardexToolStripMenuItem
            // 
            this.fixaKardexToolStripMenuItem.Name = "fixaKardexToolStripMenuItem";
            this.fixaKardexToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fixaKardexToolStripMenuItem.Text = "Fixa kardex";
            // 
            // dREToolStripMenuItem
            // 
            this.dREToolStripMenuItem.Name = "dREToolStripMenuItem";
            this.dREToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dREToolStripMenuItem.Text = "DRE";
            // 
            // orçamentosToolStripMenuItem
            // 
            this.orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            this.orçamentosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.orçamentosToolStripMenuItem.Text = "Orçamentos";
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.contasAReceberToolStripMenuItem.Text = "Contas a receber";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.contasAPagarToolStripMenuItem.Text = "Contas a pagar";
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            this.fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            this.fluxoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fluxoDeCaixaToolStripMenuItem.Text = "Fluxo de caixa";
            // 
            // contasBancosToolStripMenuItem
            // 
            this.contasBancosToolStripMenuItem.Name = "contasBancosToolStripMenuItem";
            this.contasBancosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.contasBancosToolStripMenuItem.Text = "Contas/Bancos";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem controleDeContasAReceberToolStripMenuItem;
        private ToolStripMenuItem controleDeContasAPagarToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem pDVToolStripMenuItem;
        private ToolStripMenuItem devoluçõesToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem entradaDeNotasFiscaisToolStripMenuItem;
        private ToolStripMenuItem devoluçõesToolStripMenuItem1;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem fixaKardexToolStripMenuItem;
        private ToolStripMenuItem dREToolStripMenuItem;
        private ToolStripMenuItem orçamentosToolStripMenuItem;
        private ToolStripMenuItem contasAReceberToolStripMenuItem;
        private ToolStripMenuItem contasAPagarToolStripMenuItem;
        private ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private ToolStripMenuItem contasBancosToolStripMenuItem;
    }
}