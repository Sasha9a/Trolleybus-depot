using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Trolleybus_depot
{
    public partial class Form1 : Form
    {
        List<string> Routes = new List<string>();
        List<int> TrolleyBusCount = new List<int>();
        List<int> TrolleyBusRoute = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = "Время - " + GetTime();
            Variables.Path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Trolleybus depot";
            if (!Directory.Exists(Variables.Path)) Directory.CreateDirectory(Variables.Path);
            DirectoryInfo dir = new DirectoryInfo(Variables.Path);
            TrolleyBusCount.Add(0);
            TrolleyBusRoute.Add(0);
            if (dir.GetFiles().Length != 0)
            {
                int count = 0;
                foreach (FileInfo file in dir.GetFiles())
                {
                    Routes.Add(Path.GetFileNameWithoutExtension(file.FullName));
                    lbRoutes.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
                    try
                    {
                        string text = File.ReadAllText(file.FullName);
                        string[] split = text.Split(new char[] { '|' });
                        TrolleyBusRoute.Add(Convert.ToInt32(split[0]));
                        TrolleyBusCount.Add(0);
                        DateTime dtStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(split[5]), Convert.ToInt32(split[6]), DateTime.Now.Second);
                        DateTime dtEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(split[7]), Convert.ToInt32(split[8]), DateTime.Now.Second);
                        if (dtEnd.Subtract(dtStart).ToString().IndexOf('-') != -1) dtEnd = dtEnd.AddDays(1);
                        while (true)
                        {
                            if (dtEnd.Subtract(dtStart).ToString().IndexOf('-') != -1) break;
                            DateTime dtNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                            DateTime dtRes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                            dtRes = dtRes.AddHours(-Convert.ToInt32(split[3]));
                            dtRes = dtRes.AddMinutes(-Convert.ToInt32(split[4]));
                            if (dtRes <= dtStart && dtStart < dtNow) TrolleyBusCount[count + 1]++;
                            dtStart = dtStart.AddMinutes(Convert.ToInt32(split[9]));
                        }
                    }
                    catch { }
                    count++;
                }
                for (int i = 1; i < TrolleyBusRoute.Count; i++) TrolleyBusCount[0] += TrolleyBusCount[i];
                tbInfoTrolleybus.Text = "Всего троллейбусов в пути: " + TrolleyBusCount[0];
                for (int i = 1; i < TrolleyBusRoute.Count; i++)
                {
                    tbInfoTrolleybus.Text += "\r\nМаршрут №" + TrolleyBusRoute[i] + ": " + TrolleyBusCount[i];
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Время - " + GetTime();
            DirectoryInfo dir = new DirectoryInfo(Variables.Path);
            if (Variables.isCreateRoutes)
            {
                if(Variables.PosRoute != -1)
                {
                    tbInfo.Text = "";
                    btnDelRoutes.Enabled = false;
                    btnUpdate.Enabled = false;
                    Variables.PosRoute = -1;
                }
                lbRoutes.Items.Clear();
                Routes.Clear();
                foreach (FileInfo file in dir.GetFiles())
                {
                    Routes.Add(Path.GetFileNameWithoutExtension(file.FullName));
                    lbRoutes.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
                    TrolleyBusRoute.Add(0);
                    TrolleyBusCount.Add(0);
                }
                Variables.isCreateRoutes = false;
            }
            if (dir.GetFiles().Length != 0)
            {
                int count = 0;
                int[] array = new int[dir.GetFiles().Length];
                foreach (FileInfo file in dir.GetFiles())
                {
                    int local = 0;
                    try
                    {
                        string text = File.ReadAllText(file.FullName);
                        string[] split = text.Split(new char[] { '|' });
                        TrolleyBusRoute[count + 1] = Convert.ToInt32(split[0]);
                        DateTime dtStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(split[5]), Convert.ToInt32(split[6]), DateTime.Now.Second);
                        DateTime dtEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(split[7]), Convert.ToInt32(split[8]), DateTime.Now.Second);
                        if (dtEnd.Subtract(dtStart).ToString().IndexOf('-') != -1) dtEnd = dtEnd.AddDays(1);
                        while (true)
                        {
                            if (dtEnd.Subtract(dtStart).ToString().IndexOf('-') != -1) break;
                            DateTime dtNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                            DateTime dtRes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                            dtRes = dtRes.AddHours(-Convert.ToInt32(split[3]));
                            dtRes = dtRes.AddMinutes(-Convert.ToInt32(split[4]));
                            if (dtRes <= dtStart && dtStart < dtNow) local++;
                            dtStart = dtStart.AddMinutes(Convert.ToInt32(split[9]));
                        }
                        array[count++] = local;
                    }
                    catch { }
                }
                int trolley = 0;
                for (int i = 0; i < array.Length; i++) trolley += array[i];
                if (tbInfoTrolleybus.Text.IndexOf("Всего троллейбусов в пути: " + TrolleyBusCount[0]) != -1) tbInfoTrolleybus.Text = tbInfoTrolleybus.Text.Replace("Всего троллейбусов в пути: " + TrolleyBusCount[0], "Всего троллейбусов в пути: " + trolley);
                else tbInfoTrolleybus.Text = "Всего троллейбусов в пути: " + trolley;
                TrolleyBusCount[0] = trolley;
                for (int i = 0; i < array.Length; i++)
                {
                    if (tbInfoTrolleybus.Text.IndexOf("Маршрут №" + TrolleyBusRoute[i + 1] + ": " + TrolleyBusCount[i + 1]) != -1) tbInfoTrolleybus.Text = tbInfoTrolleybus.Text.Replace("Маршрут №" + TrolleyBusRoute[i + 1] + ": " + TrolleyBusCount[i + 1], "Маршрут №" + TrolleyBusRoute[i + 1] + ": " + array[i]);
                    else tbInfoTrolleybus.Text += "\r\nМаршрут №" + TrolleyBusRoute[i + 1] + ": " + array[i];
                    TrolleyBusCount[i + 1] = array[i];
                }
            }
        }

        private void btnCreateRoutes_Click(object sender, EventArgs e)
        {
            CreateRoutes Form = new CreateRoutes();
            Form.ShowDialog();
        }

        private void lbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRoutes.SelectedIndex == -1 || lbRoutes.SelectedIndex == Variables.PosRoute) return;
            if (Variables.PosRoute == -1)
            {
                btnDelRoutes.Enabled = true;
                btnUpdate.Enabled = true;
            }
            Variables.PosRoute = (short)lbRoutes.SelectedIndex;
            LoadList(lbRoutes.SelectedIndex);
        }

        private void btnDelRoutes_Click(object sender, EventArgs e)
        {
            btnDelRoutes.Enabled = false;
            btnUpdate.Enabled = false;
            tbInfo.Text = "";
            File.Delete(Variables.Path + @"\" + Routes[lbRoutes.SelectedIndex] + ".txt");
            Variables.PosRoute = -1;
            lbRoutes.Items.Clear();
            Routes.Clear();
            TrolleyBusCount.RemoveAt(TrolleyBusCount.Count - 1);
            TrolleyBusRoute.RemoveAt(TrolleyBusRoute.Count - 1);
            tbInfoTrolleybus.Text = "";
            DirectoryInfo dir = new DirectoryInfo(Variables.Path);
            foreach (FileInfo file in dir.GetFiles())
            {
                Routes.Add(Path.GetFileNameWithoutExtension(file.FullName));
                lbRoutes.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selStart = tbInfo.SelectionStart;
            int selLen = tbInfo.SelectionLength;
            int firstDispIndex = tbInfo.GetCharIndexFromPosition(new Point(3, 3));
            btnUpdate.Enabled = false;
            btnDelRoutes.Enabled = false;
            LoadList(Variables.PosRoute);
            tbInfo.Select(firstDispIndex, 0);
            tbInfo.ScrollToCaret();
            tbInfo.Select(selStart, selLen);
            if (selStart != 0)
            {
                tbInfo.SelectionStart = selStart;
                tbInfo.SelectionLength = selLen;
            }
            else tbInfo.SelectionStart = firstDispIndex;
            tbInfo.Focus();
            btnDelRoutes.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void LoadList(int pos)
        {
            if (tbInfo.Text != "") tbInfo.Text = "";
            try
            {
                FileInfo fi = new FileInfo(Variables.Path + @"\" + Routes[pos] + ".txt");
                string text = File.ReadAllText(fi.FullName);
                string[] split = text.Split(new char[] { '|' });
                tbInfo.Text = "Номер маршрута: " + split[0] + "\r\n" +
                "Маршрут: " + split[1] + " - " + split[2] + "\r\n" +
                "Время в пути туда и обратно(ЧЧ:ММ): " + CorrectTime(split[3], split[4]) + "\r\n" +
                "Первый выпуск(ЧЧ:ММ): " + CorrectTime(split[5], split[6]) + "\r\n" +
                "Последний выпуск(ЧЧ:ММ): " + CorrectTime(split[7], split[8]) + "\r\n" +
                "Интервал: " + split[9] + " мин.\r\n";
                for (int i = 0; i != 175; i++) tbInfo.Text += "-";
                tbInfo.Text += "\r\nВремя рейса\t|\tСостояние рейса\r\n";
                for (int i = 0; i != 175; i++) tbInfo.Text += "-";
                DateTime dtStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(split[5]), Convert.ToInt32(split[6]), DateTime.Now.Second);
                DateTime dtEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(split[7]), Convert.ToInt32(split[8]), DateTime.Now.Second);
                if (dtEnd.Subtract(dtStart).ToString().IndexOf('-') != -1) dtEnd = dtEnd.AddDays(1);
                while (true)
                {
                    if (dtEnd.Subtract(dtStart).ToString().IndexOf('-') != -1) break;
                    DateTime dtNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    tbInfo.Text += "\r\n" + CorrectTime(dtStart.Hour.ToString(), dtStart.Minute.ToString());
                    tbInfo.Text += "\t\t|\t";
                    DateTime dtRes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    dtRes = dtRes.AddHours(-Convert.ToInt32(split[3]));
                    dtRes = dtRes.AddMinutes(-Convert.ToInt32(split[4]));
                    if (dtRes <= dtStart && dtStart < dtNow)
                    {
                        tbInfo.Text += "Троллейбус в пути. Прибудет в депо через(ЧЧ:ММ): " + CorrectTime((dtStart.AddHours(Convert.ToInt32(split[3])).AddMinutes(Convert.ToInt32(split[4])) - dtNow).Hours.ToString(), (dtStart.AddHours(Convert.ToInt32(split[3])).AddMinutes(Convert.ToInt32(split[4])) - dtNow).Minutes.ToString());
                    }
                    else
                    {
                        tbInfo.Text += "Пусто";
                    }
                    dtStart = dtStart.AddMinutes(Convert.ToInt32(split[9]));
                }
            }
            catch
            {
                tbInfo.Text = "Произошла ошибка. Советуем удалить маршрут, и заново создать.";
            }
        }

        private string GetTime()
        {
            string res = "";
            if (DateTime.Now.Hour < 10) res = "0" + DateTime.Now.Hour + ":";
            else res = DateTime.Now.Hour + ":";
            if (DateTime.Now.Minute < 10) res += "0" + DateTime.Now.Minute + ":";
            else res += DateTime.Now.Minute + ":";
            if (DateTime.Now.Second < 10) res += "0" + DateTime.Now.Second;
            else res += DateTime.Now.Second;
            return res;
        }

        private string CorrectTime(string hour, string minute)
        {
            string res = "";
            try
            {
                if (Convert.ToInt32(hour) < 10) res = "0" + hour + ":";
                else res = hour + ":";
                if (Convert.ToInt32(minute) < 10) res += "0" + minute;
                else res += minute;
            }
            catch { }
            return res;
        }
    }
}
