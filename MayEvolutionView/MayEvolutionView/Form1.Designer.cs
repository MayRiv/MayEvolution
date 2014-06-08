namespace MayEvolutionView
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.creaturesLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.hFearLabel = new System.Windows.Forms.Label();
            this.hSpeedLabel = new System.Windows.Forms.Label();
            this.cycleLabel = new System.Windows.Forms.Label();
            this.viewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(12, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(856, 546);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Load += new System.EventHandler(this.AnT_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(875, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // creaturesLabel
            // 
            this.creaturesLabel.AutoSize = true;
            this.creaturesLabel.Location = new System.Drawing.Point(876, 43);
            this.creaturesLabel.Name = "creaturesLabel";
            this.creaturesLabel.Size = new System.Drawing.Size(0, 13);
            this.creaturesLabel.TabIndex = 2;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(879, 64);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(41, 13);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed:";
            // 
            // hFearLabel
            // 
            this.hFearLabel.AutoSize = true;
            this.hFearLabel.Location = new System.Drawing.Point(879, 77);
            this.hFearLabel.Name = "hFearLabel";
            this.hFearLabel.Size = new System.Drawing.Size(66, 13);
            this.hFearLabel.TabIndex = 4;
            this.hFearLabel.Text = "HungerFear:";
            // 
            // hSpeedLabel
            // 
            this.hSpeedLabel.AutoSize = true;
            this.hSpeedLabel.Location = new System.Drawing.Point(879, 90);
            this.hSpeedLabel.Name = "hSpeedLabel";
            this.hSpeedLabel.Size = new System.Drawing.Size(76, 13);
            this.hSpeedLabel.TabIndex = 5;
            this.hSpeedLabel.Text = "HungerSpeed:";
            // 
            // cycleLabel
            // 
            this.cycleLabel.AutoSize = true;
            this.cycleLabel.Location = new System.Drawing.Point(879, 103);
            this.cycleLabel.Name = "cycleLabel";
            this.cycleLabel.Size = new System.Drawing.Size(67, 13);
            this.cycleLabel.TabIndex = 6;
            this.cycleLabel.Text = "CycleSpeed:";
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Location = new System.Drawing.Point(879, 116);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(66, 13);
            this.viewLabel.TabIndex = 16;
            this.viewLabel.Text = "ViewRadius:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 571);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.cycleLabel);
            this.Controls.Add(this.hSpeedLabel);
            this.Controls.Add(this.hFearLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.creaturesLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label creaturesLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label hFearLabel;
        private System.Windows.Forms.Label hSpeedLabel;
        private System.Windows.Forms.Label cycleLabel;
        private System.Windows.Forms.Label viewLabel;
    }
}

