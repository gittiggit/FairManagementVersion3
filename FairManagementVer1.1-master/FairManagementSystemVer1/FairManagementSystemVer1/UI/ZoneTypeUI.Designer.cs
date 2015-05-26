namespace FairManagementSystemVer1.UI
{
    partial class ZoneTypeUI
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.allZoneListView = new System.Windows.Forms.ListView();
            this.serialColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zonetypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zoneGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.typenameLabel = new System.Windows.Forms.Label();
            this.zoneTypeTextBox = new System.Windows.Forms.TextBox();
            this.zoneGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // allZoneListView
            // 
            this.allZoneListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialColumnHeader,
            this.zonetypeColumnHeader});
            this.allZoneListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allZoneListView.FullRowSelect = true;
            this.allZoneListView.GridLines = true;
            listViewItem1.IndentCount = 1;
            this.allZoneListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.allZoneListView.Location = new System.Drawing.Point(14, 155);
            this.allZoneListView.Name = "allZoneListView";
            this.allZoneListView.Size = new System.Drawing.Size(419, 197);
            this.allZoneListView.TabIndex = 3;
            this.allZoneListView.UseCompatibleStateImageBehavior = false;
            this.allZoneListView.View = System.Windows.Forms.View.Details;
//            this.allZoneListView.MouseHover += new System.EventHandler(this.allZoneListView_MouseHover);
            // 
            // serialColumnHeader
            // 
            this.serialColumnHeader.Text = "Serial No";
            this.serialColumnHeader.Width = 75;
            // 
            // zonetypeColumnHeader
            // 
            this.zonetypeColumnHeader.Text = "Zone Type";
            this.zonetypeColumnHeader.Width = 321;
            // 
            // zoneGroupBox
            // 
            this.zoneGroupBox.Controls.Add(this.saveButton);
            this.zoneGroupBox.Controls.Add(this.typenameLabel);
            this.zoneGroupBox.Controls.Add(this.zoneTypeTextBox);
            this.zoneGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneGroupBox.Location = new System.Drawing.Point(12, 12);
            this.zoneGroupBox.Name = "zoneGroupBox";
            this.zoneGroupBox.Size = new System.Drawing.Size(421, 137);
            this.zoneGroupBox.TabIndex = 2;
            this.zoneGroupBox.TabStop = false;
            this.zoneGroupBox.Text = "Zone Type";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(282, 66);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveZoneButton_Click);
            // 
            // typenameLabel
            // 
            this.typenameLabel.AutoSize = true;
            this.typenameLabel.Location = new System.Drawing.Point(53, 32);
            this.typenameLabel.Name = "typenameLabel";
            this.typenameLabel.Size = new System.Drawing.Size(80, 16);
            this.typenameLabel.TabIndex = 1;
            this.typenameLabel.Text = "Type Name";
            // 
            // zoneTypeTextBox
            // 
            this.zoneTypeTextBox.Location = new System.Drawing.Point(153, 29);
            this.zoneTypeTextBox.Name = "zoneTypeTextBox";
            this.zoneTypeTextBox.Size = new System.Drawing.Size(204, 22);
            this.zoneTypeTextBox.TabIndex = 0;
            // 
            // ZoneTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 374);
            this.Controls.Add(this.allZoneListView);
            this.Controls.Add(this.zoneGroupBox);
            this.Name = "ZoneTypeUI";
            this.Text = "ZoneTypeUI";
            this.Load += new System.EventHandler(this.ZoneTypeUI_Load);
            this.zoneGroupBox.ResumeLayout(false);
            this.zoneGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView allZoneListView;
        private System.Windows.Forms.ColumnHeader serialColumnHeader;
        private System.Windows.Forms.ColumnHeader zonetypeColumnHeader;
        private System.Windows.Forms.GroupBox zoneGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label typenameLabel;
        private System.Windows.Forms.TextBox zoneTypeTextBox;
    }
}