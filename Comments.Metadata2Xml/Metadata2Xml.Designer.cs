namespace Comments.Metadata2Xml
{
    partial class Metadata2Xml
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
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._rtbMetadata = new System.Windows.Forms.RichTextBox();
            this._rtbXML = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._rtbMetadata);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._rtbXML);
            this._splitContainer.Size = new System.Drawing.Size(284, 261);
            this._splitContainer.SplitterDistance = 140;
            this._splitContainer.TabIndex = 0;
            // 
            // _rtbMetadata
            // 
            this._rtbMetadata.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbMetadata.Location = new System.Drawing.Point(0, 0);
            this._rtbMetadata.Name = "_rtbMetadata";
            this._rtbMetadata.Size = new System.Drawing.Size(140, 261);
            this._rtbMetadata.TabIndex = 0;
            this._rtbMetadata.Text = "";
            this._rtbMetadata.WordWrap = false;
            this._rtbMetadata.TextChanged += new System.EventHandler(this._rtbMetadata_TextChanged);
            // 
            // _rtbXML
            // 
            this._rtbXML.BackColor = System.Drawing.SystemColors.Window;
            this._rtbXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbXML.Location = new System.Drawing.Point(0, 0);
            this._rtbXML.Name = "_rtbXML";
            this._rtbXML.ReadOnly = true;
            this._rtbXML.Size = new System.Drawing.Size(140, 261);
            this._rtbXML.TabIndex = 0;
            this._rtbXML.Text = "";
            this._rtbXML.WordWrap = false;
            // 
            // Metadata2Xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._splitContainer);
            this.Name = "Metadata2Xml";
            this.Text = "Metadata2Xml";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.RichTextBox _rtbMetadata;
        private System.Windows.Forms.RichTextBox _rtbXML;
    }
}

