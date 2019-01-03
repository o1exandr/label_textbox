namespace label_textbox
{
    partial class fmMainForm
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
            this.lbInstruction = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbMultiLine = new System.Windows.Forms.Label();
            this.lbUpperCase = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMultiline = new System.Windows.Forms.TextBox();
            this.txtUppercase = new System.Windows.Forms.TextBox();
            this.btDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInstruction
            // 
            this.lbInstruction.AutoSize = true;
            this.lbInstruction.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInstruction.Location = new System.Drawing.Point(16, 13);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(217, 15);
            this.lbInstruction.TabIndex = 0;
            this.lbInstruction.Text = "Введіть значення у всі вікна проекту";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(16, 51);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(107, 13);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "&Вікно вводу паролю";
            // 
            // lbMultiLine
            // 
            this.lbMultiLine.AutoSize = true;
            this.lbMultiLine.Location = new System.Drawing.Point(16, 85);
            this.lbMultiLine.Name = "lbMultiLine";
            this.lbMultiLine.Size = new System.Drawing.Size(121, 13);
            this.lbMultiLine.TabIndex = 2;
            this.lbMultiLine.Text = "&Багаторядковий текст";
            // 
            // lbUpperCase
            // 
            this.lbUpperCase.AutoSize = true;
            this.lbUpperCase.Location = new System.Drawing.Point(16, 146);
            this.lbUpperCase.Name = "lbUpperCase";
            this.lbUpperCase.Size = new System.Drawing.Size(114, 13);
            this.lbUpperCase.TabIndex = 3;
            this.lbUpperCase.Text = "&Лише верхній регістр";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(169, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "qwerty";
            // 
            // txtMultiline
            // 
            this.txtMultiline.Location = new System.Drawing.Point(157, 85);
            this.txtMultiline.Multiline = true;
            this.txtMultiline.Name = "txtMultiline";
            this.txtMultiline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMultiline.Size = new System.Drawing.Size(169, 47);
            this.txtMultiline.TabIndex = 5;
            this.txtMultiline.Text = "багаторядковий текст\r\nякий показує полоси прокрутки,\r\nякщо текст дуже великий";
            // 
            // txtUppercase
            // 
            this.txtUppercase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUppercase.Location = new System.Drawing.Point(157, 142);
            this.txtUppercase.Name = "txtUppercase";
            this.txtUppercase.Size = new System.Drawing.Size(169, 20);
            this.txtUppercase.TabIndex = 6;
            this.txtUppercase.Text = "КЛАВІША CAPS LOCK НЕ НАТИСНУТА";
            // 
            // btDisplay
            // 
            this.btDisplay.Location = new System.Drawing.Point(207, 188);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(119, 23);
            this.btDisplay.TabIndex = 7;
            this.btDisplay.Text = "Показати дані";
            this.btDisplay.UseVisualStyleBackColor = true;
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_Click);
            // 
            // fmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 227);
            this.Controls.Add(this.btDisplay);
            this.Controls.Add(this.txtUppercase);
            this.Controls.Add(this.txtMultiline);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbUpperCase);
            this.Controls.Add(this.lbMultiLine);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbInstruction);
            this.Name = "fmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Робота з Label і TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMultiLine;
        private System.Windows.Forms.Label lbUpperCase;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMultiline;
        private System.Windows.Forms.TextBox txtUppercase;
        private System.Windows.Forms.Button btDisplay;
    }
}

