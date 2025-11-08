namespace BTHT3Bai_05
{
    partial class fTinhToan
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
            this.txt_Number1 = new System.Windows.Forms.TextBox();
            this.txt_Number2 = new System.Windows.Forms.TextBox();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.btn_Tru = new System.Windows.Forms.Button();
            this.btn_Nhan = new System.Windows.Forms.Button();
            this.btn_Chia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number2";
            // 
            // txt_Number1
            // 
            this.txt_Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Number1.Location = new System.Drawing.Point(224, 89);
            this.txt_Number1.Name = "txt_Number1";
            this.txt_Number1.Size = new System.Drawing.Size(274, 38);
            this.txt_Number1.TabIndex = 1;
            this.txt_Number1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Number1_KeyDown);
            this.txt_Number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Number1_KeyPress);
            // 
            // txt_Number2
            // 
            this.txt_Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Number2.Location = new System.Drawing.Point(224, 171);
            this.txt_Number2.Name = "txt_Number2";
            this.txt_Number2.Size = new System.Drawing.Size(274, 38);
            this.txt_Number2.TabIndex = 2;
            // 
            // btn_Sum
            // 
            this.btn_Sum.BackColor = System.Drawing.Color.Silver;
            this.btn_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sum.Location = new System.Drawing.Point(100, 243);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(82, 71);
            this.btn_Sum.TabIndex = 3;
            this.btn_Sum.Text = "+";
            this.btn_Sum.UseVisualStyleBackColor = false;
            this.btn_Sum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Tru
            // 
            this.btn_Tru.BackColor = System.Drawing.Color.Silver;
            this.btn_Tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tru.Location = new System.Drawing.Point(200, 243);
            this.btn_Tru.Name = "btn_Tru";
            this.btn_Tru.Size = new System.Drawing.Size(82, 71);
            this.btn_Tru.TabIndex = 4;
            this.btn_Tru.Text = "-";
            this.btn_Tru.UseVisualStyleBackColor = false;
            this.btn_Tru.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Nhan
            // 
            this.btn_Nhan.BackColor = System.Drawing.Color.Silver;
            this.btn_Nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhan.Location = new System.Drawing.Point(308, 243);
            this.btn_Nhan.Name = "btn_Nhan";
            this.btn_Nhan.Size = new System.Drawing.Size(82, 71);
            this.btn_Nhan.TabIndex = 5;
            this.btn_Nhan.Text = "x";
            this.btn_Nhan.UseVisualStyleBackColor = false;
            this.btn_Nhan.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Chia
            // 
            this.btn_Chia.BackColor = System.Drawing.Color.Silver;
            this.btn_Chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chia.Location = new System.Drawing.Point(416, 243);
            this.btn_Chia.Name = "btn_Chia";
            this.btn_Chia.Size = new System.Drawing.Size(82, 71);
            this.btn_Chia.TabIndex = 6;
            this.btn_Chia.Text = "/";
            this.btn_Chia.UseVisualStyleBackColor = false;
            this.btn_Chia.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Answer";
            // 
            // txt_Answer
            // 
            this.txt_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Answer.Location = new System.Drawing.Point(224, 356);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.ReadOnly = true;
            this.txt_Answer.Size = new System.Drawing.Size(274, 38);
            this.txt_Answer.TabIndex = 7;
            // 
            // fTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 439);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Chia);
            this.Controls.Add(this.btn_Nhan);
            this.Controls.Add(this.btn_Tru);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.txt_Number2);
            this.Controls.Add(this.txt_Number1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fTinhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab02-Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Number1;
        private System.Windows.Forms.TextBox txt_Number2;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.Button btn_Tru;
        private System.Windows.Forms.Button btn_Nhan;
        private System.Windows.Forms.Button btn_Chia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Answer;
    }
}

