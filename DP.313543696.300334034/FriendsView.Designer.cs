namespace DP._313543696._300334034
{
    partial class FriendsView
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.picBox_0 = new System.Windows.Forms.PictureBox();
            this.flowLayout_Pictures = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_0)).BeginInit();
            this.flowLayout_Pictures.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.flowLayout_Pictures, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(800, 450);
            this.tableLayout.TabIndex = 0;
            // 
            // picBox_0
            // 
            this.picBox_0.Location = new System.Drawing.Point(3, 3);
            this.picBox_0.Name = "picBox_0";
            this.picBox_0.Size = new System.Drawing.Size(75, 75);
            this.picBox_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_0.TabIndex = 0;
            this.picBox_0.TabStop = false;
            this.picBox_0.Visible = false;
            // 
            // flowLayout_Pictures
            // 
            this.flowLayout_Pictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayout_Pictures.Controls.Add(this.picBox_0);
            this.flowLayout_Pictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_Pictures.Location = new System.Drawing.Point(3, 3);
            this.flowLayout_Pictures.Name = "flowLayout_Pictures";
            this.tableLayout.SetRowSpan(this.flowLayout_Pictures, 2);
            this.flowLayout_Pictures.Size = new System.Drawing.Size(394, 444);
            this.flowLayout_Pictures.TabIndex = 1;
            // 
            // FriendsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayout);
            this.Name = "FriendsView";
            this.ShowIcon = false;
            this.Text = "Friends View";
            this.Load += new System.EventHandler(this.FriendsView_Load);
            this.tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_0)).EndInit();
            this.flowLayout_Pictures.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_Pictures;
        private System.Windows.Forms.PictureBox picBox_0;
    }
}