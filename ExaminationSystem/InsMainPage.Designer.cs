namespace ExaminationSystem
{
    partial class InsMainPage
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
            this.lblMCQ = new System.Windows.Forms.Label();
            this.MCQnum = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTF = new System.Windows.Forms.Label();
            this.TFnum = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Examheaderlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMCQ
            // 
            this.lblMCQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMCQ.AutoSize = true;
            this.lblMCQ.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMCQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMCQ.Location = new System.Drawing.Point(335, 248);
            this.lblMCQ.Name = "lblMCQ";
            this.lblMCQ.Size = new System.Drawing.Size(503, 54);
            this.lblMCQ.TabIndex = 0;
            this.lblMCQ.Text = "number of MCQ questions:";
            // 
            // MCQnum
            // 
            this.MCQnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MCQnum.Location = new System.Drawing.Point(934, 268);
            this.MCQnum.Name = "MCQnum";
            this.MCQnum.Size = new System.Drawing.Size(150, 31);
            this.MCQnum.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerate.Location = new System.Drawing.Point(1231, 821);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(326, 76);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Exam";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTF
            // 
            this.lblTF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTF.AutoSize = true;
            this.lblTF.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTF.Location = new System.Drawing.Point(335, 369);
            this.lblTF.Name = "lblTF";
            this.lblTF.Size = new System.Drawing.Size(469, 54);
            this.lblTF.TabIndex = 3;
            this.lblTF.Text = "number of T/F questions:";
            // 
            // TFnum
            // 
            this.TFnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TFnum.Location = new System.Drawing.Point(934, 389);
            this.TFnum.Name = "TFnum";
            this.TFnum.Size = new System.Drawing.Size(150, 31);
            this.TFnum.TabIndex = 4;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.Location = new System.Drawing.Point(934, 510);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(150, 31);
            this.lblDuration.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(335, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exam duration:";
            // 
            // Examheaderlbl
            // 
            this.Examheaderlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Examheaderlbl.AutoSize = true;
            this.Examheaderlbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Examheaderlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Examheaderlbl.Location = new System.Drawing.Point(522, 106);
            this.Examheaderlbl.Name = "Examheaderlbl";
            this.Examheaderlbl.Size = new System.Drawing.Size(436, 54);
            this.Examheaderlbl.TabIndex = 7;
            this.Examheaderlbl.Text = "Enter Exam information";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(335, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 54);
            this.label2.TabIndex = 8;
            this.label2.Text = "Course name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(934, 631);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // InsMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1628, 932);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Examheaderlbl);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TFnum);
            this.Controls.Add(this.lblTF);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.MCQnum);
            this.Controls.Add(this.lblMCQ);
            this.Name = "InsMainPage";
            this.Text = "InsMainPage";
            this.Load += new System.EventHandler(this.InsMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMCQ;
        private TextBox MCQnum;
        private Button btnGenerate;
        private Label lblTF;
        private TextBox TFnum;
        private TextBox lblDuration;
        private Label label1;
        private Label Examheaderlbl;
        private Label label2;
        private ComboBox comboBox1;
    }
}