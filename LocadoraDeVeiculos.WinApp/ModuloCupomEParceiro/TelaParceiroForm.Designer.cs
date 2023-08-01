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
            txtNomeParceiro = new TextBox();
            label2 = new Label();
            btnGravarParceiro = new Button();
            btnCancelarParceiro = new Button();
            SuspendLayout();
            // 
            // txtNomeParceiro
            // 
            txtNomeParceiro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeParceiro.Location = new Point(89, 42);
            txtNomeParceiro.Name = "txtNomeParceiro";
            txtNomeParceiro.Size = new Size(438, 29);
            txtNomeParceiro.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 45);
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
            btnGravarParceiro.Location = new Point(306, 102);
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
            btnCancelarParceiro.Location = new Point(419, 102);
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
            ClientSize = new Size(568, 173);
            Controls.Add(btnCancelarParceiro);
            Controls.Add(btnGravarParceiro);
            Controls.Add(label2);
            Controls.Add(txtNomeParceiro);
            Name = "TelaParceiroForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parceiro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNomeParceiro;
        private Label label2;
        private Button btnGravarParceiro;
        private Button btnCancelarParceiro;
    }
}