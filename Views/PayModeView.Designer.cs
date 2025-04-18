namespace supermarket_mvp_lt.Views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModeId = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 26);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 1;
            label1.Text = "Pay Mode";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 94);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(723, 348);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Margin = new Padding(3, 2, 3, 2);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3, 2, 3, 2);
            tabPagePayModeList.Size = new Size(715, 320);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.Gainsboro;
            BtnClose.BackgroundImage = (Image)resources.GetObject("BtnClose.BackgroundImage");
            BtnClose.BackgroundImageLayout = ImageLayout.Center;
            BtnClose.Location = new Point(486, 259);
            BtnClose.Margin = new Padding(3, 2, 3, 2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(226, 59);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Gainsboro;
            BtnDelete.BackgroundImage = (Image)resources.GetObject("BtnDelete.BackgroundImage");
            BtnDelete.BackgroundImageLayout = ImageLayout.Center;
            BtnDelete.Location = new Point(486, 194);
            BtnDelete.Margin = new Padding(3, 2, 3, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(226, 60);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.Gainsboro;
            BtnEdit.BackgroundImage = (Image)resources.GetObject("BtnEdit.BackgroundImage");
            BtnEdit.BackgroundImageLayout = ImageLayout.Center;
            BtnEdit.Location = new Point(488, 129);
            BtnEdit.Margin = new Padding(3, 2, 3, 2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(224, 64);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.Gainsboro;
            BtnNew.BackgroundImage = (Image)resources.GetObject("BtnNew.BackgroundImage");
            BtnNew.BackgroundImageLayout = ImageLayout.Center;
            BtnNew.Location = new Point(486, 68);
            BtnNew.Margin = new Padding(3, 2, 3, 2);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(224, 60);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgPayMode
            // 
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(3, 68);
            DgPayMode.Margin = new Padding(3, 2, 3, 2);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.Size = new Size(481, 250);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.BackgroundImage = (Image)resources.GetObject("BtnSearch.BackgroundImage");
            BtnSearch.BackgroundImageLayout = ImageLayout.Center;
            BtnSearch.Location = new Point(438, 35);
            BtnSearch.Margin = new Padding(3, 2, 3, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(44, 28);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(3, 43);
            TxtSearch.Margin = new Padding(3, 2, 3, 2);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(431, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 26);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            label2.Click += label2_Click;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Margin = new Padding(3, 2, 3, 2);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3, 2, 3, 2);
            tabPagePayModeDetail.Size = new Size(715, 321);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.Gainsboro;
            BtnCancel.BackgroundImage = (Image)resources.GetObject("BtnCancel.BackgroundImage");
            BtnCancel.BackgroundImageLayout = ImageLayout.Center;
            BtnCancel.Location = new Point(156, 243);
            BtnCancel.Margin = new Padding(3, 2, 3, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(109, 63);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.Gainsboro;
            BtnSave.BackgroundImage = (Image)resources.GetObject("BtnSave.BackgroundImage");
            BtnSave.BackgroundImageLayout = ImageLayout.Center;
            BtnSave.Location = new Point(21, 243);
            BtnSave.Margin = new Padding(3, 2, 3, 2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(117, 63);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(21, 146);
            TxtPayModeObservation.Margin = new Padding(3, 2, 3, 2);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(291, 94);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 121);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(21, 88);
            TxtPayModeName.Margin = new Padding(3, 2, 3, 2);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(218, 23);
            TxtPayModeName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 71);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            label4.Click += label4_Click;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(21, 38);
            TxtPayModeId.Margin = new Padding(3, 2, 3, 2);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(110, 23);
            TxtPayModeId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 20);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 89);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 442);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Label label2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
        private TextBox TxtPayModeId;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
        private PictureBox pictureBox1;
    }
}