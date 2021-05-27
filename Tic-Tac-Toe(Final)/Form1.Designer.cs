
namespace Tic_Tac_Toe_Final_
{
    partial class frmGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTurnDisplay = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(10, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(165, 152);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnGrid_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(181, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(165, 152);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnGrid_click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(352, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(165, 152);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnGrid_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(352, 170);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(165, 152);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnGrid_click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(181, 170);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(165, 152);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnGrid_click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(10, 170);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(165, 152);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnGrid_click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(352, 328);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(165, 152);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnGrid_click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(181, 328);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(165, 152);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnGrid_click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(10, 328);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(165, 152);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnGrid_click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(13, 26);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(132, 95);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(151, 26);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(132, 95);
            this.btnO.TabIndex = 1;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnO);
            this.groupBox1.Controls.Add(this.btnX);
            this.groupBox1.Location = new System.Drawing.Point(521, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select first turn";
            // 
            // lblTurnDisplay
            // 
            this.lblTurnDisplay.BackColor = System.Drawing.Color.LightGray;
            this.lblTurnDisplay.Location = new System.Drawing.Point(606, 120);
            this.lblTurnDisplay.Name = "lblTurnDisplay";
            this.lblTurnDisplay.Size = new System.Drawing.Size(120, 55);
            this.lblTurnDisplay.TabIndex = 10;
            this.lblTurnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(611, 340);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(115, 28);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(611, 374);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(115, 28);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 491);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblTurnDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTurnDisplay;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnQuit;
    }
}

