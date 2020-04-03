﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DP._313543696._300334034
{
    public partial class PostsView : Form
    {
        #region Members
        private FacebookWrapper.ObjectModel.User m_LoggedInUser;
        #endregion

        #region Constructor
        public PostsView(FacebookWrapper.ObjectModel.User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
        }
        #endregion

        #region Events
        private void PostsView_Load(object sender, EventArgs e)
        {
            LoadChart_LikesPerTimeOfDay();
            LoadChart_PostsPerTimeOfDay();
            LoadGroup_Stats();
        }
        #endregion

        #region Private Methods
        private void LoadChart_LikesPerTimeOfDay()
        {
            DateTime time;
            string timeAsString;
            uint likes;

            foreach (var post in m_LoggedInUser.Posts)
            {
                // Cuz Facebook API doesn't allow us to get Like list
                //time = (DateTime)post.CreatedTime;
                //likes = (uint)post.LikedBy.Count;

                time = GetRandomDateTime(new DateTime(2000, 01, 01, 10, 00, 00), DateTime.Now);
                likes = GetRandomUnsignedNumber();
                timeAsString = time.Hour < 10 ? "0" + time.Hour.ToString() : time.Hour.ToString();
                timeAsString += ":";
                timeAsString += time.Minute < 10 ? "0" + time.Minute.ToString() : time.Minute.ToString();
                this.chart_Likes_Time.Series["Likes"].Points.AddXY(timeAsString, likes);
            }

            this.chart_Likes_Time.Series["Likes"].Sort(PointSortOrder.Ascending, "X");
        }

        private void LoadChart_PostsPerTimeOfDay()
        {
            string timeAsString;
            uint[] postsPerHour = new uint[24];
            for (int i = 0; i < 24; i++) postsPerHour[i] = 0;

            foreach (var post in m_LoggedInUser.Posts)
            {
                postsPerHour[post.CreatedTime.Value.Hour]++;
            }

            for (int i = 0; i < postsPerHour.Length; i++)
            {
                timeAsString = i < 10 ? "0" + i + ":00" : i + ":00";
                this.chart_Likes_Time.Series["Posts"].Points.AddXY(timeAsString, postsPerHour[i]);
            }
            this.chart_Likes_Time.Series["Posts"].Sort(PointSortOrder.Ascending, "X");
            CreateSecondYAxisScale(this.chart_Likes_Time, "Posts");
        }

        private void LoadGroup_Stats()
        {
            this.txt_LetterPerPost.Text = AvgNumberOfLettersInPosts() + "";
            this.txt_PostsPerDay.Text = AvgPostsPerDay() + "";
            this.txt_LikesPerPost.Text = AvgLikesPerPost() + "";
            this.txt_PhotosInPosts.Text = PresentageOfPostsWithPhotos() + "%";
            this.txt_TotalLikes.Text = TotalNumberOfLikes() + "";
        }

        private double AvgNumberOfLettersInPosts()
        {
            double result = 0;

            foreach (var post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                    result += post.Message.Length;
            }
            result /= m_LoggedInUser.Posts.Count;

            return result;
        }

        private double AvgLikesPerPost()
        {
            double result = 0;

            foreach (var post in m_LoggedInUser.Posts)
            {
                // Doesnt let see the like list
                //result += post.LikedBy.Count;
                result += GetRandomUnsignedNumber(250);
            }
            result /= m_LoggedInUser.Posts.Count;

            return result;
        }

        private double AvgPostsPerDay()
        {
            double result = 0;
            DateTime createdUser = new DateTime(0);

            /*foreach (var album in m_LoggedInUser.Albums)
            {
                if (album.Name == "Profile Pictures")
                    createdUser = album.CreatedTime.Value;
            }*/
            result = randomGenerater.NextDouble();
            if(createdUser.Ticks != 0)
            {
                result = m_LoggedInUser.Albums.Count / (DateTime.Now - createdUser).Days;
            }

            return result;
        }

        private double PresentageOfPostsWithPhotos()
        {
            double result = 0;
            foreach (var post in m_LoggedInUser.Posts)
            {
                if (post.PictureURL != null)
                    result++;
            }
            return result / (m_LoggedInUser.Posts.Count) * 100;
        }

        private double TotalNumberOfLikes()
        {
            double result = 0;
            foreach(var post in m_LoggedInUser.Posts)
            {
                //result += post.LikedBy.Count;
                result += GetRandomUnsignedNumber(150);
            }
            return result;
        }
        #endregion

        #region Helpers Methods
        static Random randomGenerater = new Random();
        private static DateTime GetRandomDateTime(DateTime i_From, DateTime i_To)
        {
            TimeSpan range = new TimeSpan(i_To.Ticks - i_From.Ticks);
            return (i_From + new TimeSpan((long)(range.Ticks * randomGenerater.NextDouble())));
        }
        private static uint GetRandomUnsignedNumber(int i_Capacity = 1500)
        {
            return (uint)(randomGenerater.Next(0, i_Capacity + 1));
        }

        private void CreateSecondYAxisScale(Chart i_Chart, string i_Series)
        {
            // Set custom chart area position
            i_Chart.ChartAreas["Default"].Position = new ElementPosition(25, 10, 68, 85);
            i_Chart.ChartAreas["Default"].InnerPlotPosition = new ElementPosition(10, 0, 90, 90);

            // Create extra Y axis for second
            CreateYAxis(i_Chart, i_Chart.ChartAreas["Default"], i_Chart.Series[i_Series], 13, 8);
        }
        public void CreateYAxis(Chart i_Chart, ChartArea i_Area, Series i_Series, float i_AxisOffset, float i_LabelsSize)
        {
            // Create new chart area for original series
            ChartArea areaSeries = i_Chart.ChartAreas.Add("ChartArea_" + i_Series.Name);
            areaSeries.BackColor = Color.Transparent;
            areaSeries.BorderColor = Color.Transparent;
            areaSeries.Position.FromRectangleF(i_Area.Position.ToRectangleF());
            areaSeries.InnerPlotPosition.FromRectangleF(i_Area.InnerPlotPosition.ToRectangleF());
            areaSeries.AxisX.MajorGrid.Enabled = false;
            areaSeries.AxisX.MajorTickMark.Enabled = false;
            areaSeries.AxisX.LabelStyle.Enabled = false;
            areaSeries.AxisY.MajorGrid.Enabled = false;
            areaSeries.AxisY.MajorTickMark.Enabled = false;
            areaSeries.AxisY.LabelStyle.Enabled = false;
            areaSeries.AxisY.IsStartedFromZero = i_Area.AxisY.IsStartedFromZero;


            i_Series.ChartArea = areaSeries.Name;

            // Create new chart area for axis
            ChartArea areaAxis = i_Chart.ChartAreas.Add("AxisY_" + i_Series.ChartArea);
            areaAxis.BackColor = Color.Transparent;
            areaAxis.BorderColor = Color.Transparent;
            areaAxis.Position.FromRectangleF(i_Chart.ChartAreas[i_Series.ChartArea].Position.ToRectangleF());
            areaAxis.InnerPlotPosition.FromRectangleF(i_Chart.ChartAreas[i_Series.ChartArea].InnerPlotPosition.ToRectangleF());

            // Create a copy of specified series
            Series seriesCopy = i_Chart.Series.Add(i_Series.Name + "_Copy");
            seriesCopy.ChartType = i_Series.ChartType;
            foreach (DataPoint point in i_Series.Points)
            {
                seriesCopy.Points.AddXY(point.XValue, point.YValues[0]);
            }

            // Hide copied series
            seriesCopy.IsVisibleInLegend = false;
            seriesCopy.Color = Color.Transparent;
            seriesCopy.BorderColor = Color.Transparent;
            seriesCopy.ChartArea = areaAxis.Name;

            // Disable drid lines & tickmarks
            areaAxis.AxisX.LineWidth = 0;
            areaAxis.AxisX.MajorGrid.Enabled = false;
            areaAxis.AxisX.MajorTickMark.Enabled = false;
            areaAxis.AxisX.LabelStyle.Enabled = false;
            areaAxis.AxisY.MajorGrid.Enabled = false;
            areaAxis.AxisY.IsStartedFromZero = i_Area.AxisY.IsStartedFromZero;
            areaAxis.AxisY.LabelStyle.Font = i_Area.AxisY.LabelStyle.Font;

            // Adjust area position
            areaAxis.Position.X -= i_AxisOffset;
            areaAxis.InnerPlotPosition.X += i_LabelsSize;

        }
        #endregion
    }
}
