namespace DB
{
    partial class visitorFunction
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
            this.prisoner_lists = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.visitorIDS = new System.Windows.Forms.ComboBox();
            this.visitor_name = new System.Windows.Forms.TextBox();
            this.prisoner_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prisoner_lists
            // 
            this.prisoner_lists.FormattingEnabled = true;
            this.prisoner_lists.ItemHeight = 16;
            this.prisoner_lists.Location = new System.Drawing.Point(21, 132);
            this.prisoner_lists.Name = "prisoner_lists";
            this.prisoner_lists.Size = new System.Drawing.Size(179, 244);
            this.prisoner_lists.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Names of prisoners";
            // 
            // visitorIDS
            // 
            this.visitorIDS.FormattingEnabled = true;
            this.visitorIDS.Location = new System.Drawing.Point(549, 88);
            this.visitorIDS.Name = "visitorIDS";
            this.visitorIDS.Size = new System.Drawing.Size(162, 24);
            this.visitorIDS.TabIndex = 2;
            this.visitorIDS.SelectedIndexChanged += new System.EventHandler(this.visitorIDS_SelectedIndexChanged);
            // 
            // visitor_name
            // 
            this.visitor_name.Location = new System.Drawing.Point(579, 189);
            this.visitor_name.Name = "visitor_name";
            this.visitor_name.Size = new System.Drawing.Size(98, 22);
            this.visitor_name.TabIndex = 3;
            // 
            // prisoner_name
            // 
            this.prisoner_name.Location = new System.Drawing.Point(579, 286);
            this.prisoner_name.Name = "prisoner_name";
            this.prisoner_name.Size = new System.Drawing.Size(98, 22);
            this.prisoner_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Visitor IDs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Visitor name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prisoner name";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(255, 405);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 27);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(427, 405);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(97, 27);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(618, 405);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(93, 27);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // visitorFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 608);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prisoner_name);
            this.Controls.Add(this.visitor_name);
            this.Controls.Add(this.visitorIDS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prisoner_lists);
            this.Name = "visitorFunction";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.visitorFunction_FormClosing);
            this.Load += new System.EventHandler(this.visitorFunction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox prisoner_lists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox visitorIDS;
        private System.Windows.Forms.TextBox visitor_name;
        private System.Windows.Forms.TextBox prisoner_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
    }
}