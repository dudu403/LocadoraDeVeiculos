namespace LocadoraDeVeiculos.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtRadioPessoaFisica = new RadioButton();
            txtRadioPessoaJuridica = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            txtCep = new TextBox();
            label12 = new Label();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtBairro = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            label7 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtTelefone = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            txtCnpj = new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 67;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(146, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(407, 29);
            txtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(86, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 71;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(146, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(407, 29);
            txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 107);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 73;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 137);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 75;
            label4.Text = "Tipo de Cliente:";
            // 
            // txtRadioPessoaFisica
            // 
            txtRadioPessoaFisica.AutoSize = true;
            txtRadioPessoaFisica.Location = new Point(148, 140);
            txtRadioPessoaFisica.Name = "txtRadioPessoaFisica";
            txtRadioPessoaFisica.Size = new Size(93, 19);
            txtRadioPessoaFisica.TabIndex = 3;
            txtRadioPessoaFisica.TabStop = true;
            txtRadioPessoaFisica.Text = "Pessoa Física";
            txtRadioPessoaFisica.UseVisualStyleBackColor = true;
            txtRadioPessoaFisica.CheckedChanged += txtRadioPessoaFisica_CheckedChanged;
            // 
            // txtRadioPessoaJuridica
            // 
            txtRadioPessoaJuridica.AutoSize = true;
            txtRadioPessoaJuridica.Location = new Point(256, 140);
            txtRadioPessoaJuridica.Name = "txtRadioPessoaJuridica";
            txtRadioPessoaJuridica.Size = new Size(104, 19);
            txtRadioPessoaJuridica.TabIndex = 4;
            txtRadioPessoaJuridica.TabStop = true;
            txtRadioPessoaJuridica.Text = "Pessoa Jurídica";
            txtRadioPessoaJuridica.UseVisualStyleBackColor = true;
            txtRadioPessoaJuridica.CheckedChanged += txtRadioPessoaJuridica_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(97, 175);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 78;
            label5.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(311, 178);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 80;
            label6.Text = "CNPJ:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(txtCep);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(txtRua);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(26, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 250);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Logradouro";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.ImageAlign = ContentAlignment.BottomRight;
            btnConsultar.Location = new Point(297, 23);
            btnConsultar.Margin = new Padding(4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(104, 30);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtCep
            // 
            txtCep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCep.Location = new Point(120, 23);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(157, 29);
            txtCep.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(70, 31);
            label12.Name = "label12";
            label12.Size = new Size(40, 21);
            label12.TabIndex = 91;
            label12.Text = "CEP:";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(120, 187);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(104, 29);
            txtNumero.TabIndex = 9;
            // 
            // txtRua
            // 
            txtRua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRua.Location = new Point(120, 147);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(407, 29);
            txtRua.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(39, 190);
            label11.Name = "label11";
            label11.Size = new Size(71, 21);
            label11.TabIndex = 88;
            label11.Text = "Número:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(70, 147);
            label10.Name = "label10";
            label10.Size = new Size(40, 21);
            label10.TabIndex = 87;
            label10.Text = "Rua:";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(120, 109);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(407, 29);
            txtBairro.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(55, 109);
            label9.Name = "label9";
            label9.Size = new Size(55, 21);
            label9.TabIndex = 86;
            label9.Text = "Bairro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(297, 77);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 85;
            label8.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(360, 69);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(167, 29);
            txtCidade.TabIndex = 11;
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(120, 69);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(157, 29);
            txtEstado.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 72);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 83;
            label7.Text = "Estado:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.BottomRight;
            btnGravar.Location = new Point(323, 483);
            btnGravar.Margin = new Padding(4);
            btnGravar.MinimumSize = new Size(94, 41);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(434, 483);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MinimumSize = new Size(94, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(146, 107);
            txtTelefone.Mask = "(00) 90000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(154, 29);
            txtTelefone.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(143, 175);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(157, 29);
            txtCpf.TabIndex = 5;
            // 
            // txtCnpj
            // 
            txtCnpj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCnpj.Location = new Point(366, 175);
            txtCnpj.Mask = "00.000.000/0000-00";
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(187, 29);
            txtCnpj.TabIndex = 83;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 533);
            Controls.Add(txtCnpj);
            Controls.Add(txtCpf);
            Controls.Add(txtTelefone);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtRadioPessoaJuridica);
            Controls.Add(txtRadioPessoaFisica);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "TelaClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefone1;
        private Label label4;
        private RadioButton txtRadioPessoaFisica;
        private RadioButton txtRadioPessoaJuridica;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txtNumero;
        private TextBox txtRua;
        private Label label11;
        private Label label10;
        private TextBox txtBairro;
        private Label label9;
        private Label label8;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Label label7;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label12;
        private Button btnConsultar;
        private TextBox txtCep;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtCnpj;
    }
}