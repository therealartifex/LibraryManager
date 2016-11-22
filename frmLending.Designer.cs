namespace LibraryManager
{
    partial class frmLending
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
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtPatronId = new System.Windows.Forms.TextBox();
            this.btnCI = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCO = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(162, 45);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(149, 27);
            this.txtBookId.TabIndex = 0;
            // 
            // txtPatronId
            // 
            this.txtPatronId.Location = new System.Drawing.Point(162, 12);
            this.txtPatronId.Name = "txtPatronId";
            this.txtPatronId.Size = new System.Drawing.Size(149, 27);
            this.txtPatronId.TabIndex = 1;
            // 
            // btnCI
            // 
            this.btnCI.Location = new System.Drawing.Point(73, 78);
            this.btnCI.Name = "btnCI";
            this.btnCI.Size = new System.Drawing.Size(116, 41);
            this.btnCI.TabIndex = 2;
            this.btnCI.Text = "Check In";
            this.btnCI.UseVisualStyleBackColor = true;
            this.btnCI.Click += new System.EventHandler(this.btnCI_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(253, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patron ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book ID:";
            // 
            // btnCO
            // 
            this.btnCO.Location = new System.Drawing.Point(195, 78);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(116, 41);
            this.btnCO.TabIndex = 6;
            this.btnCO.Text = "Check Out";
            this.btnCO.UseVisualStyleBackColor = true;
            this.btnCO.Click += new System.EventHandler(this.btnCO_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 125);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(357, 197);
            this.txtStatus.TabIndex = 7;
            // 
            // frmLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 381);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnCO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCI);
            this.Controls.Add(this.txtPatronId);
            this.Controls.Add(this.txtBookId);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLending";
            this.ShowInTaskbar = false;
            this.Text = "Check In / Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtPatronId;
        private System.Windows.Forms.Button btnCI;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.TextBox txtStatus;
    }
}