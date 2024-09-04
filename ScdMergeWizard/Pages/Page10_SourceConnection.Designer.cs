namespace ScdMergeWizard.Pages
{
    partial class Page10_SourceConnection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtbSrcConnStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbCommandText = new System.Windows.Forms.RichTextBox();
            this.rbIsCommandText = new System.Windows.Forms.RadioButton();
            this.rbIsTableOrView = new System.Windows.Forms.RadioButton();
            this.cbxSrcTableOrViewName = new ScdMergeWizard.Components.ImageComboBox();
            this.buttonPreviewData = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.btnEditCnn = new ExoticControls.SplitButton();
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditOld = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScdMergeWizard.Properties.Resources.database_arrow_right_icon;
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Size = new System.Drawing.Size(64, 59);
            // 
            // rtbSrcConnStr
            // 
            this.rtbSrcConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSrcConnStr.Location = new System.Drawing.Point(31, 118);
            this.rtbSrcConnStr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbSrcConnStr.Multiline = true;
            this.rtbSrcConnStr.Name = "rtbSrcConnStr";
            this.rtbSrcConnStr.Size = new System.Drawing.Size(599, 64);
            this.rtbSrcConnStr.TabIndex = 9;
            this.rtbSrcConnStr.TextChanged += new System.EventHandler(this.rtbSrcConnStr_TextChanged);
            this.rtbSrcConnStr.Leave += new System.EventHandler(this.rtbSrcConnStr_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "OLE DB Connection string:";
            // 
            // rtbCommandText
            // 
            this.rtbCommandText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCommandText.Enabled = false;
            this.rtbCommandText.Location = new System.Drawing.Point(31, 281);
            this.rtbCommandText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbCommandText.Name = "rtbCommandText";
            this.rtbCommandText.Size = new System.Drawing.Size(707, 98);
            this.rtbCommandText.TabIndex = 12;
            this.rtbCommandText.Text = "";
            this.rtbCommandText.TextChanged += new System.EventHandler(this.rtbCommandText_TextChanged);
            // 
            // rbIsCommandText
            // 
            this.rbIsCommandText.AutoSize = true;
            this.rbIsCommandText.Location = new System.Drawing.Point(31, 252);
            this.rbIsCommandText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbIsCommandText.Name = "rbIsCommandText";
            this.rbIsCommandText.Size = new System.Drawing.Size(113, 20);
            this.rbIsCommandText.TabIndex = 11;
            this.rbIsCommandText.Text = "Command text:";
            this.rbIsCommandText.UseVisualStyleBackColor = true;
            this.rbIsCommandText.CheckedChanged += new System.EventHandler(this.rbCommandText_CheckedChanged);
            // 
            // rbIsTableOrView
            // 
            this.rbIsTableOrView.AutoSize = true;
            this.rbIsTableOrView.Checked = true;
            this.rbIsTableOrView.Location = new System.Drawing.Point(31, 191);
            this.rbIsTableOrView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbIsTableOrView.Name = "rbIsTableOrView";
            this.rbIsTableOrView.Size = new System.Drawing.Size(173, 20);
            this.rbIsTableOrView.TabIndex = 10;
            this.rbIsTableOrView.TabStop = true;
            this.rbIsTableOrView.Text = "Table, View or Synonym:";
            this.rbIsTableOrView.UseVisualStyleBackColor = true;
            this.rbIsTableOrView.CheckedChanged += new System.EventHandler(this.rbTableOrView_CheckedChanged);
            // 
            // cbxSrcTableOrViewName
            // 
            this.cbxSrcTableOrViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSrcTableOrViewName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxSrcTableOrViewName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSrcTableOrViewName.FormattingEnabled = true;
            this.cbxSrcTableOrViewName.Location = new System.Drawing.Point(31, 219);
            this.cbxSrcTableOrViewName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSrcTableOrViewName.Name = "cbxSrcTableOrViewName";
            this.cbxSrcTableOrViewName.Size = new System.Drawing.Size(553, 23);
            this.cbxSrcTableOrViewName.TabIndex = 13;
            this.cbxSrcTableOrViewName.DropDown += new System.EventHandler(this.cbxSrcTables_DropDown);
            this.cbxSrcTableOrViewName.SelectedIndexChanged += new System.EventHandler(this.cbxSrcTableOrViewName_SelectedIndexChanged);
            this.cbxSrcTableOrViewName.TextChanged += new System.EventHandler(this.cbxSrcTables_TextChanged);
            // 
            // buttonPreviewData
            // 
            this.buttonPreviewData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreviewData.Location = new System.Drawing.Point(639, 217);
            this.buttonPreviewData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPreviewData.Name = "buttonPreviewData";
            this.buttonPreviewData.Size = new System.Drawing.Size(100, 28);
            this.buttonPreviewData.TabIndex = 14;
            this.buttonPreviewData.Text = "Preview...";
            this.buttonPreviewData.UseVisualStyleBackColor = true;
            this.buttonPreviewData.Click += new System.EventHandler(this.buttonPreviewData_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.Image = global::ScdMergeWizard.Properties.Resources.Filter2HS;
            this.buttonFilter.Location = new System.Drawing.Point(593, 217);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(37, 28);
            this.buttonFilter.TabIndex = 16;
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(245, 193);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(340, 18);
            this.labelFilter.TabIndex = 17;
            this.labelFilter.Text = "Filter: (none)";
            this.labelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditCnn
            // 
            this.btnEditCnn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCnn.ContextMenuStrip = this.cmsEdit;
            this.btnEditCnn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCnn.ImageKey = "Normal";
            this.btnEditCnn.Location = new System.Drawing.Point(640, 118);
            this.btnEditCnn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCnn.Name = "btnEditCnn";
            this.btnEditCnn.Size = new System.Drawing.Size(99, 34);
            this.btnEditCnn.TabIndex = 18;
            this.btnEditCnn.Text = "Edit";
            this.btnEditCnn.UseVisualStyleBackColor = true;
            this.btnEditCnn.ButtonClick += new System.EventHandler(this.btnEditCnn_ButtonClick);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditNew,
            this.tsmiEditOld});
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsEdit.ShowCheckMargin = true;
            this.cmsEdit.ShowImageMargin = false;
            this.cmsEdit.Size = new System.Drawing.Size(267, 70);
            // 
            // tsmiEditNew
            // 
            this.tsmiEditNew.Checked = true;
            this.tsmiEditNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiEditNew.Name = "tsmiEditNew";
            this.tsmiEditNew.Size = new System.Drawing.Size(266, 22);
            this.tsmiEditNew.Text = "Edit (.Net Framework for SQL Server)";
            this.tsmiEditNew.Click += new System.EventHandler(this.tsmiEditNew_Click);
            // 
            // tsmiEditOld
            // 
            this.tsmiEditOld.Name = "tsmiEditOld";
            this.tsmiEditOld.Size = new System.Drawing.Size(266, 22);
            this.tsmiEditOld.Text = "Edit (OLE DB Connection)";
            this.tsmiEditOld.Visible = false;
            this.tsmiEditOld.Click += new System.EventHandler(this.tsmiEditOld_Click);
            // 
            // Page10_SourceConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditCnn);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonPreviewData);
            this.Controls.Add(this.cbxSrcTableOrViewName);
            this.Controls.Add(this.rtbSrcConnStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbCommandText);
            this.Controls.Add(this.rbIsCommandText);
            this.Controls.Add(this.rbIsTableOrView);
            this.Description = "Define the source of your data";
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Page10_SourceConnection";
            this.Size = new System.Drawing.Size(784, 417);
            this.Title = "Source Connection";
            this.Controls.SetChildIndex(this.rbIsTableOrView, 0);
            this.Controls.SetChildIndex(this.rbIsCommandText, 0);
            this.Controls.SetChildIndex(this.rtbCommandText, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.rtbSrcConnStr, 0);
            this.Controls.SetChildIndex(this.cbxSrcTableOrViewName, 0);
            this.Controls.SetChildIndex(this.buttonPreviewData, 0);
            this.Controls.SetChildIndex(this.buttonFilter, 0);
            this.Controls.SetChildIndex(this.labelFilter, 0);
            this.Controls.SetChildIndex(this.btnEditCnn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPreviewData;
        public System.Windows.Forms.TextBox rtbSrcConnStr;
        public System.Windows.Forms.RadioButton rbIsTableOrView;
        public Components.ImageComboBox cbxSrcTableOrViewName;
        public System.Windows.Forms.RichTextBox rtbCommandText;
        public System.Windows.Forms.RadioButton rbIsCommandText;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelFilter;
        private ExoticControls.SplitButton btnEditCnn;
        private System.Windows.Forms.ContextMenuStrip cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditOld;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditNew;
    }
}
