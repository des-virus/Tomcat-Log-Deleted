using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomcat_Log_Deleted {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region Custom function

        public void saveData()
        {
            
        }

        public void loadData()
        {
            try {
                string[] folders = File.ReadAllLines(Application.StartupPath + @"\\data.dat");
                foreach (var folder in folders) {
                    string name = folder.Split(';')[0];
                    string path = folder.Split(';')[1];

                    dgvData.Rows.Add(name, path);
                }
            }
            catch {
                MessageBox.Show("Lỗi load file");
            }
        }


        #endregion

        #region Event Handler

        private void Form1_Load(object sender, EventArgs e) {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e) {

        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                String path = folderBrowserDialog1.SelectedPath;
                txtPath.Text = path;
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            String name = txtName.Text;
            String path = txtPath.Text;

            dgvData.Rows.Add(name, path);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index = dgvData.SelectedRows[0].Index;
            if (index < 0)
                return;

            DataGridViewRow drow = dgvData.Rows[index];
            txtName.Text = drow.Cells[0].Value.ToString();
            txtPath.Text = drow.Cells[1].Value.ToString();
        }

        private void btnDeleteLog_Click(object sender, EventArgs e) {
            rtbPreview.Text = "";
            rtbPreview.AppendText("[THÔNG TIN] Bắt đầu xóa log ...\n");
            String path = txtPath.Text;
            string[] log_file = Directory.GetFiles(path, "*.log");
            string[] txt_file = Directory.GetFiles(path, "*.txt");

            rtbPreview.AppendText("[THÔNG TIN] Tìm thấy " + log_file.Length + " file log\n");
            rtbPreview.AppendText("[THÔNG TIN] Tìm thấy " + txt_file.Length + " file txt\n");

            rtbPreview.AppendText("[THÔNG TIN] Đang tiến hành xóa log ...\n");



            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.log")
                                 .Where(p => p.Extension == ".log").ToArray();
            foreach (FileInfo file in files)
                try {
                    file.Attributes = FileAttributes.Normal;
                    File.Delete(file.FullName);
                }
                catch { }

            rtbPreview.AppendText("[THÔNG TIN] Xóa log thành công ^^");




        }

        private void ptbFacebook_Click(object sender, EventArgs e) {
            Process.Start("http://facebook.com/dominhphong.18");
        }

        private void ptbInfo_Click(object sender, EventArgs e) {
            MessageBox.Show("Phần mềm xóa log tomcat ver 1.0 by minhphong306\nThanks for using :)");
        }



        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            string[] data = new string[dgvData.Rows.Count];
            int i = 0;
            string name = "";
            string path = "";
            foreach (DataGridViewRow dgvDataRow in dgvData.Rows)
            {
                name = dgvDataRow.Cells[0].Value.ToString();
                path = dgvDataRow.Cells[1].Value.ToString();
                data[i] = name + ";" + path;
                i++;
            }
            File.WriteAllLines(Application.StartupPath + @"\\data.dat", data);
        }
    }
}
