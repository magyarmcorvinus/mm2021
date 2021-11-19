
namespace UserMaintenance
{
    partial class Form1
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.btnFajlba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(39, 55);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(134, 303);
            this.listUsers.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(217, 109);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(35, 13);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "label1";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(295, 104);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(100, 20);
            this.txtFullname.TabIndex = 7;
            // 
            // btnFajlba
            // 
            this.btnFajlba.Location = new System.Drawing.Point(220, 181);
            this.btnFajlba.Name = "btnFajlba";
            this.btnFajlba.Size = new System.Drawing.Size(175, 23);
            this.btnFajlba.TabIndex = 8;
            this.btnFajlba.Text = "button1";
            this.btnFajlba.UseVisualStyleBackColor = true;
            this.btnFajlba.Click += new System.EventHandler(this.btnFajlba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 402);
            this.Controls.Add(this.btnFajlba);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Button btnFajlba;
    }
}

