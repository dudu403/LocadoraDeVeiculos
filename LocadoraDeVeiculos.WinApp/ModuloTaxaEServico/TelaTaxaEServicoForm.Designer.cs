namespace LocadoraDeVeiculos.WinApp.ModuloTaxaEServico
{
    partial class TelaTaxaEServicoForm
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
            txtNome = new TextBox();
            label2 = new Label();
            cmbTipoCusto = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(438, 194);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 45);
            btnCancelar.TabIndex = 88;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.BottomRight;
            btnGravar.Location = new Point(316, 194);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(105, 45);
            btnGravar.TabIndex = 87;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(155, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(391, 29);
            txtNome.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 38);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 85;
            label2.Text = "Nome:";
            // 
            // cmbTipoCusto
            // 
            cmbTipoCusto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCusto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoCusto.FormattingEnabled = true;
            cmbTipoCusto.Location = new Point(155, 128);
            cmbTipoCusto.Name = "cmbTipoCusto";
            cmbTipoCusto.Size = new Size(391, 28);
            cmbTipoCusto.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 130);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 90;
            label1.Text = "Tipo do Custo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(88, 84);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 91;
            label3.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPreco.Location = new Point(155, 81);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(391, 29);
            txtPreco.TabIndex = 92;
            txtPreco.Text = "0.00";
            txtPreco.KeyPress += txtValor_KeyPress;
            // 
            // TelaTaxaEServicoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 275);
            Controls.Add(txtPreco);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbTipoCusto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Name = "TelaTaxaEServicoForm";
            ShowIcon = false;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtNome;
        private Label label2;
        private ComboBox cmbTipoCusto;
        private Label label1;
        private Label label3;
        private TextBox txtPreco;
    }
}