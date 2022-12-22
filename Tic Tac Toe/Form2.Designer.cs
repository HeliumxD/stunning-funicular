namespace Tic_Tac_Toe
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player One Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Two Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // P1
            // 
            this.P1.Location = new System.Drawing.Point(240, 44);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(204, 27);
            this.P1.TabIndex = 2;
            this.P1.TextChanged += new System.EventHandler(this.p1_TextChanged);
            // 
            // P2
            // 
            this.P2.Location = new System.Drawing.Point(240, 77);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(204, 27);
            this.P2.TabIndex = 3;
            this.P2.TextChanged += new System.EventHandler(this.p2_TextChanged);
            this.P2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox P1;
        private TextBox P2;
        private Button button1;
    }
}