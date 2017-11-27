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
            this.joeButton = new System.Windows.Forms.RadioButton();
            this.alButton = new System.Windows.Forms.RadioButton();
            this.bobButton = new System.Windows.Forms.RadioButton();
            this.txtMaxBet = new System.Windows.Forms.Label();
            this.numBetAmount = new System.Windows.Forms.NumericUpDown();
            this.numThingNumber = new System.Windows.Forms.NumericUpDown();
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
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "on ghost";
            // 
            // joeButton
            // 
            this.joeButton.AutoSize = true;
            this.joeButton.Location = new System.Drawing.Point(32, 308);
            this.joeButton.Name = "joeButton";
            this.joeButton.Size = new System.Drawing.Size(42, 17);
            this.joeButton.TabIndex = 2;
            this.joeButton.TabStop = true;
            this.joeButton.Tag = "0";
            this.joeButton.Text = "Joe";
            this.joeButton.UseVisualStyleBackColor = true;
            this.joeButton.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // alButton
            // 
            this.alButton.AutoSize = true;
            this.alButton.Location = new System.Drawing.Point(32, 330);
            this.alButton.Name = "alButton";
            this.alButton.Size = new System.Drawing.Size(34, 17);
            this.alButton.TabIndex = 3;
            this.alButton.TabStop = true;
            this.alButton.Tag = "1";
            this.alButton.Text = "Al";
            this.alButton.UseVisualStyleBackColor = true;
            this.alButton.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // bobButton
            // 
            this.bobButton.AutoSize = true;
            this.bobButton.Location = new System.Drawing.Point(32, 354);
            this.bobButton.Name = "bobButton";
            this.bobButton.Size = new System.Drawing.Size(44, 17);
            this.bobButton.TabIndex = 4;
            this.bobButton.TabStop = true;
            this.bobButton.Tag = "2";
            this.bobButton.Text = "Bob";
            this.bobButton.UseVisualStyleBackColor = true;
            this.bobButton.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
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
            this.lblBetStatus1.Location = new System.Drawing.Point(477, 297);
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
            this.lblBetStatus2.Location = new System.Drawing.Point(477, 321);
            this.lblBetStatus2.Name = "lblBetStatus2";
            this.lblBetStatus2.Size = new System.Drawing.Size(72, 13);
            this.lblBetStatus2.TabIndex = 13;
            this.lblBetStatus2.Text = "Al has not bet";
            // 
            // lblBetStatus3
            // 
            this.lblBetStatus3.AutoSize = true;
            this.lblBetStatus3.Location = new System.Drawing.Point(477, 340);
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
            this.button2.Location = new System.Drawing.Point(574, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Race";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 404);
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
            this.Controls.Add(this.numThingNumber);
            this.Controls.Add(this.numBetAmount);
            this.Controls.Add(this.txtMaxBet);
            this.Controls.Add(this.bobButton);
            this.Controls.Add(this.alButton);
            this.Controls.Add(this.joeButton);
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
        private System.Windows.Forms.RadioButton joeButton;
        private System.Windows.Forms.RadioButton alButton;
        private System.Windows.Forms.RadioButton bobButton;
        private System.Windows.Forms.Label txtMaxBet;
        private System.Windows.Forms.NumericUpDown numBetAmount;
        private System.Windows.Forms.NumericUpDown numThingNumber;
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
    }
}

