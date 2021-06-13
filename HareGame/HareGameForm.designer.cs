namespace HareGame
{
    partial class HareGameForm
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
            this.panelControls = new System.Windows.Forms.Panel();
            this.numericHare = new System.Windows.Forms.NumericUpDown();
            this.labelHare = new System.Windows.Forms.Label();
            this.numericBet = new System.Windows.Forms.NumericUpDown();
            this.labelBet = new System.Windows.Forms.Label();
            this.labelMaxBet = new System.Windows.Forms.Label();
            this.textPlayer3 = new System.Windows.Forms.TextBox();
            this.textPlayer2 = new System.Windows.Forms.TextBox();
            this.textPlayer1 = new System.Windows.Forms.TextBox();
            this.playerRadio3 = new System.Windows.Forms.RadioButton();
            this.playerRadio2 = new System.Windows.Forms.RadioButton();
            this.playerRadio1 = new System.Windows.Forms.RadioButton();
            this.btnAction = new System.Windows.Forms.Button();
            this.pictureHare4 = new System.Windows.Forms.PictureBox();
            this.pictureHare3 = new System.Windows.Forms.PictureBox();
            this.pictureHare2 = new System.Windows.Forms.PictureBox();
            this.pictureHare1 = new System.Windows.Forms.PictureBox();
            this.pictureTrack = new System.Windows.Forms.PictureBox();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHare4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHare3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHare2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHare1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControls.Controls.Add(this.numericHare);
            this.panelControls.Controls.Add(this.labelHare);
            this.panelControls.Controls.Add(this.numericBet);
            this.panelControls.Controls.Add(this.labelBet);
            this.panelControls.Controls.Add(this.labelMaxBet);
            this.panelControls.Controls.Add(this.textPlayer3);
            this.panelControls.Controls.Add(this.textPlayer2);
            this.panelControls.Controls.Add(this.textPlayer1);
            this.panelControls.Controls.Add(this.playerRadio3);
            this.panelControls.Controls.Add(this.playerRadio2);
            this.panelControls.Controls.Add(this.playerRadio1);
            this.panelControls.Location = new System.Drawing.Point(12, 370);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1189, 251);
            this.panelControls.TabIndex = 0;
            // 
            // numericHare
            // 
            this.numericHare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHare.Location = new System.Drawing.Point(1079, 174);
            this.numericHare.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericHare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHare.Name = "numericHare";
            this.numericHare.Size = new System.Drawing.Size(67, 34);
            this.numericHare.TabIndex = 10;
            this.numericHare.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelHare
            // 
            this.labelHare.AutoSize = true;
            this.labelHare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHare.Location = new System.Drawing.Point(747, 176);
            this.labelHare.Name = "labelHare";
            this.labelHare.Size = new System.Drawing.Size(237, 29);
            this.labelHare.TabIndex = 9;
            this.labelHare.Text = "Player Bet On Hare";
            this.labelHare.Click += new System.EventHandler(this.labelHare_Click);
            // 
            // numericBet
            // 
            this.numericBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBet.Location = new System.Drawing.Point(1079, 95);
            this.numericBet.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericBet.Name = "numericBet";
            this.numericBet.Size = new System.Drawing.Size(67, 34);
            this.numericBet.TabIndex = 8;
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBet.Location = new System.Drawing.Point(747, 97);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(261, 29);
            this.labelBet.TabIndex = 7;
            this.labelBet.Text = "Player Bet Amount is ";
            // 
            // labelMaxBet
            // 
            this.labelMaxBet.AutoSize = true;
            this.labelMaxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxBet.Location = new System.Drawing.Point(747, 22);
            this.labelMaxBet.Name = "labelMaxBet";
            this.labelMaxBet.Size = new System.Drawing.Size(357, 29);
            this.labelMaxBet.TabIndex = 6;
            this.labelMaxBet.Text = "Player Max Bet Amount is $50";
            // 
            // textPlayer3
            // 
            this.textPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlayer3.Location = new System.Drawing.Point(183, 176);
            this.textPlayer3.Name = "textPlayer3";
            this.textPlayer3.Size = new System.Drawing.Size(493, 30);
            this.textPlayer3.TabIndex = 5;
            // 
            // textPlayer2
            // 
            this.textPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlayer2.Location = new System.Drawing.Point(183, 99);
            this.textPlayer2.Name = "textPlayer2";
            this.textPlayer2.Size = new System.Drawing.Size(493, 30);
            this.textPlayer2.TabIndex = 4;
            // 
            // textPlayer1
            // 
            this.textPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlayer1.Location = new System.Drawing.Point(183, 22);
            this.textPlayer1.Name = "textPlayer1";
            this.textPlayer1.Size = new System.Drawing.Size(493, 30);
            this.textPlayer1.TabIndex = 3;
            // 
            // playerRadio3
            // 
            this.playerRadio3.AutoSize = true;
            this.playerRadio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRadio3.Location = new System.Drawing.Point(19, 174);
            this.playerRadio3.Name = "playerRadio3";
            this.playerRadio3.Size = new System.Drawing.Size(108, 33);
            this.playerRadio3.TabIndex = 2;
            this.playerRadio3.TabStop = true;
            this.playerRadio3.Text = "Player";
            this.playerRadio3.UseVisualStyleBackColor = true;
            this.playerRadio3.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // playerRadio2
            // 
            this.playerRadio2.AutoSize = true;
            this.playerRadio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRadio2.Location = new System.Drawing.Point(19, 97);
            this.playerRadio2.Name = "playerRadio2";
            this.playerRadio2.Size = new System.Drawing.Size(108, 33);
            this.playerRadio2.TabIndex = 1;
            this.playerRadio2.TabStop = true;
            this.playerRadio2.Text = "Player";
            this.playerRadio2.UseVisualStyleBackColor = true;
            this.playerRadio2.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // playerRadio1
            // 
            this.playerRadio1.AutoSize = true;
            this.playerRadio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerRadio1.Location = new System.Drawing.Point(19, 20);
            this.playerRadio1.Name = "playerRadio1";
            this.playerRadio1.Size = new System.Drawing.Size(108, 33);
            this.playerRadio1.TabIndex = 0;
            this.playerRadio1.TabStop = true;
            this.playerRadio1.Text = "Player";
            this.playerRadio1.UseVisualStyleBackColor = true;
            this.playerRadio1.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // btnAction
            // 
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(150, 627);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(872, 111);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "Place Bet";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // pictureHare4
            // 
            this.pictureHare4.Image = global::HareGame.Properties.Resources.hare4;
            this.pictureHare4.Location = new System.Drawing.Point(1076, 284);
            this.pictureHare4.Name = "pictureHare4";
            this.pictureHare4.Size = new System.Drawing.Size(123, 70);
            this.pictureHare4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHare4.TabIndex = 4;
            this.pictureHare4.TabStop = false;
            // 
            // pictureHare3
            // 
            this.pictureHare3.Image = global::HareGame.Properties.Resources.hare3;
            this.pictureHare3.Location = new System.Drawing.Point(1076, 194);
            this.pictureHare3.Name = "pictureHare3";
            this.pictureHare3.Size = new System.Drawing.Size(123, 70);
            this.pictureHare3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHare3.TabIndex = 3;
            this.pictureHare3.TabStop = false;
            // 
            // pictureHare2
            // 
            this.pictureHare2.Image = global::HareGame.Properties.Resources.hare2;
            this.pictureHare2.Location = new System.Drawing.Point(1076, 106);
            this.pictureHare2.Name = "pictureHare2";
            this.pictureHare2.Size = new System.Drawing.Size(123, 70);
            this.pictureHare2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHare2.TabIndex = 2;
            this.pictureHare2.TabStop = false;
            // 
            // pictureHare1
            // 
            this.pictureHare1.Image = global::HareGame.Properties.Resources.hare1;
            this.pictureHare1.Location = new System.Drawing.Point(1076, 12);
            this.pictureHare1.Name = "pictureHare1";
            this.pictureHare1.Size = new System.Drawing.Size(123, 70);
            this.pictureHare1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHare1.TabIndex = 1;
            this.pictureHare1.TabStop = false;
            // 
            // pictureTrack
            // 
            this.pictureTrack.Image = global::HareGame.Properties.Resources.racetrack;
            this.pictureTrack.Location = new System.Drawing.Point(12, 10);
            this.pictureTrack.Name = "pictureTrack";
            this.pictureTrack.Size = new System.Drawing.Size(1058, 354);
            this.pictureTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTrack.TabIndex = 6;
            this.pictureTrack.TabStop = false;
            // 
            // HareGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 750);
            this.Controls.Add(this.pictureHare4);
            this.Controls.Add(this.pictureHare3);
            this.Controls.Add(this.pictureHare2);
            this.Controls.Add(this.pictureHare1);
            this.Controls.Add(this.pictureTrack);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.panelControls);
            this.MaximizeBox = false;
            this.Name = "HareGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bet Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HareGameForm_FormClosing);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHare4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHare3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHare2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHare1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.PictureBox pictureHare1;
        private System.Windows.Forms.PictureBox pictureHare2;
        private System.Windows.Forms.PictureBox pictureHare3;
        private System.Windows.Forms.PictureBox pictureHare4;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.PictureBox pictureTrack;
        private System.Windows.Forms.TextBox textPlayer3;
        private System.Windows.Forms.TextBox textPlayer2;
        private System.Windows.Forms.TextBox textPlayer1;
        private System.Windows.Forms.RadioButton playerRadio3;
        private System.Windows.Forms.RadioButton playerRadio2;
        private System.Windows.Forms.RadioButton playerRadio1;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Label labelMaxBet;
        private System.Windows.Forms.NumericUpDown numericHare;
        private System.Windows.Forms.Label labelHare;
        private System.Windows.Forms.NumericUpDown numericBet;
    }
}

