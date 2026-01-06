namespace Tic_Tac_Toe_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pb01 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb20 = new System.Windows.Forms.PictureBox();
            this.pb21 = new System.Windows.Forms.PictureBox();
            this.pb22 = new System.Windows.Forms.PictureBox();
            this.pb02 = new System.Windows.Forms.PictureBox();
            this.pb00 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(559, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // pb01
            // 
            this.pb01.BackColor = System.Drawing.Color.Transparent;
            this.pb01.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb01.Image = global::Tic_Tac_Toe_Project.Properties.Resources.question_mark_96;
            this.pb01.Location = new System.Drawing.Point(754, 130);
            this.pb01.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb01.Name = "pb01";
            this.pb01.Size = new System.Drawing.Size(123, 118);
            this.pb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb01.TabIndex = 2;
            this.pb01.TabStop = false;
            this.pb01.Tag = "?";
            this.pb01.Click += new System.EventHandler(this.pb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(137, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 53);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(137, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 53);
            this.label3.TabIndex = 11;
            this.label3.Text = "Winner :";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(137, 195);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(175, 53);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(137, 379);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(235, 53);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(84, 487);
            this.btnRestartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(340, 66);
            this.btnRestartGame.TabIndex = 14;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // pb10
            // 
            this.pb10.BackColor = System.Drawing.Color.Transparent;
            this.pb10.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb10.Image = global::Tic_Tac_Toe_Project.Properties.Resources.question_mark_96;
            this.pb10.Location = new System.Drawing.Point(603, 286);
            this.pb10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(123, 118);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb10.TabIndex = 15;
            this.pb10.TabStop = false;
            this.pb10.Tag = "?";
            this.pb10.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb11
            // 
            this.pb11.BackColor = System.Drawing.Color.Transparent;
            this.pb11.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb11.Image = global::Tic_Tac_Toe_Project.Properties.Resources.question_mark_96;
            this.pb11.Location = new System.Drawing.Point(754, 286);
            this.pb11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(123, 118);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb11.TabIndex = 16;
            this.pb11.TabStop = false;
            this.pb11.Tag = "?";
            this.pb11.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb12
            // 
            this.pb12.BackColor = System.Drawing.Color.Transparent;
            this.pb12.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb12.Image = global::Tic_Tac_Toe_Project.Properties.Resources.question_mark_96;
            this.pb12.Location = new System.Drawing.Point(903, 286);
            this.pb12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(123, 118);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb12.TabIndex = 17;
            this.pb12.TabStop = false;
            this.pb12.Tag = "?";
            this.pb12.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb20
            // 
            this.pb20.BackColor = System.Drawing.Color.Transparent;
            this.pb20.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb20.Image = global::Tic_Tac_Toe_Project.Properties.Resources.question_mark_96;
            this.pb20.Location = new System.Drawing.Point(603, 444);
            this.pb20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb20.Name = "pb20";
            this.pb20.Size = new System.Drawing.Size(123, 118);
            this.pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb20.TabIndex = 18;
            this.pb20.TabStop = false;
            this.pb20.Tag = "?";
            this.pb20.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb21
            // 
            this.pb21.BackColor = System.Drawing.Color.Transparent;
            this.pb21.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb21.Image = global::Tic_Tac_Toe_Project.Properties.Resources.question_mark_96;
            this.pb21.Location = new System.Drawing.Point(754, 444);
            this.pb21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb21.Name = "pb21";
            this.pb21.Size = new System.Drawing.Size(123, 118);
            this.pb21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb21.TabIndex = 19;
            this.pb21.TabStop = false;
            this.pb21.Tag = "?";
            this.pb21.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb22
            // 
            this.pb22.BackColor = System.Drawing.Color.Transparent;
            this.pb22.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb22.Image = global::Tic_Tac_Toe_Project.Properties.Resources.question_mark_96;
            this.pb22.Location = new System.Drawing.Point(903, 444);
            this.pb22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb22.Name = "pb22";
            this.pb22.Size = new System.Drawing.Size(123, 118);
            this.pb22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb22.TabIndex = 20;
            this.pb22.TabStop = false;
            this.pb22.Tag = "?";
            this.pb22.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb02
            // 
            this.pb02.BackColor = System.Drawing.Color.Transparent;
            this.pb02.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb02.Image = global::Tic_Tac_Toe_Project.Properties.Resources.question_mark_96;
            this.pb02.Location = new System.Drawing.Point(903, 130);
            this.pb02.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb02.Name = "pb02";
            this.pb02.Size = new System.Drawing.Size(123, 118);
            this.pb02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb02.TabIndex = 21;
            this.pb02.TabStop = false;
            this.pb02.Tag = "?";
            this.pb02.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb00
            // 
            this.pb00.BackColor = System.Drawing.Color.Transparent;
            this.pb00.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb00.Image = global::Tic_Tac_Toe_Project.Properties.Resources.question_mark_96;
            this.pb00.Location = new System.Drawing.Point(603, 130);
            this.pb00.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb00.Name = "pb00";
            this.pb00.Size = new System.Drawing.Size(123, 118);
            this.pb00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb00.TabIndex = 22;
            this.pb00.TabStop = false;
            this.pb00.Tag = "?";
            this.pb00.Click += new System.EventHandler(this.pb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1180, 625);
            this.Controls.Add(this.pb00);
            this.Controls.Add(this.pb02);
            this.Controls.Add(this.pb22);
            this.Controls.Add(this.pb21);
            this.Controls.Add(this.pb20);
            this.Controls.Add(this.pb12);
            this.Controls.Add(this.pb11);
            this.Controls.Add(this.pb10);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb01);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb20;
        private System.Windows.Forms.PictureBox pb21;
        private System.Windows.Forms.PictureBox pb22;
        private System.Windows.Forms.PictureBox pb02;
        private System.Windows.Forms.PictureBox pb00;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

