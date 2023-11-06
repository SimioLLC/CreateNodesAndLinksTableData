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
            this.NodeXColumnName = new System.Windows.Forms.TextBox();
            this.NodeYColumnName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NodeZColumnName = new System.Windows.Forms.TextBox();
            this.StartingNodeColumnName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndingNodeColumnName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LinkPropertyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LinkPropertyValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LinkTypeColumnName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TablesUseAutoCreate = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.VertexZColumnName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.VertexXColumnName = new System.Windows.Forms.TextBox();
            this.VertexYColumnName = new System.Windows.Forms.TextBox();
            this.VerticesTable = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.VertexLinkColumnName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.LinkType = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NodesTable
            // 
            this.NodesTable.Location = new System.Drawing.Point(228, 262);
            this.NodesTable.Name = "NodesTable";
            this.NodesTable.Size = new System.Drawing.Size(235, 22);
            this.NodesTable.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nodes Table:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Links Table:";
            // 
            // LinksTable
            // 
            this.LinksTable.Location = new System.Drawing.Point(715, 262);
            this.LinksTable.Name = "LinksTable";
            this.LinksTable.Size = new System.Drawing.Size(235, 22);
            this.LinksTable.TabIndex = 10;
            // 
            // NodeColumnName
            // 
            this.NodeColumnName.Location = new System.Drawing.Point(228, 309);
            this.NodeColumnName.Name = "NodeColumnName";
            this.NodeColumnName.Size = new System.Drawing.Size(235, 22);
            this.NodeColumnName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Node Column Name:";
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Notes.Location = new System.Drawing.Point(513, 7);
            this.Notes.Margin = new System.Windows.Forms.Padding(4);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(690, 139);
            this.Notes.TabIndex = 38;
            this.Notes.TabStop = false;
            this.Notes.Text = resources.GetString("Notes.Text");
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1211, 86);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(235, 63);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(1211, 13);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(235, 64);
            this.okButton.TabIndex = 30;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Link Column Name:";
            // 
            // LinkColumnName
            // 
            this.LinkColumnName.Location = new System.Drawing.Point(715, 309);
            this.LinkColumnName.Name = "LinkColumnName";
            this.LinkColumnName.Size = new System.Drawing.Size(235, 22);
            this.LinkColumnName.TabIndex = 11;
            // 
            // NodeTypeColumnName
            // 
            this.NodeTypeColumnName.Location = new System.Drawing.Point(228, 356);
            this.NodeTypeColumnName.Name = "NodeTypeColumnName";
            this.NodeTypeColumnName.Size = new System.Drawing.Size(235, 22);
            this.NodeTypeColumnName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Node Type Column Name:";
            // 
            // NodeXColumnName
            // 
            this.NodeXColumnName.Location = new System.Drawing.Point(228, 403);
            this.NodeXColumnName.Name = "NodeXColumnName";
            this.NodeXColumnName.Size = new System.Drawing.Size(235, 22);
            this.NodeXColumnName.TabIndex = 7;
            this.NodeXColumnName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XLocationColumnName_KeyPress);
            // 
            // NodeYColumnName
            // 
            this.NodeYColumnName.Location = new System.Drawing.Point(228, 450);
            this.NodeYColumnName.Name = "NodeYColumnName";
            this.NodeYColumnName.Size = new System.Drawing.Size(235, 22);
            this.NodeYColumnName.TabIndex = 8;
            this.NodeYColumnName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YLocationColumnName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Node X Column Name:";
            // 
            // NodeZColumnName
            // 
            this.NodeZColumnName.Location = new System.Drawing.Point(228, 497);
            this.NodeZColumnName.Name = "NodeZColumnName";
            this.NodeZColumnName.Size = new System.Drawing.Size(235, 22);
            this.NodeZColumnName.TabIndex = 9;
            this.NodeZColumnName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZLocationColumnName_KeyPress);
            // 
            // StartingNodeColumnName
            // 
            this.StartingNodeColumnName.Location = new System.Drawing.Point(715, 403);
            this.StartingNodeColumnName.Name = "StartingNodeColumnName";
            this.StartingNodeColumnName.Size = new System.Drawing.Size(235, 22);
            this.StartingNodeColumnName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Starting Node Column Name:";
            // 
            // EndingNodeColumnName
            // 
            this.EndingNodeColumnName.Location = new System.Drawing.Point(715, 450);
            this.EndingNodeColumnName.Name = "EndingNodeColumnName";
            this.EndingNodeColumnName.Size = new System.Drawing.Size(235, 22);
            this.EndingNodeColumnName.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Ending Node Column Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Node Y Column Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 497);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Node Z Column Name:";
            // 
            // LinkPropertyName
            // 
            this.LinkPropertyName.Location = new System.Drawing.Point(228, 93);
            this.LinkPropertyName.Name = "LinkPropertyName";
            this.LinkPropertyName.Size = new System.Drawing.Size(235, 22);
            this.LinkPropertyName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Link Property Name:";
            // 
            // LinkPropertyValue
            // 
            this.LinkPropertyValue.Location = new System.Drawing.Point(228, 140);
            this.LinkPropertyValue.Name = "LinkPropertyValue";
            this.LinkPropertyValue.Size = new System.Drawing.Size(235, 22);
            this.LinkPropertyValue.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Link Property Value:";
            // 
            // LinkTypeColumnName
            // 
            this.LinkTypeColumnName.Location = new System.Drawing.Point(715, 356);
            this.LinkTypeColumnName.Name = "LinkTypeColumnName";
            this.LinkTypeColumnName.Size = new System.Drawing.Size(235, 22);
            this.LinkTypeColumnName.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(510, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 16);
            this.label14.TabIndex = 57;
            this.label14.Text = "Link Type Column Name:";
            // 
            // TablesUseAutoCreate
            // 
            this.TablesUseAutoCreate.AutoSize = true;
            this.TablesUseAutoCreate.Location = new System.Drawing.Point(228, 180);
            this.TablesUseAutoCreate.Name = "TablesUseAutoCreate";
            this.TablesUseAutoCreate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TablesUseAutoCreate.Size = new System.Drawing.Size(176, 20);
            this.TablesUseAutoCreate.TabIndex = 3;
            this.TablesUseAutoCreate.Text = "Tables Use Auto Create:";
            this.TablesUseAutoCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TablesUseAutoCreate.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1007, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 16);
            this.label11.TabIndex = 75;
            this.label11.Text = "Vertex Z Column Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1007, 416);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 16);
            this.label15.TabIndex = 74;
            this.label15.Text = "Vertex Y Column Name:";
            // 
            // VertexZColumnName
            // 
            this.VertexZColumnName.Location = new System.Drawing.Point(1211, 459);
            this.VertexZColumnName.Name = "VertexZColumnName";
            this.VertexZColumnName.Size = new System.Drawing.Size(235, 22);
            this.VertexZColumnName.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1007, 367);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 16);
            this.label16.TabIndex = 72;
            this.label16.Text = "Vertex X Column Name:";
            // 
            // VertexXColumnName
            // 
            this.VertexXColumnName.Location = new System.Drawing.Point(1211, 361);
            this.VertexXColumnName.Name = "VertexXColumnName";
            this.VertexXColumnName.Size = new System.Drawing.Size(235, 22);
            this.VertexXColumnName.TabIndex = 17;
            // 
            // VertexYColumnName
            // 
            this.VertexYColumnName.Location = new System.Drawing.Point(1211, 410);
            this.VertexYColumnName.Name = "VertexYColumnName";
            this.VertexYColumnName.Size = new System.Drawing.Size(235, 22);
            this.VertexYColumnName.TabIndex = 18;
            // 
            // VerticesTable
            // 
            this.VerticesTable.Location = new System.Drawing.Point(1211, 263);
            this.VerticesTable.Name = "VerticesTable";
            this.VerticesTable.Size = new System.Drawing.Size(235, 22);
            this.VerticesTable.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1007, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 16);
            this.label18.TabIndex = 66;
            this.label18.Text = "Vertices Table:";
            // 
            // VertexLinkColumnName
            // 
            this.VertexLinkColumnName.Location = new System.Drawing.Point(1211, 312);
            this.VertexLinkColumnName.Name = "VertexLinkColumnName";
            this.VertexLinkColumnName.Size = new System.Drawing.Size(235, 22);
            this.VertexLinkColumnName.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1007, 318);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 16);
            this.label19.TabIndex = 64;
            this.label19.Text = "Vertex Link Column Name:";
            // 
            // LinkType
            // 
            this.LinkType.Location = new System.Drawing.Point(228, 46);
            this.LinkType.Name = "LinkType";
            this.LinkType.Size = new System.Drawing.Size(235, 22);
            this.LinkType.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 16);
            this.label17.TabIndex = 76;
            this.label17.Text = "Link Type:";
            // 
            // AddNodesAndLinksToTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 548);
            this.ControlBox = false;
            this.Controls.Add(this.LinkType);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.VertexZColumnName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.VertexXColumnName);
            this.Controls.Add(this.VertexYColumnName);
            this.Controls.Add(this.VerticesTable);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.VertexLinkColumnName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TablesUseAutoCreate);
            this.Controls.Add(this.LinkPropertyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LinkPropertyValue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LinkTypeColumnName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartingNodeColumnName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EndingNodeColumnName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NodeYColumnName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NodeZColumnName);
            this.Controls.Add(this.NodeTypeColumnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NodeXColumnName);
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
        internal System.Windows.Forms.TextBox NodeXColumnName;
        internal System.Windows.Forms.TextBox NodeYColumnName;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox NodeZColumnName;
        internal System.Windows.Forms.TextBox StartingNodeColumnName;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox EndingNodeColumnName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox LinkPropertyName;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox LinkPropertyValue;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox LinkTypeColumnName;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.CheckBox TablesUseAutoCreate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox VertexZColumnName;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox VertexXColumnName;
        internal System.Windows.Forms.TextBox VertexYColumnName;
        internal System.Windows.Forms.TextBox VerticesTable;
        private System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox VertexLinkColumnName;
        private System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox LinkType;
        private System.Windows.Forms.Label label17;
    }
}