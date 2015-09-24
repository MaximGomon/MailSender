using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelReader;

namespace MailSender
{
    public static class Utils
    {
        public static void ShowNotImplementedMessageBox()
        {
            MessageBox.Show(@"This function don worked now. Wait new version ;-)", @"Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static List<string> ReadMailFromExcel(string filePath)
        {
            var emails = new List<string>();
            try
            {
                if (File.Exists(filePath))
                {
                    var worsSheets = Workbook.Worksheets(filePath);
                    var firstLetter = (Worksheet)worsSheets.ElementAt(0);

                    for (int i = 1; i < firstLetter.Rows.Count(); i++)
                    {
                        var splitedItem = firstLetter.Rows[i].Cells[0].Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                        emails.Add(splitedItem.First());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return emails;
        }
    }
}
