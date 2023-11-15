namespace CreateNodesAndLinksTableData
{
    partial class CreateNodesAndLinksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNodesAndLinksForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.Direction = new System.Windows.Forms.ComboBox();
            this.NodeOffset = new System.Windows.Forms.TextBox();
            this.UseExistingNodeOffset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ObjectPropertyName = new System.Windows.Forms.TextBox();
            this.ObjectPropertyValue = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ObjectType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkType = new System.Windows.Forms.TextBox();
            this.NodeType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NodeLocations = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(851, 100);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(232, 63);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(851, 24);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(232, 64);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Direction
            // 
            this.Direction.FormattingEnabled = true;
            this.Direction.Items.AddRange(new object[] {
            "LeftToRight",
            "TopToBottom"});
            this.Direction.Location = new System.Drawing.Point(326, 393);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(235, 24);
            this.Direction.TabIndex = 9;
            // 
            // NodeOffset
            // 
            this.NodeOffset.Location = new System.Drawing.Point(326, 250);
            this.NodeOffset.Name = "NodeOffset";
            this.NodeOffset.Size = new System.Drawing.Size(235, 22);
            this.NodeOffset.TabIndex = 5;
            this.NodeOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NodeOffset_KeyPress);
            // 
            // UseExistingNodeOffset
            // 
            this.UseExistingNodeOffset.Location = new System.Drawing.Point(326, 297);
            this.UseExistingNodeOffset.Name = "UseExistingNodeOffset";
            this.UseExistingNodeOffset.Size = new System.Drawing.Size(235, 22);
            this.UseExistingNodeOffset.TabIndex = 6;
            this.UseExistingNodeOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UseExistingNodeOffset_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Node Offset:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Use Existing Node Offset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Object Property Name:";
            // 
            // ObjectPropertyName
            // 
            this.ObjectPropertyName.Location = new System.Drawing.Point(326, 62);
            this.ObjectPropertyName.Name = "ObjectPropertyName";
            this.ObjectPropertyName.Size = new System.Drawing.Size(235, 22);
            this.ObjectPropertyName.TabIndex = 1;
            // 
            // ObjectPropertyValue
            // 
            this.ObjectPropertyValue.Location = new System.Drawing.Point(326, 109);
            this.ObjectPropertyValue.Name = "ObjectPropertyValue";
            this.ObjectPropertyValue.Size = new System.Drawing.Size(235, 22);
            this.ObjectPropertyValue.TabIndex = 2;
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Notes.Location = new System.Drawing.Point(581, 24);
            this.Notes.Margin = new System.Windows.Forms.Padding(4);
            this.Notes.Multiline = true;
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(232, 139);
            this.Notes.TabIndex = 25;
            this.Notes.TabStop = false;
            this.Notes.Text = resources.GetString("Notes.Text");
            this.Notes.TextChanged += new System.EventHandler(this.Notes_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Object Property Value:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Direction:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Object Type:";
            // 
            // ObjectType
            // 
            this.ObjectType.Location = new System.Drawing.Point(326, 15);
            this.ObjectType.Name = "ObjectType";
            this.ObjectType.Size = new System.Drawing.Size(235, 22);
            this.ObjectType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Link Type:";
            // 
            // LinkType
            // 
            this.LinkType.Location = new System.Drawing.Point(326, 203);
            this.LinkType.Name = "LinkType";
            this.LinkType.Size = new System.Drawing.Size(235, 22);
            this.LinkType.TabIndex = 4;
            // 
            // NodeType
            // 
            this.NodeType.Location = new System.Drawing.Point(326, 156);
            this.NodeType.Name = "NodeType";
            this.NodeType.Size = new System.Drawing.Size(235, 22);
            this.NodeType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Node Type:";
            // 
            // NodeLocations
            // 
            this.NodeLocations.AutoCompleteCustomSource.AddRange(new string[] {
            "BothBelowObject",
            "InputLeftOutputRight"});
            this.NodeLocations.FormattingEnabled = true;
            this.NodeLocations.Items.AddRange(new object[] {
            "BothBelowObject",
            "InputLeftOutputRight"});
            this.NodeLocations.Location = new System.Drawing.Point(326, 344);
            this.NodeLocations.Name = "NodeLocations";
            this.NodeLocations.Size = new System.Drawing.Size(235, 24);
            this.NodeLocations.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Node Locations:";
            // 
            // CreateNodesAndLinksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 483);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NodeLocations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinkType);
            this.Controls.Add(this.NodeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ObjectType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.ObjectPropertyValue);
            this.Controls.Add(this.ObjectPropertyName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UseExistingNodeOffset);
            this.Controls.Add(this.NodeOffset);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "CreateNodesAndLinksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Nodes and Links";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox Direction;
        internal System.Windows.Forms.TextBox NodeOffset;
        internal System.Windows.Forms.TextBox UseExistingNodeOffset;
        internal System.Windows.Forms.TextBox ObjectPropertyName;
        internal System.Windows.Forms.TextBox ObjectPropertyValue;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox ObjectType;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox LinkType;
        internal System.Windows.Forms.TextBox NodeType;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox NodeLocations;
        private System.Windows.Forms.Label label3;
    }
}