using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assigment_2_Charts
{
    public partial class AlternativePieChart : Form
    {
        public AlternativePieChart()
        {
            InitializeComponent();
        }

        private void CreatePieChartButton_Click(object sender, EventArgs e)
        {
            // Get input data (list of numbers)
            double[] data = { 10, 20, 10,30,40,50 };

            // Create a Chart
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            // Create a ChartArea
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Create a Series
            Series series = new Series();
            chart.Series.Add(series);
            series.ChartType = SeriesChartType.Pie;

            // Assign data to the Series
            series.Points.DataBindY(data);

            // Define custom colors for the chart slices
            Color[] colors = { Color.Red, Color.Blue, Color.Green };
            for (int i = 0; i < data.Length; i++)
            {
                DataPoint point = series.Points[i];
                point.Color = colors[i];
                point.LegendText = $"Slice {i + 1}: {data[i]}";
            }

            // Add the Chart to the form
            this.Controls.Add(chart);

            // Add a legend to the chart
            Legend legend = new Legend();
            chart.Legends.Add(legend);

            // Set the legend to be displayed outside the chart
            legend.Docking = Docking.Right;

            // Refresh the chart
            chart.Invalidate();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Define your data here, for example:
            double[] data = { 30, 20, 15, 10, 25 };

            // Clear existing data from the chart
            chart1.Series.Clear();
            chart1.Legends.Clear();

            // Create a new series
            Series series = new Series();
            chart1.Series.Add(series);
            series.ChartType = SeriesChartType.Pie;

            // Assign data to the series
            series.Points.DataBindY(data);

            // Customize the chart appearance
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange };
            for (int i = 0; i < data.Length; i++)
            {
                DataPoint point = series.Points[i];
                point.Color = colors[i];
                point.LegendText = $"Slice {i + 1}: {data[i]}";
            }

            // Add a legend to the chart
            Legend legend = new Legend();
            chart1.Legends.Add(legend);

            // Set the legend to be displayed outside the chart
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;

            // Refresh the chart
            chart1.Invalidate();
        }
    }
}
