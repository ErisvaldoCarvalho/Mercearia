namespace UIWinFormsApp
{
    partial class FormMBuscarUsuario
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
            this.nomeUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Text = "Busca de usuário";
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Nome",
            "Todos"});
            // 
            // bindingSourceBusca
            // 
            this.bindingSourceBusca.DataSource = typeof(Models.Usuario);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nomeUsuarioDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceBusca;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(708, 237);
            this.dataGridView1.TabIndex = 15;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeUsuarioDataGridViewTextBoxColumn
            // 
            this.nomeUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NomeUsuario";
            this.nomeUsuarioDataGridViewTextBoxColumn.HeaderText = "Nome de usuário";
            this.nomeUsuarioDataGridViewTextBoxColumn.Name = "nomeUsuarioDataGridViewTextBoxColumn";
            this.nomeUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 50;
            // 
            // FormMBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 371);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMBuscarUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMBuscarUsuario_FormClosing);
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
        private DataGridViewTextBoxColumn nomeUsuarioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
    }
}