using System;
using System.IO;
using System.Windows.Forms;

namespace Trolleybus_depot
{
    public partial class CreateRoutes : Form
    {
        public CreateRoutes()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            lblInfo.Text = "";
            if(tbFirstStop.Text == "" || tbLastStop.Text == "")
            {
                lblInfo.Text = "Вы не заполнили все поля";
                btnCreate.Enabled = true;
                return;
            }
            DirectoryInfo dir = new DirectoryInfo(Variables.Path);
            foreach (FileInfo f in dir.GetFiles())
            {
                string text = File.ReadAllText(f.FullName);
                string[] split = text.Split(new char[] { '|' });
                if(Convert.ToInt32(split[0]) == numRouteNumber.Value)
                {
                    lblInfo.Text = "Номер маршрута уже зарегестрирован, выберите другой номер";
                    btnCreate.Enabled = true;
                    return;
                }
            }
            StreamWriter file = new StreamWriter(Variables.Path + @"\№" + numRouteNumber.Value + @". " + tbFirstStop.Text + @" - " + tbLastStop.Text + @".txt");
            file.Write(numRouteNumber.Value + "|" + tbFirstStop.Text + "|" + tbLastStop.Text + "|" + 
            numTravelTimeHour.Value + "|" + numTravelTimeMin.Value + "|" + 
            numFirstEditionHour.Value + "|" + numFirstEditionMin.Value + "|" + numLatestIssueHour.Value + "|" +
            numLatestIssueMin.Value + "|" + numInterval.Value);
            file.Close();
            Variables.isCreateRoutes = true;
            Close();
        }
    }
}
