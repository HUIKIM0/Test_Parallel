
namespace Test_Parallel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnParallelFor = new System.Windows.Forms.Button();
            this.btnParallelForeach = new System.Windows.Forms.Button();
            this.btnParallelInvoke = new System.Windows.Forms.Button();
            this.lboxTime = new System.Windows.Forms.ListBox();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lboxLog);
            this.groupBox1.Controls.Add(this.lboxTime);
            this.groupBox1.Controls.Add(this.btnParallelInvoke);
            this.groupBox1.Controls.Add(this.btnParallelForeach);
            this.groupBox1.Controls.Add(this.btnParallelFor);
            this.groupBox1.Controls.Add(this.btnfor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Parallel";
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(7, 25);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(140, 30);
            this.btnfor.TabIndex = 0;
            this.btnfor.Text = "for";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnParallelFor
            // 
            this.btnParallelFor.Location = new System.Drawing.Point(153, 25);
            this.btnParallelFor.Name = "btnParallelFor";
            this.btnParallelFor.Size = new System.Drawing.Size(140, 30);
            this.btnParallelFor.TabIndex = 1;
            this.btnParallelFor.Text = "Parallel For";
            this.btnParallelFor.UseVisualStyleBackColor = true;
            this.btnParallelFor.Click += new System.EventHandler(this.btnParallelFor_Click);
            // 
            // btnParallelForeach
            // 
            this.btnParallelForeach.Location = new System.Drawing.Point(299, 25);
            this.btnParallelForeach.Name = "btnParallelForeach";
            this.btnParallelForeach.Size = new System.Drawing.Size(140, 30);
            this.btnParallelForeach.TabIndex = 2;
            this.btnParallelForeach.Text = "Parallel Foreach";
            this.btnParallelForeach.UseVisualStyleBackColor = true;
            this.btnParallelForeach.Click += new System.EventHandler(this.btnParallelForeach_Click);
            // 
            // btnParallelInvoke
            // 
            this.btnParallelInvoke.Location = new System.Drawing.Point(445, 25);
            this.btnParallelInvoke.Name = "btnParallelInvoke";
            this.btnParallelInvoke.Size = new System.Drawing.Size(140, 30);
            this.btnParallelInvoke.TabIndex = 3;
            this.btnParallelInvoke.Text = "Parallel Invoke";
            this.btnParallelInvoke.UseVisualStyleBackColor = true;
            this.btnParallelInvoke.Click += new System.EventHandler(this.btnParallelInvoke_Click);
            // 
            // lboxTime
            // 
            this.lboxTime.FormattingEnabled = true;
            this.lboxTime.ItemHeight = 15;
            this.lboxTime.Location = new System.Drawing.Point(7, 62);
            this.lboxTime.Name = "lboxTime";
            this.lboxTime.Size = new System.Drawing.Size(578, 169);
            this.lboxTime.TabIndex = 4;
            // 
            // lboxLog
            // 
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 15;
            this.lboxLog.Location = new System.Drawing.Point(6, 238);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(579, 259);
            this.lboxLog.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 529);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnParallelInvoke;
        private System.Windows.Forms.Button btnParallelForeach;
        private System.Windows.Forms.Button btnParallelFor;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.ListBox lboxTime;
    }
}

