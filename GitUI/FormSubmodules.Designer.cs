﻿namespace GitUI
{
    partial class FormSubmodules
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddSubmodule = new System.Windows.Forms.Button();
            this.Submodules = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitSubmoduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RemoveSubmodule = new System.Windows.Forms.Button();
            this.UpdateSubmodule = new System.Windows.Forms.Button();
            this.SynchronizeSubmodule = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SubModuleStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubModuleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubModuleRemotePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubModuleLocalPath = new System.Windows.Forms.TextBox();
            this.SubModuleCommit = new System.Windows.Forms.TextBox();
            this.SubModuleBranch = new System.Windows.Forms.TextBox();
#if Mono212Released //waiting for mono 2.12
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
#endif
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Submodules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitSubmoduleBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(782, 355);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.AddSubmodule, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Submodules, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 355);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // AddSubmodule
            // 
            this.AddSubmodule.Location = new System.Drawing.Point(4, 320);
            this.AddSubmodule.Margin = new System.Windows.Forms.Padding(4);
            this.AddSubmodule.Name = "AddSubmodule";
            this.AddSubmodule.Size = new System.Drawing.Size(202, 31);
            this.AddSubmodule.TabIndex = 0;
            this.AddSubmodule.Text = "Add submodule";
            this.AddSubmodule.UseVisualStyleBackColor = true;
            this.AddSubmodule.Click += new System.EventHandler(this.AddSubmoduleClick);
            // 
            // Submodules
            // 
            this.Submodules.AllowUserToAddRows = false;
            this.Submodules.AllowUserToDeleteRows = false;
            this.Submodules.AllowUserToResizeRows = false;
            this.Submodules.AutoGenerateColumns = false;
            this.Submodules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Submodules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Status});
            this.Submodules.DataSource = this.gitSubmoduleBindingSource;
            this.Submodules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Submodules.Location = new System.Drawing.Point(4, 4);
            this.Submodules.Margin = new System.Windows.Forms.Padding(4);
            this.Submodules.MultiSelect = false;
            this.Submodules.Name = "Submodules";
            this.Submodules.ReadOnly = true;
            this.Submodules.RowHeadersVisible = false;
            this.Submodules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Submodules.Size = new System.Drawing.Size(214, 308);
            this.Submodules.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // gitSubmoduleBindingSource
            // 
            this.gitSubmoduleBindingSource.DataSource = typeof(GitCommands.GitSubmodule);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(555, 355);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.RemoveSubmodule);
            this.flowLayoutPanel1.Controls.Add(this.UpdateSubmodule);
            this.flowLayoutPanel1.Controls.Add(this.SynchronizeSubmodule);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 316);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(555, 39);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // RemoveSubmodule
            // 
            this.RemoveSubmodule.Location = new System.Drawing.Point(407, 4);
            this.RemoveSubmodule.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveSubmodule.Name = "RemoveSubmodule";
            this.RemoveSubmodule.Size = new System.Drawing.Size(144, 31);
            this.RemoveSubmodule.TabIndex = 6;
            this.RemoveSubmodule.Text = "Remove";
            this.RemoveSubmodule.UseVisualStyleBackColor = true;
            this.RemoveSubmodule.Click += new System.EventHandler(this.RemoveSubmoduleClick);
            // 
            // UpdateSubmodule
            // 
            this.UpdateSubmodule.Location = new System.Drawing.Point(255, 4);
            this.UpdateSubmodule.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateSubmodule.Name = "UpdateSubmodule";
            this.UpdateSubmodule.Size = new System.Drawing.Size(144, 31);
            this.UpdateSubmodule.TabIndex = 3;
            this.UpdateSubmodule.Text = "Update";
            this.UpdateSubmodule.UseVisualStyleBackColor = true;
            this.UpdateSubmodule.Click += new System.EventHandler(this.UpdateSubmoduleClick);
            // 
            // SynchronizeSubmodule
            // 
            this.SynchronizeSubmodule.Location = new System.Drawing.Point(103, 4);
            this.SynchronizeSubmodule.Margin = new System.Windows.Forms.Padding(4);
            this.SynchronizeSubmodule.Name = "SynchronizeSubmodule";
            this.SynchronizeSubmodule.Size = new System.Drawing.Size(144, 31);
            this.SynchronizeSubmodule.TabIndex = 5;
            this.SynchronizeSubmodule.Text = "Synchronize";
            this.SynchronizeSubmodule.UseVisualStyleBackColor = true;
            this.SynchronizeSubmodule.Click += new System.EventHandler(this.SynchronizeSubmoduleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(547, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SubModuleStatus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SubModuleName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SubModuleRemotePath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SubModuleLocalPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SubModuleCommit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SubModuleBranch, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 280);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // SubModuleStatus
            // 
            this.SubModuleStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SubModuleStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gitSubmoduleBindingSource, "Status", true));
            this.SubModuleStatus.Location = new System.Drawing.Point(108, 190);
            this.SubModuleStatus.Margin = new System.Windows.Forms.Padding(5);
            this.SubModuleStatus.Name = "SubModuleStatus";
            this.SubModuleStatus.ReadOnly = true;
            this.SubModuleStatus.Size = new System.Drawing.Size(214, 27);
            this.SubModuleStatus.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Remote path";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Branch";
            // 
            // SubModuleName
            // 
            this.SubModuleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SubModuleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gitSubmoduleBindingSource, "Name", true));
            this.SubModuleName.Location = new System.Drawing.Point(108, 5);
            this.SubModuleName.Margin = new System.Windows.Forms.Padding(5);
            this.SubModuleName.Name = "SubModuleName";
            this.SubModuleName.ReadOnly = true;
            this.SubModuleName.Size = new System.Drawing.Size(214, 27);
            this.SubModuleName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Commit";
            // 
            // SubModuleRemotePath
            // 
            this.SubModuleRemotePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gitSubmoduleBindingSource, "RemotePath", true));
            this.SubModuleRemotePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubModuleRemotePath.Location = new System.Drawing.Point(108, 42);
            this.SubModuleRemotePath.Margin = new System.Windows.Forms.Padding(5);
            this.SubModuleRemotePath.Name = "SubModuleRemotePath";
            this.SubModuleRemotePath.ReadOnly = true;
            this.SubModuleRemotePath.Size = new System.Drawing.Size(426, 27);
            this.SubModuleRemotePath.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Local path";
            // 
            // SubModuleLocalPath
            // 
            this.SubModuleLocalPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gitSubmoduleBindingSource, "LocalPath", true));
            this.SubModuleLocalPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubModuleLocalPath.Location = new System.Drawing.Point(108, 79);
            this.SubModuleLocalPath.Margin = new System.Windows.Forms.Padding(5);
            this.SubModuleLocalPath.Name = "SubModuleLocalPath";
            this.SubModuleLocalPath.ReadOnly = true;
            this.SubModuleLocalPath.Size = new System.Drawing.Size(426, 27);
            this.SubModuleLocalPath.TabIndex = 10;
            // 
            // SubModuleCommit
            // 
            this.SubModuleCommit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gitSubmoduleBindingSource, "CurrentCommitGuid", true));
            this.SubModuleCommit.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubModuleCommit.Location = new System.Drawing.Point(108, 116);
            this.SubModuleCommit.Margin = new System.Windows.Forms.Padding(5);
            this.SubModuleCommit.Name = "SubModuleCommit";
            this.SubModuleCommit.ReadOnly = true;
            this.SubModuleCommit.Size = new System.Drawing.Size(426, 27);
            this.SubModuleCommit.TabIndex = 11;
            // 
            // SubModuleBranch
            // 
            this.SubModuleBranch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gitSubmoduleBindingSource, "Branch", true));
            this.SubModuleBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubModuleBranch.Location = new System.Drawing.Point(108, 153);
            this.SubModuleBranch.Margin = new System.Windows.Forms.Padding(5);
            this.SubModuleBranch.Name = "SubModuleBranch";
            this.SubModuleBranch.ReadOnly = true;
            this.SubModuleBranch.Size = new System.Drawing.Size(426, 27);
            this.SubModuleBranch.TabIndex = 12;
            // 
            // FormSubmodules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(782, 355);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(710, 350);
            this.Name = "FormSubmodules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Submodules";
            this.Shown += new System.EventHandler(this.FormSubmodulesShown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
#if Mono212Released //waiting for mono 2.12
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
#endif
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Submodules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitSubmoduleBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Submodules;
        private System.Windows.Forms.Button AddSubmodule;
        private System.Windows.Forms.BindingSource gitSubmoduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox SubModuleStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubModuleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SubModuleRemotePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubModuleLocalPath;
        private System.Windows.Forms.TextBox SubModuleCommit;
        private System.Windows.Forms.TextBox SubModuleBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SynchronizeSubmodule;
        private System.Windows.Forms.Button UpdateSubmodule;
        private System.Windows.Forms.Button RemoveSubmodule;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}