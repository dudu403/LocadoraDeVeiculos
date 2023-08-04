namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel
{
    partial class TelaAutomovelForm
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
            btnBuscar = new Button();
            label1 = new Label();
            cmbGrpAutomovel = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            txtModelo = new TextBox();
            label3 = new Label();
            txtMarca = new TextBox();
            label2 = new Label();
            txtCor = new TextBox();
            label5 = new Label();
            cmbTipoCombustivel = new ComboBox();
            label6 = new Label();
            numCapacidadeTanque = new NumericUpDown();
            btnCancelar = new Button();
            btnGravar = new Button();
            pctBoxFoto = new PictureBox();
            txtKm = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numCapacidadeTanque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBoxFoto).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscar.DialogResult = DialogResult.Cancel;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ImageAlign = ContentAlignment.BottomRight;
            btnBuscar.Location = new Point(602, 103);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 41);
            btnBuscar.TabIndex = 96;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(211, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 97;
            label1.Text = "Foto:";
            // 
            // cmbGrpAutomovel
            // 
            cmbGrpAutomovel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrpAutomovel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGrpAutomovel.FormattingEnabled = true;
            cmbGrpAutomovel.Location = new Point(274, 217);
            cmbGrpAutomovel.Name = "cmbGrpAutomovel";
            cmbGrpAutomovel.Size = new Size(422, 28);
            cmbGrpAutomovel.TabIndex = 100;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(52, 224);
            label7.Name = "label7";
            label7.Size = new Size(203, 21);
            label7.TabIndex = 99;
            label7.Text = "Grupo do GrupoAutomovel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(189, 270);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 106;
            label4.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(274, 267);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(422, 29);
            txtModelo.TabIndex = 105;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(199, 317);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 104;
            label3.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(274, 314);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(422, 29);
            txtMarca.TabIndex = 103;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 363);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 102;
            label2.Text = "Cor:";
            // 
            // txtCor
            // 
            txtCor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCor.Location = new Point(274, 360);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(422, 29);
            txtCor.TabIndex = 101;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 464);
            label5.Name = "label5";
            label5.Size = new Size(237, 21);
            label5.TabIndex = 108;
            label5.Text = "Capacidade do Tanque em Litros:";
            // 
            // cmbTipoCombustivel
            // 
            cmbTipoCombustivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoCombustivel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoCombustivel.FormattingEnabled = true;
            cmbTipoCombustivel.Location = new Point(274, 411);
            cmbTipoCombustivel.Name = "cmbTipoCombustivel";
            cmbTipoCombustivel.Size = new Size(208, 28);
            cmbTipoCombustivel.TabIndex = 110;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(99, 413);
            label6.Name = "label6";
            label6.Size = new Size(156, 21);
            label6.TabIndex = 109;
            label6.Text = "Tipo do Combustível:";
            // 
            // numCapacidadeTanque
            // 
            numCapacidadeTanque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numCapacidadeTanque.Location = new Point(274, 464);
            numCapacidadeTanque.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numCapacidadeTanque.Name = "numCapacidadeTanque";
            numCapacidadeTanque.Size = new Size(208, 29);
            numCapacidadeTanque.TabIndex = 111;
            numCapacidadeTanque.Value = new decimal(new int[] { 55, 0, 0, 0 });
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(602, 517);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 113;
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
            btnGravar.Location = new Point(487, 517);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 112;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // pctBoxFoto
            // 
            pctBoxFoto.Location = new Point(274, 24);
            pctBoxFoto.Name = "pctBoxFoto";
            pctBoxFoto.Size = new Size(300, 120);
            pctBoxFoto.TabIndex = 0;
            pctBoxFoto.TabStop = false;
            // 
            // txtKm
            // 
            txtKm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKm.Location = new Point(274, 164);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(208, 29);
            txtKm.TabIndex = 115;
            txtKm.Text = "0.000";
            txtKm.KeyPress += txtKm_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(132, 167);
            label8.Name = "label8";
            label8.Size = new Size(123, 21);
            label8.TabIndex = 114;
            label8.Text = "Quilometragem:";
            // 
            // TelaAutomovelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 592);
            Controls.Add(txtKm);
            Controls.Add(label8);
            Controls.Add(pctBoxFoto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(numCapacidadeTanque);
            Controls.Add(cmbTipoCombustivel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtModelo);
            Controls.Add(label3);
            Controls.Add(txtMarca);
            Controls.Add(label2);
            Controls.Add(txtCor);
            Controls.Add(cmbGrpAutomovel);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Name = "TelaAutomovelForm";
            ShowIcon = false;
            Text = "Automóvel";
            ((System.ComponentModel.ISupportInitialize)numCapacidadeTanque).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBoxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Label label1;
        private ComboBox cmbGrpAutomovel;
        private Label label7;
        private Label label4;
        private TextBox txtModelo;
        private Label label3;
        private TextBox txtMarca;
        private Label label2;
        private TextBox txtCor;
        private Label label5;
        private ComboBox cmbTipoCombustivel;
        private Label label6;
        private NumericUpDown numCapacidadeTanque;
        private Button btnCancelar;
        private Button btnGravar;
        private PictureBox pctBoxFoto;
        private TextBox txtKm;
        private Label label8;
    }
}