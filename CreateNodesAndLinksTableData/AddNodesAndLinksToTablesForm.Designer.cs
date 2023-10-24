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
            this.label10.Location = new System.Drawing.Point(32, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nodes Table:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Links Table:";
            // 
            // LinksTable
            // 
            this.LinksTable.Location = new System.Drawing.Point(330, 149);
            this.LinksTable.Name = "LinksTable";
            this.LinksTable.Size = new System.Drawing.Size(235, 22);
            this.LinksTable.TabIndex = 32;
            // 
            // NodeColumnName
            // 
            this.NodeColumnName.Location = new System.Drawing.Point(330, 101);
            this.NodeColumnName.Name = "NodeColumnName";
            this.NodeColumnName.Size = new System.Drawing.Size(235, 22);
            this.NodeColumnName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 107);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Link Column Name:";
            // 
            // LinkColumnName
            // 
            this.LinkColumnName.Location = new System.Drawing.Point(330, 202);
            this.LinkColumnName.Name = "LinkColumnName";
            this.LinkColumnName.Size = new System.Drawing.Size(235, 22);
            this.LinkColumnName.TabIndex = 39;
            // 
            // AddNodesAndLinksToTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.ControlBox = false;
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
    }
}