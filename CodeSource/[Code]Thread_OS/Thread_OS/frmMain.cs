using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_OS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        //Khai báo biến
        int[,] Arr1, Arr2, ArrKQ;
        TextBox[,] show, getIn1, getIn2;
        int M, N, P, sleep;
        Thread[] thr;
        bool[] Flag;

        /// <summary>
        /// Sinh ma trận 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsinh1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (txtHang1.Text.Trim() != "")
            {
                if (!int.TryParse(txtHang1.Text, out M))
                {
                    MessageBox.Show("Lỗi, Phải Phải là số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            else { MessageBox.Show("Thiếu giá trị hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtCot1.Text.Trim() != "")
            {
                if (!int.TryParse(txtCot1.Text, out N))
                { MessageBox.Show("Lỗi, Phải là số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            else { MessageBox.Show("Thiếu giá trị cột", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            //////////////////
            txtHang2.Text = N.ToString();
            btnGetData1.Enabled = true;
            ///////////////////
            Arr1 = new int[M, N];
            getIn1 = new TextBox[M, N];
            Generator(M, N, panel1, getIn1, check1.Checked);
        }
        /// <summary>
        /// Hàm hiển thị
        /// </summary>
        /// <param name="M">Hàng</param>
        /// <param name="N">Cột</param>
        /// <param name="name">panel gán ra</param>
        /// <param name="txt">ma trận TextBox</param>
        /// <param name="check">random hay không?</param>
        private void Generator(int M, int N, Panel name, TextBox[,] txt, bool check)
        {
            Random rd = new Random();
            for (int v = 0; v < M; v++)
            {
                for (int k = 0; k < N; k++)
                {
                    txt[v, k] = new TextBox();
                    txt[v, k].Location = new Point(20 + k * 45, 10 + v * 30);
                    txt[v, k].Size = new System.Drawing.Size(40, 20);
                    if (check)
                    {
                        txt[v, k].Text = rd.Next(0, 10).ToString();
                    }
                    name.Controls.Add(txt[v, k]);
                }
            }
        }
        /// <summary>
        /// Khởi tạo ma trận 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsinh2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            if (txtCot2.Text.Trim() != "")
            {
                if (int.TryParse(txtCot2.Text, out P))
                {
                    btnGetData2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lỗi, Phải là số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            else
            {
                MessageBox.Show("Lỗi, thiếu cột ma trận 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            Arr2 = new int[N, P];
            #region
            //getIn2 = new TextBox[N, P];

            //for (int v = 0; v < N; v++)
            //{
            //    for (int k = 0; k < P; k++)
            //    {
            //        getIn2[v, k] = new TextBox();
            //        getIn2[v, k].Location = new Point(20 + k * 45, 10 + v * 30);
            //        getIn2[v, k].Size = new System.Drawing.Size(40, 20);
            //        if (check2.Checked == true)
            //        {
            //            getIn2[v, k].Text = rd.Next(0, 10).ToString();
            //        }
            //        panel2.Controls.Add(getIn2[v, k]);
            //    }
            //}
            #endregion
            getIn2 = new TextBox[N, P];
            Generator(N, P, panel2, getIn2, check2.Checked);

        }
        // Đưa dữ liệu trong các ô text vào ma trận 1
        private void btnlay1_Click(object sender, EventArgs e)
        {

            if ((M == 0) || (N == 0))
            {
                MessageBox.Show("Nhập vào các giá trị cần thiết trước khi lấy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                Arr1 = new int[M, N];
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (getIn1[i, j].Text.Trim() != "")
                        {
                            int data = 0;
                            if (int.TryParse(getIn1[i, j].Text.Trim(), out data))
                            {
                                Arr1[i, j] = data;
                            }
                            else
                            {
                                MessageBox.Show("Phải là số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }
                        }
                    }
                }
                MessageBox.Show("Nhập dữ liệu cho ma trận 1 thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave1.Enabled = true;
            }
        }
        // Đưa dữ liệu trong các ô text vào ma trận 3
        private void btnlay2_Click(object sender, EventArgs e)
        {

            if ((N == 0) || (P == 0))
            {
                MessageBox.Show("Nhập vào các giá trị cần thiết trước khi lấy", "Error");
                return;
            }
            else
            {

                Arr2 = new int[N, P];
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < P; j++)
                    {
                        if (getIn2[i, j].Text.Trim() != "")
                        {
                            int data = 0;
                            if (int.TryParse(getIn2[i, j].Text.Trim(), out data))
                            {
                                Arr2[i, j] = data;
                            }
                            else
                            {
                                MessageBox.Show("Phải là số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }
                        }
                    }
                }
                MessageBox.Show("Nhập dữ liệu cho ma trận 2 thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave2.Enabled = true;
            }
        }
        /// <summary>
        /// Sinh ma trận kq
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSinh3_Click(object sender, EventArgs e)
        {
            if ((M == 0) || (N == 0) || (P == 0))
            {
                MessageBox.Show("Phải lấy giá trị cho 2 ma trận trước.", "Lỗi");
                return;
            }
            if ((Arr1 == null) || (Arr2 == null))
            {
                MessageBox.Show("Phải lấy giá trị cho 2 ma trận trước.", "Lỗi");
                return;
            }
            sleep = 0;
            if (!int.TryParse(txtSleep.Text, out sleep)|| sleep<=0)
            {
                MessageBox.Show("Lỗi,Sleep Phải Phải là số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            panel3.Controls.Clear();
            Flag = new bool[M];
            ArrKQ = new int[M, P];
            thr = new Thread[M];
            show = new TextBox[M, P];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j <P; j++)
                {
                    ArrKQ[i, j] = 0;
                    show[i, j] = new TextBox();
                    show[i, j].Location = new Point(20 + j * 45, 10 + i * 30);
                    show[i, j].Size = new System.Drawing.Size(40, 20);
                    //show[i, j].Enabled = false;
                    panel3.Controls.Add(show[i, j]);
                }
                Flag[i] = false;
            }
            btnStart.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// đọc và hiển thị data ma trận 2 lên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead2_Click(object sender, EventArgs e)
        {

            btnGetData2.Enabled = true;
            string[,] data;
            string padOpf = BusinessMaTrix.OpenFile();
            if (padOpf != null)
            {
                panel2.Controls.Clear();
                N = BusinessMaTrix.DocFile(padOpf).GetLength(0);
                P = BusinessMaTrix.DocFile(padOpf).GetLength(1);
                if (int.Parse(txtHang2.Text) != N)
                {
                    MessageBox.Show("File MaTran Không hợp lệ", "Lỗi");
                    return;
                };
                txtCot2.Text = P.ToString();
                data = new string[N, P];
                getIn2 = new TextBox[N, P];
                data = BusinessMaTrix.DocFile(padOpf);
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < P; j++)
                    {
                        getIn2[i, j] = new TextBox();
                        getIn2[i, j].Location = new Point(20 + j * 45, 10 + i * 30);
                        getIn2[i, j].Size = new System.Drawing.Size(40, 20);
                        getIn2[i, j].Text = data[i, j].ToString();
                        Thread.Sleep(100);
                        panel2.Controls.Add(getIn2[i, j]);
                    }
                }
            }
        }
        /// <summary>
        /// đọc và hiển thị data ma trận 1 lên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead1_Click(object sender, EventArgs e)
        {
            string[,] data;
            string padOpf = BusinessMaTrix.OpenFile();
            if (padOpf != null)
            {
                panel1.Controls.Clear();
                M = BusinessMaTrix.DocFile(padOpf).GetLength(0);
                N = BusinessMaTrix.DocFile(padOpf).GetLength(1);
                txtHang1.Text = M.ToString();
                txtCot1.Text = N.ToString();
                txtHang2.Text = N.ToString();
                data = new string[M, N];
                getIn1 = new TextBox[M, N];
                data = BusinessMaTrix.DocFile(padOpf);
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        getIn1[i, j] = new TextBox();
                        getIn1[i, j].Location = new Point(20 + j * 45, 10 + i * 30);
                        getIn1[i, j].Size = new System.Drawing.Size(40, 20);
                        if (check1.Checked == true)
                        {
                            getIn1[i, j].Text = data[i, j].ToString();
                        }
                        Thread.Sleep(100);
                        panel1.Controls.Add(getIn1[i, j]);
                    }

                }
                if (getIn1 != null)
                    btnGetData1.Enabled = true;
            }
        }
        /// <summary>
        /// Lưu data ma trận 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave2_Click(object sender, EventArgs e)
        {
            string padSvF = BusinessMaTrix.saveFile();
            if (padSvF != null)
            {
                if (getIn2 != null && Arr2 != null)
                {
                    BusinessMaTrix.GhiFile(padSvF, Arr2);
                }
            }
        }
        /// <summary>
        /// lưu kết quả nhận được
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveKQ_Click(object sender, EventArgs e)
        {
            string padSvF = BusinessMaTrix.saveFile();
            if (padSvF != null)
            {
                if (getIn1 != null && ArrKQ != null)
                {
                    BusinessMaTrix.GhiFile(padSvF, ArrKQ);
                }
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            string padSvF = BusinessMaTrix.saveFile();
            if (padSvF != null)
            {
                if (getIn1 != null && Arr1 != null)
                {
                    BusinessMaTrix.GhiFile(padSvF, Arr1);
                }
            }
        }

        //////////////////////////////////////////////






        //-------------------------
        // Khi ấn nút, thực hiện nhân 2 ma trận và in ra kết quả
        private void btn_start_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            ArrKQ = new int[M, P];
            for (int index = 0; index < M; index++)
            {
                thr[index] = new Thread(() => Xuli(index));
                thr[index].Start();
                while (!Flag[index]) ;
            }
            //for(int i = 0; i < M; i++){
            //    thr[i].Join(); // đợi cho thằng thr chính làm việc xong
            //}
            btnSaveKQ.Enabled = true;
        }
        // Khởi tạo ma trận kết quả và các Thread

        //Hàm xử lý nhân 2 ma trận theo từng Thread. Đưa kết quả nhân ra 
        //ma trận Kết quả THEO TỪNG HÀNG
        private void Xuli(int data)
        {
            int index = data;
            Flag[index] = true;
            for (int i = 0; i < P; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    ArrKQ[index, i] += Arr1[index, j] * Arr2[j, i];
                    Thread.Sleep(sleep);
                }
                show[index, i].Text = ArrKQ[index, i].ToString();
            }
        }
    }
}
