namespace SeparadorTokens3._0
{
    partial class btnImpLex
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.codigotxt = new System.Windows.Forms.RichTextBox();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLexemas = new System.Windows.Forms.Button();
            this.lexemastxt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(12, 12);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(250, 403);
            this.codigotxt.TabIndex = 0;
            this.codigotxt.Text = "";
            // 
            // dgvTokens
            // 
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Descripción});
            this.dgvTokens.Location = new System.Drawing.Point(286, 12);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.RowTemplate.Height = 24;
            this.dgvTokens.Size = new System.Drawing.Size(453, 447);
            this.dgvTokens.TabIndex = 1;
            this.dgvTokens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTokens_CellContentClick);
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(31, 421);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(95, 38);
            this.btnAnalizar.TabIndex = 2;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(155, 421);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(95, 38);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Importar";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLexemas
            // 
            this.btnLexemas.Location = new System.Drawing.Point(756, 421);
            this.btnLexemas.Name = "btnLexemas";
            this.btnLexemas.Size = new System.Drawing.Size(137, 38);
            this.btnLexemas.TabIndex = 4;
            this.btnLexemas.Text = "Importar Lexemas";
            this.btnLexemas.UseVisualStyleBackColor = true;
            this.btnLexemas.Click += new System.EventHandler(this.button1_Click);
            // 
            // lexemastxt
            // 
            this.lexemastxt.Location = new System.Drawing.Point(756, 12);
            this.lexemastxt.Name = "lexemastxt";
            this.lexemastxt.Size = new System.Drawing.Size(254, 403);
            this.lexemastxt.TabIndex = 5;
            this.lexemastxt.Text = "";
            // 
            // btnImpLex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 471);
            this.Controls.Add(this.lexemastxt);
            this.Controls.Add(this.btnLexemas);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.codigotxt);
            this.Name = "btnImpLex";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox codigotxt;
        private System.Windows.Forms.DataGridView dgvTokens;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLexemas;
        private System.Windows.Forms.RichTextBox lexemastxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
    }
}

