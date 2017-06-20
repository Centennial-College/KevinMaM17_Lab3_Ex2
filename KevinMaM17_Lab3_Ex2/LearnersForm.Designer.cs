namespace KevinMaM17_Lab3_Ex2
{
    partial class LearnersForm
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
            this.components = new System.ComponentModel.Container();
            this.learnerIDLbl = new System.Windows.Forms.Label();
            this.learnerNameLbl = new System.Windows.Forms.Label();
            this.enrolledProgramLbl = new System.Windows.Forms.Label();
            this.favSubjLbl = new System.Windows.Forms.Label();
            this.numLanguagesLbl = new System.Windows.Forms.Label();
            this.strongestSkillLbl = new System.Windows.Forms.Label();
            this.favSubTb = new System.Windows.Forms.TextBox();
            this.learnerIDTb = new System.Windows.Forms.TextBox();
            this.learnerNameTb = new System.Windows.Forms.TextBox();
            this.enrolledProgramTb = new System.Windows.Forms.TextBox();
            this.numLangTb = new System.Windows.Forms.TextBox();
            this.strongSkillTb = new System.Windows.Forms.TextBox();
            this.learnerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.browseAllBtn = new System.Windows.Forms.Button();
            this.searchGrouupBox = new System.Windows.Forms.GroupBox();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.kevinTBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kevinTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnerDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.searchGrouupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kevinTBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kevinTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // learnerIDLbl
            // 
            this.learnerIDLbl.AutoSize = true;
            this.learnerIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnerIDLbl.Location = new System.Drawing.Point(27, 50);
            this.learnerIDLbl.Name = "learnerIDLbl";
            this.learnerIDLbl.Size = new System.Drawing.Size(60, 13);
            this.learnerIDLbl.TabIndex = 0;
            this.learnerIDLbl.Text = "Learner ID:";
            // 
            // learnerNameLbl
            // 
            this.learnerNameLbl.AutoSize = true;
            this.learnerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnerNameLbl.Location = new System.Drawing.Point(27, 76);
            this.learnerNameLbl.Name = "learnerNameLbl";
            this.learnerNameLbl.Size = new System.Drawing.Size(77, 13);
            this.learnerNameLbl.TabIndex = 1;
            this.learnerNameLbl.Text = "Learner Name:";
            // 
            // enrolledProgramLbl
            // 
            this.enrolledProgramLbl.AutoSize = true;
            this.enrolledProgramLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrolledProgramLbl.Location = new System.Drawing.Point(27, 102);
            this.enrolledProgramLbl.Name = "enrolledProgramLbl";
            this.enrolledProgramLbl.Size = new System.Drawing.Size(90, 13);
            this.enrolledProgramLbl.TabIndex = 2;
            this.enrolledProgramLbl.Text = "Enrolled Program:";
            // 
            // favSubjLbl
            // 
            this.favSubjLbl.AutoSize = true;
            this.favSubjLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favSubjLbl.Location = new System.Drawing.Point(27, 128);
            this.favSubjLbl.Name = "favSubjLbl";
            this.favSubjLbl.Size = new System.Drawing.Size(87, 13);
            this.favSubjLbl.TabIndex = 3;
            this.favSubjLbl.Text = "Favorite Subject:";
            // 
            // numLanguagesLbl
            // 
            this.numLanguagesLbl.AutoSize = true;
            this.numLanguagesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLanguagesLbl.Location = new System.Drawing.Point(27, 157);
            this.numLanguagesLbl.Name = "numLanguagesLbl";
            this.numLanguagesLbl.Size = new System.Drawing.Size(115, 13);
            this.numLanguagesLbl.TabIndex = 4;
            this.numLanguagesLbl.Text = "Number of Languages:";
            // 
            // strongestSkillLbl
            // 
            this.strongestSkillLbl.AutoSize = true;
            this.strongestSkillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strongestSkillLbl.Location = new System.Drawing.Point(27, 186);
            this.strongestSkillLbl.Name = "strongestSkillLbl";
            this.strongestSkillLbl.Size = new System.Drawing.Size(77, 13);
            this.strongestSkillLbl.TabIndex = 5;
            this.strongestSkillLbl.Text = "Strongest Skill:";
            // 
            // favSubTb
            // 
            this.favSubTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favSubTb.Location = new System.Drawing.Point(148, 128);
            this.favSubTb.Name = "favSubTb";
            this.favSubTb.Size = new System.Drawing.Size(188, 20);
            this.favSubTb.TabIndex = 7;
            // 
            // learnerIDTb
            // 
            this.learnerIDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnerIDTb.Location = new System.Drawing.Point(148, 50);
            this.learnerIDTb.Name = "learnerIDTb";
            this.learnerIDTb.Size = new System.Drawing.Size(188, 20);
            this.learnerIDTb.TabIndex = 1;
            // 
            // learnerNameTb
            // 
            this.learnerNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnerNameTb.Location = new System.Drawing.Point(148, 76);
            this.learnerNameTb.Name = "learnerNameTb";
            this.learnerNameTb.Size = new System.Drawing.Size(188, 20);
            this.learnerNameTb.TabIndex = 3;
            // 
            // enrolledProgramTb
            // 
            this.enrolledProgramTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrolledProgramTb.Location = new System.Drawing.Point(148, 102);
            this.enrolledProgramTb.Name = "enrolledProgramTb";
            this.enrolledProgramTb.Size = new System.Drawing.Size(188, 20);
            this.enrolledProgramTb.TabIndex = 5;
            // 
            // numLangTb
            // 
            this.numLangTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLangTb.Location = new System.Drawing.Point(148, 157);
            this.numLangTb.Name = "numLangTb";
            this.numLangTb.Size = new System.Drawing.Size(188, 20);
            this.numLangTb.TabIndex = 9;
            // 
            // strongSkillTb
            // 
            this.strongSkillTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strongSkillTb.Location = new System.Drawing.Point(148, 183);
            this.strongSkillTb.Name = "strongSkillTb";
            this.strongSkillTb.Size = new System.Drawing.Size(188, 20);
            this.strongSkillTb.TabIndex = 11;
            // 
            // learnerDetailsGroupBox
            // 
            this.learnerDetailsGroupBox.Controls.Add(this.strongSkillTb);
            this.learnerDetailsGroupBox.Controls.Add(this.numLangTb);
            this.learnerDetailsGroupBox.Controls.Add(this.learnerIDLbl);
            this.learnerDetailsGroupBox.Controls.Add(this.enrolledProgramTb);
            this.learnerDetailsGroupBox.Controls.Add(this.learnerNameLbl);
            this.learnerDetailsGroupBox.Controls.Add(this.learnerNameTb);
            this.learnerDetailsGroupBox.Controls.Add(this.enrolledProgramLbl);
            this.learnerDetailsGroupBox.Controls.Add(this.learnerIDTb);
            this.learnerDetailsGroupBox.Controls.Add(this.favSubjLbl);
            this.learnerDetailsGroupBox.Controls.Add(this.favSubTb);
            this.learnerDetailsGroupBox.Controls.Add(this.numLanguagesLbl);
            this.learnerDetailsGroupBox.Controls.Add(this.strongestSkillLbl);
            this.learnerDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnerDetailsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.learnerDetailsGroupBox.Name = "learnerDetailsGroupBox";
            this.learnerDetailsGroupBox.Size = new System.Drawing.Size(352, 218);
            this.learnerDetailsGroupBox.TabIndex = 12;
            this.learnerDetailsGroupBox.TabStop = false;
            this.learnerDetailsGroupBox.Text = "Learner Details";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 236);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(106, 236);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(200, 236);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchBtn.Location = new System.Drawing.Point(260, 29);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitContainer.IsSplitterFixed = true;
            this.contentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.contentSplitContainer.Name = "contentSplitContainer";
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.Controls.Add(this.browseAllBtn);
            this.contentSplitContainer.Panel1.Controls.Add(this.deleteBtn);
            this.contentSplitContainer.Panel1.Controls.Add(this.addBtn);
            this.contentSplitContainer.Panel1.Controls.Add(this.searchGrouupBox);
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.AutoScroll = true;
            this.contentSplitContainer.Panel2.Controls.Add(this.kevinTBDataGridView);
            this.contentSplitContainer.Size = new System.Drawing.Size(772, 344);
            this.contentSplitContainer.SplitterDistance = 400;
            this.contentSplitContainer.TabIndex = 17;
            // 
            // browseAllBtn
            // 
            this.browseAllBtn.Location = new System.Drawing.Point(294, 236);
            this.browseAllBtn.Name = "browseAllBtn";
            this.browseAllBtn.Size = new System.Drawing.Size(75, 23);
            this.browseAllBtn.TabIndex = 18;
            this.browseAllBtn.Text = "Display All";
            this.browseAllBtn.UseVisualStyleBackColor = true;
            this.browseAllBtn.Click += new System.EventHandler(this.browseAllBtn_Click);
            // 
            // searchGrouupBox
            // 
            this.searchGrouupBox.Controls.Add(this.searchTb);
            this.searchGrouupBox.Controls.Add(this.searchLbl);
            this.searchGrouupBox.Controls.Add(this.searchBtn);
            this.searchGrouupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrouupBox.Location = new System.Drawing.Point(12, 273);
            this.searchGrouupBox.Name = "searchGrouupBox";
            this.searchGrouupBox.Size = new System.Drawing.Size(352, 64);
            this.searchGrouupBox.TabIndex = 17;
            this.searchGrouupBox.TabStop = false;
            this.searchGrouupBox.Text = "Find learners by enrolled program";
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTb.Location = new System.Drawing.Point(94, 30);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(163, 20);
            this.searchTb.TabIndex = 12;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(6, 34);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(90, 13);
            this.searchLbl.TabIndex = 12;
            this.searchLbl.Text = "Enrolled Program:";
            // 
            // kevinTBDataGridView
            // 
            this.kevinTBDataGridView.AllowUserToAddRows = false;
            this.kevinTBDataGridView.AllowUserToDeleteRows = false;
            this.kevinTBDataGridView.AutoGenerateColumns = false;
            this.kevinTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kevinTBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6});
            this.kevinTBDataGridView.DataSource = this.kevinTBBindingSource;
            this.kevinTBDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kevinTBDataGridView.Location = new System.Drawing.Point(0, 0);
            this.kevinTBDataGridView.Name = "kevinTBDataGridView";
            this.kevinTBDataGridView.ReadOnly = true;
            this.kevinTBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kevinTBDataGridView.Size = new System.Drawing.Size(368, 344);
            this.kevinTBDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "learnerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Learner ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 82;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "learnerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Learner Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "enrolledProgram";
            this.dataGridViewTextBoxColumn6.HeaderText = "Enrolled Program";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // kevinTBBindingSource
            // 
            this.kevinTBBindingSource.DataSource = typeof(KevinDBModel.KevinTB);
            // 
            // LearnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 344);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.learnerDetailsGroupBox);
            this.Controls.Add(this.contentSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LearnersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learners Directory";
            this.Load += new System.EventHandler(this.LearnersForm_Load);
            this.learnerDetailsGroupBox.ResumeLayout(false);
            this.learnerDetailsGroupBox.PerformLayout();
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.searchGrouupBox.ResumeLayout(false);
            this.searchGrouupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kevinTBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kevinTBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label learnerIDLbl;
        private System.Windows.Forms.Label learnerNameLbl;
        private System.Windows.Forms.Label enrolledProgramLbl;
        private System.Windows.Forms.Label favSubjLbl;
        private System.Windows.Forms.Label numLanguagesLbl;
        private System.Windows.Forms.Label strongestSkillLbl;
        private System.Windows.Forms.TextBox favSubTb;
        private System.Windows.Forms.TextBox learnerIDTb;
        private System.Windows.Forms.TextBox learnerNameTb;
        private System.Windows.Forms.TextBox enrolledProgramTb;
        private System.Windows.Forms.TextBox numLangTb;
        private System.Windows.Forms.TextBox strongSkillTb;
        private System.Windows.Forms.GroupBox learnerDetailsGroupBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.SplitContainer contentSplitContainer;
        private System.Windows.Forms.DataGridView kevinTBDataGridView;
        private System.Windows.Forms.BindingSource kevinTBBindingSource;
        private System.Windows.Forms.GroupBox searchGrouupBox;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button browseAllBtn;
    }
}

