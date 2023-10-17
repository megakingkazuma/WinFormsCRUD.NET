namespace WindowsFormWithCRUD
{
    partial class LoginForm
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
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_username
            // 
            this.input_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_username.Location = new System.Drawing.Point(157, 167);
            this.input_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(237, 26);
            this.input_username.TabIndex = 0;
            this.input_username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // input_password
            // 
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.Location = new System.Drawing.Point(157, 202);
            this.input_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(237, 26);
            this.input_password.TabIndex = 1;
            this.input_password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log in";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(70, 167);
            this.text1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(83, 20);
            this.text1.TabIndex = 3;
            this.text1.Text = "Username";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(70, 202);
            this.text2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(78, 20);
            this.text2.TabIndex = 4;
            this.text2.Text = "Password";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(152, 248);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(74, 31);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(238, 248);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 365);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_username);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.Button btnExit;
    }
}