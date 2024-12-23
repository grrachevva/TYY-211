using System.Diagnostics;
using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Linq;

namespace MyExcel
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            string[] data = File.ReadAllText("DefaultData.csv").Split(',');
            for (int i = 0; i < data.Length; i += 9)
                dataGridViewPreview.Rows.Add(data.Skip(i).Take(i + 9).ToArray());
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            app.Visible = false;

            Excel.Workbook book = app.Workbooks.Add();
            Excel.Worksheet sheet = book.ActiveSheet;

            sheet.Columns[1].ColumnWidth = 10;
            sheet.Columns[2].ColumnWidth = 9;
            sheet.Columns[9].ColumnWidth = 8;
            sheet.Columns[10].ColumnWidth = 10;

            sheet.Cells[1, 1] = "Дата состав-\nления";
            sheet.Cells[1, 2] = "Код\nвида\nоперации";
            sheet.Cells[1, 3] = "Отправитель";
            sheet.Cells[1, 5] = "Получатель";
            sheet.Cells[1, 7] = "Ответственный за поставку";

            sheet.Cells[2, 3] = "структурное\nподразделение";
            sheet.Cells[2, 4] = "вид\nдеятельности";
            sheet.Cells[2, 5] = "структурное\nподразделение";
            sheet.Cells[2, 6] = "вид\nдеятельности";
            sheet.Cells[2, 7] = "структурное\nподразделение";
            sheet.Cells[2, 8] = "вид\nдеятельности";
            sheet.Cells[2, 9] = "код испол-\nнителя";
            

            sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 1), ExcelExtension.ExcelHelpers.ExcelCellTranslator(2, 1)].Merge();
            sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 2), ExcelExtension.ExcelHelpers.ExcelCellTranslator(2, 2)].Merge();
            sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 3), ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 4)].Merge();
            sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 5), ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 6)].Merge();
            sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 7), ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 9)].Merge();

            Excel.Range cells = sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 1), ExcelExtension.ExcelHelpers.ExcelCellTranslator(4, 10)];
            cells.WrapText = true;

            Excel.Range rows;

            rows = sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 1), ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 9)];
            rows.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;

            rows = sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 1), ExcelExtension.ExcelHelpers.ExcelCellTranslator(1, 9)];
            rows.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

            rows = sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(2, 1), ExcelExtension.ExcelHelpers.ExcelCellTranslator(2, 9)];
            rows.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            rows.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThick;

            rows = sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(3, 1), ExcelExtension.ExcelHelpers.ExcelCellTranslator(3, 9)];
            rows.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            rows.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThick;

            rows = sheet.Range[ExcelExtension.ExcelHelpers.ExcelCellTranslator(4, 1), ExcelExtension.ExcelHelpers.ExcelCellTranslator(4, 9)];
            rows.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            rows.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThick;

            Excel.Range cols;

            foreach (int col in new int[] { 1, 2, 3, 5, 7, 10 })
            {
                cols = sheet.Range[sheet.Cells[1, col], sheet.Cells[4, col]];
                cols.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
            }

            foreach (int col in new int[] { 4, 6, 8, 9 })
            {
                cols = sheet.Range[sheet.Cells[1, col], sheet.Cells[4, col]];
                cols.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            }

            int[] cols_to_fix = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int col in cols_to_fix)
            {
                Excel.Range fix = sheet.Range[sheet.Cells[1, col], sheet.Cells[4, col]];
                fix.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                fix.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            }

            string[] data = File.ReadAllText("DefaultData.csv").Split(',');
            for (int i = 0; i < data.Length; i++)
            {
                sheet.Cells[3 + i / 9, 1 + i % 9] = data[i];
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Грачева Н.С. Вариант№5.xlsx";
            book.SaveAs(path);
            book.Close();
            app.Quit();

            Process.Start(new ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true
            });
        }
        
    }
}
