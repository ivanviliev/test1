namespace GraphTest
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbShowMartix = new System.Windows.Forms.Button();
            this.cmbDFS = new System.Windows.Forms.Button();
            this.cmbBFS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(878, 490);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cmbShowMartix
            // 
            this.cmbShowMartix.Location = new System.Drawing.Point(12, 86);
            this.cmbShowMartix.Name = "cmbShowMartix";
            this.cmbShowMartix.Size = new System.Drawing.Size(113, 42);
            this.cmbShowMartix.TabIndex = 1;
            this.cmbShowMartix.Text = "Show Martix";
            this.cmbShowMartix.UseVisualStyleBackColor = true;
            this.cmbShowMartix.Click += new System.EventHandler(this.cmbShowMartix_Click);
            // 
            // cmbDFS
            // 
            this.cmbDFS.Location = new System.Drawing.Point(150, 86);
            this.cmbDFS.Name = "cmbDFS";
            this.cmbDFS.Size = new System.Drawing.Size(102, 42);
            this.cmbDFS.TabIndex = 2;
            this.cmbDFS.Text = "DFS";
            this.cmbDFS.UseVisualStyleBackColor = true;
            this.cmbDFS.Click += new System.EventHandler(this.cmbDFS_Click);
            // 
            // cmbBFS
            // 
            this.cmbBFS.Location = new System.Drawing.Point(286, 86);
            this.cmbBFS.Name = "cmbBFS";
            this.cmbBFS.Size = new System.Drawing.Size(75, 42);
            this.cmbBFS.TabIndex = 3;
            this.cmbBFS.Text = "BFS";
            this.cmbBFS.UseVisualStyleBackColor = true;
            this.cmbBFS.Click += new System.EventHandler(this.cmbBFS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 624);
            this.Controls.Add(this.cmbBFS);
            this.Controls.Add(this.cmbDFS);
            this.Controls.Add(this.cmbShowMartix);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button cmbShowMartix;
        private System.Windows.Forms.Button cmbDFS;
        private System.Windows.Forms.Button cmbBFS;
    }
}

