namespace ProcessNote
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
            this.CPUlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.ProcessDetails = new System.Windows.Forms.ListBox();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.RAMlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            this.SuspendLayout();
            // 
            // CPUlabel
            // 
            this.CPUlabel.AutoSize = true;
            this.CPUlabel.Location = new System.Drawing.Point(319, 139);
            this.CPUlabel.Name = "CPUlabel";
            this.CPUlabel.Size = new System.Drawing.Size(64, 13);
            this.CPUlabel.TabIndex = 2;
            this.CPUlabel.Text = "CPU usage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // ProcessList
            // 
            this.ProcessList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ProcessList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ProcessList.Location = new System.Drawing.Point(12, 12);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(183, 252);
            this.ProcessList.TabIndex = 4;
            this.ProcessList.UseCompatibleStateImageBehavior = false;
            this.ProcessList.View = System.Windows.Forms.View.Details;
            this.ProcessList.Click += new System.EventHandler(this.itemClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // ProcessDetails
            // 
            this.ProcessDetails.FormattingEnabled = true;
            this.ProcessDetails.Location = new System.Drawing.Point(322, 12);
            this.ProcessDetails.Name = "ProcessDetails";
            this.ProcessDetails.Size = new System.Drawing.Size(270, 95);
            this.ProcessDetails.TabIndex = 7;
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(322, 244);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(270, 20);
            this.CommentBox.TabIndex = 8;
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Memory";
            this.performanceCounter2.CounterName = "Available MBytes";
            // 
            // RAMlabel
            // 
            this.RAMlabel.AutoSize = true;
            this.RAMlabel.Location = new System.Drawing.Point(322, 165);
            this.RAMlabel.Name = "RAMlabel";
            this.RAMlabel.Size = new System.Drawing.Size(93, 13);
            this.RAMlabel.TabIndex = 10;
            this.RAMlabel.Text = "Available Memory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Comment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CommentBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(220, 46);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 13;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(648, 287);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RAMlabel);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.ProcessDetails);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CPUlabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CPUlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ProcessList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.ListBox ProcessDetails;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private System.Windows.Forms.Label RAMlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RefreshBtn;
    }
}

