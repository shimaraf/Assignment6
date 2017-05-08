namespace HW2.UI
{
    partial class FRMdtgrid
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
            this.dguser = new System.Windows.Forms.DataGridView();
            this.btnshow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddcourse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnshowlist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dguser)).BeginInit();
            this.SuspendLayout();
            // 
            // dguser
            // 
            this.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dguser.Location = new System.Drawing.Point(0, 1);
            this.dguser.Name = "dguser";
            this.dguser.Size = new System.Drawing.Size(514, 211);
            this.dguser.TabIndex = 0;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(47, 218);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(142, 23);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "نمایش لیست دروس";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "کد درس جهت ثبت در لیست انتخاب واحد را وارد کنید:";
            // 
            // txtaddcourse
            // 
            this.txtaddcourse.Location = new System.Drawing.Point(128, 281);
            this.txtaddcourse.Name = "txtaddcourse";
            this.txtaddcourse.Size = new System.Drawing.Size(117, 20);
            this.txtaddcourse.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ثبت در لیست انتخاب واحد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnshowlist
            // 
            this.btnshowlist.Location = new System.Drawing.Point(343, 338);
            this.btnshowlist.Name = "btnshowlist";
            this.btnshowlist.Size = new System.Drawing.Size(142, 23);
            this.btnshowlist.TabIndex = 6;
            this.btnshowlist.Text = "نمایش لیست انتخاب واحد";
            this.btnshowlist.UseVisualStyleBackColor = true;
            this.btnshowlist.Click += new System.EventHandler(this.btnshowlist_Click);
            // 
            // FRMdtgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 404);
            this.Controls.Add(this.btnshowlist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtaddcourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.dguser);
            this.Name = "FRMdtgrid";
            this.Text = "FRMdtgrid";
            ((System.ComponentModel.ISupportInitialize)(this.dguser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dguser;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddcourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnshowlist;
    }
}