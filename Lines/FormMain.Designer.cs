﻿using System.Windows.Forms;
namespace linesk
   
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new ToolStrip();
            this.toolStripButtonNewGame = new ToolStripButton();
            this.toolStripButtonFullscreen = new ToolStripButton();
            this.toolStripButtonChangePlayersName = new ToolStripButton();
            this.toolStripButtonGameSetting = new ToolStripButton();
            this.toolStripButtonExit = new ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
            this.toolStripButtonNewGame,
            this.toolStripButtonFullscreen,
            this.toolStripButtonChangePlayersName,
            this.toolStripButtonGameSetting,
            this.toolStripButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewGame
            // 
            this.toolStripButtonNewGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNewGame.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewGame.Image")));
            this.toolStripButtonNewGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewGame.Name = "toolStripButtonNewGame";
            this.toolStripButtonNewGame.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonNewGame.Text = "Новая игра";
            this.toolStripButtonNewGame.Click += new System.EventHandler(this.toolStripButtonNewGame_Click);
            // 
            // toolStripButtonFullscreen
            // 
            this.toolStripButtonFullscreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFullscreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFullscreen.Image")));
            this.toolStripButtonFullscreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFullscreen.Name = "toolStripButtonFullscreen";
            this.toolStripButtonFullscreen.Size = new System.Drawing.Size(92, 22);
            this.toolStripButtonFullscreen.Text = "Полный экран";
            this.toolStripButtonFullscreen.Click += new System.EventHandler(this.toolStripButtonFullscreen_Click);
            // 
            // toolStripButtonChangePlayersName
            // 
            this.toolStripButtonChangePlayersName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonChangePlayersName.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonChangePlayersName.Image")));
            this.toolStripButtonChangePlayersName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangePlayersName.Name = "toolStripButtonChangePlayersName";
            this.toolStripButtonChangePlayersName.Size = new System.Drawing.Size(90, 22);
            this.toolStripButtonChangePlayersName.Text = "Изменить имя";
            this.toolStripButtonChangePlayersName.Click += new System.EventHandler(this.toolStripButtonChangePlayersName_Click);
            // 
            // toolStripButtonGameSetting
            // 
            this.toolStripButtonGameSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGameSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGameSetting.Image")));
            this.toolStripButtonGameSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGameSetting.Name = "toolStripButtonGameSetting";
            this.toolStripButtonGameSetting.Size = new System.Drawing.Size(71, 22);
            this.toolStripButtonGameSetting.Text = "Настройки";
            this.toolStripButtonGameSetting.Click += new System.EventHandler(this.toolStripButtonGameSetting_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(45, 22);
            this.toolStripButtonExit.Text = "Выход";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(810, 640);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головоломка Линии";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new MouseEventHandler(this.FormMain_MouseClick);
            this.FormClosed += new FormClosedEventHandler(this.Form1_FormClosed);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNewGame;
        private ToolStripButton toolStripButtonFullscreen;
        private ToolStripButton toolStripButtonExit;
        private ToolStripButton toolStripButtonGameSetting;
        private ToolStripButton toolStripButtonChangePlayersName;
    }
}

