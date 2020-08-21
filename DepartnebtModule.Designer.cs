namespace HRM
{
    partial class DepartmentModule
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
            this.add_dept_form = new System.Windows.Forms.Button();
            this.del_dept = new System.Windows.Forms.Button();
            this.view_dept = new System.Windows.Forms.Button();
            this.edit_dept = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_dept_form
            // 
            this.add_dept_form.Location = new System.Drawing.Point(386, 59);
            this.add_dept_form.Name = "add_dept_form";
            this.add_dept_form.Size = new System.Drawing.Size(361, 93);
            this.add_dept_form.TabIndex = 0;
            this.add_dept_form.Tag = "";
            this.add_dept_form.Text = "Add Department";
            this.add_dept_form.UseVisualStyleBackColor = true;
            this.add_dept_form.Click += new System.EventHandler(this.DepartmentModule_Load);
            this.add_dept_form.Enter += new System.EventHandler(this.button1_Click);
            // 
            // del_dept
            // 
            this.del_dept.Location = new System.Drawing.Point(386, 297);
            this.del_dept.Name = "del_dept";
            this.del_dept.Size = new System.Drawing.Size(361, 93);
            this.del_dept.TabIndex = 1;
            this.del_dept.Text = "Delete Department";
            this.del_dept.UseVisualStyleBackColor = true;
            this.del_dept.Click += new System.EventHandler(this.del_dept_Click);
            // 
            // view_dept
            // 
            this.view_dept.Location = new System.Drawing.Point(386, 406);
            this.view_dept.Name = "view_dept";
            this.view_dept.Size = new System.Drawing.Size(361, 93);
            this.view_dept.TabIndex = 2;
            this.view_dept.Text = "View Departments";
            this.view_dept.UseVisualStyleBackColor = true;
            this.view_dept.Click += new System.EventHandler(this.view_dept_Click);
            // 
            // edit_dept
            // 
            this.edit_dept.Location = new System.Drawing.Point(386, 180);
            this.edit_dept.Name = "edit_dept";
            this.edit_dept.Size = new System.Drawing.Size(361, 93);
            this.edit_dept.TabIndex = 3;
            this.edit_dept.Text = "Edit Department";
            this.edit_dept.UseVisualStyleBackColor = true;
            this.edit_dept.Click += new System.EventHandler(this.edit_dept_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(950, 475);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 219);
            this.button5.TabIndex = 4;
            this.button5.Text = "GO BACK";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DepartmentModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 706);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.edit_dept);
            this.Controls.Add(this.view_dept);
            this.Controls.Add(this.del_dept);
            this.Controls.Add(this.add_dept_form);
            this.Name = "DepartmentModule";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.DepartmentModule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_dept_form;
        private System.Windows.Forms.Button del_dept;
        private System.Windows.Forms.Button view_dept;
        private System.Windows.Forms.Button edit_dept;
        private System.Windows.Forms.Button button5;
    }
}

