namespace RacingGame
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
            this.Better = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtMaxBet = new System.Windows.Forms.Label();
            this.numBetAmount = new System.Windows.Forms.NumericUpDown();
            this.numThingNumber = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ListBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBetStatus1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBetStatus2 = new System.Windows.Forms.Label();
            this.lblBetStatus3 = new System.Windows.Forms.Label();
            this.PB4 = new System.Windows.Forms.PictureBox();
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtJoe = new System.Windows.Forms.Label();
            this.txtAl = new System.Windows.Forms.Label();
            this.txtBob = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThingNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // Better
            // 
            this.Better.AutoSize = true;
            this.Better.Location = new System.Drawing.Point(185, 312);
            this.Better.Name = "Better";
            this.Better.Size = new System.Drawing.Size(35, 13);
            this.Better.TabIndex = 0;
            this.Better.Text = "Better";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "on thing number";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 308);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "Joe";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 330);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(34, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "Al";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(32, 354);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "Bob";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // txtMaxBet
            // 
            this.txtMaxBet.AutoSize = true;
            this.txtMaxBet.Location = new System.Drawing.Point(81, 321);
            this.txtMaxBet.Name = "txtMaxBet";
            this.txtMaxBet.Size = new System.Drawing.Size(46, 13);
            this.txtMaxBet.TabIndex = 5;
            this.txtMaxBet.Text = "Max Bet";
            // 
            // numBetAmount
            // 
            this.numBetAmount.Location = new System.Drawing.Point(300, 310);
            this.numBetAmount.Name = "numBetAmount";
            this.numBetAmount.Size = new System.Drawing.Size(120, 20);
            this.numBetAmount.TabIndex = 6;
            // 
            // numThingNumber
            // 
            this.numThingNumber.Location = new System.Drawing.Point(300, 346);
            this.numThingNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numThingNumber.Name = "numThingNumber";
            this.numThingNumber.Size = new System.Drawing.Size(120, 20);
            this.numThingNumber.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Race";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.RaceHorse_Click);
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(706, 297);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(184, 95);
            this.list1.TabIndex = 9;
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(446, 369);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 10;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblBetStatus1
            // 
            this.lblBetStatus1.AutoSize = true;
            this.lblBetStatus1.Location = new System.Drawing.Point(440, 314);
            this.lblBetStatus1.Name = "lblBetStatus1";
            this.lblBetStatus1.Size = new System.Drawing.Size(80, 13);
            this.lblBetStatus1.TabIndex = 11;
            this.lblBetStatus1.Text = "Joe has not bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // lblBetStatus2
            // 
            this.lblBetStatus2.AutoSize = true;
            this.lblBetStatus2.Location = new System.Drawing.Point(443, 331);
            this.lblBetStatus2.Name = "lblBetStatus2";
            this.lblBetStatus2.Size = new System.Drawing.Size(72, 13);
            this.lblBetStatus2.TabIndex = 13;
            this.lblBetStatus2.Text = "Al has not bet";
            // 
            // lblBetStatus3
            // 
            this.lblBetStatus3.AutoSize = true;
            this.lblBetStatus3.Location = new System.Drawing.Point(443, 348);
            this.lblBetStatus3.Name = "lblBetStatus3";
            this.lblBetStatus3.Size = new System.Drawing.Size(82, 13);
            this.lblBetStatus3.TabIndex = 14;
            this.lblBetStatus3.Text = "Bob has not bet";
            // 
            // PB4
            // 
            this.PB4.Image = global::RacingGame.Resource1.Yellow;
            this.PB4.Location = new System.Drawing.Point(24, 198);
            this.PB4.Name = "PB4";
            this.PB4.Size = new System.Drawing.Size(56, 50);
            this.PB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB4.TabIndex = 20;
            this.PB4.TabStop = false;
            // 
            // PB3
            // 
            this.PB3.Image = global::RacingGame.Resource1.Red;
            this.PB3.Location = new System.Drawing.Point(23, 133);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(56, 50);
            this.PB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB3.TabIndex = 19;
            this.PB3.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.Image = global::RacingGame.Resource1.Pink;
            this.PB2.Location = new System.Drawing.Point(22, 68);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(57, 50);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB2.TabIndex = 18;
            this.PB2.TabStop = false;
            // 
            // PB1
            // 
            this.PB1.Image = global::RacingGame.Resource1.Blue;
            this.PB1.Location = new System.Drawing.Point(22, 12);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(56, 50);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 17;
            this.PB1.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::RacingGame.Resource1.ZombieGraveyard;
            this.pbBackground.Location = new System.Drawing.Point(2, -1);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(937, 292);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 21;
            this.pbBackground.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtJoe
            // 
            this.txtJoe.AutoSize = true;
            this.txtJoe.Location = new System.Drawing.Point(548, 312);
            this.txtJoe.Name = "txtJoe";
            this.txtJoe.Size = new System.Drawing.Size(35, 13);
            this.txtJoe.TabIndex = 23;
            this.txtJoe.Text = "label1";
            // 
            // txtAl
            // 
            this.txtAl.AutoSize = true;
            this.txtAl.Location = new System.Drawing.Point(551, 324);
            this.txtAl.Name = "txtAl";
            this.txtAl.Size = new System.Drawing.Size(35, 13);
            this.txtAl.TabIndex = 24;
            this.txtAl.Text = "label4";
            // 
            // txtBob
            // 
            this.txtBob.AutoSize = true;
            this.txtBob.Location = new System.Drawing.Point(554, 347);
            this.txtBob.Name = "txtBob";
            this.txtBob.Size = new System.Drawing.Size(35, 13);
            this.txtBob.TabIndex = 25;
            this.txtBob.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 404);
            this.Controls.Add(this.txtBob);
            this.Controls.Add(this.txtAl);
            this.Controls.Add(this.txtJoe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PB4);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.lblBetStatus3);
            this.Controls.Add(this.lblBetStatus2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBetStatus1);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numThingNumber);
            this.Controls.Add(this.numBetAmount);
            this.Controls.Add(this.txtMaxBet);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Better);
            this.Controls.Add(this.pbBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThingNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Better;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label txtMaxBet;
        private System.Windows.Forms.NumericUpDown numBetAmount;
        private System.Windows.Forms.NumericUpDown numThingNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBetStatus1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBetStatus2;
        private System.Windows.Forms.Label lblBetStatus3;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.PictureBox PB4;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtJoe;
        private System.Windows.Forms.Label txtAl;
        private System.Windows.Forms.Label txtBob;
    }
}

