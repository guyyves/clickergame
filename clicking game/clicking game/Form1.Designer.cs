
namespace clicking_game
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
            this.lblSpelerpunten = new System.Windows.Forms.Label();
            this.btnUpgrade50 = new System.Windows.Forms.Button();
            this.btnUpgrade100 = new System.Windows.Forms.Button();
            this.btnUpgrade500 = new System.Windows.Forms.Button();
            this.btnUpgrade1000 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblU50 = new System.Windows.Forms.Label();
            this.btnUpgrade2500 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCPM = new System.Windows.Forms.Label();
            this.lblTf = new System.Windows.Forms.Label();
            this.lblTw2 = new System.Windows.Forms.Label();
            this.lblTm2 = new System.Windows.Forms.Label();
            this.lblTm1 = new System.Windows.Forms.Label();
            this.lblTw = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSpelerpunten
            // 
            this.lblSpelerpunten.AutoSize = true;
            this.lblSpelerpunten.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpelerpunten.Location = new System.Drawing.Point(6, 18);
            this.lblSpelerpunten.Name = "lblSpelerpunten";
            this.lblSpelerpunten.Size = new System.Drawing.Size(207, 46);
            this.lblSpelerpunten.TabIndex = 0;
            this.lblSpelerpunten.Text = "0 TACO\'S";
            this.lblSpelerpunten.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpgrade50
            // 
            this.btnUpgrade50.Location = new System.Drawing.Point(9, 19);
            this.btnUpgrade50.Name = "btnUpgrade50";
            this.btnUpgrade50.Size = new System.Drawing.Size(257, 36);
            this.btnUpgrade50.TabIndex = 3;
            this.btnUpgrade50.Text = "50 Taco\'s";
            this.btnUpgrade50.UseVisualStyleBackColor = true;
            this.btnUpgrade50.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpgrade100
            // 
            this.btnUpgrade100.Location = new System.Drawing.Point(9, 61);
            this.btnUpgrade100.Name = "btnUpgrade100";
            this.btnUpgrade100.Size = new System.Drawing.Size(257, 36);
            this.btnUpgrade100.TabIndex = 4;
            this.btnUpgrade100.Text = "100 Taco\'s";
            this.btnUpgrade100.UseVisualStyleBackColor = true;
            this.btnUpgrade100.Click += new System.EventHandler(this.btnUpgrade100_Click);
            // 
            // btnUpgrade500
            // 
            this.btnUpgrade500.Location = new System.Drawing.Point(9, 103);
            this.btnUpgrade500.Name = "btnUpgrade500";
            this.btnUpgrade500.Size = new System.Drawing.Size(257, 36);
            this.btnUpgrade500.TabIndex = 5;
            this.btnUpgrade500.Text = "500 Taco\'s";
            this.btnUpgrade500.UseVisualStyleBackColor = true;
            this.btnUpgrade500.Click += new System.EventHandler(this.btnUpgrade500_Click);
            // 
            // btnUpgrade1000
            // 
            this.btnUpgrade1000.Location = new System.Drawing.Point(9, 145);
            this.btnUpgrade1000.Name = "btnUpgrade1000";
            this.btnUpgrade1000.Size = new System.Drawing.Size(257, 36);
            this.btnUpgrade1000.TabIndex = 6;
            this.btnUpgrade1000.Text = "1000 Taco\'s";
            this.btnUpgrade1000.UseVisualStyleBackColor = true;
            this.btnUpgrade1000.Click += new System.EventHandler(this.btnUpgrade1000_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Upgrades";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblU50);
            this.groupBox1.Controls.Add(this.btnUpgrade2500);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnUpgrade1000);
            this.groupBox1.Controls.Add(this.btnUpgrade500);
            this.groupBox1.Controls.Add(this.btnUpgrade100);
            this.groupBox1.Controls.Add(this.btnUpgrade50);
            this.groupBox1.Location = new System.Drawing.Point(459, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 239);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Taco fabriek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Taco Winkel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Taco machine 2.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Taco machine 1.0";
            // 
            // lblU50
            // 
            this.lblU50.AutoSize = true;
            this.lblU50.Location = new System.Drawing.Point(281, 29);
            this.lblU50.Name = "lblU50";
            this.lblU50.Size = new System.Drawing.Size(117, 17);
            this.lblU50.TabIndex = 9;
            this.lblU50.Text = "Taco Werknemer";
            // 
            // btnUpgrade2500
            // 
            this.btnUpgrade2500.Location = new System.Drawing.Point(9, 187);
            this.btnUpgrade2500.Name = "btnUpgrade2500";
            this.btnUpgrade2500.Size = new System.Drawing.Size(257, 36);
            this.btnUpgrade2500.TabIndex = 8;
            this.btnUpgrade2500.Text = "2500 Taco\'s";
            this.btnUpgrade2500.UseVisualStyleBackColor = true;
            this.btnUpgrade2500.Click += new System.EventHandler(this.btnUpgrade2500_Click);
            // 
            // button1
            // 
            this.button1.Image = global::clicking_game.Properties.Resources.taco;
            this.button1.Location = new System.Drawing.Point(636, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 204);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCPM);
            this.groupBox2.Controls.Add(this.lblTf);
            this.groupBox2.Controls.Add(this.lblTw2);
            this.groupBox2.Controls.Add(this.lblTm2);
            this.groupBox2.Controls.Add(this.lblTm1);
            this.groupBox2.Controls.Add(this.lblTw);
            this.groupBox2.Controls.Add(this.lblSpelerpunten);
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 362);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // lblCPM
            // 
            this.lblCPM.AutoSize = true;
            this.lblCPM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPM.Location = new System.Drawing.Point(6, 64);
            this.lblCPM.Name = "lblCPM";
            this.lblCPM.Size = new System.Drawing.Size(83, 28);
            this.lblCPM.TabIndex = 19;
            this.lblCPM.Text = "TPM 0";
            this.lblCPM.Click += new System.EventHandler(this.lblCPM_Click);
            // 
            // lblTf
            // 
            this.lblTf.AutoSize = true;
            this.lblTf.Location = new System.Drawing.Point(10, 285);
            this.lblTf.Name = "lblTf";
            this.lblTf.Size = new System.Drawing.Size(87, 17);
            this.lblTf.TabIndex = 18;
            this.lblTf.Text = "Taco fabriek";
            // 
            // lblTw2
            // 
            this.lblTw2.AutoSize = true;
            this.lblTw2.Location = new System.Drawing.Point(10, 243);
            this.lblTw2.Name = "lblTw2";
            this.lblTw2.Size = new System.Drawing.Size(86, 17);
            this.lblTw2.TabIndex = 17;
            this.lblTw2.Text = "Taco Winkel";
            // 
            // lblTm2
            // 
            this.lblTm2.AutoSize = true;
            this.lblTm2.Location = new System.Drawing.Point(10, 201);
            this.lblTm2.Name = "lblTm2";
            this.lblTm2.Size = new System.Drawing.Size(121, 17);
            this.lblTm2.TabIndex = 16;
            this.lblTm2.Text = "Taco machine 2.0";
            // 
            // lblTm1
            // 
            this.lblTm1.AutoSize = true;
            this.lblTm1.Location = new System.Drawing.Point(10, 159);
            this.lblTm1.Name = "lblTm1";
            this.lblTm1.Size = new System.Drawing.Size(121, 17);
            this.lblTm1.TabIndex = 15;
            this.lblTm1.Text = "Taco machine 1.0";
            // 
            // lblTw
            // 
            this.lblTw.AutoSize = true;
            this.lblTw.Location = new System.Drawing.Point(10, 117);
            this.lblTw.Name = "lblTw";
            this.lblTw.Size = new System.Drawing.Size(117, 17);
            this.lblTw.TabIndex = 14;
            this.lblTw.Text = "Taco Werknemer";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Taco Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSpelerpunten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpgrade50;
        private System.Windows.Forms.Button btnUpgrade100;
        private System.Windows.Forms.Button btnUpgrade500;
        private System.Windows.Forms.Button btnUpgrade1000;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpgrade2500;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblU50;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTf;
        private System.Windows.Forms.Label lblTw2;
        private System.Windows.Forms.Label lblTm2;
        private System.Windows.Forms.Label lblTm1;
        private System.Windows.Forms.Label lblTw;
        private System.Windows.Forms.Label lblCPM;
        private System.Windows.Forms.Timer timer2;
    }
}

