namespace WooTable
{
    partial class Form_Settings
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
            this.Form_Settings_but_Cancel = new System.Windows.Forms.Button();
            this.Form_Settings_but_Apply = new System.Windows.Forms.Button();
            this.Form_Settings_gr_StatusBar = new System.Windows.Forms.GroupBox();
            this.Form_Settings_lab_ShowMedian = new System.Windows.Forms.Label();
            this.Form_Settings_check_ShowMedian = new System.Windows.Forms.CheckBox();
            this.Form_Settings_check_ShowMax = new System.Windows.Forms.CheckBox();
            this.Form_Settings_check_ShowMin = new System.Windows.Forms.CheckBox();
            this.Form_Settings_check_ModifyStatusBar = new System.Windows.Forms.CheckBox();
            this.Form_Settings_gr_Currency = new System.Windows.Forms.GroupBox();
            this.Form_Settings_combo_Provider = new System.Windows.Forms.ComboBox();
            this.Form_Settings_lab_Provider = new System.Windows.Forms.Label();
            this.Form_Settings_lab_Ratio2 = new System.Windows.Forms.Label();
            this.Form_Settings_text_Ratio = new System.Windows.Forms.TextBox();
            this.Form_Settings_lab_Ratio = new System.Windows.Forms.Label();
            this.Form_Settings_gr_Misc = new System.Windows.Forms.GroupBox();
            this.Form_Settings_label_lang = new System.Windows.Forms.Label();
            this.Form_Settings_combo_lang = new System.Windows.Forms.ComboBox();
            this.Form_Settings_check_DialogOnMath = new System.Windows.Forms.CheckBox();
            this.Form_Settings_gr_XLSCopy = new System.Windows.Forms.GroupBox();
            this.Form_Settings_lab_ReplaceNLine = new System.Windows.Forms.Label();
            this.Form_Settings_check_ReplaceNLine = new System.Windows.Forms.CheckBox();
            this.Form_Settings_gr_Oracle = new System.Windows.Forms.GroupBox();
            this.Form_Settings_lab_OracleData_Username = new System.Windows.Forms.Label();
            this.Form_Settings_combo_OracleDataLocation = new System.Windows.Forms.ComboBox();
            this.Form_Settings_lab_OracleData = new System.Windows.Forms.Label();
            this.Form_Settings_lab_OracleData_Password = new System.Windows.Forms.Label();
            this.Form_Settings_text_OracleDataUsername = new System.Windows.Forms.TextBox();
            this.Form_Settings_text_OracleDataPassword = new System.Windows.Forms.MaskedTextBox();
            this.Form_Settings_gr_StatusBar.SuspendLayout();
            this.Form_Settings_gr_Currency.SuspendLayout();
            this.Form_Settings_gr_Misc.SuspendLayout();
            this.Form_Settings_gr_XLSCopy.SuspendLayout();
            this.Form_Settings_gr_Oracle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Settings_but_Cancel
            // 
            this.Form_Settings_but_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_Settings_but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Form_Settings_but_Cancel.Location = new System.Drawing.Point(1012, 1256);
            this.Form_Settings_but_Cancel.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_but_Cancel.Name = "Form_Settings_but_Cancel";
            this.Form_Settings_but_Cancel.Size = new System.Drawing.Size(160, 56);
            this.Form_Settings_but_Cancel.TabIndex = 5;
            this.Form_Settings_but_Cancel.Text = "Cancel";
            this.Form_Settings_but_Cancel.UseVisualStyleBackColor = true;
            this.Form_Settings_but_Cancel.Click += new System.EventHandler(this.Form_Settings_but_Cancel_Click);
            // 
            // Form_Settings_but_Apply
            // 
            this.Form_Settings_but_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Form_Settings_but_Apply.Location = new System.Drawing.Point(1186, 1256);
            this.Form_Settings_but_Apply.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_but_Apply.Name = "Form_Settings_but_Apply";
            this.Form_Settings_but_Apply.Size = new System.Drawing.Size(160, 56);
            this.Form_Settings_but_Apply.TabIndex = 4;
            this.Form_Settings_but_Apply.Text = "Apply";
            this.Form_Settings_but_Apply.UseVisualStyleBackColor = true;
            this.Form_Settings_but_Apply.Click += new System.EventHandler(this.Form_Settings_but_Apply_Click);
            // 
            // Form_Settings_gr_StatusBar
            // 
            this.Form_Settings_gr_StatusBar.Controls.Add(this.Form_Settings_lab_ShowMedian);
            this.Form_Settings_gr_StatusBar.Controls.Add(this.Form_Settings_check_ShowMedian);
            this.Form_Settings_gr_StatusBar.Controls.Add(this.Form_Settings_check_ShowMax);
            this.Form_Settings_gr_StatusBar.Controls.Add(this.Form_Settings_check_ShowMin);
            this.Form_Settings_gr_StatusBar.Controls.Add(this.Form_Settings_check_ModifyStatusBar);
            this.Form_Settings_gr_StatusBar.Location = new System.Drawing.Point(24, 23);
            this.Form_Settings_gr_StatusBar.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_StatusBar.Name = "Form_Settings_gr_StatusBar";
            this.Form_Settings_gr_StatusBar.Padding = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_StatusBar.Size = new System.Drawing.Size(818, 380);
            this.Form_Settings_gr_StatusBar.TabIndex = 6;
            this.Form_Settings_gr_StatusBar.TabStop = false;
            this.Form_Settings_gr_StatusBar.Text = "Status Bar";
            this.Form_Settings_gr_StatusBar.Enter += new System.EventHandler(this.Form_Settings_gr_StatusBar_Enter);
            // 
            // Form_Settings_lab_ShowMedian
            // 
            this.Form_Settings_lab_ShowMedian.AutoSize = true;
            this.Form_Settings_lab_ShowMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.Form_Settings_lab_ShowMedian.Location = new System.Drawing.Point(74, 287);
            this.Form_Settings_lab_ShowMedian.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form_Settings_lab_ShowMedian.Name = "Form_Settings_lab_ShowMedian";
            this.Form_Settings_lab_ShowMedian.Size = new System.Drawing.Size(579, 31);
            this.Form_Settings_lab_ShowMedian.TabIndex = 4;
            this.Form_Settings_lab_ShowMedian.Text = "(if disabled, will stop MEDIAN calculation at all)";
            // 
            // Form_Settings_check_ShowMedian
            // 
            this.Form_Settings_check_ShowMedian.AutoSize = true;
            this.Form_Settings_check_ShowMedian.Location = new System.Drawing.Point(40, 240);
            this.Form_Settings_check_ShowMedian.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_check_ShowMedian.Name = "Form_Settings_check_ShowMedian";
            this.Form_Settings_check_ShowMedian.Size = new System.Drawing.Size(388, 36);
            this.Form_Settings_check_ShowMedian.TabIndex = 3;
            this.Form_Settings_check_ShowMedian.Text = "Show median (MED) value";
            this.Form_Settings_check_ShowMedian.UseVisualStyleBackColor = true;
            // 
            // Form_Settings_check_ShowMax
            // 
            this.Form_Settings_check_ShowMax.AutoSize = true;
            this.Form_Settings_check_ShowMax.Location = new System.Drawing.Point(40, 188);
            this.Form_Settings_check_ShowMax.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_check_ShowMax.Name = "Form_Settings_check_ShowMax";
            this.Form_Settings_check_ShowMax.Size = new System.Drawing.Size(415, 36);
            this.Form_Settings_check_ShowMax.TabIndex = 2;
            this.Form_Settings_check_ShowMax.Text = "Show maximum (MAX) value";
            this.Form_Settings_check_ShowMax.UseVisualStyleBackColor = true;
            // 
            // Form_Settings_check_ShowMin
            // 
            this.Form_Settings_check_ShowMin.AutoSize = true;
            this.Form_Settings_check_ShowMin.Location = new System.Drawing.Point(40, 136);
            this.Form_Settings_check_ShowMin.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_check_ShowMin.Name = "Form_Settings_check_ShowMin";
            this.Form_Settings_check_ShowMin.Size = new System.Drawing.Size(397, 36);
            this.Form_Settings_check_ShowMin.TabIndex = 1;
            this.Form_Settings_check_ShowMin.Text = "Show minimum (MIN) value";
            this.Form_Settings_check_ShowMin.UseVisualStyleBackColor = true;
            // 
            // Form_Settings_check_ModifyStatusBar
            // 
            this.Form_Settings_check_ModifyStatusBar.AutoSize = true;
            this.Form_Settings_check_ModifyStatusBar.Location = new System.Drawing.Point(40, 58);
            this.Form_Settings_check_ModifyStatusBar.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_check_ModifyStatusBar.Name = "Form_Settings_check_ModifyStatusBar";
            this.Form_Settings_check_ModifyStatusBar.Size = new System.Drawing.Size(746, 36);
            this.Form_Settings_check_ModifyStatusBar.TabIndex = 0;
            this.Form_Settings_check_ModifyStatusBar.Text = "Use Status Bar to show mathematical data on selection";
            this.Form_Settings_check_ModifyStatusBar.UseVisualStyleBackColor = true;
            this.Form_Settings_check_ModifyStatusBar.CheckedChanged += new System.EventHandler(this.Form_Settings_check_ModifyStatusBar_CheckedChanged);
            this.Form_Settings_check_ModifyStatusBar.CheckStateChanged += new System.EventHandler(this.Form_Settings_check_ModifyStatusBar_CheckStateChanged);
            // 
            // Form_Settings_gr_Currency
            // 
            this.Form_Settings_gr_Currency.Controls.Add(this.Form_Settings_combo_Provider);
            this.Form_Settings_gr_Currency.Controls.Add(this.Form_Settings_lab_Provider);
            this.Form_Settings_gr_Currency.Controls.Add(this.Form_Settings_lab_Ratio2);
            this.Form_Settings_gr_Currency.Controls.Add(this.Form_Settings_text_Ratio);
            this.Form_Settings_gr_Currency.Controls.Add(this.Form_Settings_lab_Ratio);
            this.Form_Settings_gr_Currency.Location = new System.Drawing.Point(24, 415);
            this.Form_Settings_gr_Currency.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_Currency.Name = "Form_Settings_gr_Currency";
            this.Form_Settings_gr_Currency.Padding = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_Currency.Size = new System.Drawing.Size(1324, 279);
            this.Form_Settings_gr_Currency.TabIndex = 7;
            this.Form_Settings_gr_Currency.TabStop = false;
            this.Form_Settings_gr_Currency.Text = "Currency exchange";
            // 
            // Form_Settings_combo_Provider
            // 
            this.Form_Settings_combo_Provider.FormattingEnabled = true;
            this.Form_Settings_combo_Provider.Location = new System.Drawing.Point(70, 188);
            this.Form_Settings_combo_Provider.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_combo_Provider.Name = "Form_Settings_combo_Provider";
            this.Form_Settings_combo_Provider.Size = new System.Drawing.Size(1212, 39);
            this.Form_Settings_combo_Provider.TabIndex = 4;
            // 
            // Form_Settings_lab_Provider
            // 
            this.Form_Settings_lab_Provider.AutoSize = true;
            this.Form_Settings_lab_Provider.Location = new System.Drawing.Point(46, 143);
            this.Form_Settings_lab_Provider.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form_Settings_lab_Provider.Name = "Form_Settings_lab_Provider";
            this.Form_Settings_lab_Provider.Size = new System.Drawing.Size(315, 32);
            this.Form_Settings_lab_Provider.TabIndex = 3;
            this.Form_Settings_lab_Provider.Text = "Exchange ratio provider";
            // 
            // Form_Settings_lab_Ratio2
            // 
            this.Form_Settings_lab_Ratio2.AutoSize = true;
            this.Form_Settings_lab_Ratio2.Location = new System.Drawing.Point(590, 72);
            this.Form_Settings_lab_Ratio2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form_Settings_lab_Ratio2.Name = "Form_Settings_lab_Ratio2";
            this.Form_Settings_lab_Ratio2.Size = new System.Drawing.Size(40, 32);
            this.Form_Settings_lab_Ratio2.TabIndex = 2;
            this.Form_Settings_lab_Ratio2.Text = "%";
            // 
            // Form_Settings_text_Ratio
            // 
            this.Form_Settings_text_Ratio.Location = new System.Drawing.Point(486, 66);
            this.Form_Settings_text_Ratio.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_text_Ratio.Name = "Form_Settings_text_Ratio";
            this.Form_Settings_text_Ratio.Size = new System.Drawing.Size(88, 38);
            this.Form_Settings_text_Ratio.TabIndex = 1;
            this.Form_Settings_text_Ratio.Validating += new System.ComponentModel.CancelEventHandler(this.Form_Settings_text_Ratio_Validating);
            // 
            // Form_Settings_lab_Ratio
            // 
            this.Form_Settings_lab_Ratio.AutoSize = true;
            this.Form_Settings_lab_Ratio.Location = new System.Drawing.Point(46, 66);
            this.Form_Settings_lab_Ratio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form_Settings_lab_Ratio.Name = "Form_Settings_lab_Ratio";
            this.Form_Settings_lab_Ratio.Size = new System.Drawing.Size(302, 32);
            this.Form_Settings_lab_Ratio.TabIndex = 0;
            this.Form_Settings_lab_Ratio.Text = "Default conversion risk";
            // 
            // Form_Settings_gr_Misc
            // 
            this.Form_Settings_gr_Misc.Controls.Add(this.Form_Settings_label_lang);
            this.Form_Settings_gr_Misc.Controls.Add(this.Form_Settings_combo_lang);
            this.Form_Settings_gr_Misc.Controls.Add(this.Form_Settings_check_DialogOnMath);
            this.Form_Settings_gr_Misc.Location = new System.Drawing.Point(24, 705);
            this.Form_Settings_gr_Misc.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_Misc.Name = "Form_Settings_gr_Misc";
            this.Form_Settings_gr_Misc.Padding = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_Misc.Size = new System.Drawing.Size(1324, 238);
            this.Form_Settings_gr_Misc.TabIndex = 8;
            this.Form_Settings_gr_Misc.TabStop = false;
            this.Form_Settings_gr_Misc.Text = "Miscellaneous";
            // 
            // Form_Settings_label_lang
            // 
            this.Form_Settings_label_lang.AutoSize = true;
            this.Form_Settings_label_lang.Location = new System.Drawing.Point(34, 136);
            this.Form_Settings_label_lang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form_Settings_label_lang.Name = "Form_Settings_label_lang";
            this.Form_Settings_label_lang.Size = new System.Drawing.Size(143, 32);
            this.Form_Settings_label_lang.TabIndex = 2;
            this.Form_Settings_label_lang.Text = "Language";
            // 
            // Form_Settings_combo_lang
            // 
            this.Form_Settings_combo_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Form_Settings_combo_lang.FormattingEnabled = true;
            this.Form_Settings_combo_lang.Location = new System.Drawing.Point(212, 136);
            this.Form_Settings_combo_lang.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_combo_lang.Name = "Form_Settings_combo_lang";
            this.Form_Settings_combo_lang.Size = new System.Drawing.Size(576, 39);
            this.Form_Settings_combo_lang.TabIndex = 1;
            // 
            // Form_Settings_check_DialogOnMath
            // 
            this.Form_Settings_check_DialogOnMath.AutoSize = true;
            this.Form_Settings_check_DialogOnMath.Location = new System.Drawing.Point(40, 62);
            this.Form_Settings_check_DialogOnMath.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_check_DialogOnMath.Name = "Form_Settings_check_DialogOnMath";
            this.Form_Settings_check_DialogOnMath.Size = new System.Drawing.Size(1046, 36);
            this.Form_Settings_check_DialogOnMath.TabIndex = 0;
            this.Form_Settings_check_DialogOnMath.Text = "Show confirmation dialog when using MIN/MAX/AVG/SUM/MED copy functions";
            this.Form_Settings_check_DialogOnMath.UseVisualStyleBackColor = true;
            // 
            // Form_Settings_gr_XLSCopy
            // 
            this.Form_Settings_gr_XLSCopy.Controls.Add(this.Form_Settings_lab_ReplaceNLine);
            this.Form_Settings_gr_XLSCopy.Controls.Add(this.Form_Settings_check_ReplaceNLine);
            this.Form_Settings_gr_XLSCopy.Location = new System.Drawing.Point(854, 23);
            this.Form_Settings_gr_XLSCopy.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_XLSCopy.Name = "Form_Settings_gr_XLSCopy";
            this.Form_Settings_gr_XLSCopy.Padding = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_XLSCopy.Size = new System.Drawing.Size(490, 380);
            this.Form_Settings_gr_XLSCopy.TabIndex = 9;
            this.Form_Settings_gr_XLSCopy.TabStop = false;
            this.Form_Settings_gr_XLSCopy.Text = "groupBox1";
            // 
            // Form_Settings_lab_ReplaceNLine
            // 
            this.Form_Settings_lab_ReplaceNLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.Form_Settings_lab_ReplaceNLine.Location = new System.Drawing.Point(24, 105);
            this.Form_Settings_lab_ReplaceNLine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form_Settings_lab_ReplaceNLine.Name = "Form_Settings_lab_ReplaceNLine";
            this.Form_Settings_lab_ReplaceNLine.Size = new System.Drawing.Size(454, 91);
            this.Form_Settings_lab_ReplaceNLine.TabIndex = 5;
            this.Form_Settings_lab_ReplaceNLine.Text = "note";
            // 
            // Form_Settings_check_ReplaceNLine
            // 
            this.Form_Settings_check_ReplaceNLine.AutoSize = true;
            this.Form_Settings_check_ReplaceNLine.Location = new System.Drawing.Point(30, 58);
            this.Form_Settings_check_ReplaceNLine.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_check_ReplaceNLine.Name = "Form_Settings_check_ReplaceNLine";
            this.Form_Settings_check_ReplaceNLine.Size = new System.Drawing.Size(192, 36);
            this.Form_Settings_check_ReplaceNLine.TabIndex = 0;
            this.Form_Settings_check_ReplaceNLine.Text = "checkBox1";
            this.Form_Settings_check_ReplaceNLine.UseVisualStyleBackColor = true;
            this.Form_Settings_check_ReplaceNLine.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_Settings_gr_Oracle
            // 
            this.Form_Settings_gr_Oracle.Controls.Add(this.Form_Settings_text_OracleDataPassword);
            this.Form_Settings_gr_Oracle.Controls.Add(this.Form_Settings_text_OracleDataUsername);
            this.Form_Settings_gr_Oracle.Controls.Add(this.Form_Settings_lab_OracleData_Password);
            this.Form_Settings_gr_Oracle.Controls.Add(this.Form_Settings_lab_OracleData_Username);
            this.Form_Settings_gr_Oracle.Controls.Add(this.Form_Settings_combo_OracleDataLocation);
            this.Form_Settings_gr_Oracle.Controls.Add(this.Form_Settings_lab_OracleData);
            this.Form_Settings_gr_Oracle.Location = new System.Drawing.Point(28, 955);
            this.Form_Settings_gr_Oracle.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_Oracle.Name = "Form_Settings_gr_Oracle";
            this.Form_Settings_gr_Oracle.Padding = new System.Windows.Forms.Padding(6);
            this.Form_Settings_gr_Oracle.Size = new System.Drawing.Size(1324, 278);
            this.Form_Settings_gr_Oracle.TabIndex = 10;
            this.Form_Settings_gr_Oracle.TabStop = false;
            this.Form_Settings_gr_Oracle.Text = "Oracle";
            // 
            // Form_Settings_lab_OracleData_Username
            // 
            this.Form_Settings_lab_OracleData_Username.AutoSize = true;
            this.Form_Settings_lab_OracleData_Username.Location = new System.Drawing.Point(42, 180);
            this.Form_Settings_lab_OracleData_Username.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form_Settings_lab_OracleData_Username.Name = "Form_Settings_lab_OracleData_Username";
            this.Form_Settings_lab_OracleData_Username.Size = new System.Drawing.Size(145, 32);
            this.Form_Settings_lab_OracleData_Username.TabIndex = 5;
            this.Form_Settings_lab_OracleData_Username.Text = "Username";
            // 
            // Form_Settings_combo_OracleDataLocation
            // 
            this.Form_Settings_combo_OracleDataLocation.FormattingEnabled = true;
            this.Form_Settings_combo_OracleDataLocation.Location = new System.Drawing.Point(66, 109);
            this.Form_Settings_combo_OracleDataLocation.Margin = new System.Windows.Forms.Padding(6);
            this.Form_Settings_combo_OracleDataLocation.Name = "Form_Settings_combo_OracleDataLocation";
            this.Form_Settings_combo_OracleDataLocation.Size = new System.Drawing.Size(1212, 39);
            this.Form_Settings_combo_OracleDataLocation.TabIndex = 4;
            // 
            // Form_Settings_lab_OracleData
            // 
            this.Form_Settings_lab_OracleData.AutoSize = true;
            this.Form_Settings_lab_OracleData.Location = new System.Drawing.Point(42, 64);
            this.Form_Settings_lab_OracleData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form_Settings_lab_OracleData.Name = "Form_Settings_lab_OracleData";
            this.Form_Settings_lab_OracleData.Size = new System.Drawing.Size(255, 32);
            this.Form_Settings_lab_OracleData.TabIndex = 3;
            this.Form_Settings_lab_OracleData.Text = "Templates location";
            // 
            // Form_Settings_lab_OracleData_Password
            // 
            this.Form_Settings_lab_OracleData_Password.AutoSize = true;
            this.Form_Settings_lab_OracleData_Password.Location = new System.Drawing.Point(519, 180);
            this.Form_Settings_lab_OracleData_Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Form_Settings_lab_OracleData_Password.Name = "Form_Settings_lab_OracleData_Password";
            this.Form_Settings_lab_OracleData_Password.Size = new System.Drawing.Size(139, 32);
            this.Form_Settings_lab_OracleData_Password.TabIndex = 6;
            this.Form_Settings_lab_OracleData_Password.Text = "Password";
            // 
            // Form_Settings_text_OracleDataUsername
            // 
            this.Form_Settings_text_OracleDataUsername.Location = new System.Drawing.Point(66, 215);
            this.Form_Settings_text_OracleDataUsername.Name = "Form_Settings_text_OracleDataUsername";
            this.Form_Settings_text_OracleDataUsername.Size = new System.Drawing.Size(367, 38);
            this.Form_Settings_text_OracleDataUsername.TabIndex = 7;
            // 
            // Form_Settings_text_OracleDataPassword
            // 
            this.Form_Settings_text_OracleDataPassword.Location = new System.Drawing.Point(538, 215);
            this.Form_Settings_text_OracleDataPassword.Name = "Form_Settings_text_OracleDataPassword";
            this.Form_Settings_text_OracleDataPassword.PasswordChar = '*';
            this.Form_Settings_text_OracleDataPassword.Size = new System.Drawing.Size(377, 38);
            this.Form_Settings_text_OracleDataPassword.TabIndex = 8;
            // 
            // Form_Settings
            // 
            this.AcceptButton = this.Form_Settings_but_Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Form_Settings_but_Cancel;
            this.ClientSize = new System.Drawing.Size(1370, 1335);
            this.Controls.Add(this.Form_Settings_gr_Oracle);
            this.Controls.Add(this.Form_Settings_gr_XLSCopy);
            this.Controls.Add(this.Form_Settings_gr_Misc);
            this.Controls.Add(this.Form_Settings_gr_Currency);
            this.Controls.Add(this.Form_Settings_gr_StatusBar);
            this.Controls.Add(this.Form_Settings_but_Cancel);
            this.Controls.Add(this.Form_Settings_but_Apply);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "Form_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WooTable .::. Settings";
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.Form_Settings_gr_StatusBar.ResumeLayout(false);
            this.Form_Settings_gr_StatusBar.PerformLayout();
            this.Form_Settings_gr_Currency.ResumeLayout(false);
            this.Form_Settings_gr_Currency.PerformLayout();
            this.Form_Settings_gr_Misc.ResumeLayout(false);
            this.Form_Settings_gr_Misc.PerformLayout();
            this.Form_Settings_gr_XLSCopy.ResumeLayout(false);
            this.Form_Settings_gr_XLSCopy.PerformLayout();
            this.Form_Settings_gr_Oracle.ResumeLayout(false);
            this.Form_Settings_gr_Oracle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form_Settings_but_Cancel;
        private System.Windows.Forms.Button Form_Settings_but_Apply;
        private System.Windows.Forms.GroupBox Form_Settings_gr_StatusBar;
        private System.Windows.Forms.CheckBox Form_Settings_check_ModifyStatusBar;
        private System.Windows.Forms.CheckBox Form_Settings_check_ShowMedian;
        private System.Windows.Forms.CheckBox Form_Settings_check_ShowMax;
        private System.Windows.Forms.CheckBox Form_Settings_check_ShowMin;
        private System.Windows.Forms.Label Form_Settings_lab_ShowMedian;
        private System.Windows.Forms.GroupBox Form_Settings_gr_Currency;
        private System.Windows.Forms.ComboBox Form_Settings_combo_Provider;
        private System.Windows.Forms.Label Form_Settings_lab_Provider;
        private System.Windows.Forms.Label Form_Settings_lab_Ratio2;
        private System.Windows.Forms.TextBox Form_Settings_text_Ratio;
        private System.Windows.Forms.Label Form_Settings_lab_Ratio;
        private System.Windows.Forms.GroupBox Form_Settings_gr_Misc;
        private System.Windows.Forms.CheckBox Form_Settings_check_DialogOnMath;
        private System.Windows.Forms.Label Form_Settings_label_lang;
        private System.Windows.Forms.ComboBox Form_Settings_combo_lang;
        private System.Windows.Forms.GroupBox Form_Settings_gr_XLSCopy;
        private System.Windows.Forms.CheckBox Form_Settings_check_ReplaceNLine;
        private System.Windows.Forms.Label Form_Settings_lab_ReplaceNLine;
        private System.Windows.Forms.GroupBox Form_Settings_gr_Oracle;
        private System.Windows.Forms.ComboBox Form_Settings_combo_OracleDataLocation;
        private System.Windows.Forms.Label Form_Settings_lab_OracleData;
        private System.Windows.Forms.Label Form_Settings_lab_OracleData_Username;
        private System.Windows.Forms.Label Form_Settings_lab_OracleData_Password;
        private System.Windows.Forms.MaskedTextBox Form_Settings_text_OracleDataPassword;
        private System.Windows.Forms.TextBox Form_Settings_text_OracleDataUsername;
    }
}