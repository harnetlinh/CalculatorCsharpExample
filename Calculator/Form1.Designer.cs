namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbNumA = new TextBox();
            tbNumB = new TextBox();
            tbNumC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // tbNumA
            // 
            tbNumA.Location = new Point(117, 38);
            tbNumA.Name = "tbNumA";
            tbNumA.Size = new Size(141, 23);
            tbNumA.TabIndex = 0;
            // 
            // tbNumB
            // 
            tbNumB.Location = new Point(117, 93);
            tbNumB.Name = "tbNumB";
            tbNumB.Size = new Size(141, 23);
            tbNumB.TabIndex = 1;
            // 
            // tbNumC
            // 
            tbNumC.Location = new Point(117, 149);
            tbNumC.Name = "tbNumC";
            tbNumC.Size = new Size(141, 23);
            tbNumC.TabIndex = 2;
            tbNumC.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 3;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 101);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 152);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 5;
            label3.Text = "C";
            // 
            // btnCong
            // 
            btnCong.BackColor = SystemColors.ActiveCaption;
            btnCong.Location = new Point(427, 33);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(75, 23);
            btnCong.TabIndex = 6;
            btnCong.Text = "Cong";
            btnCong.UseVisualStyleBackColor = false;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.BackColor = SystemColors.Info;
            btnTru.Location = new Point(427, 77);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(75, 23);
            btnTru.TabIndex = 7;
            btnTru.Text = "Tru";
            btnTru.UseVisualStyleBackColor = false;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = SystemColors.ScrollBar;
            btnNhan.Location = new Point(427, 123);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(75, 23);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "Nhan";
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.BackColor = SystemColors.AppWorkspace;
            btnChia.Location = new Point(427, 165);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(75, 23);
            btnChia.TabIndex = 9;
            btnChia.Text = "Chia";
            btnChia.UseVisualStyleBackColor = false;
            btnChia.Click += btnChia_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(50, 208);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(452, 23);
            btnReset.TabIndex = 10;
            btnReset.Text = "reset ";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNumC);
            Controls.Add(tbNumB);
            Controls.Add(tbNumA);
            Name = "Form1";
            Text = "Linh's Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNumA;
        private TextBox tbNumB;
        private TextBox tbNumC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnReset;
    }
}