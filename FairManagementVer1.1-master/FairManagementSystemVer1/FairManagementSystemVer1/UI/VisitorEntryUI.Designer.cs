namespace FairManagementSystemVer1
{
    partial class VisitorEntryUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.visitorNameTextBox = new System.Windows.Forms.TextBox();
            this.visitorNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveVisitorButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveVisitorButton);
            this.groupBox1.Controls.Add(this.contactNumberTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.visitorNameTextBox);
            this.groupBox1.Controls.Add(this.visitorNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor\'s Information";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(172, 96);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(251, 22);
            this.contactNumberTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact number :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(172, 53);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(251, 22);
            this.emailTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email :";
            // 
            // visitorNameTextBox
            // 
            this.visitorNameTextBox.Location = new System.Drawing.Point(172, 16);
            this.visitorNameTextBox.Name = "visitorNameTextBox";
            this.visitorNameTextBox.Size = new System.Drawing.Size(251, 22);
            this.visitorNameTextBox.TabIndex = 1;
            // 
            // visitorNameLabel
            // 
            this.visitorNameLabel.AutoSize = true;
            this.visitorNameLabel.Location = new System.Drawing.Point(31, 23);
            this.visitorNameLabel.Name = "visitorNameLabel";
            this.visitorNameLabel.Size = new System.Drawing.Size(51, 16);
            this.visitorNameLabel.TabIndex = 0;
            this.visitorNameLabel.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zone type visitor\'s want to visit";
            // 
            // saveVisitorButton
            // 
            this.saveVisitorButton.Location = new System.Drawing.Point(331, 132);
            this.saveVisitorButton.Name = "saveVisitorButton";
            this.saveVisitorButton.Size = new System.Drawing.Size(92, 23);
            this.saveVisitorButton.TabIndex = 2;
            this.saveVisitorButton.Text = "Save";
            this.saveVisitorButton.UseVisualStyleBackColor = true;
            this.saveVisitorButton.Click += new System.EventHandler(this.saveVisitorButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(468, 226);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // VisitorEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisitorEntryUI";
            this.Text = "VisitorEntryUI";
            this.Load += new System.EventHandler(this.VisitorEntryUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox visitorNameTextBox;
        private System.Windows.Forms.Label visitorNameLabel;
        private System.Windows.Forms.Button saveVisitorButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    }
}

