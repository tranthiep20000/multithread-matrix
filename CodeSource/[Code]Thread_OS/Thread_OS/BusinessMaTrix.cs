using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_OS
{
    class BusinessMaTrix
    {
        /// <summary>
        /// Hàm này để ghi file dữ liệu ma trận.
        /// </summary>
        /// <param name="pad"> là đường link lưu file</param>
        /// <param name="data"> mảng dữ liệu kiểu int đưa vào</param>
        public static void GhiFile(string pad, int[,] data)
        {
            StreamWriter stw = new StreamWriter(pad);
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (j == data.GetLength(1) - 1)
                    {
                        stw.WriteLine("{0}", data[i, j]);
                    }
                    else
                    {
                        stw.Write("{0} ", data[i, j]);
                    }
                }
            }
            stw.Close();
        }
        /// <summary>
        /// Hàm Này để đọc file.
        /// </summary>
        /// <param name="pad">Dường link Đọc file</param>
        /// <returns></returns>
        public static string[,] DocFile(string pad)
        {
            int i=0, j=0;
            string[,] mtData;
            List<string> line = new List<string>();
            StreamReader stw = new StreamReader(pad);
            while (!stw.EndOfStream)
            {
                line.Add(stw.ReadLine());
            }
            if (line.Count>0)
            {
                int col = line.Count;
                int row = line[0].Split(' ').Length;
                mtData = new string[col, row];
                foreach (string x in line)
                {
                    string[] Element = new string[x.Split(' ').Length];
                    Element = x.Split(' ');
                    foreach(string str in Element)
                    {
                        mtData[i,j] = str;
                        j++;
                    }
                    j = 0;
                    i++;
                }
                stw.Close();
                return mtData;
            }
            else
            {
                stw.Close();
                return null;
            }
          
        }
        /// <summary>
        /// Hàm Này mở file để nhận đường link.
        /// </summary>
        /// <returns></returns>
        public static string OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Matrix files (*.Matrix)|*.Matrix|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            ofd.ShowDialog();
            if (ofd.FileName == "")
            {
                MessageBox.Show("No file select", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else
            {
                return ofd.FileName;
            }
        }
        /// <summary>
        /// Hàm Này mở file để nhận đường link.
        /// </summary>
        /// <returns></returns>
        public static string saveFile()
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Matrix files (*.Matrix)|*.Matrix|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            ofd.ShowDialog();
            if (ofd.FileName == "")
            {
                MessageBox.Show("No file select", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else
            {
                return ofd.FileName;
            }
        }
        
    }
}
