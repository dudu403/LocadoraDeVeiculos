namespace LocadoraDeVeiculos.WinApp.ModuloCondutor
{
    partial class TelaCondutorForm
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
            cmbCliente = new ComboBox();
            checkClienteCondutor = new CheckBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new MaskedTextBox();
            label4 = new Label();
            txtCpf = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            txtCnh = new TextBox();
            label7 = new Label();
            txtData = new DateTimePicker();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 77;
            label1.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(132, 29);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(355, 29);
            cmbCliente.TabIndex = 84;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // checkClienteCondutor
            // 
            checkClienteCondutor.AutoSize = true;
            checkClienteCondutor.Location = new Point(132, 64);
            checkClienteCondutor.Name = "checkClienteCondutor";
            checkClienteCondutor.Size = new Size(124, 19);
            checkClienteCondutor.TabIndex = 85;
            checkClienteCondutor.Text = "Cliente é condutor";
            checkClienteCondutor.UseVisualStyleBackColor = true;
            checkClienteCondutor.CheckedChanged += checkClienteCondutor_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 97);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 86;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(132, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(355, 29);
            txtNome.TabIndex = 87;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 133);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 88;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(132, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(355, 29);
            txtEmail.TabIndex = 89;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(132, 176);
            txtTelefone.Mask = "(00) 90000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(163, 29);
            txtTelefone.TabIndex = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 184);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 91;
            label4.Text = "Telefone:";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(347, 176);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(140, 29);
            txtCpf.TabIndex = 92;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(301, 184);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 93;
            label5.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(75, 230);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 94;
            label6.Text = "CNH:";
            // 
            // txtCnh
            // 
            txtCnh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCnh.Location = new Point(132, 222);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(163, 29);
            txtCnh.TabIndex = 95;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(49, 270);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 96;
            label7.Text = "Validade:";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(132, 264);
            txtData.Name = "txtData";
            txtData.Size = new Size(163, 29);
            txtData.TabIndex = 97;
            txtData.Value = new DateTime(2023, 8, 1, 22, 0, 14, 0);
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.BottomRight;
            btnGravar.Location = new Point(248, 328);
            btnGravar.Margin = new Padding(4);
            btnGravar.MinimumSize = new Size(94, 41);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(107, 41);
            btnGravar.TabIndex = 98;
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
            btnCancelar.Location = new Point(376, 328);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MinimumSize = new Size(94, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 41);
            btnCancelar.TabIndex = 99;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCondutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 382);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtData);
            Controls.Add(label7);
            Controls.Add(txtCnh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCpf);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(checkClienteCondutor);
            Controls.Add(cmbCliente);
            Controls.Add(label1);
            Name = "TelaCondutorForm";
            Text = "Cadastro Condutor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCliente;
        private CheckBox checkClienteCondutor;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEmail;
        private MaskedTextBox txtTelefone;
        private Label label4;
        private MaskedTextBox txtCpf;
        private Label label5;
        private Label label6;
        private TextBox txtCnh;
        private Label label7;
        private DateTimePicker txtData;
        private Button btnGravar;
        private Button btnCancelar;
    }
}