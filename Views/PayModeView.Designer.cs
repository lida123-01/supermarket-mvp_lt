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
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            tabPagePayModeDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label3 = new Label();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 34);
            label1.Name = "label1";
            label1.Size = new Size(157, 41);
            label1.TabIndex = 1;
            label1.Text = "Pay Mode";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 119);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(826, 465);
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
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(820, 385);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
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
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(818, 432);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 13);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            label2.Click += label2_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(3, 36);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(492, 27);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.BackgroundImage = (Image)resources.GetObject("BtnSearch.BackgroundImage");
            BtnSearch.BackgroundImageLayout = ImageLayout.Center;
            BtnSearch.Location = new Point(501, 31);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 37);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(3, 74);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.Size = new Size(550, 293);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.Gainsboro;
            BtnNew.BackgroundImage = (Image)resources.GetObject("BtnNew.BackgroundImage");
            BtnNew.BackgroundImageLayout = ImageLayout.Center;
            BtnNew.Location = new Point(557, 60);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(256, 76);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.Gainsboro;
            BtnEdit.BackgroundImage = (Image)resources.GetObject("BtnEdit.BackgroundImage");
            BtnEdit.BackgroundImageLayout = ImageLayout.Center;
            BtnEdit.Location = new Point(559, 142);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(256, 81);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Gainsboro;
            BtnDelete.BackgroundImage = (Image)resources.GetObject("BtnDelete.BackgroundImage");
            BtnDelete.BackgroundImageLayout = ImageLayout.Center;
            BtnDelete.Location = new Point(557, 229);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(258, 67);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.Gainsboro;
            BtnClose.BackgroundImage = (Image)resources.GetObject("BtnClose.BackgroundImage");
            BtnClose.BackgroundImageLayout = ImageLayout.Center;
            BtnClose.Location = new Point(557, 302);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(258, 75);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 27);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(24, 50);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(125, 27);
            TxtPayModeId.TabIndex = 1;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(24, 118);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(248, 27);
            TxtPayModeName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 95);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            label4.Click += label4_Click;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(24, 194);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(332, 124);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 161);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.Gainsboro;
            BtnSave.BackgroundImage = (Image)resources.GetObject("BtnSave.BackgroundImage");
            BtnSave.BackgroundImageLayout = ImageLayout.Center;
            BtnSave.Location = new Point(24, 324);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(134, 84);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.Gainsboro;
            BtnCancel.BackgroundImage = (Image)resources.GetObject("BtnCancel.BackgroundImage");
            BtnCancel.BackgroundImageLayout = ImageLayout.Center;
            BtnCancel.Location = new Point(178, 324);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(125, 84);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 590);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
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
    }
}