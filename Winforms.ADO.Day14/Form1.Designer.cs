namespace Winforms.ADO.Day14
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
            this.LblEmpCode = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.TxtEmpCode = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEmpCode
            // 
            this.LblEmpCode.AutoSize = true;
            this.LblEmpCode.Location = new System.Drawing.Point(119, 54);
            this.LblEmpCode.Name = "LblEmpCode";
            this.LblEmpCode.Size = new System.Drawing.Size(81, 13);
            this.LblEmpCode.TabIndex = 0;
            this.LblEmpCode.Text = "Employee Code";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(143, 101);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(57, 13);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "First Name";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(176, 150);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(24, 13);
            this.LblCity.TabIndex = 2;
            this.LblCity.Text = "City";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(168, 196);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(32, 13);
            this.LblState.TabIndex = 3;
            this.LblState.Text = "State";
            // 
            // TxtEmpCode
            // 
            this.TxtEmpCode.Location = new System.Drawing.Point(311, 51);
            this.TxtEmpCode.Name = "TxtEmpCode";
            this.TxtEmpCode.Size = new System.Drawing.Size(100, 20);
            this.TxtEmpCode.TabIndex = 4;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(311, 94);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.TxtFirstName.TabIndex = 5;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(311, 147);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(100, 20);
            this.TxtCity.TabIndex = 6;
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(311, 193);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(100, 20);
            this.TxtState.TabIndex = 7;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(453, 49);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(216, 243);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TxtEmpCode);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblEmpCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmpCode;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.TextBox TxtEmpCode;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReset;
    }
}

