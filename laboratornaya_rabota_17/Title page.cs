using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using wword;


namespace laboratornaya_rabota_17
{

    public partial class TitlePage : Form
    {
        object ObjMissing = Missing.Value;
        private string[] typeOfReportingDocument = { "Отчёт", "Реферат", "Эссе", "Курсовой проект",
            "Курсовая работа", "Доклад", "Домашнее задание"};
        private string[] typeOfWork = { "Лабораторная работа", "Практическая работа", "Индивидуальное задание",
            "Учебная практика", "Производственная практика", "Преддипломная практика"};
        private string[] numberOfWork = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        private string selectedDocument;
        public TitlePage()
        {
            InitializeComponent();
            reportingDocument.Items.AddRange(typeOfReportingDocument);
            workType.Items.AddRange(typeOfWork);
            number.Items.AddRange(numberOfWork);

        }
        private void createATitlePage_Click(object sender, EventArgs e)
        {

            Word.Application wordApp = new Word.Application();
            Word.Document oDoc;
            Word.Paragraph oPr;
            Word.Application oWord = new Word.Application();
            oDoc = oWord.Documents.Add();
            oPr = oDoc.Paragraphs.Add();

            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Министерство транспорта Российской Федерации";
            oPr.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Федеральное государственное автономное образовательное";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "учреждение высшего образования";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "«Российский университет транспорта»";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "(ФГАОУ ВО РУТ(МИИТ), РУТ (МИИТ)";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Институт транспортной техники и систем управления";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Кафедра «Управление и защита информации»";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";
            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";
            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";
            oPr.Range.Text = "";
            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 28;
            oPr.Range.Text = (reportingDocument.SelectedIndex >= 0 ? reportingDocument.Text : workType.Text) + " №" + number.Text;

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = $"по дисциплине: «{nameOfTheDiscipline.Text}»";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = $"на тему: «{topicOfWork.Text}»";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";
            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";
            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";
            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";
            oPr.Range.Text = "";
            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Выполнил: ст. гр. ТУУ-211";
            oPr.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Грачева Н.С.";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Вариант №5";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = $"Проверил: {teacher.Text}";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";
            oPr.Range.Text = "";
            oPr.Range.InsertParagraphAfter();
            oPr.Range.Text = "";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Москва – 2024 г.";
            oPr.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            oDoc.SaveAs2(Application.StartupPath + "\\Титульный лист.docx");
            oWord.Quit();
        }

        private void btnQuestionnaire_Click(object sender, EventArgs e)
        {
            FormQuestionnaire form2 = new FormQuestionnaire(); 
            form2.Show();             
            this.Hide();
        }
    }
}