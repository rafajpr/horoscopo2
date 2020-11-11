namespace Cliente_Zodeiaco_WS
{
    partial class Horoscopo
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
            this.horoscopoLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.bronzeButton = new System.Windows.Forms.Button();
            this.ouroButton = new System.Windows.Forms.Button();
            this.yourNicknameLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // horoscopoLabel
            // 
            this.horoscopoLabel.AutoSize = true;
            this.horoscopoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horoscopoLabel.Location = new System.Drawing.Point(283, 16);
            this.horoscopoLabel.Name = "horoscopoLabel";
            this.horoscopoLabel.Size = new System.Drawing.Size(258, 55);
            this.horoscopoLabel.TabIndex = 0;
            this.horoscopoLabel.Text = "Horóscopo";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(276, 131);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(267, 26);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Mensagem do Horoscopo.";
            // 
            // bronzeButton
            // 
            this.bronzeButton.Location = new System.Drawing.Point(281, 241);
            this.bronzeButton.Name = "bronzeButton";
            this.bronzeButton.Size = new System.Drawing.Size(75, 23);
            this.bronzeButton.TabIndex = 2;
            this.bronzeButton.Text = "Bronze";
            this.bronzeButton.UseVisualStyleBackColor = true;
            this.bronzeButton.Click += new System.EventHandler(this.bronzeButton_Click);
            // 
            // ouroButton
            // 
            this.ouroButton.Location = new System.Drawing.Point(468, 241);
            this.ouroButton.Name = "ouroButton";
            this.ouroButton.Size = new System.Drawing.Size(75, 23);
            this.ouroButton.TabIndex = 3;
            this.ouroButton.Text = "Ouro";
            this.ouroButton.UseVisualStyleBackColor = true;
            this.ouroButton.Click += new System.EventHandler(this.ouroButton_Click);
            // 
            // yourNicknameLabel
            // 
            this.yourNicknameLabel.AutoSize = true;
            this.yourNicknameLabel.Location = new System.Drawing.Point(13, 13);
            this.yourNicknameLabel.Name = "yourNicknameLabel";
            this.yourNicknameLabel.Size = new System.Drawing.Size(75, 13);
            this.yourNicknameLabel.TabIndex = 4;
            this.yourNicknameLabel.Text = "Logado como:";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(13, 30);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(55, 13);
            this.nicknameLabel.TabIndex = 5;
            this.nicknameLabel.Text = "Nickname";
            // 
            // Horoscopo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.yourNicknameLabel);
            this.Controls.Add(this.ouroButton);
            this.Controls.Add(this.bronzeButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.horoscopoLabel);
            this.Name = "Horoscopo";
            this.Text = "Horoscopo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label horoscopoLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button bronzeButton;
        private System.Windows.Forms.Button ouroButton;
        private System.Windows.Forms.Label yourNicknameLabel;
        private System.Windows.Forms.Label nicknameLabel;
    }
}