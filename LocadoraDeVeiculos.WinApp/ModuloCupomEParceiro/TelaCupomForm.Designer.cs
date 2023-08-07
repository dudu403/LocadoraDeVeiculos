namespace LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro
{
    partial class TelaCupomForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            cmbParceiro = new ComboBox();
            txtData = new DateTimePicker();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(366, 214);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MinimumSize = new Size(94, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 75;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.BottomRight;
            btnGravar.Location = new Point(264, 214);
            btnGravar.Margin = new Padding(4);
            btnGravar.MinimumSize = new Size(94, 41);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 74;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 40);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 76;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 77);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 77;
            label2.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 109);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 78;
            label3.Text = "Data Validade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 136);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 79;
            label4.Text = "Parceiro:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(121, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(339, 23);
            txtNome.TabIndex = 80;
            // 
            // cmbParceiro
            // 
            cmbParceiro.FormattingEnabled = true;
            cmbParceiro.Location = new Point(121, 133);
            cmbParceiro.Name = "cmbParceiro";
            cmbParceiro.Size = new Size(200, 23);
            cmbParceiro.TabIndex = 83;
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(121, 98);
            txtData.Name = "txtData";
            txtData.Size = new Size(195, 29);
            txtData.TabIndex = 84;
            txtData.Value = new DateTime(2023, 8, 1, 22, 0, 14, 0);
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(121, 63);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(195, 29);
            txtValor.TabIndex = 85;
            txtValor.Text = "0.00";
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // TelaCupomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 304);
            Controls.Add(txtValor);
            Controls.Add(txtData);
            Controls.Add(cmbParceiro);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaCupomForm";
            ShowIcon = false;
            Text = "Cadastro de Cupom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private ComboBox cmbParceiro;
        private DateTimePicker txtData;
        private TextBox txtValor;
    }
}