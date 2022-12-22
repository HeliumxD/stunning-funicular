namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gegenComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.x_win_Count = new System.Windows.Forms.Label();
            this.draw_Count = new System.Windows.Forms.Label();
            this.o_win_Count = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.TextBox();
            this.P1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.gegenComputerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gegenComputerToolStripMenuItem
            // 
            this.gegenComputerToolStripMenuItem.Name = "gegenComputerToolStripMenuItem";
            this.gegenComputerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.gegenComputerToolStripMenuItem.Text = "Gegen Computer spielen";
            this.gegenComputerToolStripMenuItem.Click += new System.EventHandler(this.gegenComputerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.Location = new System.Drawing.Point(10, 23);
            this.A1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(82, 70);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.Location = new System.Drawing.Point(98, 23);
            this.A2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(82, 70);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.Location = new System.Drawing.Point(186, 23);
            this.A3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(82, 70);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.Location = new System.Drawing.Point(187, 97);
            this.B3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(82, 70);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.Location = new System.Drawing.Point(98, 98);
            this.B2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(82, 70);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.Location = new System.Drawing.Point(10, 98);
            this.B1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(82, 70);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.Location = new System.Drawing.Point(186, 173);
            this.C3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(82, 70);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.Location = new System.Drawing.Point(98, 173);
            this.C2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(82, 70);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.Location = new System.Drawing.Point(10, 173);
            this.C1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(82, 70);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draw Count";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // x_win_Count
            // 
            this.x_win_Count.AutoSize = true;
            this.x_win_Count.Location = new System.Drawing.Point(42, 286);
            this.x_win_Count.Name = "x_win_Count";
            this.x_win_Count.Size = new System.Drawing.Size(13, 15);
            this.x_win_Count.TabIndex = 13;
            this.x_win_Count.Text = "0";
            this.x_win_Count.Click += new System.EventHandler(this.X_win_Count_Click);
            // 
            // draw_Count
            // 
            this.draw_Count.AutoSize = true;
            this.draw_Count.Location = new System.Drawing.Point(129, 286);
            this.draw_Count.Name = "draw_Count";
            this.draw_Count.Size = new System.Drawing.Size(13, 15);
            this.draw_Count.TabIndex = 14;
            this.draw_Count.Text = "0";
            this.draw_Count.Click += new System.EventHandler(this.Draw_Count_Click);
            // 
            // o_win_Count
            // 
            this.o_win_Count.AutoSize = true;
            this.o_win_Count.Location = new System.Drawing.Point(218, 286);
            this.o_win_Count.Name = "o_win_Count";
            this.o_win_Count.Size = new System.Drawing.Size(13, 15);
            this.o_win_Count.TabIndex = 15;
            this.o_win_Count.Text = "0";
            this.o_win_Count.Click += new System.EventHandler(this.O_win_Count_Click);
            // 
            // P2
            // 
            this.P2.Location = new System.Drawing.Point(178, 263);
            this.P2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(91, 23);
            this.P2.TabIndex = 16;
            this.P2.Text = "Player 2";
            this.P2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.P2.TextChanged += new System.EventHandler(this.P2_TextChanged);
            // 
            // P1
            // 
            this.P1.Location = new System.Drawing.Point(10, 264);
            this.P1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(91, 23);
            this.P1.TabIndex = 17;
            this.P1.Text = "Player 1";
            this.P1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.P1.TextChanged += new System.EventHandler(this.P1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 310);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.o_win_Count);
            this.Controls.Add(this.draw_Count);
            this.Controls.Add(this.x_win_Count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B3;
        private Button B2;
        private Button B1;
        private Button C3;
        private Button C2;
        private Button C1;
        private Label label2;
        private Label x_win_Count;
        private Label draw_Count;
        private Label o_win_Count;
        private TextBox P2;
        private TextBox P1;
        private ToolStripMenuItem gegenComputerToolStripMenuItem;
    }
}