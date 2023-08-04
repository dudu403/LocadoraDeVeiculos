namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca
{
    partial class TelaPlanoCobrancaForm
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
            cmbGAutomoveis = new ComboBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            txtKmExcedente = new TextBox();
            label6 = new Label();
            txtKm = new TextBox();
            txtPrecoDiaria = new TextBox();
            cbmTipoPlano = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbGAutomoveis
            // 
            cmbGAutomoveis.FormattingEnabled = true;
            cmbGAutomoveis.Location = new Point(158, 41);
            cmbGAutomoveis.Name = "cmbGAutomoveis";
            cmbGAutomoveis.Size = new Size(345, 23);
            cmbGAutomoveis.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 49);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 2;
            label1.Text = "Grupo de Automoveis";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(409, 322);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MinimumSize = new Size(94, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 77;
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
            btnGravar.Location = new Point(307, 322);
            btnGravar.Margin = new Padding(4);
            btnGravar.MinimumSize = new Size(94, 41);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 76;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKmExcedente);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtKm);
            groupBox1.Controls.Add(txtPrecoDiaria);
            groupBox1.Controls.Add(cbmTipoPlano);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(29, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 198);
            groupBox1.TabIndex = 78;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuração de Planos";
            // 
            // txtKmExcedente
            // 
            txtKmExcedente.Location = new Point(189, 138);
            txtKmExcedente.Name = "txtKmExcedente";
            txtKmExcedente.Size = new Size(256, 23);
            txtKmExcedente.TabIndex = 13;
            txtKmExcedente.KeyPress += txtPrecoLocacao_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 138);
            label6.Name = "label6";
            label6.Size = new Size(144, 15);
            label6.TabIndex = 12;
            label6.Text = "Preço por Km(Excedente):";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(189, 109);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(256, 23);
            txtKm.TabIndex = 11;
            txtKm.KeyPress += txtPrecoLocacao_KeyPress;
            // 
            // txtPrecoDiaria
            // 
            txtPrecoDiaria.Location = new Point(189, 80);
            txtPrecoDiaria.Name = "txtPrecoDiaria";
            txtPrecoDiaria.Size = new Size(256, 23);
            txtPrecoDiaria.TabIndex = 10;
            txtPrecoDiaria.KeyPress += txtPrecoLocacao_KeyPress;
            // 
            // cbmTipoPlano
            // 
            cbmTipoPlano.FormattingEnabled = true;
            cbmTipoPlano.Location = new Point(189, 48);
            cbmTipoPlano.Name = "cbmTipoPlano";
            cbmTipoPlano.Size = new Size(256, 23);
            cbmTipoPlano.TabIndex = 9;
            cbmTipoPlano.SelectedIndexChanged += cbmTipoPlano_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 108);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 8;
            label4.Text = "Preço por Km:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 79);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 7;
            label3.Text = "Preço Diária:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 51);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "Tipo do Plano:";
            // 
            // TelaPlanoCobrancaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 386);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cmbGAutomoveis);
            Controls.Add(label1);
            Name = "TelaPlanoCobrancaForm";
            ShowIcon = false;
            Text = "Plano de  Cobrança";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGAutomoveis;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private GroupBox groupBox1;
        private TextBox txtKm;
        private TextBox txtPrecoDiaria;
        private ComboBox cbmTipoPlano;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtKmExcedente;
        private Label label6;
    }
}