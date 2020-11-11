namespace Cliente_Zodeiaco_WS
{
    partial class CadastroForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Botao_Cadastro = new System.Windows.Forms.Button();
            this.boxNickname = new System.Windows.Forms.TextBox();
            this.boxSigno = new System.Windows.Forms.TextBox();
            this.Cadastro = new System.Windows.Forms.Label();
            this.Plano = new System.Windows.Forms.Label();
            this.Signo = new System.Windows.Forms.Label();
            this.label_confirma_cadastro = new System.Windows.Forms.Label();
            this.comboBox_Planos = new System.Windows.Forms.ComboBox();
            this.messageObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.messageObjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Botao_Cadastro
            // 
            this.Botao_Cadastro.Location = new System.Drawing.Point(365, 281);
            this.Botao_Cadastro.Name = "Botao_Cadastro";
            this.Botao_Cadastro.Size = new System.Drawing.Size(75, 23);
            this.Botao_Cadastro.TabIndex = 0;
            this.Botao_Cadastro.Text = "Cadastro";
            this.Botao_Cadastro.UseVisualStyleBackColor = true;
            this.Botao_Cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxNickname
            // 
            this.boxNickname.Location = new System.Drawing.Point(351, 94);
            this.boxNickname.Name = "boxNickname";
            this.boxNickname.Size = new System.Drawing.Size(121, 20);
            this.boxNickname.TabIndex = 1;
            // 
            // boxSigno
            // 
            this.boxSigno.Location = new System.Drawing.Point(351, 228);
            this.boxSigno.Name = "boxSigno";
            this.boxSigno.Size = new System.Drawing.Size(121, 20);
            this.boxSigno.TabIndex = 3;
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSize = true;
            this.Cadastro.Location = new System.Drawing.Point(348, 75);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(57, 13);
            this.Cadastro.TabIndex = 4;
            this.Cadastro.Text = "NickName";
            // 
            // Plano
            // 
            this.Plano.AutoSize = true;
            this.Plano.Location = new System.Drawing.Point(348, 164);
            this.Plano.Name = "Plano";
            this.Plano.Size = new System.Drawing.Size(39, 13);
            this.Plano.TabIndex = 5;
            this.Plano.Text = "Planos";
            // 
            // Signo
            // 
            this.Signo.AutoSize = true;
            this.Signo.Location = new System.Drawing.Point(348, 212);
            this.Signo.Name = "Signo";
            this.Signo.Size = new System.Drawing.Size(34, 13);
            this.Signo.TabIndex = 6;
            this.Signo.Text = "Signo";
            this.Signo.Click += new System.EventHandler(this.Signo_Click);
            // 
            // label_confirma_cadastro
            // 
            this.label_confirma_cadastro.AutoSize = true;
            this.label_confirma_cadastro.Location = new System.Drawing.Point(395, 316);
            this.label_confirma_cadastro.Name = "label_confirma_cadastro";
            this.label_confirma_cadastro.Size = new System.Drawing.Size(10, 13);
            this.label_confirma_cadastro.TabIndex = 8;
            this.label_confirma_cadastro.Text = " ";
            // 
            // comboBox_Planos
            // 
            this.comboBox_Planos.AllowDrop = true;
            this.comboBox_Planos.FormattingEnabled = true;
            this.comboBox_Planos.Location = new System.Drawing.Point(351, 180);
            this.comboBox_Planos.Name = "comboBox_Planos";
            this.comboBox_Planos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Planos.TabIndex = 13;
            this.comboBox_Planos.Text = "Plano";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastro";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(348, 117);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(351, 133);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Planos);
            this.Controls.Add(this.label_confirma_cadastro);
            this.Controls.Add(this.Signo);
            this.Controls.Add(this.Plano);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.boxSigno);
            this.Controls.Add(this.boxNickname);
            this.Controls.Add(this.Botao_Cadastro);
            this.Name = "CadastroForm";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.messageObjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Botao_Cadastro;
        private System.Windows.Forms.TextBox boxNickname;
        private System.Windows.Forms.TextBox boxSigno;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.Label Plano;
        private System.Windows.Forms.Label Signo;
        private System.Windows.Forms.Label label_confirma_cadastro;
        private System.Windows.Forms.ComboBox comboBox_Planos;
        private System.Windows.Forms.BindingSource messageObjectBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}

