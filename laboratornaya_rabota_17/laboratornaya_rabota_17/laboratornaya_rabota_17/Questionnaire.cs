using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace wword
{
    public partial class Questionnaire : Form
    {
        private string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Анкета.docx");

        public Questionnaire()
        {
            InitializeComponent();
        }

        private void AddParagraph(Word.Document doc, string text, int fontSize, bool isBold, Word.WdParagraphAlignment alignment)
        {
            Word.Paragraph paragraph = doc.Paragraphs.Add();
            paragraph.Range.Text = text;
            paragraph.Range.Font.Size = fontSize;
            paragraph.Range.Font.Bold = isBold ? 1 : 0;
            paragraph.Alignment = alignment;
            paragraph.Range.InsertParagraphAfter();
        }

        private void AddSimpleParagraph(Word.Document doc, string text)
        {
            AddParagraph(doc, text, 12, false, Word.WdParagraphAlignment.wdAlignParagraphLeft);
        }

        private void AddRow(Word.Table table, int row, string label, string value)
        {
            table.Cell(row, 1).Range.Text = label;
            table.Cell(row, 2).Range.Text = value;
        }

        private void FormatTable(Word.Table table)
        {
            table.Borders.Enable = 1;
            table.Range.Font.Size = 12;
            table.Range.Font.Name = "Times New Roman";
        }

        private void AddImageToTable(Word.Table table, int row, int column, Image image)
        {
            if (image == null) return;

            string tempPath = Path.Combine(Path.GetTempPath(), "tempImage.jpg");
            image.Save(tempPath);

            Word.Range cellRange = table.Cell(row, column).Range;
            cellRange.InlineShapes.AddPicture(tempPath);
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnGenerateWord_Click_1(object sender, EventArgs e)
        {
            try
            {
                Word.Application wordApp = new Word.Application();
                Word.Document doc = wordApp.Documents.Add();

                AddParagraph(doc, "АНКЕТА", 16, true, Word.WdParagraphAlignment.wdAlignParagraphCenter);
                AddParagraph(doc, "кандидата для приема на работу", 14, false, Word.WdParagraphAlignment.wdAlignParagraphCenter);

                Word.Table fioTable = doc.Tables.Add(doc.Paragraphs.Add().Range, 1, 2);
                FormatTable(fioTable);

                fioTable.Cell(1, 1).Range.Text = $"Фамилия: {txtLastName.Text}\nИмя: {txtFirstName.Text}\nОтчество: {txtMiddleName.Text}";
                fioTable.Cell(1, 2).Range.Text = "Фото";
                AddImageToTable(fioTable, 1, 2, pbPhoto.Image);

                AddParagraph(doc, "Личные данные:", 14, true, Word.WdParagraphAlignment.wdAlignParagraphLeft);

                Word.Table personalDataTable = doc.Tables.Add(doc.Paragraphs.Add().Range, 10, 2);
                FormatTable(personalDataTable);

                AddRow(personalDataTable, 1, "Дата рождения", dtpBirthDate.Value.ToShortDateString());
                AddRow(personalDataTable, 2, "Место рождения", txtBirthPlace.Text);
                AddRow(personalDataTable, 3, "Адрес регистрации", txtRegistrationAddress.Text);
                AddRow(personalDataTable, 4, "Адрес проживания", txtLivingAddress.Text);
                AddRow(personalDataTable, 5, "Телефон", $"Домашний: {txtDomphone.Text}, Мобильный: {txtMobPhone.Text}");
                AddRow(personalDataTable, 6, "Паспорт", $"Выдан: {txtPasportVydan.Text}, Дата выдачи: {datetimeDataVydachi.Value.ToShortDateString()}");
                AddRow(personalDataTable, 7, "ИНН", txtINN.Text);
                AddRow(personalDataTable, 8, "Военнообязанный", rbMilitaryYes.Checked ? "Да" : "Нет");
                AddRow(personalDataTable, 9, "Служил/не служил", slyzhilRadioBtn.Checked ? "Служил" : "Не служил");
                AddRow(personalDataTable, 10, "Наличие отсрочки", otstEst.Checked ? "Есть" : "Нет");

                AddSimpleParagraph(doc, $"Семейное положение: {txtSemPolozh.Text}");
                AddSimpleParagraph(doc, $"Состояние здоровья: {txtHealth.Text}");
                AddSimpleParagraph(doc, $"Ограничения по здоровью: {txtOgrPoZd.Text}");
                AddSimpleParagraph(doc, $"Наличие личного транспорта: {txtLichTr.Text}");
                AddSimpleParagraph(doc, $"Должность: {txtPosition.Text}");
                AddSimpleParagraph(doc, $"Зарплатные ожидания: {txtSalaryExpectation.Text}");
                AddSimpleParagraph(doc, $"Когда приступить к работе: {dateTimePristKRab.Value.ToShortDateString()}");
                AddSimpleParagraph(doc, $"Образование: {tbEducation.Text}");

                doc.SaveAs2(savePath);
                doc.Close();
                wordApp.Quit();

                MessageBox.Show($"Анкета сохранена на рабочем столе: {savePath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
