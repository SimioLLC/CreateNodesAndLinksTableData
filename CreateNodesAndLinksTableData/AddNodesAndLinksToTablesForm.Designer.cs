namespace CreateNodesAndLinksTableData
{
    partial class AddNodesAndLinksToTablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNodesAndLinksToTablesForm));
            this.NodesTable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LinksTable = new System.Windows.Forms.TextBox();
            this.NodeColumnName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkColumnName = new System.Windows.Forms.TextBox();
            this.NodeTypeColumnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XLocationColumnName = new System.Windows.Forms.TextBox();
            this.YLocationColumnName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ZLocationColumnName = new System.Windows.Forms.TextBox();
            this.StartingNodeColumnName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndingNodeColumnName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LinkTypeColumnName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LinkPropertyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LinkPropertyValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LinkType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NodesTable
            // 
            this.NodesTable.Location = new System.Drawing.Point(330, 53);
            this.NodesTable.Name = "NodesTable";
            this.NodesTable.Size = new System.Drawing.Size(235, 22);
            this.NodesTable.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nodes Table:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Links Table:";
            // 
            // LinksTable
            // 
            this.LinksTable.Location = new System.Drawing.Point(330, 347);
            this.LinksTable.Name = "LinksTable";
            this.LinksTable.Size = new System.Drawing.Size(235, 22);
            this.LinksTable.TabIndex = 32;
            // 
            // NodeColumnName
            // 
            this.NodeColumnName.Location = new System.Drawing.Point(330, 102);
            this.NodeColumnName.Name = "NodeColumnName";
            this.NodeColumnName.Size = new System.Drawing.Size(235, 22);
            this.NodeColumnName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Node Column Name:";
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Notes.Location = new System.Drawing.Point(729, 189);
            this.Notes.Margin = new System.Windows.Forms.Padding(4);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(232, 127);
            this.Notes.TabIndex = 38;
            this.Notes.Text = resources.GetString("Notes.Text");
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(729, 108);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(232, 63);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(729, 32);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(232, 64);
            this.okButton.TabIndex = 36;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Link Column Name:";
            // 
            // LinkColumnName
            // 
            this.LinkColumnName.Location = new System.Drawing.Point(330, 396);
            this.LinkColumnName.Name = "LinkColumnName";
            this.LinkColumnName.Size = new System.Drawing.Size(235, 22);
            this.LinkColumnName.TabIndex = 39;
            // 
            // NodeTypeColumnName
            // 
            this.NodeTypeColumnName.Location = new System.Drawing.Point(330, 151);
            this.NodeTypeColumnName.Name = "NodeTypeColumnName";
            this.NodeTypeColumnName.Size = new System.Drawing.Size(235, 22);
            this.NodeTypeColumnName.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Node Type Column Name:";
            // 
            // XLocationColumnName
            // 
            this.XLocationColumnName.Location = new System.Drawing.Point(330, 200);
            this.XLocationColumnName.Name = "XLocationColumnName";
            this.XLocationColumnName.Size = new System.Drawing.Size(235, 22);
            this.XLocationColumnName.TabIndex = 42;
            this.XLocationColumnName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XLocationColumnName_KeyPress);
            // 
            // YLocationColumnName
            // 
            this.YLocationColumnName.Location = new System.Drawing.Point(330, 249);
            this.YLocationColumnName.Name = "YLocationColumnName";
            this.YLocationColumnName.Size = new System.Drawing.Size(235, 22);
            this.YLocationColumnName.TabIndex = 48;
            this.YLocationColumnName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YLocationColumnName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "X Location Column Name:";
            // 
            // ZLocationColumnName
            // 
            this.ZLocationColumnName.Location = new System.Drawing.Point(330, 298);
            this.ZLocationColumnName.Name = "ZLocationColumnName";
            this.ZLocationColumnName.Size = new System.Drawing.Size(235, 22);
            this.ZLocationColumnName.TabIndex = 46;
            this.ZLocationColumnName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZLocationColumnName_KeyPress);
            // 
            // StartingNodeColumnName
            // 
            this.StartingNodeColumnName.Location = new System.Drawing.Point(330, 494);
            this.StartingNodeColumnName.Name = "StartingNodeColumnName";
            this.StartingNodeColumnName.Size = new System.Drawing.Size(235, 22);
            this.StartingNodeColumnName.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Starting Node Column Name:";
            // 
            // EndingNodeColumnName
            // 
            this.EndingNodeColumnName.Location = new System.Drawing.Point(330, 543);
            this.EndingNodeColumnName.Name = "EndingNodeColumnName";
            this.EndingNodeColumnName.Size = new System.Drawing.Size(235, 22);
            this.EndingNodeColumnName.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Ending Node Column Name:";
            // 
            // LinkTypeColumnName
            // 
            this.LinkTypeColumnName.Location = new System.Drawing.Point(330, 445);
            this.LinkTypeColumnName.Name = "LinkTypeColumnName";
            this.LinkTypeColumnName.Size = new System.Drawing.Size(235, 22);
            this.LinkTypeColumnName.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Link Type Column Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Y Location Column Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Z Location Column Name:";
            // 
            // LinkPropertyName
            // 
            this.LinkPropertyName.Location = new System.Drawing.Point(330, 644);
            this.LinkPropertyName.Name = "LinkPropertyName";
            this.LinkPropertyName.Size = new System.Drawing.Size(235, 22);
            this.LinkPropertyName.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 644);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Link Property Name:";
            // 
            // LinkPropertyValue
            // 
            this.LinkPropertyValue.Location = new System.Drawing.Point(330, 693);
            this.LinkPropertyValue.Name = "LinkPropertyValue";
            this.LinkPropertyValue.Size = new System.Drawing.Size(235, 22);
            this.LinkPropertyValue.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 693);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Link Property Value:";
            // 
            // LinkType
            // 
            this.LinkType.Location = new System.Drawing.Point(330, 595);
            this.LinkType.Name = "LinkType";
            this.LinkType.Size = new System.Drawing.Size(235, 22);
            this.LinkType.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 595);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 57;
            this.label14.Text = "Link Type:";
            // 
            // AddNodesAndLinksToTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 772);
            this.ControlBox = false;
            this.Controls.Add(this.LinkPropertyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LinkPropertyValue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LinkType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartingNodeColumnName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EndingNodeColumnName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LinkTypeColumnName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.YLocationColumnName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZLocationColumnName);
            this.Controls.Add(this.NodeTypeColumnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XLocationColumnName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinkColumnName);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.NodesTable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LinksTable);
            this.Controls.Add(this.NodeColumnName);
            this.Controls.Add(this.label7);
            this.Name = "AddNodesAndLinksToTablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNodesAndLinksToTablesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox NodesTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox LinksTable;
        internal System.Windows.Forms.TextBox NodeColumnName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox LinkColumnName;
        internal System.Windows.Forms.TextBox NodeTypeColumnName;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox XLocationColumnName;
        internal System.Windows.Forms.TextBox YLocationColumnName;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox ZLocationColumnName;
        internal System.Windows.Forms.TextBox StartingNodeColumnName;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox EndingNodeColumnName;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox LinkTypeColumnName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox LinkPropertyName;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox LinkPropertyValue;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox LinkType;
        private System.Windows.Forms.Label label14;
    }
}