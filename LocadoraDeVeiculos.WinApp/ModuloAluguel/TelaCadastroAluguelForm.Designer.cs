namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    partial class TelaCadastroAluguelForm
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
            txtValorTotal = new TextBox();
            txtData = new DateTimePicker();
            cmbFuncionario = new ComboBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            btnCupom = new Button();
            txtCupom = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbCliente = new ComboBox();
            label4 = new Label();
            cmbGAutomovel = new ComboBox();
            label5 = new Label();
            cmbPCobranca = new ComboBox();
            label6 = new Label();
            cmbCondutor = new ComboBox();
            label7 = new Label();
            cmbAutomovel = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtKmAutomovel = new TextBox();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotal.Location = new Point(218, 554);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.ReadOnly = true;
            txtValorTotal.Size = new Size(195, 29);
            txtValorTotal.TabIndex = 90;
            txtValorTotal.Text = "0.00";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(188, 155);
            txtData.Name = "txtData";
            txtData.Size = new Size(195, 29);
            txtData.TabIndex = 89;
            txtData.Value = new DateTime(2023, 8, 1, 22, 0, 14, 0);
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(188, 30);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(200, 23);
            cmbFuncionario.TabIndex = 88;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(654, 554);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MinimumSize = new Size(94, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 87;
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
            btnGravar.Location = new Point(552, 554);
            btnGravar.Margin = new Padding(4);
            btnGravar.MinimumSize = new Size(94, 41);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 86;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 562);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 91;
            label1.Text = "Valor Total Previsto:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(59, 262);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(678, 255);
            tabControl1.TabIndex = 92;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBox5);
            tabPage1.Controls.Add(checkBox4);
            tabPage1.Controls.Add(checkBox3);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(670, 227);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Taxas Selecionadas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox5.Location = new Point(47, 140);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(132, 21);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Lavação do Carro";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.Location = new Point(47, 115);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(85, 21);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Translado";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(47, 90);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(78, 21);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Frigobar";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(47, 65);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 21);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Cadeirinha";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(47, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Seguro";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnCupom
            // 
            btnCupom.Location = new Point(294, 196);
            btnCupom.Name = "btnCupom";
            btnCupom.Size = new Size(145, 23);
            btnCupom.TabIndex = 93;
            btnCupom.Text = "Aplicar Cupom";
            btnCupom.UseVisualStyleBackColor = true;
            // 
            // txtCupom
            // 
            txtCupom.Location = new Point(188, 197);
            txtCupom.Name = "txtCupom";
            txtCupom.Size = new Size(100, 23);
            txtCupom.TabIndex = 94;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 36);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 95;
            label2.Text = "Funcionario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(128, 68);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 97;
            label3.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(188, 68);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(200, 23);
            cmbCliente.TabIndex = 96;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 103);
            label4.Name = "label4";
            label4.Size = new Size(139, 17);
            label4.TabIndex = 99;
            label4.Text = "Grupo de Automoveis:";
            // 
            // cmbGAutomovel
            // 
            cmbGAutomovel.FormattingEnabled = true;
            cmbGAutomovel.Location = new Point(188, 97);
            cmbGAutomovel.Name = "cmbGAutomovel";
            cmbGAutomovel.Size = new Size(200, 23);
            cmbGAutomovel.TabIndex = 98;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 132);
            label5.Name = "label5";
            label5.Size = new Size(122, 17);
            label5.TabIndex = 101;
            label5.Text = "Plano de Cobrança:";
            // 
            // cmbPCobranca
            // 
            cmbPCobranca.FormattingEnabled = true;
            cmbPCobranca.Location = new Point(188, 126);
            cmbPCobranca.Name = "cmbPCobranca";
            cmbPCobranca.Size = new Size(200, 23);
            cmbPCobranca.TabIndex = 100;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(459, 74);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 103;
            label6.Text = "Condutor:";
            // 
            // cmbCondutor
            // 
            cmbCondutor.FormattingEnabled = true;
            cmbCondutor.Location = new Point(537, 68);
            cmbCondutor.Name = "cmbCondutor";
            cmbCondutor.Size = new Size(200, 23);
            cmbCondutor.TabIndex = 102;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(452, 103);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 105;
            label7.Text = "Automóvel:";
            // 
            // cmbAutomovel
            // 
            cmbAutomovel.FormattingEnabled = true;
            cmbAutomovel.Location = new Point(537, 97);
            cmbAutomovel.Name = "cmbAutomovel";
            cmbAutomovel.Size = new Size(200, 23);
            cmbAutomovel.TabIndex = 104;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(408, 132);
            label8.Name = "label8";
            label8.Size = new Size(117, 17);
            label8.TabIndex = 107;
            label8.Text = "KM do Automóvel:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(69, 164);
            label9.Name = "label9";
            label9.Size = new Size(109, 17);
            label9.TabIndex = 108;
            label9.Text = "Data de Locação:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(404, 164);
            label10.Name = "label10";
            label10.Size = new Size(121, 17);
            label10.TabIndex = 109;
            label10.Text = "Devolução Prevista:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(538, 155);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 29);
            dateTimePicker1.TabIndex = 110;
            dateTimePicker1.Value = new DateTime(2023, 8, 1, 22, 0, 14, 0);
            // 
            // txtKmAutomovel
            // 
            txtKmAutomovel.Location = new Point(537, 126);
            txtKmAutomovel.Name = "txtKmAutomovel";
            txtKmAutomovel.Size = new Size(200, 23);
            txtKmAutomovel.TabIndex = 111;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(125, 203);
            label11.Name = "label11";
            label11.Size = new Size(53, 17);
            label11.TabIndex = 112;
            label11.Text = "Cupom:";
            // 
            // TelaCadastroAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 630);
            Controls.Add(label11);
            Controls.Add(txtKmAutomovel);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbAutomovel);
            Controls.Add(label6);
            Controls.Add(cmbCondutor);
            Controls.Add(label5);
            Controls.Add(cmbPCobranca);
            Controls.Add(label4);
            Controls.Add(cmbGAutomovel);
            Controls.Add(label3);
            Controls.Add(cmbCliente);
            Controls.Add(label2);
            Controls.Add(txtCupom);
            Controls.Add(btnCupom);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(txtValorTotal);
            Controls.Add(txtData);
            Controls.Add(cmbFuncionario);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaCadastroAluguelForm";
            ShowIcon = false;
            Text = "Cadastro de Alugueis";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorTotal;
        private DateTimePicker txtData;
        private ComboBox cmbFuncionario;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btnCupom;
        private TextBox txtCupom;
        private Label label2;
        private Label label3;
        private ComboBox cmbCliente;
        private Label label4;
        private ComboBox cmbGAutomovel;
        private Label label5;
        private ComboBox cmbPCobranca;
        private Label label6;
        private ComboBox cmbCondutor;
        private Label label7;
        private ComboBox cmbAutomovel;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private TextBox txtKmAutomovel;
        private Label label11;
    }
}