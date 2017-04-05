namespace MultiFonctionClock
{
    partial class MainView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerInvalidate = new System.Windows.Forms.Timer(this.components);
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.mnStrpMain = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skyClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAnAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmmyyyyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerInvalidate
            // 
            this.timerInvalidate.Enabled = true;
            this.timerInvalidate.Interval = 25;
            this.timerInvalidate.Tick += new System.EventHandler(this.timerInvalidate_Tick);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Enabled = true;
            this.timerAlarm.Interval = 1000;
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // mnStrpMain
            // 
            this.mnStrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.mnStrpMain.Location = new System.Drawing.Point(0, 0);
            this.mnStrpMain.Name = "mnStrpMain";
            this.mnStrpMain.Size = new System.Drawing.Size(244, 24);
            this.mnStrpMain.TabIndex = 1;
            this.mnStrpMain.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockTypeToolStripMenuItem,
            this.alarmToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // clockTypeToolStripMenuItem
            // 
            this.clockTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularToolStripMenuItem});
            this.clockTypeToolStripMenuItem.Name = "clockTypeToolStripMenuItem";
            this.clockTypeToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.clockTypeToolStripMenuItem.Text = "Clock";
            // 
            // regularToolStripMenuItem
            // 
            this.regularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digitalToolStripMenuItem,
            this.regularToolStripMenuItem1});
            this.regularToolStripMenuItem.Name = "regularToolStripMenuItem";
            this.regularToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.regularToolStripMenuItem.Text = "Type";
            // 
            // digitalToolStripMenuItem
            // 
            this.digitalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decimalToolStripMenuItem,
            this.hexadecimalToolStripMenuItem,
            this.binaryToolStripMenuItem,
            this.octalToolStripMenuItem,
            this.romanToolStripMenuItem});
            this.digitalToolStripMenuItem.Name = "digitalToolStripMenuItem";
            this.digitalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.digitalToolStripMenuItem.Text = "Digital";
            // 
            // decimalToolStripMenuItem
            // 
            this.decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
            this.decimalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.decimalToolStripMenuItem.Text = "Decimal";
            this.decimalToolStripMenuItem.Click += new System.EventHandler(this.decimalToolStripMenuItem_Click);
            // 
            // hexadecimalToolStripMenuItem
            // 
            this.hexadecimalToolStripMenuItem.Name = "hexadecimalToolStripMenuItem";
            this.hexadecimalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.hexadecimalToolStripMenuItem.Text = "Hexadecimal";
            this.hexadecimalToolStripMenuItem.Click += new System.EventHandler(this.hexadecimalToolStripMenuItem_Click);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // octalToolStripMenuItem
            // 
            this.octalToolStripMenuItem.Name = "octalToolStripMenuItem";
            this.octalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.octalToolStripMenuItem.Text = "Octal";
            this.octalToolStripMenuItem.Click += new System.EventHandler(this.octalToolStripMenuItem_Click);
            // 
            // romanToolStripMenuItem
            // 
            this.romanToolStripMenuItem.Name = "romanToolStripMenuItem";
            this.romanToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.romanToolStripMenuItem.Text = "Roman";
            this.romanToolStripMenuItem.Click += new System.EventHandler(this.romanToolStripMenuItem_Click);
            // 
            // regularToolStripMenuItem1
            // 
            this.regularToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.skyClockToolStripMenuItem,
            this.pointClockToolStripMenuItem});
            this.regularToolStripMenuItem1.Name = "regularToolStripMenuItem1";
            this.regularToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.regularToolStripMenuItem1.Text = "Regular";
            this.regularToolStripMenuItem1.Click += new System.EventHandler(this.regularToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // skyClockToolStripMenuItem
            // 
            this.skyClockToolStripMenuItem.Name = "skyClockToolStripMenuItem";
            this.skyClockToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.skyClockToolStripMenuItem.Text = "SkyClock";
            this.skyClockToolStripMenuItem.Click += new System.EventHandler(this.skyClockToolStripMenuItem_Click);
            // 
            // pointClockToolStripMenuItem
            // 
            this.pointClockToolStripMenuItem.Name = "pointClockToolStripMenuItem";
            this.pointClockToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.pointClockToolStripMenuItem.Text = "PointClock";
            this.pointClockToolStripMenuItem.Click += new System.EventHandler(this.pointClockToolStripMenuItem_Click);
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAnAlarmToolStripMenuItem});
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.alarmToolStripMenuItem.Text = "Alarm";
            // 
            // setAnAlarmToolStripMenuItem
            // 
            this.setAnAlarmToolStripMenuItem.Name = "setAnAlarmToolStripMenuItem";
            this.setAnAlarmToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.setAnAlarmToolStripMenuItem.Text = "Set an alarm";
            this.setAnAlarmToolStripMenuItem.Click += new System.EventHandler(this.setAnAlarmToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.ddmmyyyyToolStripMenuItem});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // ddmmyyyyToolStripMenuItem
            // 
            this.ddmmyyyyToolStripMenuItem.Name = "ddmmyyyyToolStripMenuItem";
            this.ddmmyyyyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ddmmyyyyToolStripMenuItem.Text = "dd/mm/yyyy";
            this.ddmmyyyyToolStripMenuItem.Click += new System.EventHandler(this.ddmmyyyyToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 302);
            this.Controls.Add(this.mnStrpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnStrpMain;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainView_Paint);
            this.mnStrpMain.ResumeLayout(false);
            this.mnStrpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerInvalidate;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.MenuStrip mnStrpMain;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clockTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAnAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexadecimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ddmmyyyyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skyClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanToolStripMenuItem;
    }
}

