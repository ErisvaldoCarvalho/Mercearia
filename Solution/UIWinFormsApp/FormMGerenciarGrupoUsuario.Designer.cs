namespace UIWinFormsApp
{
    partial class FormMGerenciarGrupoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewPermissoes = new System.Windows.Forms.DataGridView();
            this.dataGridViewGrupoUsuario = new System.Windows.Forms.DataGridView();
            this.bindingSourcePermissao = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermissoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePermissao)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceCadastro
            // 
            this.bindingSourceCadastro.DataSource = typeof(Models.GrupoUsuario);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(800, 46);
            this.labelTitulo.Text = "Gerenciar grupos de usuários";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(713, 415);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(632, 415);
            // 
            // dataGridViewPermissoes
            // 
            this.dataGridViewPermissoes.AllowUserToAddRows = false;
            this.dataGridViewPermissoes.AllowUserToDeleteRows = false;
            this.dataGridViewPermissoes.AllowUserToOrderColumns = true;
            this.dataGridViewPermissoes.AutoGenerateColumns = false;
            this.dataGridViewPermissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermissoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn1});
            this.dataGridViewPermissoes.DataSource = this.bindingSourcePermissao;
            this.dataGridViewPermissoes.Location = new System.Drawing.Point(351, 78);
            this.dataGridViewPermissoes.Name = "dataGridViewPermissoes";
            this.dataGridViewPermissoes.ReadOnly = true;
            this.dataGridViewPermissoes.RowTemplate.Height = 25;
            this.dataGridViewPermissoes.Size = new System.Drawing.Size(437, 331);
            this.dataGridViewPermissoes.TabIndex = 7;
            // 
            // dataGridViewGrupoUsuario
            // 
            this.dataGridViewGrupoUsuario.AllowUserToAddRows = false;
            this.dataGridViewGrupoUsuario.AllowUserToDeleteRows = false;
            this.dataGridViewGrupoUsuario.AllowUserToOrderColumns = true;
            this.dataGridViewGrupoUsuario.AutoGenerateColumns = false;
            this.dataGridViewGrupoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupoUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridViewGrupoUsuario.DataSource = this.bindingSourceCadastro;
            this.dataGridViewGrupoUsuario.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewGrupoUsuario.Name = "dataGridViewGrupoUsuario";
            this.dataGridViewGrupoUsuario.ReadOnly = true;
            this.dataGridViewGrupoUsuario.RowTemplate.Height = 25;
            this.dataGridViewGrupoUsuario.Size = new System.Drawing.Size(333, 331);
            this.dataGridViewGrupoUsuario.TabIndex = 7;
            // 
            // bindingSourcePermissao
            // 
            this.bindingSourcePermissao.DataSource = this.bindingSourceCadastro;
            // 
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Permissões do grupo";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            this.descricaoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Grupos de usuário";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(713, 49);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 8;
            this.buttonRemover.Text = "&Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(632, 49);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 8;
            this.buttonAdicionar.Text = "&Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // FormMGerenciarGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.dataGridViewGrupoUsuario);
            this.Controls.Add(this.dataGridViewPermissoes);
            this.Name = "FormMGerenciarGrupoUsuario";
            this.Controls.SetChildIndex(this.buttonSalvar, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.labelTitulo, 0);
            this.Controls.SetChildIndex(this.dataGridViewPermissoes, 0);
            this.Controls.SetChildIndex(this.dataGridViewGrupoUsuario, 0);
            this.Controls.SetChildIndex(this.buttonRemover, 0);
            this.Controls.SetChildIndex(this.buttonAdicionar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermissoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePermissao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewPermissoes;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private BindingSource bindingSourcePermissao;
        private DataGridView dataGridViewGrupoUsuario;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private Button buttonRemover;
        private Button buttonAdicionar;
    }
}