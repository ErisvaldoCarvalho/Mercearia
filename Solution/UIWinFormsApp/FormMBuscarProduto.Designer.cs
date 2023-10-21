namespace UIWinFormsApp
{
    partial class FormMBuscarProduto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGrupoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(713, 415);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(632, 415);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(713, 64);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(632, 64);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(551, 64);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(470, 64);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(800, 46);
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Size = new System.Drawing.Size(325, 23);
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Nome/Descricao",
            "Código de barras",
            "Marca",
            "Fornecedor",
            "Todos"});
            // 
            // bindingSourceBusca
            // 
            this.bindingSourceBusca.DataSource = typeof(Models.Produto);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.categoriaProdutoDataGridViewTextBoxColumn,
            this.subGrupoProdutoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceBusca;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 316);
            this.dataGridView1.TabIndex = 15;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoriaProdutoDataGridViewTextBoxColumn
            // 
            this.categoriaProdutoDataGridViewTextBoxColumn.DataPropertyName = "CategoriaProduto";
            this.categoriaProdutoDataGridViewTextBoxColumn.HeaderText = "CategoriaProduto";
            this.categoriaProdutoDataGridViewTextBoxColumn.Name = "categoriaProdutoDataGridViewTextBoxColumn";
            this.categoriaProdutoDataGridViewTextBoxColumn.Width = 200;
            // 
            // subGrupoProdutoDataGridViewTextBoxColumn
            // 
            this.subGrupoProdutoDataGridViewTextBoxColumn.DataPropertyName = "SubGrupoProduto";
            this.subGrupoProdutoDataGridViewTextBoxColumn.HeaderText = "SubGrupoProduto";
            this.subGrupoProdutoDataGridViewTextBoxColumn.Name = "subGrupoProdutoDataGridViewTextBoxColumn";
            this.subGrupoProdutoDataGridViewTextBoxColumn.Width = 200;
            // 
            // FormMBuscarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMBuscarProduto";
            this.Text = "FormMBuscarProduto";
            this.Controls.SetChildIndex(this.comboBoxBuscarPor, 0);
            this.Controls.SetChildIndex(this.textBoxBuscarPor, 0);
            this.Controls.SetChildIndex(this.labelTitulo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.buttonBuscar, 0);
            this.Controls.SetChildIndex(this.buttonInserir, 0);
            this.Controls.SetChildIndex(this.buttonAlterar, 0);
            this.Controls.SetChildIndex(this.buttonExcluir, 0);
            this.Controls.SetChildIndex(this.buttonSelecionar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subGrupoProdutoDataGridViewTextBoxColumn;
    }
}