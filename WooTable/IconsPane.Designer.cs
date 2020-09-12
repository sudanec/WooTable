namespace WooTable
{
    partial class IconsPane
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
            this.IconsPane_lView_Docs = new System.Windows.Forms.ListView();
            this.IconsPane_but_Create = new System.Windows.Forms.Button();
            this.IconsPane_but_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IconsPane_lView_Docs
            // 
            this.IconsPane_lView_Docs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IconsPane_lView_Docs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.IconsPane_lView_Docs.Location = new System.Drawing.Point(19, 28);
            this.IconsPane_lView_Docs.MultiSelect = false;
            this.IconsPane_lView_Docs.Name = "IconsPane_lView_Docs";
            this.IconsPane_lView_Docs.Size = new System.Drawing.Size(599, 1460);
            this.IconsPane_lView_Docs.TabIndex = 2;
            this.IconsPane_lView_Docs.UseCompatibleStateImageBehavior = false;
            this.IconsPane_lView_Docs.View = System.Windows.Forms.View.Tile;
            // 
            // IconsPane_but_Create
            // 
            this.IconsPane_but_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IconsPane_but_Create.Location = new System.Drawing.Point(275, 1506);
            this.IconsPane_but_Create.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.IconsPane_but_Create.Name = "IconsPane_but_Create";
            this.IconsPane_but_Create.Size = new System.Drawing.Size(163, 62);
            this.IconsPane_but_Create.TabIndex = 4;
            this.IconsPane_but_Create.Text = "button1";
            this.IconsPane_but_Create.UseVisualStyleBackColor = true;
            this.IconsPane_but_Create.Click += new System.EventHandler(this.IconsPane_but_Create_Click);
            // 
            // IconsPane_but_Cancel
            // 
            this.IconsPane_but_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IconsPane_but_Cancel.Location = new System.Drawing.Point(455, 1506);
            this.IconsPane_but_Cancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.IconsPane_but_Cancel.Name = "IconsPane_but_Cancel";
            this.IconsPane_but_Cancel.Size = new System.Drawing.Size(163, 62);
            this.IconsPane_but_Cancel.TabIndex = 3;
            this.IconsPane_but_Cancel.Text = "button1";
            this.IconsPane_but_Cancel.UseVisualStyleBackColor = true;
            this.IconsPane_but_Cancel.Click += new System.EventHandler(this.IconsPane_but_Cancel_Click);
            // 
            // IconsPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IconsPane_but_Create);
            this.Controls.Add(this.IconsPane_but_Cancel);
            this.Controls.Add(this.IconsPane_lView_Docs);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "IconsPane";
            this.Size = new System.Drawing.Size(640, 1588);
            this.Load += new System.EventHandler(this.IconsPane_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView IconsPane_lView_Docs;
        private System.Windows.Forms.Button IconsPane_but_Create;
        private System.Windows.Forms.Button IconsPane_but_Cancel;
    }
}
