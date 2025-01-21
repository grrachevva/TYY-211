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

        private ChartDataSet LoadDataFromCsv(string filePath) //загружаем данные из файла csv
        {
            ChartDataSet data = GetData(); //данные диаграмм
            List<string> titles = NewMethod();//названия диаграмм
            string[] lines = File.ReadAllLines(filePath);//считывание всех строк файла
            foreach (string line in lines)//перебираем строки
            {
                string[] parts = line.Split(',');//разбиваем на части (то есть запятыми)
                titles.Add(parts[0]);//первую часть(в файле это заголовок) добавляем в заголовок в диаграмме 
                ChartData chartData = GetChartData(parts);

                data.Add(chartData); //добавляем этот список в общий список
            }

            chartNazv = titles; //присваиваем заголовки
            return data;
        }

        private static ChartData GetChartData(string[] parts)
        {
            return new List<KeyValuePair<string, double>>()//список для данных диаграмм(тут это значения, то есть какой цвет на диаграмме за что отвечает)
                {
                    new KeyValuePair<string, double>("HCO3-", double.Parse(parts[1])),
                    new KeyValuePair<string, double>("Cl-", double.Parse(parts[2])),
                    new KeyValuePair<string, double>("Ca2+", double.Parse(parts[3])),
                    new KeyValuePair<string, double>("Mg2+", double.Parse(parts[4])),
                    new KeyValuePair<string, double>("Другие элементы", double.Parse(parts[5]))
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

        private void ZapolnChart(Chart chart, ChartData data, string title)//заполняем диаграммы данными
        {
            chart.Series.Clear();//очищаем все серии диаграммы
            Series series = new Series//создаем новую серию
            {
                ChartType = SeriesChartType.Pie,//то, что крутовая диаграмма
                IsValueShownAsLabel = true//значения будут отображаться в виде меток на долях
            };

            for (int i = 0; i < data.Count; i++)//перебираем элементы данных, чтобы задать начальный круг диаграммы 
            {
                series.Points.AddXY(data[i].Key, data[i].Value);//добавляем точки данных
            }
            series["PieStartAngle"] = "180"; //ставим, что начальный круг - 180 градусов верх
            chart.Series.Add(series); //добавляем данные
            chart.Titles.Clear(); //заголовки очищаем
            chart.Titles.Add(title); //добавляем новые
        }


        private void ChangeBtn_Click_1(object sender, EventArgs e) //выбираем определенную диаграмму
        {
            if (LB.SelectedIndices.Count > 0) //если элементы в листбоксе выбрали
            {
                List<int> selectedIndices = LB.SelectedIndices.Cast<int>().ToList(); //получаем индексы элементов, которые выбрали

                for (int i = 0; i < 6; i++) //перебираем все диаграммы
                {
                   
                    if (Controls.Find($"chart{i + 1}", true).FirstOrDefault() is Chart chart) //если диаграмму нашли
                    {
                        if (selectedIndices.Contains(i)) // и если индекс содержится в выбранных
                        {
                            ZapolnChart(chart, chartData[i], chartNazv[i]); //то заполняем данными 
                            chart.BringToFront(); // и выносим ее вперед 
                            chart.Visible = true; //и чтобы ее было видно
                        }
                        else //иначе - делаем ее невидимой
                        {
                            chart.Visible = false;
                        }
                    }
                }

                if (LB.SelectedIndices.Count == 1) //если выбран только 1 элемент
                {
                    Chart? chart = (Chart)Controls.Find($"chart{selectedIndices[0] + 1}", true).FirstOrDefault(); //ищем соответствующий
                    if (chart != null) //если диаграмма найдена
                    {
                        ZapolnChart(chart, chartData[selectedIndices[0]], chartNazv[selectedIndices[0]]); //заполняем ее
                        chart.BringToFront();//выносим вперед
                        chart.Visible = true; //делаем видимой
                    }
                }
            }
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++) //перебираем все диаграммы
            {
                if (Controls.Find($"chart{i + 1}", true).FirstOrDefault() is Chart chart)//если диаграммы найдены
                {
                    chart.Visible = true;//делаем видимыми
                    chart.BringToFront();//и выносим вперед
                }
            }
        }
    }
}
