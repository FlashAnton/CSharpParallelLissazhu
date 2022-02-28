namespace Lisazy
{
    partial class frmMain
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
            this.pbFieldPrime = new System.Windows.Forms.PictureBox();
            this.btnDots = new System.Windows.Forms.Button();
            this.chkFix = new System.Windows.Forms.CheckBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtox = new System.Windows.Forms.TextBox();
            this.txtoy = new System.Windows.Forms.TextBox();
            this.txtfx = new System.Windows.Forms.TextBox();
            this.txtfy = new System.Windows.Forms.TextBox();
            this.btnLines = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.pbFieldSecond = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFieldPrime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFieldSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFieldPrime
            // 
            this.pbFieldPrime.Location = new System.Drawing.Point(215, 73);
            this.pbFieldPrime.Margin = new System.Windows.Forms.Padding(4);
            this.pbFieldPrime.Name = "pbFieldPrime";
            this.pbFieldPrime.Size = new System.Drawing.Size(400, 400);
            this.pbFieldPrime.TabIndex = 0;
            this.pbFieldPrime.TabStop = false;
            // 
            // btnDots
            // 
            this.btnDots.Location = new System.Drawing.Point(215, 3);
            this.btnDots.Margin = new System.Windows.Forms.Padding(4);
            this.btnDots.Name = "btnDots";
            this.btnDots.Size = new System.Drawing.Size(100, 28);
            this.btnDots.TabIndex = 1;
            this.btnDots.Text = "точками";
            this.btnDots.UseVisualStyleBackColor = true;
            this.btnDots.Click += new System.EventHandler(this.btnDots_Click);
            // 
            // chkFix
            // 
            this.chkFix.AutoSize = true;
            this.chkFix.Location = new System.Drawing.Point(215, 42);
            this.chkFix.Margin = new System.Windows.Forms.Padding(4);
            this.chkFix.Name = "chkFix";
            this.chkFix.Size = new System.Drawing.Size(243, 21);
            this.chkFix.TabIndex = 2;
            this.chkFix.Text = "Закрепить введённые значения";
            this.chkFix.UseVisualStyleBackColor = true;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(55, 41);
            this.txta.Margin = new System.Windows.Forms.Padding(4);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(132, 22);
            this.txta.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(55, 73);
            this.txtb.Margin = new System.Windows.Forms.Padding(4);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(132, 22);
            this.txtb.TabIndex = 4;
            // 
            // txtox
            // 
            this.txtox.Location = new System.Drawing.Point(55, 105);
            this.txtox.Margin = new System.Windows.Forms.Padding(4);
            this.txtox.Name = "txtox";
            this.txtox.Size = new System.Drawing.Size(132, 22);
            this.txtox.TabIndex = 5;
            // 
            // txtoy
            // 
            this.txtoy.Location = new System.Drawing.Point(55, 137);
            this.txtoy.Margin = new System.Windows.Forms.Padding(4);
            this.txtoy.Name = "txtoy";
            this.txtoy.Size = new System.Drawing.Size(132, 22);
            this.txtoy.TabIndex = 6;
            // 
            // txtfx
            // 
            this.txtfx.Location = new System.Drawing.Point(55, 169);
            this.txtfx.Margin = new System.Windows.Forms.Padding(4);
            this.txtfx.Name = "txtfx";
            this.txtfx.Size = new System.Drawing.Size(132, 22);
            this.txtfx.TabIndex = 7;
            // 
            // txtfy
            // 
            this.txtfy.Location = new System.Drawing.Point(55, 201);
            this.txtfy.Margin = new System.Windows.Forms.Padding(4);
            this.txtfy.Name = "txtfy";
            this.txtfy.Size = new System.Drawing.Size(132, 22);
            this.txtfy.TabIndex = 8;
            // 
            // btnLines
            // 
            this.btnLines.Location = new System.Drawing.Point(323, 3);
            this.btnLines.Margin = new System.Windows.Forms.Padding(4);
            this.btnLines.Name = "btnLines";
            this.btnLines.Size = new System.Drawing.Size(100, 28);
            this.btnLines.TabIndex = 9;
            this.btnLines.Text = "линиями";
            this.btnLines.UseVisualStyleBackColor = true;
            this.btnLines.Click += new System.EventHandler(this.btnLines_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "α";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "β";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "ω X ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "ω Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "ϕ X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "ϕ Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Построение фигуры Лиссажу";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(9, 231);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pbFieldSecond
            // 
            this.pbFieldSecond.Location = new System.Drawing.Point(623, 73);
            this.pbFieldSecond.Margin = new System.Windows.Forms.Padding(4);
            this.pbFieldSecond.Name = "pbFieldSecond";
            this.pbFieldSecond.Size = new System.Drawing.Size(400, 400);
            this.pbFieldSecond.TabIndex = 18;
            this.pbFieldSecond.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 493);
            this.Controls.Add(this.pbFieldSecond);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLines);
            this.Controls.Add(this.txtfy);
            this.Controls.Add(this.txtfx);
            this.Controls.Add(this.txtoy);
            this.Controls.Add(this.txtox);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.chkFix);
            this.Controls.Add(this.btnDots);
            this.Controls.Add(this.pbFieldPrime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Фигуры Лиссажу";
            this.Load += new System.EventHandler(this.Lesazy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFieldPrime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFieldSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFieldPrime;
        private System.Windows.Forms.Button btnDots;
        private System.Windows.Forms.CheckBox chkFix;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtox;
        private System.Windows.Forms.TextBox txtoy;
        private System.Windows.Forms.TextBox txtfx;
        private System.Windows.Forms.TextBox txtfy;
        private System.Windows.Forms.Button btnLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pbFieldSecond;
    }
}

