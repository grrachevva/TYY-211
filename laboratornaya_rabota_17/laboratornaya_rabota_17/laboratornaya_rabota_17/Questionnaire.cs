using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace wword
{
    public partial class Questionnaire : Form
    {
        private string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "������.docx");

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

                AddParagraph(doc, "������", 16, true, Word.WdParagraphAlignment.wdAlignParagraphCenter);
                AddParagraph(doc, "��������� ��� ������ �� ������", 14, false, Word.WdParagraphAlignment.wdAlignParagraphCenter);

                Word.Table fioTable = doc.Tables.Add(doc.Paragraphs.Add().Range, 1, 2);
                FormatTable(fioTable);

                fioTable.Cell(1, 1).Range.Text = $"�������: {txtLastName.Text}\n���: {txtFirstName.Text}\n��������: {txtMiddleName.Text}";
                fioTable.Cell(1, 2).Range.Text = "����";
                AddImageToTable(fioTable, 1, 2, pbPhoto.Image);

                AddParagraph(doc, "������ ������:", 14, true, Word.WdParagraphAlignment.wdAlignParagraphLeft);

                Word.Table personalDataTable = doc.Tables.Add(doc.Paragraphs.Add().Range, 10, 2);
                FormatTable(personalDataTable);

                AddRow(personalDataTable, 1, "���� ��������", dtpBirthDate.Value.ToShortDateString());
                AddRow(personalDataTable, 2, "����� ��������", txtBirthPlace.Text);
                AddRow(personalDataTable, 3, "����� �����������", txtRegistrationAddress.Text);
                AddRow(personalDataTable, 4, "����� ����������", txtLivingAddress.Text);
                AddRow(personalDataTable, 5, "�������", $"��������: {txtDomphone.Text}, ���������: {txtMobPhone.Text}");
                AddRow(personalDataTable, 6, "�������", $"�����: {txtPasportVydan.Text}, ���� ������: {datetimeDataVydachi.Value.ToShortDateString()}");
                AddRow(personalDataTable, 7, "���", txtINN.Text);
                AddRow(personalDataTable, 8, "���������������", rbMilitaryYes.Checked ? "��" : "���");
                AddRow(personalDataTable, 9, "������/�� ������", slyzhilRadioBtn.Checked ? "������" : "�� ������");
                AddRow(personalDataTable, 10, "������� ��������", otstEst.Checked ? "����" : "���");

                AddSimpleParagraph(doc, $"�������� ���������: {txtSemPolozh.Text}");
                AddSimpleParagraph(doc, $"��������� ��������: {txtHealth.Text}");
                AddSimpleParagraph(doc, $"����������� �� ��������: {txtOgrPoZd.Text}");
                AddSimpleParagraph(doc, $"������� ������� ����������: {txtLichTr.Text}");
                AddSimpleParagraph(doc, $"���������: {txtPosition.Text}");
                AddSimpleParagraph(doc, $"���������� ��������: {txtSalaryExpectation.Text}");
                AddSimpleParagraph(doc, $"����� ���������� � ������: {dateTimePristKRab.Value.ToShortDateString()}");
                AddSimpleParagraph(doc, $"�����������: {tbEducation.Text}");

                doc.SaveAs2(savePath);
                doc.Close();
                wordApp.Quit();

                MessageBox.Show($"������ ��������� �� ������� �����: {savePath}", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
