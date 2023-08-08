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
            cmbGrpAutomoveis = new ComboBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            txtKmDisponivel = new TextBox();
            lblKmDisponiveis = new Label();
            txtKmExcedente = new TextBox();
            lblPrecoKmExedente = new Label();
            txtKm = new TextBox();
            txtPrecoDiaria = new TextBox();
            cmbTipoPlano = new ComboBox();
            lblPrecoPorKm = new Label();
            lblPrecoDiaria = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbGrpAutomoveis
            // 
            cmbGrpAutomoveis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrpAutomoveis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGrpAutomoveis.FormattingEnabled = true;
            cmbGrpAutomoveis.Location = new Point(216, 31);
            cmbGrpAutomoveis.Name = "cmbGrpAutomoveis";
            cmbGrpAutomoveis.Size = new Size(338, 29);
            cmbGrpAutomoveis.TabIndex = 3;
            cmbGrpAutomoveis.SelectedIndexChanged += cmbGrpAutomoveis_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 2;
            label1.Text = "Grupo de Automoveis:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(460, 346);
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
            btnGravar.Location = new Point(358, 346);
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
            groupBox1.Controls.Add(txtKmDisponivel);
            groupBox1.Controls.Add(lblKmDisponiveis);
            groupBox1.Controls.Add(txtKmExcedente);
            groupBox1.Controls.Add(lblPrecoKmExedente);
            groupBox1.Controls.Add(txtKm);
            groupBox1.Controls.Add(txtPrecoDiaria);
            groupBox1.Controls.Add(cmbTipoPlano);
            groupBox1.Controls.Add(lblPrecoPorKm);
            groupBox1.Controls.Add(lblPrecoDiaria);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(29, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 230);
            groupBox1.TabIndex = 78;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuração de Planos";
            // 
            // txtKmDisponivel
            // 
            txtKmDisponivel.Enabled = false;
            txtKmDisponivel.Location = new Point(230, 177);
            txtKmDisponivel.Name = "txtKmDisponivel";
            txtKmDisponivel.Size = new Size(270, 29);
            txtKmDisponivel.TabIndex = 15;
            // 
            // lblKmDisponiveis
            // 
            lblKmDisponiveis.AutoSize = true;
            lblKmDisponiveis.Location = new Point(9, 180);
            lblKmDisponiveis.Name = "lblKmDisponiveis";
            lblKmDisponiveis.Size = new Size(200, 21);
            lblKmDisponiveis.TabIndex = 14;
            lblKmDisponiveis.Text = "Quilometragem Disponível:";
            // 
            // txtKmExcedente
            // 
            txtKmExcedente.Enabled = false;
            txtKmExcedente.Location = new Point(230, 142);
            txtKmExcedente.Name = "txtKmExcedente";
            txtKmExcedente.Size = new Size(270, 29);
            txtKmExcedente.TabIndex = 13;
            txtKmExcedente.KeyPress += txtPrecosLocacao_KeyPress;
            // 
            // lblPrecoKmExedente
            // 
            lblPrecoKmExedente.AutoSize = true;
            lblPrecoKmExedente.Location = new Point(36, 145);
            lblPrecoKmExedente.Name = "lblPrecoKmExedente";
            lblPrecoKmExedente.Size = new Size(172, 21);
            lblPrecoKmExedente.TabIndex = 12;
            lblPrecoKmExedente.Text = "Preço Por Km Exedente:";
            // 
            // txtKm
            // 
            txtKm.Enabled = false;
            txtKm.Location = new Point(230, 107);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(270, 29);
            txtKm.TabIndex = 11;
            txtKm.KeyPress += txtPrecosLocacao_KeyPress;
            // 
            // txtPrecoDiaria
            // 
            txtPrecoDiaria.Enabled = false;
            txtPrecoDiaria.Location = new Point(230, 72);
            txtPrecoDiaria.Name = "txtPrecoDiaria";
            txtPrecoDiaria.Size = new Size(270, 29);
            txtPrecoDiaria.TabIndex = 10;
            txtPrecoDiaria.KeyPress += txtPrecosLocacao_KeyPress;
            // 
            // cmbTipoPlano
            // 
            cmbTipoPlano.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPlano.Enabled = false;
            cmbTipoPlano.FormattingEnabled = true;
            cmbTipoPlano.Location = new Point(230, 37);
            cmbTipoPlano.Name = "cmbTipoPlano";
            cmbTipoPlano.Size = new Size(270, 29);
            cmbTipoPlano.TabIndex = 9;
            cmbTipoPlano.SelectedIndexChanged += cbmTipoPlano_SelectedIndexChanged;
            // 
            // lblPrecoPorKm
            // 
            lblPrecoPorKm.AutoSize = true;
            lblPrecoPorKm.Location = new Point(101, 110);
            lblPrecoPorKm.Name = "lblPrecoPorKm";
            lblPrecoPorKm.Size = new Size(106, 21);
            lblPrecoPorKm.TabIndex = 8;
            lblPrecoPorKm.Text = "Preço Por Km:";
            // 
            // lblPrecoDiaria
            // 
            lblPrecoDiaria.AutoSize = true;
            lblPrecoDiaria.Location = new Point(112, 77);
            lblPrecoDiaria.Name = "lblPrecoDiaria";
            lblPrecoDiaria.Size = new Size(97, 21);
            lblPrecoDiaria.TabIndex = 7;
            lblPrecoDiaria.Text = "Preço Diária:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 40);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 6;
            label2.Text = "Tipo do Plano:";
            // 
            // TelaPlanoCobrancaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 416);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cmbGrpAutomoveis);
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

        private ComboBox cmbGrpAutomoveis;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private GroupBox groupBox1;
        private TextBox txtKm;
        private TextBox txtPrecoDiaria;
        private ComboBox cmbTipoPlano;
        private Label lblPrecoPorKm;
        private Label lblPrecoDiaria;
        private Label label2;
        private TextBox txtKmExcedente;
        private Label lblPrecoKmExedente;
        private TextBox txtKmDisponivel;
        private Label lblKmDisponiveis;
    }
}