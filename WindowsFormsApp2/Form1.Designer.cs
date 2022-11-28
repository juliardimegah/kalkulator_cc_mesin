namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBore = new System.Windows.Forms.TextBox();
            this.tbStroke = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bHitung = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.epcorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.eperror = new System.Windows.Forms.ErrorProvider(this.components);
            this.epwarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epinfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbJumlahSilinder = new System.Windows.Forms.GroupBox();
            this.rb1Silinder = new System.Windows.Forms.RadioButton();
            this.rb2Silinder = new System.Windows.Forms.RadioButton();
            this.rb3Silinder = new System.Windows.Forms.RadioButton();
            this.rb4Silinder = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.epcorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eperror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epwarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epinfo)).BeginInit();
            this.gbJumlahSilinder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yaro Op", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator Hitung CC Mesin";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stroke";
            // 
            // tbBore
            // 
            this.tbBore.Location = new System.Drawing.Point(104, 114);
            this.tbBore.Name = "tbBore";
            this.tbBore.Size = new System.Drawing.Size(100, 20);
            this.tbBore.TabIndex = 3;
            this.tbBore.Leave += new System.EventHandler(this.tbBore_Leave);
            // 
            // tbStroke
            // 
            this.tbStroke.Location = new System.Drawing.Point(104, 174);
            this.tbStroke.Name = "tbStroke";
            this.tbStroke.Size = new System.Drawing.Size(100, 20);
            this.tbStroke.TabIndex = 4;
            this.tbStroke.Leave += new System.EventHandler(this.tbStroke_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jumlah Silinder";
            // 
            // bHitung
            // 
            this.bHitung.Location = new System.Drawing.Point(222, 273);
            this.bHitung.Name = "bHitung";
            this.bHitung.Size = new System.Drawing.Size(75, 23);
            this.bHitung.TabIndex = 10;
            this.bHitung.Text = "&Hitung";
            this.bHitung.UseVisualStyleBackColor = true;
            this.bHitung.Click += new System.EventHandler(this.bHitung_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(363, 273);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 11;
            this.bClear.Text = "&Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // epcorrect
            // 
            this.epcorrect.ContainerControl = this;
            this.epcorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epcorrect.Icon")));
            // 
            // eperror
            // 
            this.eperror.ContainerControl = this;
            this.eperror.Icon = ((System.Drawing.Icon)(resources.GetObject("eperror.Icon")));
            // 
            // epwarning
            // 
            this.epwarning.ContainerControl = this;
            this.epwarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epwarning.Icon")));
            // 
            // epinfo
            // 
            this.epinfo.ContainerControl = this;
            this.epinfo.Icon = ((System.Drawing.Icon)(resources.GetObject("epinfo.Icon")));
            // 
            // gbJumlahSilinder
            // 
            this.gbJumlahSilinder.Controls.Add(this.rb4Silinder);
            this.gbJumlahSilinder.Controls.Add(this.rb3Silinder);
            this.gbJumlahSilinder.Controls.Add(this.rb2Silinder);
            this.gbJumlahSilinder.Controls.Add(this.rb1Silinder);
            this.gbJumlahSilinder.Location = new System.Drawing.Point(411, 114);
            this.gbJumlahSilinder.Name = "gbJumlahSilinder";
            this.gbJumlahSilinder.Size = new System.Drawing.Size(289, 90);
            this.gbJumlahSilinder.TabIndex = 12;
            this.gbJumlahSilinder.TabStop = false;
            // 
            // rb1Silinder
            // 
            this.rb1Silinder.AutoSize = true;
            this.rb1Silinder.Location = new System.Drawing.Point(6, 19);
            this.rb1Silinder.Name = "rb1Silinder";
            this.rb1Silinder.Size = new System.Drawing.Size(68, 17);
            this.rb1Silinder.TabIndex = 0;
            this.rb1Silinder.TabStop = true;
            this.rb1Silinder.Text = "1 Silinder";
            this.rb1Silinder.UseVisualStyleBackColor = true;
            this.rb1Silinder.CheckedChanged += new System.EventHandler(this.rb1Silinder_CheckedChanged);
            // 
            // rb2Silinder
            // 
            this.rb2Silinder.AutoSize = true;
            this.rb2Silinder.Location = new System.Drawing.Point(6, 54);
            this.rb2Silinder.Name = "rb2Silinder";
            this.rb2Silinder.Size = new System.Drawing.Size(68, 17);
            this.rb2Silinder.TabIndex = 1;
            this.rb2Silinder.TabStop = true;
            this.rb2Silinder.Text = "2 Silinder";
            this.rb2Silinder.UseVisualStyleBackColor = true;
            this.rb2Silinder.CheckedChanged += new System.EventHandler(this.rb2Silinder_CheckedChanged);
            // 
            // rb3Silinder
            // 
            this.rb3Silinder.AutoSize = true;
            this.rb3Silinder.Location = new System.Drawing.Point(110, 19);
            this.rb3Silinder.Name = "rb3Silinder";
            this.rb3Silinder.Size = new System.Drawing.Size(68, 17);
            this.rb3Silinder.TabIndex = 2;
            this.rb3Silinder.TabStop = true;
            this.rb3Silinder.Text = "3 Silinder";
            this.rb3Silinder.UseVisualStyleBackColor = true;
            this.rb3Silinder.CheckedChanged += new System.EventHandler(this.rb3Silinder_CheckedChanged);
            // 
            // rb4Silinder
            // 
            this.rb4Silinder.AutoSize = true;
            this.rb4Silinder.Location = new System.Drawing.Point(110, 54);
            this.rb4Silinder.Name = "rb4Silinder";
            this.rb4Silinder.Size = new System.Drawing.Size(68, 17);
            this.rb4Silinder.TabIndex = 3;
            this.rb4Silinder.TabStop = true;
            this.rb4Silinder.Text = "4 Silinder";
            this.rb4Silinder.UseVisualStyleBackColor = true;
            this.rb4Silinder.CheckedChanged += new System.EventHandler(this.rb4Silinder_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 312);
            this.Controls.Add(this.gbJumlahSilinder);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bHitung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStroke);
            this.Controls.Add(this.tbBore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epcorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eperror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epwarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epinfo)).EndInit();
            this.gbJumlahSilinder.ResumeLayout(false);
            this.gbJumlahSilinder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBore;
        private System.Windows.Forms.TextBox tbStroke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bHitung;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ErrorProvider epcorrect;
        private System.Windows.Forms.ErrorProvider eperror;
        private System.Windows.Forms.ErrorProvider epwarning;
        private System.Windows.Forms.ErrorProvider epinfo;
        private System.Windows.Forms.GroupBox gbJumlahSilinder;
        private System.Windows.Forms.RadioButton rb4Silinder;
        private System.Windows.Forms.RadioButton rb3Silinder;
        private System.Windows.Forms.RadioButton rb2Silinder;
        private System.Windows.Forms.RadioButton rb1Silinder;
    }
}

