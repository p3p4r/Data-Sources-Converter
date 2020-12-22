using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace Project
{
    using Excel = Microsoft.Office.Interop.Excel;

    class ExcelFunctions
    {
        public string ExcelToJson(string path, bool horizontalheader)
        {
            // bool horizontalheader:
            // For Future applications: Allow to read excel with header horizontal or Vertical
            // Now By Default its horizontal header only
            var excelAplication = new Excel.Application();
            excelAplication.Visible = false;
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path2 += "/DataConverter";

            try
            {
                //var excelworkbook = excelAplication.Workbooks.Open(textBox_Excel.Text);
                var excelworkbook = excelAplication.Workbooks.Open(path);
                var excelworksheet = (Excel.Worksheet)excelworkbook.ActiveSheet;

                Boolean stop = false;
                Excel.Range range = excelworksheet.UsedRange;
                Excel.Range beginCell = range.Cells[1, 1];
                Excel.Range endCell = range.Cells[range.Rows.Count, range.Columns.Count];

                if (!beginCell.HasFormula)
                {
                    var beginCellRow = range.Find(
                        "*",
                        beginCell,
                        XlFindLookIn.xlFormulas,
                        XlLookAt.xlPart,
                        XlSearchOrder.xlByRows,
                        XlSearchDirection.xlNext,
                        false);

                    var beginCellCol = range.Find(
                        "*",
                        beginCell,
                        XlFindLookIn.xlFormulas,
                        XlLookAt.xlPart,
                        XlSearchOrder.xlByColumns,
                        XlSearchDirection.xlNext,
                        false);

                    if (null == beginCellRow || null == beginCellCol)
                        stop = true;

                    beginCell = range.Worksheet.Cells[beginCellRow.Row, beginCellCol.Column];
                }

                if (!endCell.HasFormula)
                {
                    var endCellRow = range.Find(
                    "*",
                    endCell,
                    XlFindLookIn.xlFormulas,
                    XlLookAt.xlPart,
                    XlSearchOrder.xlByRows,
                    XlSearchDirection.xlPrevious,
                    false);

                    var endCellCol = range.Find(
                        "*",
                        endCell,
                        XlFindLookIn.xlFormulas,
                        XlLookAt.xlPart,
                        XlSearchOrder.xlByColumns,
                        XlSearchDirection.xlPrevious,
                        false);

                    if (endCellRow == null || endCellCol == null)
                        stop = true;

                    endCell = range.Worksheet.Cells[endCellRow.Row, endCellCol.Column];
                }

                if (endCell == null || beginCell == null)
                    stop = true;

                if (!stop)
                {
                    Excel.Range finalRng = range.Worksheet.Range[beginCell, endCell];

                    int endRow = endCell.Row;
                    int endCol = endCell.Column;

                    int beginRow = beginCell.Row;
                    int beginCol = beginCell.Column;
                    string fileJSN = "";
                    //Boolean ctrl = false; 
                    Boolean flag = true;


                    for (int i = beginRow; i < endRow; i++)
                    {
                        Dictionary<string, string> js = new Dictionary<string, string>();
                        for (int j = beginCol; j < endCol; j++)
                        {
                            if (range.Cells[i, j] == null || range.Cells[i, j].Value == null)
                                js.Add(range.Cells[1, j].Value.ToString(), " ");
                            else
                                js.Add(range.Cells[1, j].Value.ToString(), range.Cells[i, j].Value.ToString());
                        }

                        if (i == endRow - 1)
                            fileJSN += JsonConvert.SerializeObject(js);
                        else
                            fileJSN += JsonConvert.SerializeObject(js) + ",";
                    }

                    
                    //System.IO.File.WriteAllText(path + "/result" + DateTime.Now.ToString(@"MM\_dd\_yyyy_h\_mm") + ".txt", fileJSN);

                    return fileJSN;
                    Marshal.ReleaseComObject(range);
                    RealeaseCOMObjects(excelworkbook);
                    RealeaseCOMObjects(excelAplication);
                }
                else
                    MessageBox.Show("Please insert a Valid Excel: " + path + "is not valid");
            }
            catch (Exception ex)
            {
                RealeaseCOMObjects(excelAplication);
                MessageBox.Show(ex.Message.ToString());
                MessageBox.Show("Please insert a Valid Excel Exception: '" + ex.Message + "'");
            }
            return null;
        }
    
        private static void RealeaseCOMObjects(object obj)
        {

            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception exception) //confirar esta variavel 
            {
                obj = null;
                System.Diagnostics.Debug.WriteLine("EException ocorred while releasing obj");
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
