namespace AMLibary
{
    partial class transfer
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
            this.btn_import = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_current_folder = new System.Windows.Forms.TextBox();
            this.btn_select_current_folder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(43, 103);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(200, 23);
            this.btn_import.TabIndex = 0;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // tb_current_folder
            // 
            this.tb_current_folder.Location = new System.Drawing.Point(43, 32);
            this.tb_current_folder.Name = "tb_current_folder";
            this.tb_current_folder.Size = new System.Drawing.Size(200, 20);
            this.tb_current_folder.TabIndex = 1;
            // 
            // btn_select_current_folder
            // 
            this.btn_select_current_folder.Location = new System.Drawing.Point(43, 59);
            this.btn_select_current_folder.Name = "btn_select_current_folder";
            this.btn_select_current_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_select_current_folder.TabIndex = 3;
            this.btn_select_current_folder.Text = "Select File";
            this.btn_select_current_folder.UseVisualStyleBackColor = true;
            this.btn_select_current_folder.Click += new System.EventHandler(this.btn_select_current_folder_Click);
            // 
            // transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.btn_select_current_folder);
            this.Controls.Add(this.tb_current_folder);
            this.Controls.Add(this.btn_import);
            this.Name = "transfer";
            this.Text = "transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tb_current_folder;
        private System.Windows.Forms.Button btn_select_current_folder;
    }
}