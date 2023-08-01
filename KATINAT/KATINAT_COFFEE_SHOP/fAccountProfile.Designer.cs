namespace KATINAT_COFFEE_SHOP
{
    partial class fAccountProfile
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
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbDisPlayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPassword = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReEnterPassword = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 74);
            panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(226, 27);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(321, 27);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 27);
            label1.Name = "label1";
            label1.Size = new Size(123, 27);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisPlayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 74);
            panel1.TabIndex = 2;
            // 
            // txbDisPlayName
            // 
            txbDisPlayName.Location = new Point(226, 27);
            txbDisPlayName.Name = "txbDisPlayName";
            txbDisPlayName.Size = new Size(321, 27);
            txbDisPlayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 27);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 0;
            label2.Text = "NAME";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(596, 74);
            panel3.TabIndex = 3;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(226, 27);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.ReadOnly = true;
            txbPassWord.Size = new Size(321, 27);
            txbPassWord.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 27);
            label3.Name = "label3";
            label3.Size = new Size(126, 27);
            label3.TabIndex = 0;
            label3.Text = "PAXXWORD";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPassword);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 270);
            panel4.Name = "panel4";
            panel4.Size = new Size(596, 74);
            panel4.TabIndex = 4;
            // 
            // txbNewPassword
            // 
            txbNewPassword.Location = new Point(226, 27);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(321, 27);
            txbNewPassword.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(41, 27);
            label4.Name = "label4";
            label4.Size = new Size(176, 27);
            label4.TabIndex = 0;
            label4.Text = "NEW PAXXWORD";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPassword);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 350);
            panel5.Name = "panel5";
            panel5.Size = new Size(596, 74);
            panel5.TabIndex = 5;
            // 
            // txbReEnterPassword
            // 
            txbReEnterPassword.Location = new Point(226, 27);
            txbReEnterPassword.Name = "txbReEnterPassword";
            txbReEnterPassword.Size = new Size(321, 27);
            txbReEnterPassword.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 9);
            label5.Name = "label5";
            label5.Size = new Size(126, 54);
            label5.TabIndex = 0;
            label5.Text = "RETYPE \r\nPAXXWORD";
            label5.Click += label5_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(390, 430);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(511, 430);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 472);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            Text = "fAccountProfile";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel1;
        private TextBox txbDisPlayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPassword;
        private Label label4;
        private Panel panel5;
        private TextBox txbReEnterPassword;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}