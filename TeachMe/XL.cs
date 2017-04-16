using System;
using Microsoft.Office.Interop.Excel;

namespace TeachMe
{
    class XL
    {
        Application xlApp;
        Workbook wb;
        Worksheet ws;
        Object misValue = System.Reflection.Missing.Value;
        static int totalwords = 0;
        public XL(string File)
        {
            xlApp = new Application();
            if (!isXlExist(File))
            {
                CreateNewExcel(File);
            }
            else
            {
                wb = xlApp.Workbooks.Open(File, Type.Missing, ReadOnly: false);
                ws = (Worksheet)wb.Worksheets.get_Item(1);
            }
            int i = 1;
            while ((string)(ws.Cells[i, 1] as Range).Value != null)
            {
                totalwords++;
                i++;
            }
        }

        private bool isXlExist(string FileName)
        {
            
            if (System.IO.File.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), FileName)))
            {
                return true;
            }
            return false;
        }

        private void CreateNewExcel(string FileName)
        {
            wb = xlApp.Workbooks.Add(misValue);
            wb.SaveAs(FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            wb = xlApp.Workbooks.Open(FileName, Type.Missing, ReadOnly: false);
            ws = (Worksheet)wb.Worksheets.get_Item(1);
            ws.Name = "Words";

        }
        public void ReleaseObjects()
        {
            wb.Save();
            wb.Close(misValue, misValue);
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ws);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            ws = null;
            wb = null;
            xlApp = null;
            GC.Collect();
        }

        public void AddWord(string word, string def)
        {
            ws.Cells[totalwords + 1, 1] = word;
            ws.Cells[totalwords + 1, 2] = def;
            ws.Cells[totalwords + 1, 3] = "TEST";
            totalwords++;
            wb.Save();
        }

        public string[,] GetListForTest(int numOfWords)
        {
            int totalWordsToTest = 0;
            for (int i = 1; i < totalwords+1; i++)
			{
                if ((string)(ws.Cells[i, 3] as Range).Value == "TEST")
	            {
		            totalWordsToTest++;
	            }			 
			}
            int maxNumberOfWords = (numOfWords < totalWordsToTest) ? numOfWords : totalWordsToTest;
            string[,] list = new string[maxNumberOfWords, 2];
            int index = 0;
            for (int i = 1; i < totalwords + 1; i++)
            {
                if ((string)(ws.Cells[i, 3] as Range).Value == "TEST")
                {
                    list[index, 0] = (string)(ws.Cells[i, 1] as Range).Value;
                    list[index, 1] = (string)(ws.Cells[i, 2] as Range).Value;
                    if (index + 1 == maxNumberOfWords)
                    {
                        i = totalwords + 1;
                    }
                    else { index++; }
                }
            }
            return list;
        }

        public string[,] GetListForRevertTest(int numOfWords)
        {
            int totalWordsToTest = 0;
            for (int i = 1; i < totalwords+1; i++)
			{
                if ((string)(ws.Cells[i, 3] as Range).Value == "TEST")
	            {
		            totalWordsToTest++;
	            }			 
			}
            int maxNumberOfWords = (numOfWords < totalWordsToTest) ? numOfWords : totalWordsToTest;
            string[,] list = new string[maxNumberOfWords, 2];
            int index = 0;
            for (int i = 1; i < totalwords + 1; i++)
            {
                if ((string)(ws.Cells[i, 3] as Range).Value == "TEST")
                {
                    list[index, 0] = (string)(ws.Cells[i, 2] as Range).Value;
                    list[index, 1] = (string)(ws.Cells[i, 1] as Range).Value;
                    if (index + 1 == maxNumberOfWords)
                    {
                        i = totalwords + 1;
                    }
                    else { index++; }
                }
            }
            return list;
        }
        public void DeleteWord(string word)
        {
            for (int i = 1; i < totalwords+1; i++)
            {
                if ((string)(ws.Cells[i, 1] as Range).Value == word)
	            {
                    ws.Cells[i, 3] = "non";
	            }
            }
            wb.Save();
        }
    }
}
