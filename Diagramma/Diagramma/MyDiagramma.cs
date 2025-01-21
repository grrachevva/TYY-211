using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ChartData = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, double>>;
using ChartDataSet = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, double>>>;
using ChartInfo = (char chart, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, double>> data, string title);

namespace Diagramma
{
    public partial class MyDiagramma : Form
    {
        ChartDataSet chartData = new();
        List<string> chartNazv = new();

        public MyDiagramma()
        {
            InitializeComponent();
            LBAdd();
            AutoLoadData();
        }

        private void AutoLoadData()
        {
            string filePath = @"C:\Users\User\Desktop\Diagramma\Diagramma\Diagramma\bin\Debug\data.csv";

            if (File.Exists(filePath))
            {
                chartData = LoadDataFromCsv(filePath);

                for (int i = 0; i < 6; i++)  
                {
                    Chart? chart = (Chart)Controls.Find($"chart{i + 1}", true).FirstOrDefault(); 
                    if (chart != null && i < chartData.Count)
                    {
                        ZapolnChart(chart, chartData[i], chartNazv[i]);
                    }
                }
            }
            else 
            {
                MessageBox.Show("���� �� ������!");
            }
        }

        private void LBAdd() 
        {
            LB.Items.Clear(); 
            for (int i = 0; i < 6; i++) 
            {
                LB.Items.Add($"��������� {i + 1}");
            }
            LB.SelectionMode = SelectionMode.MultiExtended; 
        }

        private ChartDataSet LoadDataFromCsv(string filePath) //��������� ������ �� ����� csv
        {
            ChartDataSet data = GetData(); //������ ��������
            List<string> titles = NewMethod();//�������� ��������
            string[] lines = File.ReadAllLines(filePath);//���������� ���� ����� �����
            foreach (string line in lines)//���������� ������
            {
                string[] parts = line.Split(',');//��������� �� ����� (�� ���� ��������)
                titles.Add(parts[0]);//������ �����(� ����� ��� ���������) ��������� � ��������� � ��������� 
                ChartData chartData = GetChartData(parts);

                data.Add(chartData); //��������� ���� ������ � ����� ������
            }

            chartNazv = titles; //����������� ���������
            return data;
        }

        private static ChartData GetChartData(string[] parts)
        {
            return new List<KeyValuePair<string, double>>()//������ ��� ������ ��������(��� ��� ��������, �� ���� ����� ���� �� ��������� �� ��� ��������)
                {
                    new KeyValuePair<string, double>("HCO3-", double.Parse(parts[1])),
                    new KeyValuePair<string, double>("Cl-", double.Parse(parts[2])),
                    new KeyValuePair<string, double>("Ca2+", double.Parse(parts[3])),
                    new KeyValuePair<string, double>("Mg2+", double.Parse(parts[4])),
                    new KeyValuePair<string, double>("������ ��������", double.Parse(parts[5]))
                };
        }

        private static List<string> NewMethod()
        {
            return new List<string>();
        }

        private static ChartDataSet GetData()
        {
            return new List<List<KeyValuePair<string, double>>>();
        }

        private void ZapolnChart(Chart chart, ChartData data, string title)//��������� ��������� �������
        {
            chart.Series.Clear();//������� ��� ����� ���������
            Series series = new Series//������� ����� �����
            {
                ChartType = SeriesChartType.Pie,//��, ��� �������� ���������
                IsValueShownAsLabel = true//�������� ����� ������������ � ���� ����� �� �����
            };

            for (int i = 0; i < data.Count; i++)//���������� �������� ������, ����� ������ ��������� ���� ��������� 
            {
                series.Points.AddXY(data[i].Key, data[i].Value);//��������� ����� ������
            }
            series["PieStartAngle"] = "180"; //������, ��� ��������� ���� - 180 �������� ����
            chart.Series.Add(series); //��������� ������
            chart.Titles.Clear(); //��������� �������
            chart.Titles.Add(title); //��������� �����
        }


        private void ChangeBtn_Click_1(object sender, EventArgs e) //�������� ������������ ���������
        {
            if (LB.SelectedIndices.Count > 0) //���� �������� � ��������� �������
            {
                List<int> selectedIndices = LB.SelectedIndices.Cast<int>().ToList(); //�������� ������� ���������, ������� �������

                for (int i = 0; i < 6; i++) //���������� ��� ���������
                {
                   
                    if (Controls.Find($"chart{i + 1}", true).FirstOrDefault() is Chart chart) //���� ��������� �����
                    {
                        if (selectedIndices.Contains(i)) // � ���� ������ ���������� � ���������
                        {
                            ZapolnChart(chart, chartData[i], chartNazv[i]); //�� ��������� ������� 
                            chart.BringToFront(); // � ������� �� ������ 
                            chart.Visible = true; //� ����� �� ���� �����
                        }
                        else //����� - ������ �� ���������
                        {
                            chart.Visible = false;
                        }
                    }
                }

                if (LB.SelectedIndices.Count == 1) //���� ������ ������ 1 �������
                {
                    Chart? chart = (Chart)Controls.Find($"chart{selectedIndices[0] + 1}", true).FirstOrDefault(); //���� ���������������
                    if (chart != null) //���� ��������� �������
                    {
                        ZapolnChart(chart, chartData[selectedIndices[0]], chartNazv[selectedIndices[0]]); //��������� ��
                        chart.BringToFront();//������� ������
                        chart.Visible = true; //������ �������
                    }
                }
            }
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++) //���������� ��� ���������
            {
                if (Controls.Find($"chart{i + 1}", true).FirstOrDefault() is Chart chart)//���� ��������� �������
                {
                    chart.Visible = true;//������ ��������
                    chart.BringToFront();//� ������� ������
                }
            }
        }
    }
}
