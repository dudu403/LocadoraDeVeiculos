namespace LocadoraDeVeiculos.WinApp.ModuloConfigPreco
{
    partial class TelaConfigPrecoForm
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
            label2 = new Label();
            label1 = new Label();
            numPrecoGasolina = new NumericUpDown();
            numPrecoAlcool = new NumericUpDown();
            numPrecoDisel = new NumericUpDown();
            numPrecoGas = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPrecoGasolina).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecoAlcool).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecoDisel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecoGas).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(229, 283);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 78;
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
            btnGravar.Location = new Point(100, 283);
            btnGravar.Margin = new Padding(4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 77;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 88);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 76;
            label2.Text = "Preço do Álcool:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 28);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 75;
            label1.Text = "Preço da Gasolina:";
            // 
            // numPrecoGasolina
            // 
            numPrecoGasolina.DecimalPlaces = 2;
            numPrecoGasolina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numPrecoGasolina.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numPrecoGasolina.Location = new Point(229, 26);
            numPrecoGasolina.Name = "numPrecoGasolina";
            numPrecoGasolina.Size = new Size(94, 29);
            numPrecoGasolina.TabIndex = 73;
            numPrecoGasolina.Value = new decimal(new int[] { 400, 0, 0, 131072 });
            numPrecoGasolina.KeyPress += numPrecos_KeyPress;
            // 
            // numPrecoAlcool
            // 
            numPrecoAlcool.DecimalPlaces = 2;
            numPrecoAlcool.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numPrecoAlcool.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numPrecoAlcool.Location = new Point(229, 86);
            numPrecoAlcool.Name = "numPrecoAlcool";
            numPrecoAlcool.Size = new Size(94, 29);
            numPrecoAlcool.TabIndex = 79;
            numPrecoAlcool.Value = new decimal(new int[] { 360, 0, 0, 131072 });
            numPrecoAlcool.KeyPress += numPrecos_KeyPress;
            // 
            // numPrecoDisel
            // 
            numPrecoDisel.DecimalPlaces = 2;
            numPrecoDisel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numPrecoDisel.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numPrecoDisel.Location = new Point(229, 148);
            numPrecoDisel.Name = "numPrecoDisel";
            numPrecoDisel.Size = new Size(94, 29);
            numPrecoDisel.TabIndex = 80;
            numPrecoDisel.Value = new decimal(new int[] { 330, 0, 0, 131072 });
            numPrecoDisel.KeyPress += numPrecos_KeyPress;
            // 
            // numPrecoGas
            // 
            numPrecoGas.DecimalPlaces = 2;
            numPrecoGas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numPrecoGas.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numPrecoGas.Location = new Point(229, 209);
            numPrecoGas.Name = "numPrecoGas";
            numPrecoGas.Size = new Size(94, 29);
            numPrecoGas.TabIndex = 81;
            numPrecoGas.Value = new decimal(new int[] { 200, 0, 0, 131072 });
            numPrecoGas.KeyPress += numPrecos_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 211);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 82;
            label3.Text = "Preço do Gás:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(82, 150);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 83;
            label4.Text = "Preço do Disel:";
            // 
            // TelaConfigPrecoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 367);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numPrecoGas);
            Controls.Add(numPrecoDisel);
            Controls.Add(numPrecoAlcool);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numPrecoGasolina);
            Name = "TelaConfigPrecoForm";
            ShowIcon = false;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPrecoGasolina).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecoAlcool).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecoDisel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecoGas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private Label label2;
        private Label label1;
        private NumericUpDown numPrecoGasolina;
        private NumericUpDown numPrecoAlcool;
        private NumericUpDown numPrecoDisel;
        private NumericUpDown numPrecoGas;
        private Label label3;
        private Label label4;
    }
}