using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Diagramma
{
    public partial class MyDiagramma : Form
    {
        private List<List<KeyValuePair<string, double>>> chartData = new();
        private List<string> chartNazv = new();

        public MyDiagramma()
        {
            InitializeComponent();
            AutoLoadData();
            LBAdd();
            
        }

        private void AutoLoadData()
        {
            string filePath = @"C:\Users\User\Desktop\Diagramma\Diagramma\Diagramma\bin\Debug\data.csv";
            if (File.Exists(filePath))
            {
                chartData = LoadDataFromCsv(filePath);

                for (int i = 0; i < 6; i++)
                {
                    if (Controls.Find($"chart{i + 1}", true).FirstOrDefault() is Chart chart && i < chartData.Count)
                    {
                        ZapolnChart(chart, chartData[i], chartNazv[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден!");
            }
        }
        

        private void LBAdd()
        {
            LB.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                LB.Items.Add($"Диаграмма {i + 1}");
            }
            LB.SelectionMode = SelectionMode.MultiExtended;
        }

        private List<List<KeyValuePair<string, double>>> LoadDataFromCsv(string filePath)
        {
            List<List<KeyValuePair<string, double>>> data = new List<List<KeyValuePair<string, double>>>();
            List<string> titles = new List<string>();

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                titles.Add(parts[0]);

                List<KeyValuePair<string, double>> chartData = new List<KeyValuePair<string, double>>()
                {
                    new("HCO3-", double.Parse(parts[1])),
                    new("Cl-", double.Parse(parts[2])),
                    new("Ca2+", double.Parse(parts[3])),
                    new("Mg2+", double.Parse(parts[4])),
                    new("Другие элементы", double.Parse(parts[5]))
                };

                data.Add(chartData);
            }

            chartNazv = titles;
            return data;
        }

        private void ZapolnChart(Chart chart, List<KeyValuePair<string, double>> data, string title)
        {
            chart.Series.Clear();
            Series series = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            foreach (KeyValuePair<string, double> item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
            series["PieStartAngle"] = "180";
            chart.Series.Add(series);
            chart.Titles.Clear();
            chart.Titles.Add(title);
        }


        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (LB.SelectedIndices.Count > 0)
            {
                List<int> selectedIndices = LB.SelectedIndices.Cast<int>().ToList();

                for (int i = 0; i < 6; i++)
                {
                    if (Controls.Find($"chart{i + 1}", true).FirstOrDefault() is Chart chart)
                    {
                        if (selectedIndices.Contains(i))
                        {
                            ZapolnChart(chart, chartData[i], chartNazv[i]);
                            chart.BringToFront();
                            chart.Visible = true;
                        }
                        else
                        {
                            chart.Visible = false;
                        }
                    }
                }

                if (LB.SelectedIndices.Count == 1)
                {
                    if (Controls.Find($"chart{selectedIndices[0] + 1}", true).FirstOrDefault() is Chart chart)
                    {
                        ZapolnChart(chart, chartData[selectedIndices[0]], chartNazv[selectedIndices[0]]);
                        chart.BringToFront();
                        chart.Visible = true;
                    }
                }
            }
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (Controls.Find($"chart{i + 1}", true).FirstOrDefault() is Chart chart)
                {
                    chart.Visible = true;
                    chart.BringToFront();
                }
            }
        }
    }
}
