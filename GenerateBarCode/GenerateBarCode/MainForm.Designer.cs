namespace GenerateBarCode
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.picCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printLabel = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picCode
            // 
            this.picCode.Location = new System.Drawing.Point(110, 61);
            this.picCode.Name = "picCode";
            this.picCode.Size = new System.Drawing.Size(275, 50);
            this.picCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCode.TabIndex = 1;
            this.picCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BarCode: ";
            // 
            // printLabel
            // 
            this.printLabel.AutoSize = true;
            this.printLabel.Location = new System.Drawing.Point(227, 114);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(0, 13);
            this.printLabel.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(149, 182);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(155, 20);
            this.txtCode.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 293);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.printLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCode);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Generate BarCode";
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label printLabel;
        private System.Windows.Forms.TextBox txtCode;
    }
}

