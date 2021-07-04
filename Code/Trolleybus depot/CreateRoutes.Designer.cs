namespace Trolleybus_depot
{
    partial class CreateRoutes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoutes));
            this.label1 = new System.Windows.Forms.Label();
            this.numRouteNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstStop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastStop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numTravelTimeHour = new System.Windows.Forms.NumericUpDown();
            this.numTravelTimeMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numFirstEditionHour = new System.Windows.Forms.NumericUpDown();
            this.numFirstEditionMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numLatestIssueHour = new System.Windows.Forms.NumericUpDown();
            this.numLatestIssueMin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRouteNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelTimeHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstEditionHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstEditionMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatestIssueHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatestIssueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер маршрута:";
            // 
            // numRouteNumber
            // 
            this.numRouteNumber.Location = new System.Drawing.Point(244, 30);
            this.numRouteNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRouteNumber.Name = "numRouteNumber";
            this.numRouteNumber.Size = new System.Drawing.Size(176, 20);
            this.numRouteNumber.TabIndex = 1;
            this.numRouteNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название первой остановки:";
            // 
            // tbFirstStop
            // 
            this.tbFirstStop.Location = new System.Drawing.Point(244, 70);
            this.tbFirstStop.Name = "tbFirstStop";
            this.tbFirstStop.Size = new System.Drawing.Size(176, 20);
            this.tbFirstStop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название конечной остановки:";
            // 
            // tbLastStop
            // 
            this.tbLastStop.Location = new System.Drawing.Point(244, 110);
            this.tbLastStop.Name = "tbLastStop";
            this.tbLastStop.Size = new System.Drawing.Size(176, 20);
            this.tbLastStop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(48, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Среднее время пути туда и обратно(ЧЧ:ММ):";
            // 
            // numTravelTimeHour
            // 
            this.numTravelTimeHour.Location = new System.Drawing.Point(12, 170);
            this.numTravelTimeHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numTravelTimeHour.Name = "numTravelTimeHour";
            this.numTravelTimeHour.Size = new System.Drawing.Size(195, 20);
            this.numTravelTimeHour.TabIndex = 7;
            // 
            // numTravelTimeMin
            // 
            this.numTravelTimeMin.Location = new System.Drawing.Point(225, 170);
            this.numTravelTimeMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTravelTimeMin.Name = "numTravelTimeMin";
            this.numTravelTimeMin.Size = new System.Drawing.Size(195, 20);
            this.numTravelTimeMin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(129, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Первый выпуск(ЧЧ:ММ):";
            // 
            // numFirstEditionHour
            // 
            this.numFirstEditionHour.Location = new System.Drawing.Point(12, 214);
            this.numFirstEditionHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numFirstEditionHour.Name = "numFirstEditionHour";
            this.numFirstEditionHour.Size = new System.Drawing.Size(195, 20);
            this.numFirstEditionHour.TabIndex = 11;
            // 
            // numFirstEditionMin
            // 
            this.numFirstEditionMin.Location = new System.Drawing.Point(225, 214);
            this.numFirstEditionMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numFirstEditionMin.Name = "numFirstEditionMin";
            this.numFirstEditionMin.Size = new System.Drawing.Size(195, 20);
            this.numFirstEditionMin.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(117, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Последний выпуск(ЧЧ:ММ):";
            // 
            // numLatestIssueHour
            // 
            this.numLatestIssueHour.Location = new System.Drawing.Point(12, 258);
            this.numLatestIssueHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numLatestIssueHour.Name = "numLatestIssueHour";
            this.numLatestIssueHour.Size = new System.Drawing.Size(195, 20);
            this.numLatestIssueHour.TabIndex = 14;
            // 
            // numLatestIssueMin
            // 
            this.numLatestIssueMin.Location = new System.Drawing.Point(225, 258);
            this.numLatestIssueMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLatestIssueMin.Name = "numLatestIssueMin";
            this.numLatestIssueMin.Size = new System.Drawing.Size(195, 20);
            this.numLatestIssueMin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Интервал(ММ):";
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(225, 295);
            this.numInterval.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(195, 20);
            this.numInterval.TabIndex = 17;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(154, 346);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(125, 23);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Создать маршрут";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(12, 330);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(408, 13);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(432, 381);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numLatestIssueMin);
            this.Controls.Add(this.numLatestIssueHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numFirstEditionMin);
            this.Controls.Add(this.numFirstEditionHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTravelTimeMin);
            this.Controls.Add(this.numTravelTimeHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLastStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirstStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numRouteNumber);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 420);
            this.MinimumSize = new System.Drawing.Size(448, 420);
            this.Name = "CreateRoutes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание маршрута";
            ((System.ComponentModel.ISupportInitialize)(this.numRouteNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelTimeHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTravelTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstEditionHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstEditionMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatestIssueHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatestIssueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRouteNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirstStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTravelTimeHour;
        private System.Windows.Forms.NumericUpDown numTravelTimeMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFirstEditionHour;
        private System.Windows.Forms.NumericUpDown numFirstEditionMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numLatestIssueHour;
        private System.Windows.Forms.NumericUpDown numLatestIssueMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblInfo;
    }
}