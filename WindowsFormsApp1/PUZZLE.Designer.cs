namespace WindowsFormsApp1
{
    partial class PUZZLE
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
            this.pnl = new System.Windows.Forms.Panel();
            this.btn_21 = new System.Windows.Forms.Button();
            this.btn_22 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.J = new System.Windows.Forms.Button();
            this.lblNoOfMoves = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl.Controls.Add(this.btn_11);
            this.pnl.Controls.Add(this.btn_21);
            this.pnl.Controls.Add(this.btn_00);
            this.pnl.Controls.Add(this.btn_22);
            this.pnl.Controls.Add(this.btn_02);
            this.pnl.Controls.Add(this.btn_20);
            this.pnl.Controls.Add(this.btn_01);
            this.pnl.Controls.Add(this.btn_10);
            this.pnl.Controls.Add(this.btn_12);
            this.pnl.Location = new System.Drawing.Point(374, 67);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(285, 269);
            this.pnl.TabIndex = 10;
            // 
            // btn_21
            // 
            this.btn_21.BackColor = System.Drawing.Color.Cyan;
            this.btn_21.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_21.Location = new System.Drawing.Point(104, 186);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(80, 71);
            this.btn_21.TabIndex = 8;
            this.btn_21.Tag = "2,1";
            this.btn_21.UseVisualStyleBackColor = false;
            this.btn_21.Click += new System.EventHandler(this.swapLabel);
            // 
            // btn_22
            // 
            this.btn_22.BackColor = System.Drawing.Color.Cyan;
            this.btn_22.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_22.Location = new System.Drawing.Point(194, 186);
            this.btn_22.Name = "btn_22";
            this.btn_22.Size = new System.Drawing.Size(80, 71);
            this.btn_22.TabIndex = 7;
            this.btn_22.Tag = "2,2";
            this.btn_22.UseVisualStyleBackColor = false;
            this.btn_22.Click += new System.EventHandler(this.swapLabel);
            // 
            // btn_02
            // 
            this.btn_02.BackColor = System.Drawing.Color.Cyan;
            this.btn_02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_02.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_02.Location = new System.Drawing.Point(194, 13);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(80, 71);
            this.btn_02.TabIndex = 1;
            this.btn_02.Tag = "0,2";
            this.btn_02.UseVisualStyleBackColor = false;
            this.btn_02.Click += new System.EventHandler(this.swapLabel);
            // 
            // btn_20
            // 
            this.btn_20.BackColor = System.Drawing.Color.Cyan;
            this.btn_20.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_20.Location = new System.Drawing.Point(12, 186);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(80, 71);
            this.btn_20.TabIndex = 6;
            this.btn_20.Tag = "2,0";
            this.btn_20.UseVisualStyleBackColor = false;
            this.btn_20.Click += new System.EventHandler(this.swapLabel);
            // 
            // btn_10
            // 
            this.btn_10.BackColor = System.Drawing.Color.Cyan;
            this.btn_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_10.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_10.Location = new System.Drawing.Point(12, 98);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(80, 71);
            this.btn_10.TabIndex = 3;
            this.btn_10.Tag = "1,0";
            this.btn_10.UseVisualStyleBackColor = false;
            this.btn_10.Click += new System.EventHandler(this.swapLabel);
            // 
            // btn_12
            // 
            this.btn_12.BackColor = System.Drawing.Color.Cyan;
            this.btn_12.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_12.Location = new System.Drawing.Point(194, 98);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(80, 71);
            this.btn_12.TabIndex = 4;
            this.btn_12.Tag = "1,2";
            this.btn_12.UseVisualStyleBackColor = false;
            this.btn_12.Click += new System.EventHandler(this.swapLabel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(33, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 307);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JUGADORES";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 2;
            // 
            // J
            // 
            this.J.BackColor = System.Drawing.Color.Black;
            this.J.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.J.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.J.Location = new System.Drawing.Point(234, 391);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(146, 40);
            this.J.TabIndex = 12;
            this.J.Text = "NUEVO JUEGO";
            this.J.UseVisualStyleBackColor = false;
            this.J.Click += new System.EventHandler(this.J_Click);
            // 
            // lblNoOfMoves
            // 
            this.lblNoOfMoves.AutoSize = true;
            this.lblNoOfMoves.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfMoves.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNoOfMoves.Location = new System.Drawing.Point(385, 33);
            this.lblNoOfMoves.Name = "lblNoOfMoves";
            this.lblNoOfMoves.Size = new System.Drawing.Size(121, 18);
            this.lblNoOfMoves.TabIndex = 13;
            this.lblNoOfMoves.Text = "MOVIMIENTOS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "ATRAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_00
            // 
            this.btn_00.BackColor = System.Drawing.Color.Cyan;
            this.btn_00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_00.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_00.Location = new System.Drawing.Point(12, 13);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(80, 71);
            this.btn_00.TabIndex = 0;
            this.btn_00.Tag = "0,0";
            this.btn_00.UseVisualStyleBackColor = false;
            this.btn_00.Click += new System.EventHandler(this.swapLabel);
            // 
            // btn_11
            // 
            this.btn_11.BackColor = System.Drawing.Color.Cyan;
            this.btn_11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_11.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_11.Location = new System.Drawing.Point(104, 98);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(80, 71);
            this.btn_11.TabIndex = 5;
            this.btn_11.Tag = "1,1";
            this.btn_11.UseVisualStyleBackColor = false;
            this.btn_11.Click += new System.EventHandler(this.swapLabel);
            // 
            // btn_01
            // 
            this.btn_01.BackColor = System.Drawing.Color.Cyan;
            this.btn_01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_01.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_01.Location = new System.Drawing.Point(104, 13);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(80, 71);
            this.btn_01.TabIndex = 2;
            this.btn_01.Tag = "0,1";
            this.btn_01.UseVisualStyleBackColor = false;
            this.btn_01.Click += new System.EventHandler(this.swapLabel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(56, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(56, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(478, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "SIGUIENTE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SIG_Click);
            // 
            // PUZZLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNoOfMoves);
            this.Controls.Add(this.J);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl);
            this.Name = "PUZZLE";
            this.Text = "PUZZLE";
            this.Load += new System.EventHandler(this.PUZZLE_Load);
            this.pnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btn_21;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_22;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button J;
        private System.Windows.Forms.Label lblNoOfMoves;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button button2;
    }
}