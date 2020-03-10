﻿namespace ArcWeek
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.lblMainText = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainText
            // 
            this.lblMainText.AutoSize = true;
            this.lblMainText.BackColor = System.Drawing.Color.Black;
            this.lblMainText.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainText.ForeColor = System.Drawing.Color.White;
            this.lblMainText.Location = new System.Drawing.Point(131, 9);
            this.lblMainText.Name = "lblMainText";
            this.lblMainText.Size = new System.Drawing.Size(245, 33);
            this.lblMainText.TabIndex = 0;
            this.lblMainText.Text = "Неделя обучения";
            this.lblMainText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Black;
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(12, 459);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(472, 69);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Начать обучение";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Black;
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(12, 534);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(234, 69);
            this.btn.TabIndex = 2;
            this.btn.Text = "Концовки";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 609);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(472, 69);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выключить";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Black;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(120, 120);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(256, 256);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Black;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(250, 534);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(234, 69);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // loadFile
            // 
            this.loadFile.FileName = "openFileDialog1";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "TextFiles|*.txt";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(496, 689);
            this.ControlBox = false;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblMainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Как ты это увидел?";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainText;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLoad;
        public System.Windows.Forms.OpenFileDialog loadFile;
        public System.Windows.Forms.SaveFileDialog saveFile;
    }
}

