using System;

namespace CreateModels
{
    partial class ForMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboDataBases = new System.Windows.Forms.ComboBox();
            this.trvDataTable = new System.Windows.Forms.TreeView();
            this.chkModes = new System.Windows.Forms.CheckBox();
            this.chkDAL = new System.Windows.Forms.CheckBox();
            this.chkBLL = new System.Windows.Forms.CheckBox();
            this.butcerate = new System.Windows.Forms.Button();
            this.dvgDataCount = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataCount)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(992, 587);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(992, 587);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trvDataTable);
            this.panel1.Controls.Add(this.cboDataBases);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 587);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butcerate);
            this.panel2.Controls.Add(this.chkBLL);
            this.panel2.Controls.Add(this.chkDAL);
            this.panel2.Controls.Add(this.chkModes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dvgDataCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 487);
            this.panel3.TabIndex = 2;
            // 
            // cboDataBases
            // 
            this.cboDataBases.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboDataBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataBases.Location = new System.Drawing.Point(0, 0);
            this.cboDataBases.Name = "cboDataBases";
            this.cboDataBases.Size = new System.Drawing.Size(200, 20);
            this.cboDataBases.TabIndex = 0;
            this.cboDataBases.SelectedIndexChanged += new System.EventHandler(this.cboDataBases_SelectedIndexChanged);
            // 
            // trvDataTable
            // 
            this.trvDataTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trvDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDataTable.LineColor = System.Drawing.Color.White;
            this.trvDataTable.Location = new System.Drawing.Point(0, 20);
            this.trvDataTable.Name = "trvDataTable";
            this.trvDataTable.ShowLines = false;
            this.trvDataTable.ShowPlusMinus = false;
            this.trvDataTable.ShowRootLines = false;
            this.trvDataTable.Size = new System.Drawing.Size(200, 567);
            this.trvDataTable.TabIndex = 1;
            this.trvDataTable.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDataTable_AfterSelect);
            // 
            // chkModes
            // 
            this.chkModes.AutoSize = true;
            this.chkModes.Location = new System.Drawing.Point(21, 20);
            this.chkModes.Name = "chkModes";
            this.chkModes.Size = new System.Drawing.Size(102, 16);
            this.chkModes.TabIndex = 0;
            this.chkModes.Text = "Modes实体类层";
            this.chkModes.UseVisualStyleBackColor = true;
            // 
            // chkDAL
            // 
            this.chkDAL.AutoSize = true;
            this.chkDAL.Location = new System.Drawing.Point(21, 42);
            this.chkDAL.Name = "chkDAL";
            this.chkDAL.Size = new System.Drawing.Size(102, 16);
            this.chkDAL.TabIndex = 1;
            this.chkDAL.Text = "DAL业务逻辑层";
            this.chkDAL.UseVisualStyleBackColor = true;
            // 
            // chkBLL
            // 
            this.chkBLL.AutoSize = true;
            this.chkBLL.Location = new System.Drawing.Point(21, 64);
            this.chkBLL.Name = "chkBLL";
            this.chkBLL.Size = new System.Drawing.Size(102, 16);
            this.chkBLL.TabIndex = 2;
            this.chkBLL.Text = "BLL数据访问层";
            this.chkBLL.UseVisualStyleBackColor = true;
            // 
            // butcerate
            // 
            this.butcerate.Location = new System.Drawing.Point(698, 53);
            this.butcerate.Name = "butcerate";
            this.butcerate.Size = new System.Drawing.Size(82, 30);
            this.butcerate.TabIndex = 3;
            this.butcerate.Text = "生成类型";
            this.butcerate.UseVisualStyleBackColor = true;
            this.butcerate.Click += new System.EventHandler(this.butcerate_Click);
            // 
            // dvgDataCount
            // 
            this.dvgDataCount.AllowUserToAddRows = false;
            this.dvgDataCount.AllowUserToDeleteRows = false;
            this.dvgDataCount.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dvgDataCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDataCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgDataCount.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dvgDataCount.Location = new System.Drawing.Point(0, 0);
            this.dvgDataCount.Name = "dvgDataCount";
            this.dvgDataCount.ReadOnly = true;
            this.dvgDataCount.RowTemplate.Height = 23;
            this.dvgDataCount.Size = new System.Drawing.Size(792, 487);
            this.dvgDataCount.TabIndex = 0;
            // 
            // ForMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 609);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ForMain";
            this.Text = "ForMain";
            this.Load += new System.EventHandler(this.ForMain_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDataCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dvgDataCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butcerate;
        private System.Windows.Forms.CheckBox chkBLL;
        private System.Windows.Forms.CheckBox chkDAL;
        private System.Windows.Forms.CheckBox chkModes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trvDataTable;
        private System.Windows.Forms.ComboBox cboDataBases;
    }
}

