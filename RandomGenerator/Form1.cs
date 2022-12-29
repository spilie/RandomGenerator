using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RandomGenerator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void btnCreateShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbGroupNum.Text))
            {
                MessageBox.Show("請輸入組數");
                return;
            }

            int groupNum = 0;

            if (!int.TryParse(tbGroupNum.Text, out groupNum))
            {
                MessageBox.Show("組數請輸入數字");
                return;
            }

            if (groupNum > 100 || groupNum < 1)
            {
                MessageBox.Show("組數請輸入介於1~100的數字");
                return;
            }

            int gNum = Convert.ToInt32(cbGeneratorNum.SelectedValue);

            List<string> passwordList = createPassowrd(gNum, (string)cbCaps.SelectedValue, chkIncludeSign.Checked, groupNum);

            displayForm dForm = new displayForm(passwordList);
            dForm.Show();
        }

        private List<string> createPassowrd(int generatorNum, string selectCase, bool includeSign, int groupNum)
        {
            List<string> passwordList = new List<string>();

            string enLowerCase = "abcdefghijkmnpqrstuvwxyz";
            string enUpperCase = "ABCDEFGHJKLMNPQRSTUVWXYZ";
            string numbers = "234567892345678923456789";
            string sign = "!@$?_-";

            string allowWord = string.Empty;

            switch (selectCase)
            {
                case "0":
                    allowWord += enLowerCase + enUpperCase;
                    break;
                case "1":
                    allowWord += enUpperCase;
                    break;
                case "2":
                    allowWord += enLowerCase;
                    break;
                default:
                    allowWord += enLowerCase + enUpperCase;
                    break;
            }

            allowWord += numbers;

            if (includeSign)
                allowWord += sign;

            int cursorNum = 0;
            while (cursorNum < groupNum)
            {
                char[] chars = new char[generatorNum];
                Random r = new Random(GetRandomSeed());

                for (int i = 0; i < generatorNum; i++)
                {
                    chars[i] = allowWord[r.Next(0, allowWord.Length)];
                }

                string password = new string(chars);

                if ((password.IndexOfAny(enLowerCase.ToCharArray()) == -1) && (password.IndexOfAny(enUpperCase.ToCharArray()) == -1))
                    continue;

                if (password.IndexOfAny(numbers.ToCharArray()) == -1)
                    continue;

                passwordList.Add(password);
                cursorNum++;
                r = null;
            }

            return passwordList;
        }

        private int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        private void createExcel(string filePath, List<string> passwordList)
        {
            object nothing = System.Reflection.Missing.Value;
            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(nothing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            worksheet.Name = "Passwords";

            for (int i = 0; i < passwordList.Count(); i++)
            {
                worksheet.Cells[i + 1, 1] = passwordList[i];
            }

            worksheet.SaveAs(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
            workbook.Close(false, Type.Missing, Type.Missing);
            app.Quit();

            MessageBox.Show("Excel產檔案完成");
        }

        private void init()
        {
            Dictionary<string, string> tempDic = new Dictionary<string, string>();
            tempDic.Add("6", "6");
            tempDic.Add("7", "7");
            tempDic.Add("8", "8");
            tempDic.Add("9", "9");
            tempDic.Add("10", "10");
            tempDic.Add("11","11");
            tempDic.Add("12","12");

            cbGeneratorNum.DataSource = new BindingSource(tempDic, null);
            cbGeneratorNum.DisplayMember = "Value";
            cbGeneratorNum.ValueMember = "Key";

            tempDic.Clear();
            tempDic.Add("0", "大小寫");
            tempDic.Add("1", "僅大寫");
            tempDic.Add("2", "僅小寫");

            cbCaps.DataSource = new BindingSource(tempDic, null);
            cbCaps.DisplayMember = "Value";
            cbCaps.ValueMember = "Key";
        }

        private void btnCreateExcel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbGroupNum.Text))
            {
                MessageBox.Show("請輸入組數");
                return;
            }

            int groupNum = 0;

            if (!int.TryParse(tbGroupNum.Text, out groupNum))
            {
                MessageBox.Show("組數請輸入數字");
                return;
            }

            if (groupNum > 100 || groupNum < 1)
            {
                MessageBox.Show("組數請輸入介於1~100的數字");
                return;
            }

            if (string.IsNullOrEmpty(txtExcelPath.Text))
            {
                MessageBox.Show("請選擇檔案路徑並輸入檔名");
                return;
            }

            int gNum = Convert.ToInt32(cbGeneratorNum.SelectedValue);

            List<string> passwordList = createPassowrd(gNum, (string)cbCaps.SelectedValue, chkIncludeSign.Checked, groupNum);

            createExcel(txtExcelPath.Text, passwordList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSelectExcelPath_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = string.Empty;
            this.txtExcelPath.Text = string.Empty;

            this.saveFileDialog1.Filter = "Excel |*.xls";
            this.saveFileDialog1.ShowDialog();

            txtExcelPath.Text = this.saveFileDialog1.FileName;
            //this.folderBrowserDialog1.ShowDialog();
            //txtExcelPath.Text = this.folderBrowserDialog1.SelectedPath;

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
