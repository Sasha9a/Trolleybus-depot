namespace Trolleybus_depot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbRoutes = new System.Windows.Forms.ListBox();
            this.btnCreateRoutes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelRoutes = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.RichTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbInfoTrolleybus = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRoutes
            // 
            this.lbRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRoutes.FormattingEnabled = true;
            this.lbRoutes.Location = new System.Drawing.Point(13, 13);
            this.lbRoutes.Name = "lbRoutes";
            this.lbRoutes.Size = new System.Drawing.Size(196, 433);
            this.lbRoutes.TabIndex = 0;
            this.lbRoutes.TabStop = false;
            this.lbRoutes.SelectedIndexChanged += new System.EventHandler(this.lbRoutes_SelectedIndexChanged);
            // 
            // btnCreateRoutes
            // 
            this.btnCreateRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateRoutes.Location = new System.Drawing.Point(13, 453);
            this.btnCreateRoutes.Name = "btnCreateRoutes";
            this.btnCreateRoutes.Size = new System.Drawing.Size(196, 23);
            this.btnCreateRoutes.TabIndex = 1;
            this.btnCreateRoutes.TabStop = false;
            this.btnCreateRoutes.Text = "Создать маршрут";
            this.btnCreateRoutes.UseVisualStyleBackColor = true;
            this.btnCreateRoutes.Click += new System.EventHandler(this.btnCreateRoutes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelRoutes);
            this.groupBox1.Controls.Add(this.tbInfo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(216, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 360);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о маршруте";
            // 
            // btnDelRoutes
            // 
            this.btnDelRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelRoutes.Enabled = false;
            this.btnDelRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelRoutes.ForeColor = System.Drawing.Color.Black;
            this.btnDelRoutes.Location = new System.Drawing.Point(563, 331);
            this.btnDelRoutes.Name = "btnDelRoutes";
            this.btnDelRoutes.Size = new System.Drawing.Size(179, 23);
            this.btnDelRoutes.TabIndex = 1;
            this.btnDelRoutes.TabStop = false;
            this.btnDelRoutes.Text = "Удалить маршрут";
            this.btnDelRoutes.UseVisualStyleBackColor = true;
            this.btnDelRoutes.Click += new System.EventHandler(this.btnDelRoutes_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfo.Location = new System.Drawing.Point(7, 20);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(735, 310);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.TabStop = false;
            this.tbInfo.Text = "";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTime.Location = new System.Drawing.Point(332, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(215, 29);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Время - 12:20:20";
            // 
            // tbInfoTrolleybus
            // 
            this.tbInfoTrolleybus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfoTrolleybus.Location = new System.Drawing.Point(656, 12);
            this.tbInfoTrolleybus.Name = "tbInfoTrolleybus";
            this.tbInfoTrolleybus.ReadOnly = true;
            this.tbInfoTrolleybus.Size = new System.Drawing.Size(308, 96);
            this.tbInfoTrolleybus.TabIndex = 4;
            this.tbInfoTrolleybus.TabStop = false;
            this.tbInfoTrolleybus.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(7, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 488);
            this.Controls.Add(this.tbInfoTrolleybus);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreateRoutes);
            this.Controls.Add(this.lbRoutes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(992, 527);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ диспетчера троллейбусного депо";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRoutes;
        private System.Windows.Forms.Button btnCreateRoutes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RichTextBox tbInfo;
        private System.Windows.Forms.Button btnDelRoutes;
        private System.Windows.Forms.RichTextBox tbInfoTrolleybus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

