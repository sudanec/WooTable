namespace WooTable
{
    partial class Form_CurrencyConverter
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
            this.Form_CurrencyConverter_but_Cancel = new System.Windows.Forms.Button();
            this.Form_CurrencyConverter_but_Apply = new System.Windows.Forms.Button();
            this.Form_CurrencyConverter_list_Source = new System.Windows.Forms.ListBox();
            this.Form_CurrencyConverter_lab_Source = new System.Windows.Forms.Label();
            this.Form_CurrencyConverter_lab_Target = new System.Windows.Forms.Label();
            this.Form_CurrencyConverter_list_Target = new System.Windows.Forms.ListBox();
            this.Form_CurrencyConverter_text_Source = new System.Windows.Forms.TextBox();
            this.Form_CurrencyConverter_text_Target = new System.Windows.Forms.TextBox();
            this.Form_CurrencyConverter_lab_To = new System.Windows.Forms.Label();
            this.Form_CurrencyConverter_lab_Risk = new System.Windows.Forms.Label();
            this.Form_CurrencyConverter_text_risk = new System.Windows.Forms.TextBox();
            this.Form_CurrencyConverter_lab_Riskp = new System.Windows.Forms.Label();
            this.Form_CurrencyConverter_lab_Riski = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Form_CurrencyConverter_but_Cancel
            // 
            this.Form_CurrencyConverter_but_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_CurrencyConverter_but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Form_CurrencyConverter_but_Cancel.Location = new System.Drawing.Point(267, 390);
            this.Form_CurrencyConverter_but_Cancel.Name = "Form_CurrencyConverter_but_Cancel";
            this.Form_CurrencyConverter_but_Cancel.Size = new System.Drawing.Size(82, 29);
            this.Form_CurrencyConverter_but_Cancel.TabIndex = 5;
            this.Form_CurrencyConverter_but_Cancel.Text = "Cancel";
            this.Form_CurrencyConverter_but_Cancel.UseVisualStyleBackColor = true;
            this.Form_CurrencyConverter_but_Cancel.Click += new System.EventHandler(this.Form_CurrencyConverter_but_Cancel_Click);
            // 
            // Form_CurrencyConverter_but_Apply
            // 
            this.Form_CurrencyConverter_but_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_CurrencyConverter_but_Apply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Form_CurrencyConverter_but_Apply.Location = new System.Drawing.Point(355, 390);
            this.Form_CurrencyConverter_but_Apply.Name = "Form_CurrencyConverter_but_Apply";
            this.Form_CurrencyConverter_but_Apply.Size = new System.Drawing.Size(87, 29);
            this.Form_CurrencyConverter_but_Apply.TabIndex = 4;
            this.Form_CurrencyConverter_but_Apply.Text = "Convert";
            this.Form_CurrencyConverter_but_Apply.UseVisualStyleBackColor = true;
            this.Form_CurrencyConverter_but_Apply.Click += new System.EventHandler(this.Form_CurrencyConverter_but_Apply_Click);
            // 
            // Form_CurrencyConverter_list_Source
            // 
            this.Form_CurrencyConverter_list_Source.FormattingEnabled = true;
            this.Form_CurrencyConverter_list_Source.ItemHeight = 16;
            this.Form_CurrencyConverter_list_Source.Location = new System.Drawing.Point(16, 33);
            this.Form_CurrencyConverter_list_Source.Name = "Form_CurrencyConverter_list_Source";
            this.Form_CurrencyConverter_list_Source.Size = new System.Drawing.Size(134, 228);
            this.Form_CurrencyConverter_list_Source.TabIndex = 6;
            this.Form_CurrencyConverter_list_Source.SelectedIndexChanged += new System.EventHandler(this.Form_CurrencyConverter_list_Source_SelectedIndexChanged);
            // 
            // Form_CurrencyConverter_lab_Source
            // 
            this.Form_CurrencyConverter_lab_Source.AutoSize = true;
            this.Form_CurrencyConverter_lab_Source.Location = new System.Drawing.Point(13, 13);
            this.Form_CurrencyConverter_lab_Source.Name = "Form_CurrencyConverter_lab_Source";
            this.Form_CurrencyConverter_lab_Source.Size = new System.Drawing.Size(116, 17);
            this.Form_CurrencyConverter_lab_Source.TabIndex = 7;
            this.Form_CurrencyConverter_lab_Source.Text = "Source currency:";
            // 
            // Form_CurrencyConverter_lab_Target
            // 
            this.Form_CurrencyConverter_lab_Target.AutoSize = true;
            this.Form_CurrencyConverter_lab_Target.Location = new System.Drawing.Point(290, 13);
            this.Form_CurrencyConverter_lab_Target.Name = "Form_CurrencyConverter_lab_Target";
            this.Form_CurrencyConverter_lab_Target.Size = new System.Drawing.Size(113, 17);
            this.Form_CurrencyConverter_lab_Target.TabIndex = 9;
            this.Form_CurrencyConverter_lab_Target.Text = "Target currency:";
            // 
            // Form_CurrencyConverter_list_Target
            // 
            this.Form_CurrencyConverter_list_Target.FormattingEnabled = true;
            this.Form_CurrencyConverter_list_Target.ItemHeight = 16;
            this.Form_CurrencyConverter_list_Target.Location = new System.Drawing.Point(293, 33);
            this.Form_CurrencyConverter_list_Target.Name = "Form_CurrencyConverter_list_Target";
            this.Form_CurrencyConverter_list_Target.Size = new System.Drawing.Size(134, 228);
            this.Form_CurrencyConverter_list_Target.TabIndex = 8;
            this.Form_CurrencyConverter_list_Target.SelectedIndexChanged += new System.EventHandler(this.Form_CurrencyConverter_list_Target_SelectedIndexChanged);
            // 
            // Form_CurrencyConverter_text_Source
            // 
            this.Form_CurrencyConverter_text_Source.Location = new System.Drawing.Point(16, 278);
            this.Form_CurrencyConverter_text_Source.Name = "Form_CurrencyConverter_text_Source";
            this.Form_CurrencyConverter_text_Source.ReadOnly = true;
            this.Form_CurrencyConverter_text_Source.Size = new System.Drawing.Size(134, 22);
            this.Form_CurrencyConverter_text_Source.TabIndex = 10;
            // 
            // Form_CurrencyConverter_text_Target
            // 
            this.Form_CurrencyConverter_text_Target.Location = new System.Drawing.Point(293, 278);
            this.Form_CurrencyConverter_text_Target.Name = "Form_CurrencyConverter_text_Target";
            this.Form_CurrencyConverter_text_Target.ReadOnly = true;
            this.Form_CurrencyConverter_text_Target.Size = new System.Drawing.Size(134, 22);
            this.Form_CurrencyConverter_text_Target.TabIndex = 11;
            // 
            // Form_CurrencyConverter_lab_To
            // 
            this.Form_CurrencyConverter_lab_To.AutoSize = true;
            this.Form_CurrencyConverter_lab_To.Location = new System.Drawing.Point(171, 136);
            this.Form_CurrencyConverter_lab_To.Name = "Form_CurrencyConverter_lab_To";
            this.Form_CurrencyConverter_lab_To.Size = new System.Drawing.Size(77, 17);
            this.Form_CurrencyConverter_lab_To.TabIndex = 12;
            this.Form_CurrencyConverter_lab_To.Text = "Convert to:";
            // 
            // Form_CurrencyConverter_lab_Risk
            // 
            this.Form_CurrencyConverter_lab_Risk.AutoSize = true;
            this.Form_CurrencyConverter_lab_Risk.Location = new System.Drawing.Point(42, 334);
            this.Form_CurrencyConverter_lab_Risk.Name = "Form_CurrencyConverter_lab_Risk";
            this.Form_CurrencyConverter_lab_Risk.Size = new System.Drawing.Size(177, 17);
            this.Form_CurrencyConverter_lab_Risk.TabIndex = 13;
            this.Form_CurrencyConverter_lab_Risk.Text = "Conversion risk coefficient:";
            // 
            // Form_CurrencyConverter_text_risk
            // 
            this.Form_CurrencyConverter_text_risk.Location = new System.Drawing.Point(225, 331);
            this.Form_CurrencyConverter_text_risk.Name = "Form_CurrencyConverter_text_risk";
            this.Form_CurrencyConverter_text_risk.Size = new System.Drawing.Size(40, 22);
            this.Form_CurrencyConverter_text_risk.TabIndex = 14;
            this.Form_CurrencyConverter_text_risk.Text = "0";
            this.Form_CurrencyConverter_text_risk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Form_CurrencyConverter_text_risk.TextChanged += new System.EventHandler(this.Form_CurrencyConverter_text_risk_TextChanged);
            this.Form_CurrencyConverter_text_risk.Validating += new System.ComponentModel.CancelEventHandler(this.Form_CurrencyConverter_text_risk_Validating);
            // 
            // Form_CurrencyConverter_lab_Riskp
            // 
            this.Form_CurrencyConverter_lab_Riskp.AutoSize = true;
            this.Form_CurrencyConverter_lab_Riskp.Location = new System.Drawing.Point(271, 334);
            this.Form_CurrencyConverter_lab_Riskp.Name = "Form_CurrencyConverter_lab_Riskp";
            this.Form_CurrencyConverter_lab_Riskp.Size = new System.Drawing.Size(20, 17);
            this.Form_CurrencyConverter_lab_Riskp.TabIndex = 15;
            this.Form_CurrencyConverter_lab_Riskp.Text = "%";
            // 
            // Form_CurrencyConverter_lab_Riski
            // 
            this.Form_CurrencyConverter_lab_Riski.AutoSize = true;
            this.Form_CurrencyConverter_lab_Riski.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_CurrencyConverter_lab_Riski.Location = new System.Drawing.Point(42, 357);
            this.Form_CurrencyConverter_lab_Riski.Name = "Form_CurrencyConverter_lab_Riski";
            this.Form_CurrencyConverter_lab_Riski.Size = new System.Drawing.Size(262, 17);
            this.Form_CurrencyConverter_lab_Riski.TabIndex = 16;
            this.Form_CurrencyConverter_lab_Riski.Text = "(all values will be incremented by this %)";
            // 
            // Form_CurrencyConverter
            // 
            this.AcceptButton = this.Form_CurrencyConverter_but_Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Form_CurrencyConverter_but_Cancel;
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.Form_CurrencyConverter_lab_Riski);
            this.Controls.Add(this.Form_CurrencyConverter_lab_Riskp);
            this.Controls.Add(this.Form_CurrencyConverter_text_risk);
            this.Controls.Add(this.Form_CurrencyConverter_lab_Risk);
            this.Controls.Add(this.Form_CurrencyConverter_lab_To);
            this.Controls.Add(this.Form_CurrencyConverter_text_Target);
            this.Controls.Add(this.Form_CurrencyConverter_text_Source);
            this.Controls.Add(this.Form_CurrencyConverter_lab_Target);
            this.Controls.Add(this.Form_CurrencyConverter_list_Target);
            this.Controls.Add(this.Form_CurrencyConverter_lab_Source);
            this.Controls.Add(this.Form_CurrencyConverter_list_Source);
            this.Controls.Add(this.Form_CurrencyConverter_but_Cancel);
            this.Controls.Add(this.Form_CurrencyConverter_but_Apply);
            this.MinimizeBox = false;
            this.Name = "Form_CurrencyConverter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WooTable .::. Currency Converter";
            this.Load += new System.EventHandler(this.Form_CurrencyConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Form_CurrencyConverter_but_Cancel;
        private System.Windows.Forms.Button Form_CurrencyConverter_but_Apply;
        private System.Windows.Forms.ListBox Form_CurrencyConverter_list_Source;
        private System.Windows.Forms.Label Form_CurrencyConverter_lab_Source;
        private System.Windows.Forms.Label Form_CurrencyConverter_lab_Target;
        private System.Windows.Forms.ListBox Form_CurrencyConverter_list_Target;
        private System.Windows.Forms.TextBox Form_CurrencyConverter_text_Source;
        private System.Windows.Forms.TextBox Form_CurrencyConverter_text_Target;
        private System.Windows.Forms.Label Form_CurrencyConverter_lab_To;
        private System.Windows.Forms.Label Form_CurrencyConverter_lab_Risk;
        private System.Windows.Forms.TextBox Form_CurrencyConverter_text_risk;
        private System.Windows.Forms.Label Form_CurrencyConverter_lab_Riskp;
        private System.Windows.Forms.Label Form_CurrencyConverter_lab_Riski;
    }
}