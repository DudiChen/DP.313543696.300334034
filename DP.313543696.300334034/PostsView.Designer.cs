namespace DP._313543696._300334034
{
    partial class PostsView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_Likes_Time = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grp_Stats = new System.Windows.Forms.GroupBox();
            this.txt_PhotosInPosts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TotalLikes = new System.Windows.Forms.TextBox();
            this.txt_LikesPerPost = new System.Windows.Forms.TextBox();
            this.txt_PostsPerDay = new System.Windows.Forms.TextBox();
            this.txt_LetterPerPost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Likes_Time)).BeginInit();
            this.grp_Stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chart_Likes_Time, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grp_Stats, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 323);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chart_Likes_Time
            // 
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "Default";
            this.chart_Likes_Time.ChartAreas.Add(chartArea1);
            this.chart_Likes_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Likes_Time.Legends.Add(legend1);
            this.chart_Likes_Time.Location = new System.Drawing.Point(3, 3);
            this.chart_Likes_Time.Name = "chart_Likes_Time";
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Likes";
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series2.BorderWidth = 2;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Posts";
            this.chart_Likes_Time.Series.Add(series1);
            this.chart_Likes_Time.Series.Add(series2);
            this.chart_Likes_Time.Size = new System.Drawing.Size(428, 317);
            this.chart_Likes_Time.TabIndex = 0;
            this.chart_Likes_Time.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Posts Compare Time of Day";
            this.chart_Likes_Time.Titles.Add(title1);
            // 
            // grp_Stats
            // 
            this.grp_Stats.Controls.Add(this.txt_PhotosInPosts);
            this.grp_Stats.Controls.Add(this.label4);
            this.grp_Stats.Controls.Add(this.txt_TotalLikes);
            this.grp_Stats.Controls.Add(this.txt_LikesPerPost);
            this.grp_Stats.Controls.Add(this.txt_PostsPerDay);
            this.grp_Stats.Controls.Add(this.txt_LetterPerPost);
            this.grp_Stats.Controls.Add(this.label5);
            this.grp_Stats.Controls.Add(this.label3);
            this.grp_Stats.Controls.Add(this.label2);
            this.grp_Stats.Controls.Add(this.label1);
            this.grp_Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grp_Stats.Location = new System.Drawing.Point(437, 3);
            this.grp_Stats.Name = "grp_Stats";
            this.grp_Stats.Size = new System.Drawing.Size(429, 317);
            this.grp_Stats.TabIndex = 1;
            this.grp_Stats.TabStop = false;
            this.grp_Stats.Text = "Stats";
            // 
            // txt_PhotosInPosts
            // 
            this.txt_PhotosInPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PhotosInPosts.Location = new System.Drawing.Point(289, 260);
            this.txt_PhotosInPosts.Margin = new System.Windows.Forms.Padding(15);
            this.txt_PhotosInPosts.MaxLength = 6;
            this.txt_PhotosInPosts.Name = "txt_PhotosInPosts";
            this.txt_PhotosInPosts.ReadOnly = true;
            this.txt_PhotosInPosts.Size = new System.Drawing.Size(122, 22);
            this.txt_PhotosInPosts.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(13, 239);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(15);
            this.label4.Size = new System.Drawing.Size(261, 50);
            this.label4.TabIndex = 9;
            this.label4.Text = "Presentage of Post with Photos";
            // 
            // txt_TotalLikes
            // 
            this.txt_TotalLikes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalLikes.Location = new System.Drawing.Point(289, 210);
            this.txt_TotalLikes.Margin = new System.Windows.Forms.Padding(15);
            this.txt_TotalLikes.Name = "txt_TotalLikes";
            this.txt_TotalLikes.ReadOnly = true;
            this.txt_TotalLikes.Size = new System.Drawing.Size(122, 22);
            this.txt_TotalLikes.TabIndex = 8;
            // 
            // txt_LikesPerPost
            // 
            this.txt_LikesPerPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LikesPerPost.Location = new System.Drawing.Point(289, 158);
            this.txt_LikesPerPost.Margin = new System.Windows.Forms.Padding(15);
            this.txt_LikesPerPost.Name = "txt_LikesPerPost";
            this.txt_LikesPerPost.ReadOnly = true;
            this.txt_LikesPerPost.Size = new System.Drawing.Size(122, 22);
            this.txt_LikesPerPost.TabIndex = 7;
            // 
            // txt_PostsPerDay
            // 
            this.txt_PostsPerDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PostsPerDay.Location = new System.Drawing.Point(289, 106);
            this.txt_PostsPerDay.Margin = new System.Windows.Forms.Padding(15);
            this.txt_PostsPerDay.MaxLength = 5;
            this.txt_PostsPerDay.Name = "txt_PostsPerDay";
            this.txt_PostsPerDay.ReadOnly = true;
            this.txt_PostsPerDay.Size = new System.Drawing.Size(122, 22);
            this.txt_PostsPerDay.TabIndex = 6;
            // 
            // txt_LetterPerPost
            // 
            this.txt_LetterPerPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LetterPerPost.Location = new System.Drawing.Point(289, 54);
            this.txt_LetterPerPost.Margin = new System.Windows.Forms.Padding(15);
            this.txt_LetterPerPost.Name = "txt_LetterPerPost";
            this.txt_LetterPerPost.ReadOnly = true;
            this.txt_LetterPerPost.Size = new System.Drawing.Size(122, 22);
            this.txt_LetterPerPost.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(15);
            this.label5.Size = new System.Drawing.Size(252, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Avg. Number of Likes per Post";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(15);
            this.label3.Size = new System.Drawing.Size(193, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Number of Likes";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15);
            this.label2.Size = new System.Drawing.Size(173, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Avg. Posts per Day";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15);
            this.label1.Size = new System.Drawing.Size(265, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avg. Number of Letters per Post";
            // 
            // PostsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PostsView";
            this.ShowIcon = false;
            this.Text = "Posts View";
            this.Load += new System.EventHandler(this.PostsView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Likes_Time)).EndInit();
            this.grp_Stats.ResumeLayout(false);
            this.grp_Stats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Likes_Time;
        private System.Windows.Forms.GroupBox grp_Stats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TotalLikes;
        private System.Windows.Forms.TextBox txt_LikesPerPost;
        private System.Windows.Forms.TextBox txt_PostsPerDay;
        private System.Windows.Forms.TextBox txt_LetterPerPost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PhotosInPosts;
        private System.Windows.Forms.Label label4;
    }
}