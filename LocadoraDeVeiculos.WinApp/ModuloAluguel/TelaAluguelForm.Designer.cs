namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            txtValorTotalPrevisto = new TextBox();
            txtDataLocacao = new DateTimePicker();
            cmbFuncionario = new ComboBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            lblValorPrevisto = new Label();
            btnAplicarCupom = new Button();
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
            txtDataPrevista = new DateTimePicker();
            txtKmAutomovel = new TextBox();
            label11 = new Label();
            txtKmPercorrido = new TextBox();
            lblKmPercorrido = new Label();
            lblNivelTanque = new Label();
            cmbNivelTanque = new ComboBox();
            txtKmFinal = new TextBox();
            lblKmFinal = new Label();
            lblDataDevolucao = new Label();
            txtDataDevolucao = new DateTimePicker();
            lblValorFinal = new Label();
            txtValorTotalFinal = new TextBox();
            listBoxTaxasAdicionadas = new TabControl();
            Taxas_E_Serviços = new TabPage();
            listBoxTaxasIniciais = new CheckedListBox();
            tabPage2 = new TabPage();
            listBoxTaxasExtras = new CheckedListBox();
            listBoxTaxasAdicionadas.SuspendLayout();
            Taxas_E_Serviços.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // txtValorTotalPrevisto
            // 
            txtValorTotalPrevisto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotalPrevisto.Location = new Point(241, 592);
            txtValorTotalPrevisto.Name = "txtValorTotalPrevisto";
            txtValorTotalPrevisto.ReadOnly = true;
            txtValorTotalPrevisto.Size = new Size(200, 29);
            txtValorTotalPrevisto.TabIndex = 90;
            txtValorTotalPrevisto.Text = "0.00";
            // 
            // txtDataLocacao
            // 
            txtDataLocacao.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataLocacao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataLocacao.Format = DateTimePickerFormat.Short;
            txtDataLocacao.Location = new Point(241, 154);
            txtDataLocacao.Name = "txtDataLocacao";
            txtDataLocacao.Size = new Size(200, 25);
            txtDataLocacao.TabIndex = 89;
            txtDataLocacao.Value = new DateTime(2023, 8, 1, 22, 0, 14, 0);
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuncionario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(241, 22);
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
            btnCancelar.Location = new Point(759, 659);
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
            btnGravar.Location = new Point(653, 659);
            btnGravar.Margin = new Padding(4);
            btnGravar.MinimumSize = new Size(94, 41);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 86;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // lblValorPrevisto
            // 
            lblValorPrevisto.AutoSize = true;
            lblValorPrevisto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorPrevisto.Location = new Point(74, 595);
            lblValorPrevisto.Name = "lblValorPrevisto";
            lblValorPrevisto.Size = new Size(145, 21);
            lblValorPrevisto.TabIndex = 91;
            lblValorPrevisto.Text = "Valor Total Previsto:";
            // 
            // btnAplicarCupom
            // 
            btnAplicarCupom.Enabled = false;
            btnAplicarCupom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAplicarCupom.Location = new Point(338, 214);
            btnAplicarCupom.Name = "btnAplicarCupom";
            btnAplicarCupom.Size = new Size(103, 23);
            btnAplicarCupom.TabIndex = 93;
            btnAplicarCupom.Text = "Aplicar Cupom";
            btnAplicarCupom.UseVisualStyleBackColor = true;
            btnAplicarCupom.Click += btnAplicarCupom_Click;
            // 
            // txtCupom
            // 
            txtCupom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCupom.Location = new Point(241, 185);
            txtCupom.Name = "txtCupom";
            txtCupom.Size = new Size(200, 23);
            txtCupom.TabIndex = 94;
            txtCupom.TextChanged += txtCupom_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 25);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 95;
            label2.Text = "Funcionario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(171, 70);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 97;
            label3.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(241, 67);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(200, 23);
            cmbCliente.TabIndex = 96;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(93, 99);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 99;
            label4.Text = "Grupo de Automoveis:";
            // 
            // cmbGAutomovel
            // 
            cmbGAutomovel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGAutomovel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGAutomovel.FormattingEnabled = true;
            cmbGAutomovel.Location = new Point(241, 96);
            cmbGAutomovel.Name = "cmbGAutomovel";
            cmbGAutomovel.Size = new Size(200, 23);
            cmbGAutomovel.TabIndex = 98;
            cmbGAutomovel.SelectedIndexChanged += cmbGAutomovel_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(108, 128);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 101;
            label5.Text = "Plano de Cobrança:";
            // 
            // cmbPCobranca
            // 
            cmbPCobranca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPCobranca.Enabled = false;
            cmbPCobranca.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPCobranca.FormattingEnabled = true;
            cmbPCobranca.Location = new Point(241, 125);
            cmbPCobranca.Name = "cmbPCobranca";
            cmbPCobranca.Size = new Size(200, 23);
            cmbPCobranca.TabIndex = 100;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(568, 70);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 103;
            label6.Text = "Condutor:";
            // 
            // cmbCondutor
            // 
            cmbCondutor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondutor.Enabled = false;
            cmbCondutor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCondutor.FormattingEnabled = true;
            cmbCondutor.Location = new Point(653, 67);
            cmbCondutor.Name = "cmbCondutor";
            cmbCondutor.Size = new Size(200, 23);
            cmbCondutor.TabIndex = 102;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(560, 99);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 105;
            label7.Text = "Automóvel:";
            // 
            // cmbAutomovel
            // 
            cmbAutomovel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutomovel.Enabled = false;
            cmbAutomovel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAutomovel.FormattingEnabled = true;
            cmbAutomovel.Location = new Point(653, 96);
            cmbAutomovel.Name = "cmbAutomovel";
            cmbAutomovel.Size = new Size(200, 23);
            cmbAutomovel.TabIndex = 104;
            cmbAutomovel.SelectedIndexChanged += cmbAutomovel_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(453, 130);
            label8.Name = "label8";
            label8.Size = new Size(176, 15);
            label8.TabIndex = 107;
            label8.Text = "Quilometragem  do Automóvel:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(120, 157);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 108;
            label9.Text = "Data de Locação:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(477, 162);
            label10.Name = "label10";
            label10.Size = new Size(153, 15);
            label10.TabIndex = 109;
            label10.Text = "Data Prevista da Devolução:";
            // 
            // txtDataPrevista
            // 
            txtDataPrevista.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataPrevista.Format = DateTimePickerFormat.Short;
            txtDataPrevista.Location = new Point(653, 154);
            txtDataPrevista.Name = "txtDataPrevista";
            txtDataPrevista.Size = new Size(200, 25);
            txtDataPrevista.TabIndex = 110;
            txtDataPrevista.Value = new DateTime(2023, 8, 1, 22, 0, 14, 0);
            // 
            // txtKmAutomovel
            // 
            txtKmAutomovel.Enabled = false;
            txtKmAutomovel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtKmAutomovel.Location = new Point(653, 125);
            txtKmAutomovel.Name = "txtKmAutomovel";
            txtKmAutomovel.Size = new Size(200, 23);
            txtKmAutomovel.TabIndex = 111;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(98, 188);
            label11.Name = "label11";
            label11.Size = new Size(119, 15);
            label11.TabIndex = 112;
            label11.Text = "Cupom de Desconto:";
            // 
            // txtKmPercorrido
            // 
            txtKmPercorrido.Enabled = false;
            txtKmPercorrido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtKmPercorrido.Location = new Point(653, 186);
            txtKmPercorrido.Name = "txtKmPercorrido";
            txtKmPercorrido.Size = new Size(200, 23);
            txtKmPercorrido.TabIndex = 146;
            txtKmPercorrido.Visible = false;
            txtKmPercorrido.KeyPress += txtKmPercorrido_KeyPress;
            // 
            // lblKmPercorrido
            // 
            lblKmPercorrido.AutoSize = true;
            lblKmPercorrido.Enabled = false;
            lblKmPercorrido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblKmPercorrido.Location = new Point(478, 189);
            lblKmPercorrido.Name = "lblKmPercorrido";
            lblKmPercorrido.Size = new Size(151, 15);
            lblKmPercorrido.TabIndex = 145;
            lblKmPercorrido.Text = "Quilometragem Percorrida:";
            lblKmPercorrido.Visible = false;
            // 
            // lblNivelTanque
            // 
            lblNivelTanque.AutoSize = true;
            lblNivelTanque.Enabled = false;
            lblNivelTanque.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNivelTanque.Location = new Point(551, 218);
            lblNivelTanque.Name = "lblNivelTanque";
            lblNivelTanque.Size = new Size(78, 15);
            lblNivelTanque.TabIndex = 148;
            lblNivelTanque.Text = "Nivel Tanque:";
            lblNivelTanque.Visible = false;
            // 
            // cmbNivelTanque
            // 
            cmbNivelTanque.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelTanque.Enabled = false;
            cmbNivelTanque.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbNivelTanque.FormattingEnabled = true;
            cmbNivelTanque.Location = new Point(653, 215);
            cmbNivelTanque.Name = "cmbNivelTanque";
            cmbNivelTanque.Size = new Size(200, 23);
            cmbNivelTanque.TabIndex = 147;
            cmbNivelTanque.Visible = false;
            // 
            // txtKmFinal
            // 
            txtKmFinal.Enabled = false;
            txtKmFinal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtKmFinal.Location = new Point(653, 244);
            txtKmFinal.Name = "txtKmFinal";
            txtKmFinal.Size = new Size(200, 23);
            txtKmFinal.TabIndex = 150;
            txtKmFinal.Visible = false;
            // 
            // lblKmFinal
            // 
            lblKmFinal.AutoSize = true;
            lblKmFinal.Enabled = false;
            lblKmFinal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblKmFinal.Location = new Point(428, 247);
            lblKmFinal.Name = "lblKmFinal";
            lblKmFinal.Size = new Size(201, 15);
            lblKmFinal.TabIndex = 149;
            lblKmFinal.Text = "Quilometragem Final do Automóvel:";
            lblKmFinal.Visible = false;
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataDevolucao.Location = new Point(520, 281);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new Size(109, 15);
            lblDataDevolucao.TabIndex = 152;
            lblDataDevolucao.Text = "Data da Devolução:";
            // 
            // txtDataDevolucao
            // 
            txtDataDevolucao.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataDevolucao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataDevolucao.Format = DateTimePickerFormat.Short;
            txtDataDevolucao.Location = new Point(653, 273);
            txtDataDevolucao.Name = "txtDataDevolucao";
            txtDataDevolucao.Size = new Size(200, 25);
            txtDataDevolucao.TabIndex = 151;
            txtDataDevolucao.Value = new DateTime(2023, 8, 1, 22, 0, 14, 0);
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Enabled = false;
            lblValorFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorFinal.Location = new Point(94, 636);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(122, 21);
            lblValorFinal.TabIndex = 154;
            lblValorFinal.Text = "Valor Total Final:";
            lblValorFinal.Visible = false;
            // 
            // txtValorTotalFinal
            // 
            txtValorTotalFinal.Enabled = false;
            txtValorTotalFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTotalFinal.Location = new Point(241, 633);
            txtValorTotalFinal.Name = "txtValorTotalFinal";
            txtValorTotalFinal.ReadOnly = true;
            txtValorTotalFinal.Size = new Size(200, 29);
            txtValorTotalFinal.TabIndex = 153;
            txtValorTotalFinal.Text = "0.00";
            txtValorTotalFinal.Visible = false;
            // 
            // listBoxTaxasAdicionadas
            // 
            listBoxTaxasAdicionadas.AccessibleName = "Taxas e Serviços";
            listBoxTaxasAdicionadas.Controls.Add(Taxas_E_Serviços);
            listBoxTaxasAdicionadas.Controls.Add(tabPage2);
            listBoxTaxasAdicionadas.Location = new Point(124, 328);
            listBoxTaxasAdicionadas.Name = "listBoxTaxasAdicionadas";
            listBoxTaxasAdicionadas.SelectedIndex = 0;
            listBoxTaxasAdicionadas.Size = new Size(729, 231);
            listBoxTaxasAdicionadas.TabIndex = 155;
            listBoxTaxasAdicionadas.Tag = "";
            listBoxTaxasAdicionadas.Visible = false;
            // 
            // Taxas_E_Serviços
            // 
            Taxas_E_Serviços.Controls.Add(listBoxTaxasIniciais);
            Taxas_E_Serviços.Location = new Point(4, 24);
            Taxas_E_Serviços.Name = "Taxas_E_Serviços";
            Taxas_E_Serviços.Padding = new Padding(3);
            Taxas_E_Serviços.Size = new Size(721, 203);
            Taxas_E_Serviços.TabIndex = 0;
            Taxas_E_Serviços.Text = "Taxas e Serviços";
            Taxas_E_Serviços.UseVisualStyleBackColor = true;
            // 
            // listBoxTaxasIniciais
            // 
            listBoxTaxasIniciais.FormattingEnabled = true;
            listBoxTaxasIniciais.Location = new Point(0, 0);
            listBoxTaxasIniciais.Name = "listBoxTaxasIniciais";
            listBoxTaxasIniciais.Size = new Size(721, 202);
            listBoxTaxasIniciais.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBoxTaxasExtras);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(721, 203);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Taxas e Serviços Extras";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxTaxasExtras
            // 
            listBoxTaxasExtras.FormattingEnabled = true;
            listBoxTaxasExtras.Location = new Point(0, 1);
            listBoxTaxasExtras.Name = "listBoxTaxasExtras";
            listBoxTaxasExtras.Size = new Size(725, 202);
            listBoxTaxasExtras.TabIndex = 1;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 732);
            Controls.Add(listBoxTaxasAdicionadas);
            Controls.Add(lblValorFinal);
            Controls.Add(txtValorTotalFinal);
            Controls.Add(lblDataDevolucao);
            Controls.Add(txtDataDevolucao);
            Controls.Add(txtKmFinal);
            Controls.Add(lblKmFinal);
            Controls.Add(lblNivelTanque);
            Controls.Add(cmbNivelTanque);
            Controls.Add(txtKmPercorrido);
            Controls.Add(lblKmPercorrido);
            Controls.Add(label11);
            Controls.Add(txtKmAutomovel);
            Controls.Add(txtDataPrevista);
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
            Controls.Add(btnAplicarCupom);
            Controls.Add(lblValorPrevisto);
            Controls.Add(txtValorTotalPrevisto);
            Controls.Add(txtDataLocacao);
            Controls.Add(cmbFuncionario);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Cadastro de Alugueis";
            listBoxTaxasAdicionadas.ResumeLayout(false);
            Taxas_E_Serviços.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorTotalPrevisto;
        private DateTimePicker txtDataLocacao;
        private ComboBox cmbFuncionario;
        private Button btnCancelar;
        private Button btnGravar;
        private Label lblValorPrevisto;
        private Button btnAplicarCupom;
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
        private DateTimePicker txtDataPrevista;
        private TextBox txtKmAutomovel;
        private Label label11;
        private TextBox txtKmPercorrido;
        private Label lblKmPercorrido;
        private Label lblNivelTanque;
        private ComboBox cmbNivelTanque;
        private TextBox txtKmFinal;
        private Label lblKmFinal;
        private Label lblDataDevolucao;
        private DateTimePicker txtDataDevolucao;
        private Label lblValorFinal;
        private TextBox txtValorTotalFinal;
        private TabControl listBoxTaxasAdicionadas;
        private TabPage Taxas_E_Serviços;
        private CheckedListBox listBoxTaxasIniciais;
        private TabPage tabPage2;
        private CheckedListBox listBoxTaxasExtras;
    }
}