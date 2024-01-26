namespace Snap2HTMLNG.Forms
{
    partial class frmFileDateConfigure
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
            this.lblOperator = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.lblFileProperty = new System.Windows.Forms.Label();
            this.cbBasis = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(20, 20);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(63, 16);
            this.lblOperator.TabIndex = 0;
            this.lblOperator.Text = "Operator:";
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "Less Than",
            "More Than",
            "Equal "});
            this.cbOperator.Location = new System.Drawing.Point(89, 17);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(155, 24);
            this.cbOperator.TabIndex = 1;
            // 
            // lblFileProperty
            // 
            this.lblFileProperty.AutoSize = true;
            this.lblFileProperty.Location = new System.Drawing.Point(39, 50);
            this.lblFileProperty.Name = "lblFileProperty";
            this.lblFileProperty.Size = new System.Drawing.Size(44, 16);
            this.lblFileProperty.TabIndex = 2;
            this.lblFileProperty.Text = "Basis:";
            // 
            // cbBasis
            // 
            this.cbBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBasis.FormattingEnabled = true;
            this.cbBasis.Items.AddRange(new object[] {
            "Created Date",
            "Modified Date",
            "Both"});
            this.cbBasis.Location = new System.Drawing.Point(89, 47);
            this.cbBasis.Name = "cbBasis";
            this.cbBasis.Size = new System.Drawing.Size(155, 24);
            this.cbBasis.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(169, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmFileDateConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 125);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbBasis);
            this.Controls.Add(this.lblFileProperty);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.lblOperator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFileDateConfigure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Date Configurator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label lblFileProperty;
        private System.Windows.Forms.ComboBox cbBasis;
        private System.Windows.Forms.Button btnSave;
    }
}