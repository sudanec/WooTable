namespace WooTable
{
    partial class Form_NewTable
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
            this.Form_NewTable_but_Create = new System.Windows.Forms.Button();
            this.Form_NewTable_but_Cancel = new System.Windows.Forms.Button();
            this.Form_NewTable_group_Dimensions = new System.Windows.Forms.GroupBox();
            this.Form_NewTable_lab_Rows = new System.Windows.Forms.Label();
            this.Form_NewTable_sel_Rows = new System.Windows.Forms.NumericUpDown();
            this.Form_NewTable_lab_Columns = new System.Windows.Forms.Label();
            this.Form_NewTable_sel_Columns = new System.Windows.Forms.NumericUpDown();
            this.Form_NewTable_group_Dimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_NewTable_sel_Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_NewTable_sel_Columns)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_NewTable_but_Create
            // 
            this.Form_NewTable_but_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_NewTable_but_Create.Location = new System.Drawing.Point(316, 150);
            this.Form_NewTable_but_Create.Name = "Form_NewTable_but_Create";
            this.Form_NewTable_but_Create.Size = new System.Drawing.Size(75, 24);
            this.Form_NewTable_but_Create.TabIndex = 0;
            this.Form_NewTable_but_Create.Text = "Create";
            this.Form_NewTable_but_Create.UseVisualStyleBackColor = true;
            this.Form_NewTable_but_Create.Click += new System.EventHandler(this.Form_NewTable_but_Create_Click);
            // 
            // Form_NewTable_but_Cancel
            // 
            this.Form_NewTable_but_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_NewTable_but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Form_NewTable_but_Cancel.Location = new System.Drawing.Point(235, 150);
            this.Form_NewTable_but_Cancel.Name = "Form_NewTable_but_Cancel";
            this.Form_NewTable_but_Cancel.Size = new System.Drawing.Size(75, 24);
            this.Form_NewTable_but_Cancel.TabIndex = 1;
            this.Form_NewTable_but_Cancel.Text = "Cancel";
            this.Form_NewTable_but_Cancel.UseVisualStyleBackColor = true;
            this.Form_NewTable_but_Cancel.Click += new System.EventHandler(this.Form_NewTable_but_Cancel_Click);
            // 
            // Form_NewTable_group_Dimensions
            // 
            this.Form_NewTable_group_Dimensions.Controls.Add(this.Form_NewTable_lab_Rows);
            this.Form_NewTable_group_Dimensions.Controls.Add(this.Form_NewTable_sel_Rows);
            this.Form_NewTable_group_Dimensions.Controls.Add(this.Form_NewTable_lab_Columns);
            this.Form_NewTable_group_Dimensions.Controls.Add(this.Form_NewTable_sel_Columns);
            this.Form_NewTable_group_Dimensions.Location = new System.Drawing.Point(12, 12);
            this.Form_NewTable_group_Dimensions.Name = "Form_NewTable_group_Dimensions";
            this.Form_NewTable_group_Dimensions.Size = new System.Drawing.Size(215, 121);
            this.Form_NewTable_group_Dimensions.TabIndex = 2;
            this.Form_NewTable_group_Dimensions.TabStop = false;
            this.Form_NewTable_group_Dimensions.Text = "Dimensions";
            // 
            // Form_NewTable_lab_Rows
            // 
            this.Form_NewTable_lab_Rows.AutoSize = true;
            this.Form_NewTable_lab_Rows.Location = new System.Drawing.Point(84, 71);
            this.Form_NewTable_lab_Rows.Name = "Form_NewTable_lab_Rows";
            this.Form_NewTable_lab_Rows.Size = new System.Drawing.Size(42, 17);
            this.Form_NewTable_lab_Rows.TabIndex = 4;
            this.Form_NewTable_lab_Rows.Text = "Rows";
            // 
            // Form_NewTable_sel_Rows
            // 
            this.Form_NewTable_sel_Rows.Location = new System.Drawing.Point(16, 69);
            this.Form_NewTable_sel_Rows.Name = "Form_NewTable_sel_Rows";
            this.Form_NewTable_sel_Rows.Size = new System.Drawing.Size(62, 22);
            this.Form_NewTable_sel_Rows.TabIndex = 5;
            this.Form_NewTable_sel_Rows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form_NewTable_lab_Columns
            // 
            this.Form_NewTable_lab_Columns.AutoSize = true;
            this.Form_NewTable_lab_Columns.Location = new System.Drawing.Point(84, 34);
            this.Form_NewTable_lab_Columns.Name = "Form_NewTable_lab_Columns";
            this.Form_NewTable_lab_Columns.Size = new System.Drawing.Size(62, 17);
            this.Form_NewTable_lab_Columns.TabIndex = 3;
            this.Form_NewTable_lab_Columns.Text = "Columns";
            // 
            // Form_NewTable_sel_Columns
            // 
            this.Form_NewTable_sel_Columns.Location = new System.Drawing.Point(16, 32);
            this.Form_NewTable_sel_Columns.Name = "Form_NewTable_sel_Columns";
            this.Form_NewTable_sel_Columns.Size = new System.Drawing.Size(62, 22);
            this.Form_NewTable_sel_Columns.TabIndex = 3;
            this.Form_NewTable_sel_Columns.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form_NewTable
            // 
            this.AcceptButton = this.Form_NewTable_but_Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.Form_NewTable_but_Cancel;
            this.ClientSize = new System.Drawing.Size(403, 186);
            this.Controls.Add(this.Form_NewTable_group_Dimensions);
            this.Controls.Add(this.Form_NewTable_but_Cancel);
            this.Controls.Add(this.Form_NewTable_but_Create);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_NewTable";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WooTable .::. Create New Table";
            this.Load += new System.EventHandler(this.Form_NewTable_Load);
            this.Form_NewTable_group_Dimensions.ResumeLayout(false);
            this.Form_NewTable_group_Dimensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form_NewTable_sel_Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_NewTable_sel_Columns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form_NewTable_but_Create;
        private System.Windows.Forms.Button Form_NewTable_but_Cancel;
        private System.Windows.Forms.GroupBox Form_NewTable_group_Dimensions;
        private System.Windows.Forms.Label Form_NewTable_lab_Rows;
        private System.Windows.Forms.NumericUpDown Form_NewTable_sel_Rows;
        private System.Windows.Forms.Label Form_NewTable_lab_Columns;
        private System.Windows.Forms.NumericUpDown Form_NewTable_sel_Columns;
    }
}