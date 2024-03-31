namespace AddressBook
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Register_Pwd1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Register_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.Register_Pwd2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, -10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1067, 125);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎注册";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register_Pwd1
            // 
            this.Register_Pwd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Register_Pwd1.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register_Pwd1.Location = new System.Drawing.Point(343, 202);
            this.Register_Pwd1.Margin = new System.Windows.Forms.Padding(4);
            this.Register_Pwd1.Name = "Register_Pwd1";
            this.Register_Pwd1.PasswordChar = '*';
            this.Register_Pwd1.Size = new System.Drawing.Size(400, 34);
            this.Register_Pwd1.TabIndex = 13;
            this.Register_Pwd1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(215, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "密码";
            // 
            // Register_Name
            // 
            this.Register_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Register_Name.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register_Name.Location = new System.Drawing.Point(343, 119);
            this.Register_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Register_Name.Name = "Register_Name";
            this.Register_Name.Size = new System.Drawing.Size(400, 34);
            this.Register_Name.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(215, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "用户名";

            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(343, 375);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 50);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Register_Pwd2
            // 
            this.Register_Pwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Register_Pwd2.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register_Pwd2.Location = new System.Drawing.Point(343, 292);
            this.Register_Pwd2.Margin = new System.Windows.Forms.Padding(4);
            this.Register_Pwd2.Name = "Register_Pwd2";
            this.Register_Pwd2.PasswordChar = '*';
            this.Register_Pwd2.Size = new System.Drawing.Size(400, 34);
            this.Register_Pwd2.TabIndex = 17;
            this.Register_Pwd2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(215, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "确认密码";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(616, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Register_Pwd2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.Register_Pwd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Register_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";

      
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Register_Pwd1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Register_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox Register_Pwd2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}