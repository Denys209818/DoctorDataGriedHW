
namespace DataGriedDoctor2HW
{
    partial class MainForm
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
            this.doctorDataGried = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.doctorScrollBar = new System.Windows.Forms.HScrollBar();
            this.checkBoxIsScroll = new System.Windows.Forms.CheckBox();
            this.linkFirst = new System.Windows.Forms.LinkLabel();
            this.linkSecond = new System.Windows.Forms.LinkLabel();
            this.linkLast = new System.Windows.Forms.LinkLabel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGried)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorDataGried
            // 
            this.doctorDataGried.BackgroundColor = System.Drawing.Color.White;
            this.doctorDataGried.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGried.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColFirstName,
            this.colLastName,
            this.colDepartmentName});
            this.doctorDataGried.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.doctorDataGried.Location = new System.Drawing.Point(12, 90);
            this.doctorDataGried.Name = "doctorDataGried";
            this.doctorDataGried.RowHeadersWidth = 51;
            this.doctorDataGried.RowTemplate.Height = 29;
            this.doctorDataGried.Size = new System.Drawing.Size(776, 268);
            this.doctorDataGried.TabIndex = 0;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Width = 60;
            // 
            // ColFirstName
            // 
            this.ColFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFirstName.HeaderText = "Ім\'я";
            this.ColFirstName.MinimumWidth = 6;
            this.ColFirstName.Name = "ColFirstName";
            // 
            // colLastName
            // 
            this.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLastName.HeaderText = "Прізвище";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepartmentName.HeaderText = "Назва відділу";
            this.colDepartmentName.MinimumWidth = 6;
            this.colDepartmentName.Name = "colDepartmentName";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(264, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Список лікарів";
            // 
            // doctorScrollBar
            // 
            this.doctorScrollBar.Location = new System.Drawing.Point(12, 375);
            this.doctorScrollBar.Name = "doctorScrollBar";
            this.doctorScrollBar.Size = new System.Drawing.Size(776, 26);
            this.doctorScrollBar.SmallChange = 9;
            this.doctorScrollBar.TabIndex = 9;
            this.doctorScrollBar.ValueChanged += new System.EventHandler(this.doctorScrollBar_ValueChanged);
            // 
            // checkBoxIsScroll
            // 
            this.checkBoxIsScroll.AutoSize = true;
            this.checkBoxIsScroll.BackColor = System.Drawing.Color.Lime;
            this.checkBoxIsScroll.Location = new System.Drawing.Point(12, 414);
            this.checkBoxIsScroll.Name = "checkBoxIsScroll";
            this.checkBoxIsScroll.Size = new System.Drawing.Size(182, 24);
            this.checkBoxIsScroll.TabIndex = 10;
            this.checkBoxIsScroll.Text = "Включить скролл-бар";
            this.checkBoxIsScroll.UseVisualStyleBackColor = false;
            this.checkBoxIsScroll.CheckedChanged += new System.EventHandler(this.checkBoxIsScroll_CheckedChanged);
            // 
            // linkFirst
            // 
            this.linkFirst.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkFirst.AutoSize = true;
            this.linkFirst.BackColor = System.Drawing.Color.Lime;
            this.linkFirst.Location = new System.Drawing.Point(434, 415);
            this.linkFirst.Name = "linkFirst";
            this.linkFirst.Size = new System.Drawing.Size(17, 20);
            this.linkFirst.TabIndex = 11;
            this.linkFirst.TabStop = true;
            this.linkFirst.Text = "1";
            this.linkFirst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFirst_LinkClicked);
            // 
            // linkSecond
            // 
            this.linkSecond.AutoSize = true;
            this.linkSecond.BackColor = System.Drawing.Color.Lime;
            this.linkSecond.Location = new System.Drawing.Point(490, 415);
            this.linkSecond.Name = "linkSecond";
            this.linkSecond.Size = new System.Drawing.Size(17, 20);
            this.linkSecond.TabIndex = 12;
            this.linkSecond.TabStop = true;
            this.linkSecond.Text = "2";
            // 
            // linkLast
            // 
            this.linkLast.AutoSize = true;
            this.linkLast.BackColor = System.Drawing.Color.Lime;
            this.linkLast.Location = new System.Drawing.Point(546, 414);
            this.linkLast.Name = "linkLast";
            this.linkLast.Size = new System.Drawing.Size(17, 20);
            this.linkLast.TabIndex = 13;
            this.linkLast.TabStop = true;
            this.linkLast.Text = "3";
            this.linkLast.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLast_LinkClicked);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Lime;
            this.lblMenu.Location = new System.Drawing.Point(289, 415);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(129, 20);
            this.lblMenu.TabIndex = 14;
            this.lblMenu.Text = "Оберіть сторінку:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.Location = new System.Drawing.Point(642, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 58);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.BackColor = System.Drawing.Color.Lime;
            this.lblOut.Location = new System.Drawing.Point(644, 415);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(144, 20);
            this.lblOut.TabIndex = 13;
            this.lblOut.TabStop = true;
            this.lblOut.Text = "Повернутися назад";
            this.lblOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.linkLast);
            this.Controls.Add(this.linkSecond);
            this.Controls.Add(this.linkFirst);
            this.Controls.Add(this.checkBoxIsScroll);
            this.Controls.Add(this.doctorScrollBar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.doctorDataGried);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна сторінка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGried)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorDataGried;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentName;
        private System.Windows.Forms.HScrollBar doctorScrollBar;
        private System.Windows.Forms.CheckBox checkBoxIsScroll;
        private System.Windows.Forms.LinkLabel linkFirst;
        private System.Windows.Forms.LinkLabel linkSecond;
        private System.Windows.Forms.LinkLabel linkLast;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.LinkLabel lblOut;
    }
}