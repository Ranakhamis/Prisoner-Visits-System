namespace DB
{
    partial class visitorSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select_all_visitors = new System.Windows.Forms.DataGridView();
            this.visitor_name = new System.Windows.Forms.Label();
            this.visitor_ids = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.select_all_visitors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecting a visitor using id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "All vistors data";
            // 
            // select_all_visitors
            // 
            this.select_all_visitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.select_all_visitors.Location = new System.Drawing.Point(276, 187);
            this.select_all_visitors.Name = "select_all_visitors";
            this.select_all_visitors.RowTemplate.Height = 24;
            this.select_all_visitors.Size = new System.Drawing.Size(438, 231);
            this.select_all_visitors.TabIndex = 5;
            this.select_all_visitors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.select_all_visitors_CellContentClick);
            // 
            // visitor_name
            // 
            this.visitor_name.AutoSize = true;
            this.visitor_name.Location = new System.Drawing.Point(630, 81);
            this.visitor_name.Name = "visitor_name";
            this.visitor_name.Size = new System.Drawing.Size(84, 17);
            this.visitor_name.TabIndex = 6;
            this.visitor_name.Text = "visitor name";
            // 
            // visitor_ids
            // 
            this.visitor_ids.FormattingEnabled = true;
            this.visitor_ids.Location = new System.Drawing.Point(380, 75);
            this.visitor_ids.Name = "visitor_ids";
            this.visitor_ids.Size = new System.Drawing.Size(121, 24);
            this.visitor_ids.TabIndex = 7;
            this.visitor_ids.SelectedIndexChanged += new System.EventHandler(this.visitor_ids_SelectedIndexChanged);
            // 
            // visitorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visitor_ids);
            this.Controls.Add(this.visitor_name);
            this.Controls.Add(this.select_all_visitors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "visitorSelection";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.visitorSelection_FormClosing);
            this.Load += new System.EventHandler(this.visitorSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.select_all_visitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView select_all_visitors;
        private System.Windows.Forms.Label visitor_name;
        private System.Windows.Forms.ComboBox visitor_ids;
    }
}

