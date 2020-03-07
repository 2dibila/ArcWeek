namespace ArcWeek
{
    partial class formGame
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
            this.components = new System.ComponentModel.Container();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice4 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.cmsSaveLoad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLoadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEventField = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPressSpace = new System.Windows.Forms.Label();
            this.cmsSaveLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Black;
            this.lblDay.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(200, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(104, 33);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "День 1";
            this.lblDay.Visible = false;
            // 
            // btnChoice3
            // 
            this.btnChoice3.BackColor = System.Drawing.Color.Black;
            this.btnChoice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoice3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChoice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoice3.ForeColor = System.Drawing.Color.White;
            this.btnChoice3.Location = new System.Drawing.Point(12, 515);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(234, 69);
            this.btnChoice3.TabIndex = 3;
            this.btnChoice3.Text = "Выбор 3";
            this.btnChoice3.UseVisualStyleBackColor = false;
            // 
            // btnChoice4
            // 
            this.btnChoice4.BackColor = System.Drawing.Color.Black;
            this.btnChoice4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoice4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChoice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoice4.ForeColor = System.Drawing.Color.White;
            this.btnChoice4.Location = new System.Drawing.Point(250, 515);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Size = new System.Drawing.Size(234, 69);
            this.btnChoice4.TabIndex = 4;
            this.btnChoice4.Text = "Выбор 4";
            this.btnChoice4.UseVisualStyleBackColor = false;
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.Color.Black;
            this.btnChoice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoice2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChoice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoice2.ForeColor = System.Drawing.Color.White;
            this.btnChoice2.Location = new System.Drawing.Point(250, 440);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(234, 69);
            this.btnChoice2.TabIndex = 6;
            this.btnChoice2.Text = "Выбор 2";
            this.btnChoice2.UseVisualStyleBackColor = false;
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.Color.Black;
            this.btnChoice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoice1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChoice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoice1.ForeColor = System.Drawing.Color.White;
            this.btnChoice1.Location = new System.Drawing.Point(12, 440);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(234, 69);
            this.btnChoice1.TabIndex = 5;
            this.btnChoice1.Text = "Выбор 1";
            this.btnChoice1.UseVisualStyleBackColor = false;
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.BackColor = System.Drawing.Color.Black;
            this.btnReturnToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMain.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnToMain.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMain.Location = new System.Drawing.Point(131, 630);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(234, 47);
            this.btnReturnToMain.TabIndex = 8;
            this.btnReturnToMain.Text = "В главное меню";
            this.btnReturnToMain.UseVisualStyleBackColor = false;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // cmsSaveLoad
            // 
            this.cmsSaveLoad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmsSaveLoad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSaveItem,
            this.cmsLoadItem});
            this.cmsSaveLoad.Name = "cmsSaveLoad";
            this.cmsSaveLoad.Size = new System.Drawing.Size(182, 56);
            // 
            // cmsSaveItem
            // 
            this.cmsSaveItem.Name = "cmsSaveItem";
            this.cmsSaveItem.Size = new System.Drawing.Size(181, 26);
            this.cmsSaveItem.Text = "Сохранить";
            this.cmsSaveItem.Click += new System.EventHandler(this.cmsSaveItem_Click);
            // 
            // cmsLoadItem
            // 
            this.cmsLoadItem.Name = "cmsLoadItem";
            this.cmsLoadItem.Size = new System.Drawing.Size(181, 26);
            this.cmsLoadItem.Text = "Загрузить";
            this.cmsLoadItem.Click += new System.EventHandler(this.cmsLoadItem_Click);
            // 
            // lblEventField
            // 
            this.lblEventField.BackColor = System.Drawing.Color.Black;
            this.lblEventField.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEventField.ForeColor = System.Drawing.Color.White;
            this.lblEventField.Location = new System.Drawing.Point(6, 52);
            this.lblEventField.Name = "lblEventField";
            this.lblEventField.Size = new System.Drawing.Size(483, 385);
            this.lblEventField.TabIndex = 9;
            this.lblEventField.Text = "Вы оказались в мире, которому грозит опасность. \r\nУ вас есть 7 дней чтобы предотв" +
    "ратить это.\r\n\r\nВсё в ваших руках.";
            this.lblEventField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPressSpace
            // 
            this.lblPressSpace.AutoSize = true;
            this.lblPressSpace.BackColor = System.Drawing.Color.Black;
            this.lblPressSpace.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPressSpace.ForeColor = System.Drawing.Color.White;
            this.lblPressSpace.Location = new System.Drawing.Point(-5, 492);
            this.lblPressSpace.Name = "lblPressSpace";
            this.lblPressSpace.Size = new System.Drawing.Size(505, 33);
            this.lblPressSpace.TabIndex = 10;
            this.lblPressSpace.Text = "Нажмите ПРОБЕЛ чтобы продолжить";
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(496, 689);
            this.ContextMenuStrip = this.cmsSaveLoad;
            this.ControlBox = false;
            this.Controls.Add(this.lblPressSpace);
            this.Controls.Add(this.lblEventField);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.lblDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ты не должен это видеть!";
            this.Load += new System.EventHandler(this.formGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formGame_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formGame_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formGame_MouseMove);
            this.cmsSaveLoad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDay;
        public System.Windows.Forms.Button btnChoice3;
        public System.Windows.Forms.Button btnChoice4;
        public System.Windows.Forms.Button btnChoice2;
        public System.Windows.Forms.Button btnChoice1;
        public System.Windows.Forms.Button btnReturnToMain;
        public System.Windows.Forms.ContextMenuStrip cmsSaveLoad;
        public System.Windows.Forms.ToolStripMenuItem cmsSaveItem;
        public System.Windows.Forms.ToolStripMenuItem cmsLoadItem;
        public System.Windows.Forms.Label lblEventField;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblPressSpace;
    }
}