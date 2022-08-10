namespace projetodoyoutube
{
    partial class F_CheckedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrar_Selecionados = new System.Windows.Forms.Button();
            this.btn_limpar_Lista = new System.Windows.Forms.Button();
            this.btn_resetarLista = new System.Windows.Forms.Button();
            this.tb_NovoTransporte = new System.Windows.Forms.TextBox();
            this.btn_addNovoTransporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(46, 49);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(165, 310);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrar_Selecionados
            // 
            this.btn_mostrar_Selecionados.Location = new System.Drawing.Point(263, 49);
            this.btn_mostrar_Selecionados.Name = "btn_mostrar_Selecionados";
            this.btn_mostrar_Selecionados.Size = new System.Drawing.Size(234, 43);
            this.btn_mostrar_Selecionados.TabIndex = 1;
            this.btn_mostrar_Selecionados.Text = "Mostrar selecionados";
            this.btn_mostrar_Selecionados.UseVisualStyleBackColor = true;
            this.btn_mostrar_Selecionados.Click += new System.EventHandler(this.btn_mostrar_Selecionados_Click);
            // 
            // btn_limpar_Lista
            // 
            this.btn_limpar_Lista.Location = new System.Drawing.Point(263, 98);
            this.btn_limpar_Lista.Name = "btn_limpar_Lista";
            this.btn_limpar_Lista.Size = new System.Drawing.Size(234, 43);
            this.btn_limpar_Lista.TabIndex = 2;
            this.btn_limpar_Lista.Text = "Limpar lista";
            this.btn_limpar_Lista.UseVisualStyleBackColor = true;
            this.btn_limpar_Lista.Click += new System.EventHandler(this.btn_limpar_Lista_Click);
            // 
            // btn_resetarLista
            // 
            this.btn_resetarLista.Location = new System.Drawing.Point(263, 147);
            this.btn_resetarLista.Name = "btn_resetarLista";
            this.btn_resetarLista.Size = new System.Drawing.Size(234, 43);
            this.btn_resetarLista.TabIndex = 3;
            this.btn_resetarLista.Text = "Resetar lista";
            this.btn_resetarLista.UseVisualStyleBackColor = true;
            this.btn_resetarLista.Click += new System.EventHandler(this.btn_resetarLista_Click);
            // 
            // tb_NovoTransporte
            // 
            this.tb_NovoTransporte.Location = new System.Drawing.Point(263, 285);
            this.tb_NovoTransporte.Name = "tb_NovoTransporte";
            this.tb_NovoTransporte.Size = new System.Drawing.Size(234, 22);
            this.tb_NovoTransporte.TabIndex = 4;
            // 
            // btn_addNovoTransporte
            // 
            this.btn_addNovoTransporte.Location = new System.Drawing.Point(263, 313);
            this.btn_addNovoTransporte.Name = "btn_addNovoTransporte";
            this.btn_addNovoTransporte.Size = new System.Drawing.Size(234, 43);
            this.btn_addNovoTransporte.TabIndex = 5;
            this.btn_addNovoTransporte.Text = "Adicionar novo transporte";
            this.btn_addNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_addNovoTransporte.Click += new System.EventHandler(this.btn_addNovoTransporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addNovoTransporte);
            this.Controls.Add(this.tb_NovoTransporte);
            this.Controls.Add(this.btn_resetarLista);
            this.Controls.Add(this.btn_limpar_Lista);
            this.Controls.Add(this.btn_mostrar_Selecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrar_Selecionados;
        private System.Windows.Forms.Button btn_limpar_Lista;
        private System.Windows.Forms.Button btn_resetarLista;
        private System.Windows.Forms.TextBox tb_NovoTransporte;
        private System.Windows.Forms.Button btn_addNovoTransporte;
        private System.Windows.Forms.Label label1;
    }
}