
namespace hockey1
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
            this.disk1 = new System.Windows.Forms.Button();
            this.disk2 = new System.Windows.Forms.Button();
            this.puck = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.puck)).BeginInit();
            this.SuspendLayout();
            // 
            // disk1
            // 
            this.disk1.BackColor = System.Drawing.Color.White;
            this.disk1.Location = new System.Drawing.Point(12, 157);
            this.disk1.Name = "disk1";
            this.disk1.Size = new System.Drawing.Size(20, 100);
            this.disk1.TabIndex = 0;
            this.disk1.TabStop = false;
            this.disk1.UseVisualStyleBackColor = false;
            this.disk1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.disk1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // disk2
            // 
            this.disk2.BackColor = System.Drawing.Color.White;
            this.disk2.Location = new System.Drawing.Point(768, 157);
            this.disk2.Name = "disk2";
            this.disk2.Size = new System.Drawing.Size(20, 100);
            this.disk2.TabIndex = 1;
            this.disk2.TabStop = false;
            this.disk2.UseVisualStyleBackColor = false;
            this.disk2.Click += new System.EventHandler(this.button2_Click);
            this.disk2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.disk2_KeyDown);
            // 
            // puck
            // 
            this.puck.Image = ((System.Drawing.Image)(resources.GetObject("puck.Image")));
            this.puck.Location = new System.Drawing.Point(390, 196);
            this.puck.Name = "puck";
            this.puck.Size = new System.Drawing.Size(20, 20);
            this.puck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.puck.TabIndex = 2;
            this.puck.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "PLAYER 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(530, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "PLAYER 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.ForeColor = System.Drawing.Color.White;
            this.score1.Location = new System.Drawing.Point(284, 9);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(16, 17);
            this.score1.TabIndex = 5;
            this.score1.Text = "0";
            this.score1.Click += new System.EventHandler(this.label3_Click);
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.ForeColor = System.Drawing.Color.White;
            this.score2.Location = new System.Drawing.Point(614, 9);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(16, 17);
            this.score2.TabIndex = 6;
            this.score2.Text = "0";
            this.score2.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(837, 456);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puck);
            this.Controls.Add(this.disk2);
            this.Controls.Add(this.disk1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.puck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disk1;
        private System.Windows.Forms.Button disk2;
        private System.Windows.Forms.PictureBox puck;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
    }
}

