namespace LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro
{
    partial class TelaParceiroForm
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
            txtIdParceiro = new TextBox();
            label1 = new Label();
            txtNomeParceiro = new TextBox();
            label2 = new Label();
            btnGravarParceiro = new Button();
            btnCancelarParceiro = new Button();
            SuspendLayout();
            // 
            // txtIdParceiro
            // 
            txtIdParceiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdParceiro.Location = new Point(74, 12);
            txtIdParceiro.Name = "txtIdParceiro";
            txtIdParceiro.ReadOnly = true;
            txtIdParceiro.Size = new Size(190, 29);
            txtIdParceiro.TabIndex = 83;
            txtIdParceiro.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 20);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 84;
            label1.Text = "Id:";
            // 
            // txtNomeParceiro
            // 
            txtNomeParceiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeParceiro.Location = new Point(74, 51);
            txtNomeParceiro.Name = "txtNomeParceiro";
            txtNomeParceiro.Size = new Size(438, 29);
            txtNomeParceiro.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 86;
            label2.Text = "Nome:";
            // 
            // btnGravarParceiro
            // 
            btnGravarParceiro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravarParceiro.DialogResult = DialogResult.OK;
            btnGravarParceiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravarParceiro.ImageAlign = ContentAlignment.BottomRight;
            btnGravarParceiro.Location = new Point(293, 114);
            btnGravarParceiro.Margin = new Padding(4);
            btnGravarParceiro.Name = "btnGravarParceiro";
            btnGravarParceiro.Size = new Size(105, 45);
            btnGravarParceiro.TabIndex = 87;
            btnGravarParceiro.Text = "Gravar";
            btnGravarParceiro.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravarParceiro.UseVisualStyleBackColor = true;
            btnGravarParceiro.Click += btnGravarParceiro_Click;
            // 
            // btnCancelarParceiro
            // 
            btnCancelarParceiro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarParceiro.DialogResult = DialogResult.Cancel;
            btnCancelarParceiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarParceiro.ImageAlign = ContentAlignment.BottomRight;
            btnCancelarParceiro.Location = new Point(406, 114);
            btnCancelarParceiro.Margin = new Padding(4);
            btnCancelarParceiro.Name = "btnCancelarParceiro";
            btnCancelarParceiro.Size = new Size(108, 45);
            btnCancelarParceiro.TabIndex = 88;
            btnCancelarParceiro.Text = "Cancelar";
            btnCancelarParceiro.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelarParceiro.UseVisualStyleBackColor = true;
            // 
            // TelaParceiroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 181);
            Controls.Add(btnCancelarParceiro);
            Controls.Add(btnGravarParceiro);
            Controls.Add(label2);
            Controls.Add(txtNomeParceiro);
            Controls.Add(label1);
            Controls.Add(txtIdParceiro);
            Name = "TelaParceiroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parceiro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdParceiro;
        private Label label1;
        private TextBox txtNomeParceiro;
        private Label label2;
        private Button btnGravarParceiro;
        private Button btnCancelarParceiro;
    }
}