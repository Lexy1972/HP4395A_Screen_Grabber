
namespace HP4395A_Screen_Grabber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.cbAutoCopy = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.grpCapture = new System.Windows.Forms.GroupBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.grpGPIB = new System.Windows.Forms.GroupBox();
            this.secondaryAddressComboBox = new System.Windows.Forms.ComboBox();
            this.secondaryAddressLabel = new System.Windows.Forms.Label();
            this.primaryAddressLabel = new System.Windows.Forms.Label();
            this.boardIdLabel = new System.Windows.Forms.Label();
            this.primaryAddressNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.boardIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.closeButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFit = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnPaste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCapture.SuspendLayout();
            this.grpGPIB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primaryAddressNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtLog);
            this.splitContainer1.Size = new System.Drawing.Size(1147, 742);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.grpCapture);
            this.splitContainer2.Panel1.Controls.Add(this.grpGPIB);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1147, 528);
            this.splitContainer2.SplitterDistance = 207;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPaste);
            this.groupBox4.Controls.Add(this.btnCopyToClipboard);
            this.groupBox4.Controls.Add(this.cbAutoCopy);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 76);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ClipBoard";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(101, 15);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(75, 23);
            this.btnCopyToClipboard.TabIndex = 1;
            this.btnCopyToClipboard.Text = "Copy";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // cbAutoCopy
            // 
            this.cbAutoCopy.AutoSize = true;
            this.cbAutoCopy.Checked = true;
            this.cbAutoCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoCopy.Location = new System.Drawing.Point(6, 19);
            this.cbAutoCopy.Name = "cbAutoCopy";
            this.cbAutoCopy.Size = new System.Drawing.Size(74, 17);
            this.cbAutoCopy.TabIndex = 0;
            this.cbAutoCopy.Text = "Auto copy";
            this.cbAutoCopy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnFileOpen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(207, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(101, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(20, 26);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(75, 23);
            this.btnFileOpen.TabIndex = 0;
            this.btnFileOpen.Text = "Open";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // grpCapture
            // 
            this.grpCapture.Controls.Add(this.cbColor);
            this.grpCapture.Controls.Add(this.btnCapture);
            this.grpCapture.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCapture.Location = new System.Drawing.Point(0, 143);
            this.grpCapture.Name = "grpCapture";
            this.grpCapture.Size = new System.Drawing.Size(207, 79);
            this.grpCapture.TabIndex = 1;
            this.grpCapture.TabStop = false;
            this.grpCapture.Text = "Capture";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Color on White background",
            "Color on Black background",
            "Black and White"});
            this.cbColor.Location = new System.Drawing.Point(4, 17);
            this.cbColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(192, 21);
            this.cbColor.TabIndex = 1;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(3, 43);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(193, 26);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // grpGPIB
            // 
            this.grpGPIB.Controls.Add(this.secondaryAddressComboBox);
            this.grpGPIB.Controls.Add(this.secondaryAddressLabel);
            this.grpGPIB.Controls.Add(this.primaryAddressLabel);
            this.grpGPIB.Controls.Add(this.boardIdLabel);
            this.grpGPIB.Controls.Add(this.primaryAddressNumericUpDown);
            this.grpGPIB.Controls.Add(this.boardIdNumericUpDown);
            this.grpGPIB.Controls.Add(this.closeButton);
            this.grpGPIB.Controls.Add(this.openButton);
            this.grpGPIB.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGPIB.Location = new System.Drawing.Point(0, 0);
            this.grpGPIB.Name = "grpGPIB";
            this.grpGPIB.Size = new System.Drawing.Size(207, 143);
            this.grpGPIB.TabIndex = 0;
            this.grpGPIB.TabStop = false;
            this.grpGPIB.Text = "GPIB";
            // 
            // secondaryAddressComboBox
            // 
            this.secondaryAddressComboBox.Location = new System.Drawing.Point(132, 64);
            this.secondaryAddressComboBox.Name = "secondaryAddressComboBox";
            this.secondaryAddressComboBox.Size = new System.Drawing.Size(56, 21);
            this.secondaryAddressComboBox.TabIndex = 25;
            this.secondaryAddressComboBox.Text = "secondaryAddressComboBox";
            // 
            // secondaryAddressLabel
            // 
            this.secondaryAddressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.secondaryAddressLabel.Location = new System.Drawing.Point(12, 64);
            this.secondaryAddressLabel.Name = "secondaryAddressLabel";
            this.secondaryAddressLabel.Size = new System.Drawing.Size(112, 16);
            this.secondaryAddressLabel.TabIndex = 24;
            this.secondaryAddressLabel.Text = "Secondary Address:";
            // 
            // primaryAddressLabel
            // 
            this.primaryAddressLabel.Location = new System.Drawing.Point(12, 40);
            this.primaryAddressLabel.Name = "primaryAddressLabel";
            this.primaryAddressLabel.Size = new System.Drawing.Size(100, 16);
            this.primaryAddressLabel.TabIndex = 23;
            this.primaryAddressLabel.Text = "Primary Address:";
            // 
            // boardIdLabel
            // 
            this.boardIdLabel.Location = new System.Drawing.Point(12, 16);
            this.boardIdLabel.Name = "boardIdLabel";
            this.boardIdLabel.Size = new System.Drawing.Size(72, 16);
            this.boardIdLabel.TabIndex = 22;
            this.boardIdLabel.Text = "Board ID:";
            // 
            // primaryAddressNumericUpDown
            // 
            this.primaryAddressNumericUpDown.Location = new System.Drawing.Point(132, 40);
            this.primaryAddressNumericUpDown.Name = "primaryAddressNumericUpDown";
            this.primaryAddressNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.primaryAddressNumericUpDown.TabIndex = 21;
            this.primaryAddressNumericUpDown.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // boardIdNumericUpDown
            // 
            this.boardIdNumericUpDown.Location = new System.Drawing.Point(132, 16);
            this.boardIdNumericUpDown.Name = "boardIdNumericUpDown";
            this.boardIdNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.boardIdNumericUpDown.TabIndex = 20;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(92, 96);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "&Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 96);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 18;
            this.openButton.Text = "&Open";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer3.Size = new System.Drawing.Size(936, 528);
            this.splitContainer3.SplitterDistance = 258;
            this.splitContainer3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbFit);
            this.groupBox3.Controls.Add(this.rbNormal);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // rbFit
            // 
            this.rbFit.AutoSize = true;
            this.rbFit.Location = new System.Drawing.Point(6, 42);
            this.rbFit.Name = "rbFit";
            this.rbFit.Size = new System.Drawing.Size(36, 17);
            this.rbFit.TabIndex = 1;
            this.rbFit.Text = "Fit";
            this.rbFit.UseVisualStyleBackColor = true;
            this.rbFit.CheckedChanged += new System.EventHandler(this.rbView_CheckChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(6, 19);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(79, 17);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal size";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbView_CheckChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvColors);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 419);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // dgvColors
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvColors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColors.Location = new System.Drawing.Point(3, 16);
            this.dgvColors.Margin = new System.Windows.Forms.Padding(2);
            this.dgvColors.Name = "dgvColors";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColors.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColors.RowHeadersWidth = 82;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvColors.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColors.RowTemplate.Height = 20;
            this.dgvColors.Size = new System.Drawing.Size(252, 400);
            this.dgvColors.TabIndex = 3;
            this.dgvColors.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColors_CellValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1147, 210);
            this.txtLog.TabIndex = 0;
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(101, 44);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 748);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "HP4395A Screen Grabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpCapture.ResumeLayout(false);
            this.grpGPIB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.primaryAddressNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardIdNumericUpDown)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grpGPIB;
        private System.Windows.Forms.ComboBox secondaryAddressComboBox;
        private System.Windows.Forms.Label secondaryAddressLabel;
        private System.Windows.Forms.Label primaryAddressLabel;
        private System.Windows.Forms.Label boardIdLabel;
        private System.Windows.Forms.NumericUpDown primaryAddressNumericUpDown;
        private System.Windows.Forms.NumericUpDown boardIdNumericUpDown;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox grpCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.RadioButton rbFit;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.CheckBox cbAutoCopy;
        private System.Windows.Forms.Button btnPaste;
    }
}

