namespace WooTable
{
    partial class Form_NumberFormat
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
            this.Form_NumberFormat_but_Cancel = new System.Windows.Forms.Button();
            this.Form_NumberFormat_but_Apply = new System.Windows.Forms.Button();
            this.Form_NumberFormat_lab_Info = new System.Windows.Forms.Label();
            this.Form_NumberFormat_grid_Formats = new System.Windows.Forms.DataGridView();
            this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Example = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form_NumberFormat_lab_Custom = new System.Windows.Forms.Label();
            this.Form_NumberFormat_Edit_Custom = new System.Windows.Forms.TextBox();
            this.Form_NumberFormat_edit_CustomOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Form_NumberFormat_grid_Formats)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_NumberFormat_but_Cancel
            // 
            this.Form_NumberFormat_but_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_NumberFormat_but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Form_NumberFormat_but_Cancel.Location = new System.Drawing.Point(602, 296);
            this.Form_NumberFormat_but_Cancel.Name = "Form_NumberFormat_but_Cancel";
            this.Form_NumberFormat_but_Cancel.Size = new System.Drawing.Size(75, 29);
            this.Form_NumberFormat_but_Cancel.TabIndex = 3;
            this.Form_NumberFormat_but_Cancel.Text = "Cancel";
            this.Form_NumberFormat_but_Cancel.UseVisualStyleBackColor = true;
            this.Form_NumberFormat_but_Cancel.Click += new System.EventHandler(this.Form_NewTable_but_Cancel_Click);
            // 
            // Form_NumberFormat_but_Apply
            // 
            this.Form_NumberFormat_but_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_NumberFormat_but_Apply.Location = new System.Drawing.Point(683, 296);
            this.Form_NumberFormat_but_Apply.Name = "Form_NumberFormat_but_Apply";
            this.Form_NumberFormat_but_Apply.Size = new System.Drawing.Size(75, 29);
            this.Form_NumberFormat_but_Apply.TabIndex = 2;
            this.Form_NumberFormat_but_Apply.Text = "Apply";
            this.Form_NumberFormat_but_Apply.UseVisualStyleBackColor = true;
            this.Form_NumberFormat_but_Apply.Click += new System.EventHandler(this.Form_NewTable_but_Create_Click);
            // 
            // Form_NumberFormat_lab_Info
            // 
            this.Form_NumberFormat_lab_Info.AutoSize = true;
            this.Form_NumberFormat_lab_Info.Location = new System.Drawing.Point(12, 9);
            this.Form_NumberFormat_lab_Info.Name = "Form_NumberFormat_lab_Info";
            this.Form_NumberFormat_lab_Info.Size = new System.Drawing.Size(256, 17);
            this.Form_NumberFormat_lab_Info.TabIndex = 4;
            this.Form_NumberFormat_lab_Info.Text = "Select a number format or set your own";
            // 
            // Form_NumberFormat_grid_Formats
            // 
            this.Form_NumberFormat_grid_Formats.AllowUserToAddRows = false;
            this.Form_NumberFormat_grid_Formats.AllowUserToDeleteRows = false;
            this.Form_NumberFormat_grid_Formats.AllowUserToResizeColumns = false;
            this.Form_NumberFormat_grid_Formats.AllowUserToResizeRows = false;
            this.Form_NumberFormat_grid_Formats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Form_NumberFormat_grid_Formats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Form_NumberFormat_grid_Formats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Format,
            this.Code,
            this.Example});
            this.Form_NumberFormat_grid_Formats.Location = new System.Drawing.Point(72, 44);
            this.Form_NumberFormat_grid_Formats.MultiSelect = false;
            this.Form_NumberFormat_grid_Formats.Name = "Form_NumberFormat_grid_Formats";
            this.Form_NumberFormat_grid_Formats.ReadOnly = true;
            this.Form_NumberFormat_grid_Formats.RowHeadersVisible = false;
            this.Form_NumberFormat_grid_Formats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Form_NumberFormat_grid_Formats.RowTemplate.Height = 24;
            this.Form_NumberFormat_grid_Formats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Form_NumberFormat_grid_Formats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Form_NumberFormat_grid_Formats.Size = new System.Drawing.Size(637, 167);
            this.Form_NumberFormat_grid_Formats.TabIndex = 5;
            this.Form_NumberFormat_grid_Formats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Form_NumberFormat_grid_Formats_CellContentClick);
            this.Form_NumberFormat_grid_Formats.SelectionChanged += new System.EventHandler(this.Form_NumberFormat_grid_Formats_SelectionChanged);
            this.Form_NumberFormat_grid_Formats.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_NumberFormat_grid_Formats_Paint);
            // 
            // Format
            // 
            this.Format.HeaderText = "Format";
            this.Format.Name = "Format";
            this.Format.ReadOnly = true;
            this.Format.Width = 81;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 70;
            // 
            // Example
            // 
            this.Example.HeaderText = "Example";
            this.Example.Name = "Example";
            this.Example.ReadOnly = true;
            this.Example.Width = 90;
            // 
            // Form_NumberFormat_lab_Custom
            // 
            this.Form_NumberFormat_lab_Custom.AutoSize = true;
            this.Form_NumberFormat_lab_Custom.Location = new System.Drawing.Point(108, 241);
            this.Form_NumberFormat_lab_Custom.Name = "Form_NumberFormat_lab_Custom";
            this.Form_NumberFormat_lab_Custom.Size = new System.Drawing.Size(116, 17);
            this.Form_NumberFormat_lab_Custom.TabIndex = 6;
            this.Form_NumberFormat_lab_Custom.Text = "Set format string:";
            this.Form_NumberFormat_lab_Custom.Visible = false;
            // 
            // Form_NumberFormat_Edit_Custom
            // 
            this.Form_NumberFormat_Edit_Custom.Location = new System.Drawing.Point(230, 238);
            this.Form_NumberFormat_Edit_Custom.Name = "Form_NumberFormat_Edit_Custom";
            this.Form_NumberFormat_Edit_Custom.Size = new System.Drawing.Size(234, 22);
            this.Form_NumberFormat_Edit_Custom.TabIndex = 7;
            this.Form_NumberFormat_Edit_Custom.Visible = false;
            this.Form_NumberFormat_Edit_Custom.TextChanged += new System.EventHandler(this.Form_NumberFormat_Edit_Custom_TextChanged);
            // 
            // Form_NumberFormat_edit_CustomOut
            // 
            this.Form_NumberFormat_edit_CustomOut.Enabled = false;
            this.Form_NumberFormat_edit_CustomOut.Location = new System.Drawing.Point(470, 238);
            this.Form_NumberFormat_edit_CustomOut.Name = "Form_NumberFormat_edit_CustomOut";
            this.Form_NumberFormat_edit_CustomOut.Size = new System.Drawing.Size(239, 22);
            this.Form_NumberFormat_edit_CustomOut.TabIndex = 8;
            this.Form_NumberFormat_edit_CustomOut.Visible = false;
            // 
            // Form_NumberFormat
            // 
            this.AcceptButton = this.Form_NumberFormat_but_Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Form_NumberFormat_but_Cancel;
            this.ClientSize = new System.Drawing.Size(770, 337);
            this.Controls.Add(this.Form_NumberFormat_edit_CustomOut);
            this.Controls.Add(this.Form_NumberFormat_Edit_Custom);
            this.Controls.Add(this.Form_NumberFormat_lab_Custom);
            this.Controls.Add(this.Form_NumberFormat_grid_Formats);
            this.Controls.Add(this.Form_NumberFormat_lab_Info);
            this.Controls.Add(this.Form_NumberFormat_but_Cancel);
            this.Controls.Add(this.Form_NumberFormat_but_Apply);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_NumberFormat";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WooTable .::. Set Number Format";
            this.Load += new System.EventHandler(this.Form_NumberFormat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Form_NumberFormat_grid_Formats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Form_NumberFormat_but_Cancel;
        private System.Windows.Forms.Button Form_NumberFormat_but_Apply;
        private System.Windows.Forms.Label Form_NumberFormat_lab_Info;
        private System.Windows.Forms.DataGridView Form_NumberFormat_grid_Formats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Format;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Example;
        private System.Windows.Forms.Label Form_NumberFormat_lab_Custom;
        private System.Windows.Forms.TextBox Form_NumberFormat_Edit_Custom;
        private System.Windows.Forms.TextBox Form_NumberFormat_edit_CustomOut;
    }
}