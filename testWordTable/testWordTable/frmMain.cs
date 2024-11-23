using System;
using System.IO;
using System.Windows.Forms;
using W = Microsoft.Office.Interop.Word;

namespace testWordTable
{
    public partial class frmMain : Form
    {
        public frmMain() => InitializeComponent();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dlgOpen.InitialDirectory = Application.StartupPath;
            dlgOpen.Filter = "MS Word|*.docx|Все|*.*";
            dlgOpen.Title = "Выберите список трудов...";
            dlgOpen.ShowDialog();
        }

        private void dlgOpen_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string path;

            if (!e.Cancel)
            {
                path = (sender as OpenFileDialog).FileName;
                wordCore(path);
            }
        }

        private void wordCore(string path)
        {
            W.Application oWord;
            W.Document oDoc;
            int counter = 0;

            oWord = new W.Application();
            oDoc = oWord.Documents.Open(path);

            foreach (W.Table oTab in oDoc.Tables)
            {
                if (oTab.Columns.Count == 6)
                {
                    if (counter == 0)
                    {
                        dgMain.Rows.Clear();
                        dgMain.Columns.Clear();
                        for (int i = 0; i < oTab.Columns.Count; i++)
                            dgMain.Columns.Add("col" + (i + 1),
                                oTab.Cell(1, i + 1).Range.Text.TrimEnd(new char[] { '\r', '\a' }));
                    }
                    dgMain.Rows.Add(oTab.Rows.Count - 1);
                    for (int i = 1; i < oTab.Rows.Count; i++)
                        for (int j = 0; j < oTab.Columns.Count; j++)
                        {
                            if (!dgMain.Columns[j].HeaderText.Equals(
                                oTab.Cell(i + 1, j + 1).Range.Text.TrimEnd(new char[] { '\r', '\a' })))
                            {
                                dgMain[j, counter + i - 1].Value =
                                    oTab.Cell(i + 1, j + 1).Range.Text.TrimEnd(new char[] { '\r', '\a' });
                            }
                            else
                            {
                                counter--;
                                break;
                            }
                        }
                    counter += oTab.Rows.Count - 1;
                }
            }
            oWord.Quit();
        }

        private void CustomizedParagraph(ref W.Paragraph fPr, 
            string fText, int fBold = 0,
            W.WdColor fColor = W.WdColor.wdColorBlack, 
            string fFntName = "Times New Roman", 
            W.WdParagraphAlignment fAlign = 
                W.WdParagraphAlignment.wdAlignParagraphJustify)
        {
            fPr.Range.Font.Bold = fBold;
            fPr.Range.Font.Color = fColor;
            fPr.Range.Font.Name = fFntName;
            fPr.Range.Text = fText;
            fPr.Alignment = fAlign;
        }

        private void pageCfg(ref W.Document fDoc, float fLeft, 
            float fRigth, float fTop, float fBottom)
        {
            fDoc.PageSetup.LeftMargin = 
                fDoc.Application.CentimetersToPoints(fLeft);
            fDoc.PageSetup.RightMargin = 
                fDoc.Application.CentimetersToPoints(fRigth);
            fDoc.PageSetup.TopMargin = 
                fDoc.Application.CentimetersToPoints(fTop);
            fDoc.PageSetup.BottomMargin = 
                fDoc.Application.CentimetersToPoints(fBottom);
        }

        private void ParagraphDemo()
        {
            W.Application oWord;
            W.Document oDoc;
            W.Paragraph oPr;

            oWord = new W.Application();
            oDoc = oWord.Documents.Add();
            oPr = oDoc.Paragraphs.Add();

            CustomizedParagraph(ref oPr, "Новый текст", 1, W.WdColor.wdColorRed,
                "Tahoma", W.WdParagraphAlignment.wdAlignParagraphCenter);
            oPr.Range.InsertParagraphAfter();
            CustomizedParagraph(ref oPr, "Следующий абзац", 1, W.WdColor.wdColorDarkGreen,
                "Book Antiqua", W.WdParagraphAlignment.wdAlignParagraphLeft);
            oPr.Range.InsertParagraphAfter();
            CustomizedParagraph(ref oPr, "Ещё один абзац", fAlign: W.WdParagraphAlignment.wdAlignParagraphRight);
            oPr.Range.InsertParagraphAfter();
            CustomizedParagraph(ref oPr, "И ещё один", 1, fFntName: "Comic Sans MS");
            oDoc.SaveAs2(Application.StartupPath + "\\Новый документ.docx");
            oWord.Quit();
        }

        private void PageSetUpDemo()
        {
            try
            {
                W.Application oWord;
                W.Document oDoc;

                oWord = new W.Application();
                oDoc = oWord.Documents.Add();

                pageCfg(ref oDoc, 5f, 6f, 3f, 4f);

                oDoc.SaveAs2(Application.StartupPath + "\\Новый документ.docx");
                oWord.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла следующая ошибка: {ex.ToString()}", "ОШИБКА!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TabStopsDemo()
        {
            W.Application oWord;
            W.Document oDoc;
            W.Paragraph oPr;

            oWord = new W.Application();
            oDoc = oWord.Documents.Add();
            oPr = oDoc.Paragraphs.Add();

            oPr.Range.Text = "Заведующий каф. \"УиЗИ\"\tЛ.А. Баранов";
            oPr.TabStops.Add(oWord.CentimetersToPoints(16.5f),
                W.WdTabAlignment.wdAlignTabList,
                W.WdTabLeader.wdTabLeaderLines);

            oDoc.SaveAs2(Application.StartupPath + "\\Новый документ.docx");
            oWord.Quit();
        }

        private void ToFillGrid()
        {
            string tmpStr;
            string[] Record;
            int counter = 0;
            StreamReader sr = new StreamReader(Application.StartupPath + "\\articles.csv");

            dgMain.Rows.Clear();
            dgMain.Columns.Clear();
            while ((tmpStr = sr.ReadLine()) != null)
            {
                Record = tmpStr.Split(new char[] { ';' });
                if (counter == 0)
                {
                    for (int i = 0; i < Record.Length; i++)
                        dgMain.Columns.Add("col" + i, Record[i]);
                }
                else
                {
                    dgMain.Rows.Add();
                    for (int i = 0; i < Record.Length; i++)
                        dgMain[i, counter - 1].Value = Record[i];
                }
                counter++;
            }

            sr.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            W.Application oWord;
            W.Document oDoc;
            W.Paragraph oPar;
            W.Table oTab;
            W.Cell oCell;
            float[] colWdt = new float[] { 0.99f, 5.25f, 1.5f, 5.25f, 1.5f, 2.01f };

            oWord = new W.Application();
            oDoc = oWord.Documents.Add();
            oPar = oDoc.Paragraphs.Add();

            ToFillGrid();

            oTab = oDoc.Tables.Add(oPar.Range, dgMain.RowCount, dgMain.ColumnCount);

            oTab.Borders[W.WdBorderType.wdBorderTop].Visible = true;
            oTab.Borders[W.WdBorderType.wdBorderBottom].Visible = true;
            oTab.Borders[W.WdBorderType.wdBorderLeft].Visible = true;
            oTab.Borders[W.WdBorderType.wdBorderRight].Visible = true;
            oTab.Borders[W.WdBorderType.wdBorderVertical].Visible = true;
            oTab.Borders[W.WdBorderType.wdBorderHorizontal].Visible = true;

            for (int j = 0; j < dgMain.ColumnCount; j++)
            {
                oTab.Columns[j + 1].Width = oWord.CentimetersToPoints(colWdt[j]);
                oCell = oTab.Cell(1, j + 1);
                oCell.Range.Font.Size = 10;
                oCell.Range.ParagraphFormat.Space1();
                oCell.Range.Text = dgMain.Columns[j].HeaderText;
            }

            for (int i = 0; i < dgMain.RowCount; i++)
                for (int j = 0; j < dgMain.ColumnCount; j++)
                    if (dgMain[j, i].Value != null)
                    {
                        oCell = oTab.Cell(i + 2, j + 1);
                        oCell.Range.Font.Size = 10;
                        oCell.Range.ParagraphFormat.Space1();
                        oCell.Range.Text = dgMain[j, i].Value.ToString();
                    }

            oDoc.SaveAs2(Application.StartupPath + "\\Список трудов.docx");
            oWord.Quit();
        }
    }
}
