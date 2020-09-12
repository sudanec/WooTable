namespace WooTable
{
    partial class TablesPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TablesPane_but_Apply = new System.Windows.Forms.Button();
            this.TablesPane_but_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TablesPane_but_Apply
            // 
            this.TablesPane_but_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesPane_but_Apply.Location = new System.Drawing.Point(398, 1410);
            this.TablesPane_but_Apply.Name = "TablesPane_but_Apply";
            this.TablesPane_but_Apply.Size = new System.Drawing.Size(143, 58);
            this.TablesPane_but_Apply.TabIndex = 0;
            this.TablesPane_but_Apply.Text = "button1";
            this.TablesPane_but_Apply.UseVisualStyleBackColor = true;
            this.TablesPane_but_Apply.Click += new System.EventHandler(this.TablesPane_but_Apply_Click);
            // 
            // TablesPane_but_Cancel
            // 
            this.TablesPane_but_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesPane_but_Cancel.Location = new System.Drawing.Point(237, 1410);
            this.TablesPane_but_Cancel.Name = "TablesPane_but_Cancel";
            this.TablesPane_but_Cancel.Size = new System.Drawing.Size(143, 58);
            this.TablesPane_but_Cancel.TabIndex = 1;
            this.TablesPane_but_Cancel.Text = "button1";
            this.TablesPane_but_Cancel.UseVisualStyleBackColor = true;
            this.TablesPane_but_Cancel.Click += new System.EventHandler(this.TablesPane_but_Cancel_Click);
            // 
            // TablesPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablesPane_but_Cancel);
            this.Controls.Add(this.TablesPane_but_Apply);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TablesPane";
            this.Size = new System.Drawing.Size(560, 1486);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TablesPane_but_Cancel;
        private System.Windows.Forms.Button TablesPane_but_Apply;
    }
}
