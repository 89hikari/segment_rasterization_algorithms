﻿namespace laba_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.windowA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.windowB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.windowC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.windowD = new System.Windows.Forms.NumericUpDown();
            this.par_X1 = new System.Windows.Forms.NumericUpDown();
            this.par_X2 = new System.Windows.Forms.NumericUpDown();
            this.par_Y2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.check_f = new System.Windows.Forms.CheckBox();
            this.check_CDA2 = new System.Windows.Forms.CheckBox();
            this.button_UP = new System.Windows.Forms.Button();
            this.button_Clean = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.par_Y1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.brez_check = new System.Windows.Forms.CheckBox();
            this.kastl_check = new System.Windows.Forms.CheckBox();
            this.coef = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.CheckBox();
            this.check_circ = new System.Windows.Forms.CheckBox();
            this.rad = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.windowA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_X1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_X2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_Y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размеры поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A";
            // 
            // windowA
            // 
            this.windowA.DecimalPlaces = 1;
            this.windowA.Location = new System.Drawing.Point(32, 29);
            this.windowA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.windowA.Name = "windowA";
            this.windowA.Size = new System.Drawing.Size(57, 20);
            this.windowA.TabIndex = 9;
            this.windowA.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // windowB
            // 
            this.windowB.DecimalPlaces = 1;
            this.windowB.Location = new System.Drawing.Point(32, 57);
            this.windowB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.windowB.Name = "windowB";
            this.windowB.Size = new System.Drawing.Size(57, 20);
            this.windowB.TabIndex = 7;
            this.windowB.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "C";
            // 
            // windowC
            // 
            this.windowC.DecimalPlaces = 1;
            this.windowC.Location = new System.Drawing.Point(115, 29);
            this.windowC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.windowC.Name = "windowC";
            this.windowC.Size = new System.Drawing.Size(58, 20);
            this.windowC.TabIndex = 9;
            this.windowC.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "D";
            // 
            // windowD
            // 
            this.windowD.DecimalPlaces = 1;
            this.windowD.Location = new System.Drawing.Point(115, 57);
            this.windowD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.windowD.Name = "windowD";
            this.windowD.Size = new System.Drawing.Size(58, 20);
            this.windowD.TabIndex = 11;
            this.windowD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // par_X1
            // 
            this.par_X1.Location = new System.Drawing.Point(255, 33);
            this.par_X1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_X1.Name = "par_X1";
            this.par_X1.Size = new System.Drawing.Size(40, 20);
            this.par_X1.TabIndex = 13;
            // 
            // par_X2
            // 
            this.par_X2.Location = new System.Drawing.Point(364, 34);
            this.par_X2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_X2.Name = "par_X2";
            this.par_X2.Size = new System.Drawing.Size(40, 20);
            this.par_X2.TabIndex = 14;
            this.par_X2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // par_Y2
            // 
            this.par_Y2.Location = new System.Drawing.Point(364, 56);
            this.par_Y2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_Y2.Name = "par_Y2";
            this.par_Y2.Size = new System.Drawing.Size(40, 20);
            this.par_Y2.TabIndex = 15;
            this.par_Y2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Шо рисуем";
            // 
            // check_f
            // 
            this.check_f.AutoSize = true;
            this.check_f.Location = new System.Drawing.Point(606, 136);
            this.check_f.Name = "check_f";
            this.check_f.Size = new System.Drawing.Size(50, 17);
            this.check_f.TabIndex = 31;
            this.check_f.Text = "ЦДА";
            this.check_f.UseVisualStyleBackColor = true;
            // 
            // check_CDA2
            // 
            this.check_CDA2.AutoSize = true;
            this.check_CDA2.Location = new System.Drawing.Point(606, 159);
            this.check_CDA2.Name = "check_CDA2";
            this.check_CDA2.Size = new System.Drawing.Size(110, 17);
            this.check_CDA2.TabIndex = 34;
            this.check_CDA2.Text = "ЦДА (по лекции)";
            this.check_CDA2.UseVisualStyleBackColor = true;
            // 
            // button_UP
            // 
            this.button_UP.Location = new System.Drawing.Point(638, 314);
            this.button_UP.Name = "button_UP";
            this.button_UP.Size = new System.Drawing.Size(97, 23);
            this.button_UP.TabIndex = 36;
            this.button_UP.Text = "Нарисовать";
            this.button_UP.UseVisualStyleBackColor = true;
            this.button_UP.Click += new System.EventHandler(this.button_UP_Click);
            // 
            // button_Clean
            // 
            this.button_Clean.Location = new System.Drawing.Point(638, 343);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(97, 23);
            this.button_Clean.TabIndex = 37;
            this.button_Clean.Text = "Очистить";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zedGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zedGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraph.Enabled = false;
            this.zedGraph.ForeColor = System.Drawing.Color.DimGray;
            this.zedGraph.IsShowPointValues = false;
            this.zedGraph.Location = new System.Drawing.Point(12, 101);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.PointValueFormat = "G";
            this.zedGraph.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zedGraph.Size = new System.Drawing.Size(570, 488);
            this.zedGraph.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(272, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 19);
            this.textBox3.TabIndex = 50;
            this.textBox3.Text = "График";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(272, 547);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 19);
            this.textBox4.TabIndex = 51;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(32, 300);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(23, 73);
            this.textBox5.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(226, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Х1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(225, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Y1";
            // 
            // par_Y1
            // 
            this.par_Y1.Location = new System.Drawing.Point(255, 56);
            this.par_Y1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.par_Y1.Name = "par_Y1";
            this.par_Y1.Size = new System.Drawing.Size(40, 20);
            this.par_Y1.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(335, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "X2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(335, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Y2";
            // 
            // brez_check
            // 
            this.brez_check.AutoSize = true;
            this.brez_check.Location = new System.Drawing.Point(606, 182);
            this.brez_check.Name = "brez_check";
            this.brez_check.Size = new System.Drawing.Size(82, 17);
            this.brez_check.TabIndex = 60;
            this.brez_check.Text = "Брезенхем";
            this.brez_check.UseVisualStyleBackColor = true;
            // 
            // kastl_check
            // 
            this.kastl_check.AutoSize = true;
            this.kastl_check.Location = new System.Drawing.Point(606, 205);
            this.kastl_check.Name = "kastl_check";
            this.kastl_check.Size = new System.Drawing.Size(102, 17);
            this.kastl_check.TabIndex = 62;
            this.kastl_check.Text = "Кастла-Питвея";
            this.kastl_check.UseVisualStyleBackColor = true;
            // 
            // coef
            // 
            this.coef.Location = new System.Drawing.Point(668, 432);
            this.coef.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.coef.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.coef.Name = "coef";
            this.coef.Size = new System.Drawing.Size(40, 20);
            this.coef.TabIndex = 63;
            this.coef.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(588, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "Масштабный коэффиициент";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.Location = new System.Drawing.Point(606, 228);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(82, 17);
            this.last.TabIndex = 65;
            this.last.Text = "Последний";
            this.last.UseVisualStyleBackColor = true;
            // 
            // check_circ
            // 
            this.check_circ.AutoSize = true;
            this.check_circ.Location = new System.Drawing.Point(606, 251);
            this.check_circ.Name = "check_circ";
            this.check_circ.Size = new System.Drawing.Size(127, 17);
            this.check_circ.TabIndex = 66;
            this.check_circ.Text = "Окружн. Бразенхем";
            this.check_circ.UseVisualStyleBackColor = true;
            // 
            // rad
            // 
            this.rad.Location = new System.Drawing.Point(504, 33);
            this.rad.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(40, 20);
            this.rad.TabIndex = 67;
            this.rad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(464, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 68;
            this.label12.Text = "Rad";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(781, 612);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rad);
            this.Controls.Add(this.check_circ);
            this.Controls.Add(this.last);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.coef);
            this.Controls.Add(this.kastl_check);
            this.Controls.Add(this.brez_check);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.par_Y1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.button_UP);
            this.Controls.Add(this.check_CDA2);
            this.Controls.Add(this.check_f);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.par_Y2);
            this.Controls.Add(this.par_X2);
            this.Controls.Add(this.par_X1);
            this.Controls.Add(this.windowD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.windowC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.windowB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.windowA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraph);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Алгоритмы растеризации";
            ((System.ComponentModel.ISupportInitialize)(this.windowA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_X1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_X2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_Y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.par_Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown windowA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown windowB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown windowC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown windowD;
        private System.Windows.Forms.NumericUpDown par_X1;
        private System.Windows.Forms.NumericUpDown par_X2;
        private System.Windows.Forms.NumericUpDown par_Y2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox check_f;
        private System.Windows.Forms.CheckBox check_CDA2;
        private System.Windows.Forms.Button button_UP;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown par_Y1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox brez_check;
        private System.Windows.Forms.CheckBox kastl_check;
        private System.Windows.Forms.NumericUpDown coef;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox last;
        private System.Windows.Forms.CheckBox check_circ;
        private System.Windows.Forms.NumericUpDown rad;
        private System.Windows.Forms.Label label12;
    }
}

