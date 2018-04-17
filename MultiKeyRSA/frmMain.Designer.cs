namespace MultiKeyRSS
{
    partial class frmMain
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
            this.flpPrimes = new System.Windows.Forms.FlowLayoutPanel();
            this.tbPrimeCount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbSteps = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPrimes
            // 
            this.flpPrimes.AutoScroll = true;
            this.flpPrimes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPrimes.Location = new System.Drawing.Point(12, 65);
            this.flpPrimes.Name = "flpPrimes";
            this.flpPrimes.Size = new System.Drawing.Size(330, 511);
            this.flpPrimes.TabIndex = 0;
            this.flpPrimes.WrapContents = false;
            // 
            // tbPrimeCount
            // 
            this.tbPrimeCount.Location = new System.Drawing.Point(6, 19);
            this.tbPrimeCount.Name = "tbPrimeCount";
            this.tbPrimeCount.Size = new System.Drawing.Size(237, 20);
            this.tbPrimeCount.TabIndex = 1;
            this.tbPrimeCount.Text = "8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.tbPrimeCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asal Sayısı";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(249, 17);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(317, 17);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbInput);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Location = new System.Drawing.Point(348, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 47);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Girdi";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(6, 20);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(305, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "786";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbOutput);
            this.groupBox3.Location = new System.Drawing.Point(348, 529);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 47);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çıktı";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(6, 20);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(511, 20);
            this.tbOutput.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbSteps);
            this.groupBox4.Location = new System.Drawing.Point(348, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 458);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adımlar";
            // 
            // tbSteps
            // 
            this.tbSteps.AcceptsReturn = true;
            this.tbSteps.AcceptsTab = true;
            this.tbSteps.Location = new System.Drawing.Point(6, 19);
            this.tbSteps.Multiline = true;
            this.tbSteps.Name = "tbSteps";
            this.tbSteps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSteps.Size = new System.Drawing.Size(511, 433);
            this.tbSteps.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 588);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpPrimes);
            this.Name = "frmMain";
            this.Text = "MultiKeyRSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPrimes;
        private System.Windows.Forms.TextBox tbPrimeCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbSteps;
    }
}

