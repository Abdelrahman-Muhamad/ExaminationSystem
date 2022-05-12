
namespace ExaminationSystem
{
    partial class StudentLogin
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
            this.Errorlbl = new System.Windows.Forms.Label();
            this.insID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.insUser = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Errorlbl
            // 
            this.Errorlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Errorlbl.AutoSize = true;
            this.Errorlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Errorlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Errorlbl.Location = new System.Drawing.Point(608, 118);
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.Size = new System.Drawing.Size(294, 54);
            this.Errorlbl.TabIndex = 13;
            this.Errorlbl.Text = "Enter your data";
            // 
            // insID
            // 
            this.insID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.insID.AutoSize = true;
            this.insID.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insID.Location = new System.Drawing.Point(443, 358);
            this.insID.Name = "insID";
            this.insID.Size = new System.Drawing.Size(62, 54);
            this.insID.TabIndex = 12;
            this.insID.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(790, 480);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 31);
            this.textBox2.TabIndex = 11;
            // 
            // insUser
            // 
            this.insUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.insUser.AutoSize = true;
            this.insUser.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insUser.Location = new System.Drawing.Point(443, 460);
            this.insUser.Name = "insUser";
            this.insUser.Size = new System.Drawing.Size(211, 54);
            this.insUser.TabIndex = 10;
            this.insUser.Text = "User name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(790, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 31);
            this.textBox1.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(696, 691);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(251, 66);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Show Courses";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(443, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "Course name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(790, 590);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 33);
            this.comboBox1.TabIndex = 16;
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1628, 932);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Errorlbl);
            this.Controls.Add(this.insID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.insUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLogin);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.Load += new System.EventHandler(this.StudentLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Errorlbl;
        private Label insID;
        private TextBox textBox2;
        private Label insUser;
        private TextBox textBox1;
        private Button btnLogin;
        private Label label1;
        private ComboBox comboBox1;
    }
}