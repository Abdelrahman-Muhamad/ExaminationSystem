namespace ExaminationSystem
{
    partial class instructor
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.insUser = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.insID = new System.Windows.Forms.Label();
            this.Errorlbl = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(602, 707);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 66);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(773, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 31);
            this.textBox1.TabIndex = 1;
            // 
            // insUser
            // 
            this.insUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.insUser.AutoSize = true;
            this.insUser.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insUser.Location = new System.Drawing.Point(426, 447);
            this.insUser.Name = "insUser";
            this.insUser.Size = new System.Drawing.Size(211, 54);
            this.insUser.TabIndex = 3;
            this.insUser.Text = "User name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(773, 457);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 31);
            this.textBox2.TabIndex = 4;
            // 
            // insID
            // 
            this.insID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.insID.AutoSize = true;
            this.insID.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insID.Location = new System.Drawing.Point(426, 317);
            this.insID.Name = "insID";
            this.insID.Size = new System.Drawing.Size(62, 54);
            this.insID.TabIndex = 5;
            this.insID.Text = "ID";
            // 
            // Errorlbl
            // 
            this.Errorlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Errorlbl.AutoSize = true;
            this.Errorlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Errorlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Errorlbl.Location = new System.Drawing.Point(621, 91);
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.Size = new System.Drawing.Size(294, 54);
            this.Errorlbl.TabIndex = 6;
            this.Errorlbl.Text = "Enter your data";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(918, 707);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(313, 66);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create new account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1628, 932);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.Errorlbl);
            this.Controls.Add(this.insID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.insUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLogin);
            this.Name = "instructor";
            this.Text = "instructor";
            this.Load += new System.EventHandler(this.instructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private TextBox textBox1;
        private Label insUser;
        private TextBox textBox2;
        private Label insID;
        private Label Errorlbl;
        private Button btnCreate;
    }
}