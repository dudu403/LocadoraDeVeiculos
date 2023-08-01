namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario
{
    partial class TelaFuncionarioForm
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
            txtSalario = new TextBox();
            txtData = new DateTimePicker();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.BottomRight;
            btnCancelar.Location = new Point(400, 180);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MinimumSize = new Size(94, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 41);
            btnCancelar.TabIndex = 73;
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
            btnGravar.Location = new Point(298, 180);
            btnGravar.Margin = new Padding(4);
            btnGravar.MinimumSize = new Size(94, 41);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 72;
            btnGravar.Text = "Gravar";
            btnGravar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalario.Location = new Point(87, 109);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(195, 29);
            txtSalario.TabIndex = 71;
            txtSalario.Text = "0.00";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(87, 67);
            txtData.Name = "txtData";
            txtData.Size = new Size(195, 29);
            txtData.TabIndex = 70;
            txtData.Value = new DateTime(2023, 6, 16, 0, 0, 0, 0);
            // 
            // txtNome
            // 
            txtNome.Location = new Point(87, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(407, 23);
            txtNome.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 117);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 68;
            label3.Text = "Salario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 78);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 67;
            label2.Text = "Admissão:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 66;
            label1.Text = "Nome:";
            // 
            // TelaFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 261);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtSalario);
            Controls.Add(txtData);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaFuncionarioForm";
            ShowIcon = false;
            Text = "Cadastro de Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtSalario;
        private DateTimePicker txtData;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}