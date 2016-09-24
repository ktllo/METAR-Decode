namespace METAR_Decode
{
    partial class mainForm
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.butDecode = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "METAR Code";
            // 
            // txtCode
            // 
            this.txtCode.AcceptsReturn = true;
            this.txtCode.AccessibleDescription = "Enter the METAR code here";
            this.txtCode.AllowDrop = true;
            this.txtCode.Location = new System.Drawing.Point(15, 27);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(600, 73);
            this.txtCode.TabIndex = 1;
            // 
            // butDecode
            // 
            this.butDecode.Location = new System.Drawing.Point(540, 106);
            this.butDecode.Name = "butDecode";
            this.butDecode.Size = new System.Drawing.Size(75, 23);
            this.butDecode.TabIndex = 2;
            this.butDecode.Text = "Decode";
            this.butDecode.UseVisualStyleBackColor = true;
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(459, 106);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 3;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 253);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butDecode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "METAR Decoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button butDecode;
        private System.Windows.Forms.Button butClear;
    }
}

