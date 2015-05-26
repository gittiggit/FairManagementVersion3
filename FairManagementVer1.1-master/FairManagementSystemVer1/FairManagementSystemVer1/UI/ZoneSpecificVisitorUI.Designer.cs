namespace FairManagementSystemVer1.UI
{
    partial class ZoneSpecificVisitorUI
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
            this.zoneSpecificVisitorListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showButton = new System.Windows.Forms.Button();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zoneSpecificVisitorListView
            // 
            this.zoneSpecificVisitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.zoneSpecificVisitorListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneSpecificVisitorListView.FullRowSelect = true;
            this.zoneSpecificVisitorListView.GridLines = true;
            this.zoneSpecificVisitorListView.Location = new System.Drawing.Point(30, 68);
            this.zoneSpecificVisitorListView.Name = "zoneSpecificVisitorListView";
            this.zoneSpecificVisitorListView.Size = new System.Drawing.Size(600, 296);
            this.zoneSpecificVisitorListView.TabIndex = 11;
            this.zoneSpecificVisitorListView.UseCompatibleStateImageBehavior = false;
            this.zoneSpecificVisitorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Serial No.";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Visitor Name";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact Number";
            this.columnHeader3.Width = 242;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(451, 28);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(94, 23);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showVisitorInSpecificZoneButton_Click);
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(177, 28);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(268, 24);
            this.zoneComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Zone";
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(462, 404);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(168, 23);
            this.exportButton.TabIndex = 14;
            this.exportButton.Text = "Export to Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(502, 378);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(126, 22);
            this.totalTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Visitor :";
            // 
            // ZoneSpecificVisitorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 477);
            this.Controls.Add(this.zoneSpecificVisitorListView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.zoneComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label2);
            this.Name = "ZoneSpecificVisitorUI";
            this.Text = "ZoneSpecificVisitorUI";
            this.Load += new System.EventHandler(this.ZoneSpecificVisitorUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView zoneSpecificVisitorListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label2;
    }
}