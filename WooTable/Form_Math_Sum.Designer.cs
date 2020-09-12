namespace WooTable
{
    partial class Form_Math_Sum
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
            this.Form_Sum_Text_Range = new System.Windows.Forms.TextBox();
            this.Form_Sum_but_Cancel = new System.Windows.Forms.Button();
            this.Form_Sum_but_Create = new System.Windows.Forms.Button();
            this.Form_Sum_Lab_Range = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Form_Sum_Text_Range
            // 
            this.Form_Sum_Text_Range.Location = new System.Drawing.Point(112, 33);
            this.Form_Sum_Text_Range.Name = "Form_Sum_Text_Range";
            this.Form_Sum_Text_Range.Size = new System.Drawing.Size(382, 22);
            this.Form_Sum_Text_Range.TabIndex = 0;
            // 
            // Form_Sum_but_Cancel
            // 
            this.Form_Sum_but_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_Sum_but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Form_Sum_but_Cancel.Location = new System.Drawing.Point(389, 94);
            this.Form_Sum_but_Cancel.Name = "Form_Sum_but_Cancel";
            this.Form_Sum_but_Cancel.Size = new System.Drawing.Size(75, 26);
            this.Form_Sum_but_Cancel.TabIndex = 3;
            this.Form_Sum_but_Cancel.Text = "Cancel";
            this.Form_Sum_but_Cancel.UseVisualStyleBackColor = true;
            this.Form_Sum_but_Cancel.Click += new System.EventHandler(this.Form_Sum_but_Cancel_Click);
            // 
            // Form_Sum_but_Create
            // 
            this.Form_Sum_but_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_Sum_but_Create.Location = new System.Drawing.Point(470, 94);
            this.Form_Sum_but_Create.Name = "Form_Sum_but_Create";
            this.Form_Sum_but_Create.Size = new System.Drawing.Size(75, 26);
            this.Form_Sum_but_Create.TabIndex = 2;
            this.Form_Sum_but_Create.Text = "Set";
            this.Form_Sum_but_Create.UseVisualStyleBackColor = true;
            this.Form_Sum_but_Create.Click += new System.EventHandler(this.Form_Sum_but_Create_Click);
            // 
            // Form_Sum_Lab_Range
            // 
            this.Form_Sum_Lab_Range.AutoSize = true;
            this.Form_Sum_Lab_Range.Location = new System.Drawing.Point(13, 36);
            this.Form_Sum_Lab_Range.Name = "Form_Sum_Lab_Range";
            this.Form_Sum_Lab_Range.Size = new System.Drawing.Size(93, 17);
            this.Form_Sum_Lab_Range.TabIndex = 4;
            this.Form_Sum_Lab_Range.Text = "Select Range";
            // 
            // Form_Math_Sum
            // 
            this.AcceptButton = this.Form_Sum_but_Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Form_Sum_but_Cancel;
            this.ClientSize = new System.Drawing.Size(557, 132);
            this.Controls.Add(this.Form_Sum_Lab_Range);
            this.Controls.Add(this.Form_Sum_but_Cancel);
            this.Controls.Add(this.Form_Sum_but_Create);
            this.Controls.Add(this.Form_Sum_Text_Range);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Math_Sum";
            this.ShowInTaskbar = false;
            this.Text = "Form_Math_Sum";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Form_Sum_Text_Range;
        private System.Windows.Forms.Button Form_Sum_but_Cancel;
        private System.Windows.Forms.Button Form_Sum_but_Create;
        private System.Windows.Forms.Label Form_Sum_Lab_Range;
    }
}