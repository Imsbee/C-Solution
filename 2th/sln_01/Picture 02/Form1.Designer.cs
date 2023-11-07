namespace Picture_02
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.색상선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.빨간색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파란색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.검은색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선두께ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선두께입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.초기화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.지우개ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.색상선택ToolStripMenuItem,
            this.선두께ToolStripMenuItem,
            this.초기화ToolStripMenuItem,
            this.지우개ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "설정ToolStripMenuItem";
            // 
            // 색상선택ToolStripMenuItem
            // 
            this.색상선택ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.빨간색ToolStripMenuItem,
            this.파란색ToolStripMenuItem,
            this.검은색ToolStripMenuItem});
            this.색상선택ToolStripMenuItem.Name = "색상선택ToolStripMenuItem";
            this.색상선택ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.색상선택ToolStripMenuItem.Text = "색상선택";
            // 
            // 빨간색ToolStripMenuItem
            // 
            this.빨간색ToolStripMenuItem.Name = "빨간색ToolStripMenuItem";
            this.빨간색ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.빨간색ToolStripMenuItem.Text = "빨간색";
            this.빨간색ToolStripMenuItem.Click += new System.EventHandler(this.빨간색ToolStripMenuItem_Click);
            // 
            // 파란색ToolStripMenuItem
            // 
            this.파란색ToolStripMenuItem.Name = "파란색ToolStripMenuItem";
            this.파란색ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.파란색ToolStripMenuItem.Text = "파란색";
            this.파란색ToolStripMenuItem.Click += new System.EventHandler(this.파란색ToolStripMenuItem_Click);
            // 
            // 검은색ToolStripMenuItem
            // 
            this.검은색ToolStripMenuItem.Name = "검은색ToolStripMenuItem";
            this.검은색ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.검은색ToolStripMenuItem.Text = "검은색";
            this.검은색ToolStripMenuItem.Click += new System.EventHandler(this.검은색ToolStripMenuItem_Click);
            // 
            // 선두께ToolStripMenuItem
            // 
            this.선두께ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선두께입력ToolStripMenuItem});
            this.선두께ToolStripMenuItem.Name = "선두께ToolStripMenuItem";
            this.선두께ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.선두께ToolStripMenuItem.Text = "선두께";
            // 
            // 선두께입력ToolStripMenuItem
            // 
            this.선두께입력ToolStripMenuItem.Name = "선두께입력ToolStripMenuItem";
            this.선두께입력ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.선두께입력ToolStripMenuItem.Text = "선두께입력";
            this.선두께입력ToolStripMenuItem.Click += new System.EventHandler(this.선두께입력ToolStripMenuItem_Click);
            // 
            // 초기화ToolStripMenuItem
            // 
            this.초기화ToolStripMenuItem.Name = "초기화ToolStripMenuItem";
            this.초기화ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.초기화ToolStripMenuItem.Text = "초기화";
            this.초기화ToolStripMenuItem.Click += new System.EventHandler(this.초기화ToolStripMenuItem_Click);
            // 
            // 지우개ToolStripMenuItem
            // 
            this.지우개ToolStripMenuItem.Name = "지우개ToolStripMenuItem";
            this.지우개ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.지우개ToolStripMenuItem.Text = "지우개";
            this.지우개ToolStripMenuItem.Click += new System.EventHandler(this.지우개ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "그림판";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 색상선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 빨간색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파란색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 검은색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선두께ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선두께입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 초기화ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 지우개ToolStripMenuItem;
    }
}

