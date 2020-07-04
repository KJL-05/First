namespace First
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonADD = new System.Windows.Forms.Button();
            this.textBoxOp2 = new System.Windows.Forms.TextBox();
            this.textBoxOp1 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonmMul = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("萝莉体 第二版", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonADD.ForeColor = System.Drawing.Color.Red;
            this.buttonADD.Location = new System.Drawing.Point(251, 114);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(86, 54);
            this.buttonADD.TabIndex = 0;
            this.buttonADD.Text = "+";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOp2
            // 
            this.textBoxOp2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxOp2.Location = new System.Drawing.Point(80, 211);
            this.textBoxOp2.Name = "textBoxOp2";
            this.textBoxOp2.Size = new System.Drawing.Size(100, 38);
            this.textBoxOp2.TabIndex = 1;
            // 
            // textBoxOp1
            // 
            this.textBoxOp1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxOp1.Location = new System.Drawing.Point(80, 130);
            this.textBoxOp1.Name = "textBoxOp1";
            this.textBoxOp1.Size = new System.Drawing.Size(100, 38);
            this.textBoxOp1.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(62, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(137, 40);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "result";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("萝莉体 第二版", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(251, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonmMul
            // 
            this.buttonmMul.Font = new System.Drawing.Font("萝莉体 第二版", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonmMul.ForeColor = System.Drawing.Color.Red;
            this.buttonmMul.Location = new System.Drawing.Point(360, 114);
            this.buttonmMul.Name = "buttonmMul";
            this.buttonmMul.Size = new System.Drawing.Size(88, 54);
            this.buttonmMul.TabIndex = 5;
            this.buttonmMul.Text = "X";
            this.buttonmMul.UseVisualStyleBackColor = true;
            this.buttonmMul.Click += new System.EventHandler(this.buttonmMul_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("萝莉体 第二版", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(360, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 331);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonmMul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxOp1);
            this.Controls.Add(this.textBoxOp2);
            this.Controls.Add(this.buttonADD);
            this.Name = "Form1";
            this.Text = "My calt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.TextBox textBoxOp2;
        private System.Windows.Forms.TextBox textBoxOp1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonmMul;
        private System.Windows.Forms.Button button3;
    }
}

