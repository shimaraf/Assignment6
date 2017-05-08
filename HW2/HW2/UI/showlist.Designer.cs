namespace HW2.UI
{
    partial class showlistdg
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
            this.btnexit = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgviewlist = new System.Windows.Forms.DataGridView();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(53, 227);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(122, 23);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            // 
            // dgviewlist
            // 
            this.dgviewlist.AutoGenerateColumns = false;
            this.dgviewlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewlist.DataSource = this.database1DataSet1BindingSource;
            this.dgviewlist.Location = new System.Drawing.Point(0, 1);
            this.dgviewlist.Name = "dgviewlist";
            this.dgviewlist.Size = new System.Drawing.Size(387, 150);
            this.dgviewlist.TabIndex = 2;
            // 
            // showlistdg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(this.dgviewlist);
            this.Controls.Add(this.btnexit);
            this.Name = "showlistdg";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.showlistdg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
      //  private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
      //  private Database1DataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridView dgviewlist;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
       // private Database1DataSet1 database1DataSet1;
    }
}