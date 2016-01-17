namespace OpenXML
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
            this.rdURL = new System.Windows.Forms.RadioButton();
            this.rdStream = new System.Windows.Forms.RadioButton();
            this.rdMemory = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenDocument = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // rdURL
            // 
            this.rdURL.AutoSize = true;
            this.rdURL.Location = new System.Drawing.Point(12, 48);
            this.rdURL.Name = "rdURL";
            this.rdURL.Size = new System.Drawing.Size(47, 17);
            this.rdURL.TabIndex = 0;
            this.rdURL.TabStop = true;
            this.rdURL.Text = "URL";
            this.rdURL.UseVisualStyleBackColor = true;
            // 
            // rdStream
            // 
            this.rdStream.AutoSize = true;
            this.rdStream.Location = new System.Drawing.Point(12, 71);
            this.rdStream.Name = "rdStream";
            this.rdStream.Size = new System.Drawing.Size(58, 17);
            this.rdStream.TabIndex = 0;
            this.rdStream.TabStop = true;
            this.rdStream.Text = "Stream";
            this.rdStream.UseVisualStyleBackColor = true;
            // 
            // rdMemory
            // 
            this.rdMemory.AutoSize = true;
            this.rdMemory.Location = new System.Drawing.Point(12, 94);
            this.rdMemory.Name = "rdMemory";
            this.rdMemory.Size = new System.Drawing.Size(62, 17);
            this.rdMemory.TabIndex = 0;
            this.rdMemory.TabStop = true;
            this.rdMemory.Text = "Memory";
            this.rdMemory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open Document";
            // 
            // btnOpenDocument
            // 
            this.btnOpenDocument.Location = new System.Drawing.Point(12, 156);
            this.btnOpenDocument.Name = "btnOpenDocument";
            this.btnOpenDocument.Size = new System.Drawing.Size(270, 23);
            this.btnOpenDocument.TabIndex = 2;
            this.btnOpenDocument.Text = "Open Document";
            this.btnOpenDocument.UseVisualStyleBackColor = true;
            this.btnOpenDocument.Click += new System.EventHandler(this.btnOpenDocument_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 130);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(270, 20);
            this.txtPath.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 194);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(270, 331);
            this.treeView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 537);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpenDocument);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdMemory);
            this.Controls.Add(this.rdStream);
            this.Controls.Add(this.rdURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdURL;
        private System.Windows.Forms.RadioButton rdStream;
        private System.Windows.Forms.RadioButton rdMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDocument;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TreeView treeView1;
    }
}

