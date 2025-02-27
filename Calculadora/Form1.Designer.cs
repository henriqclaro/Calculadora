namespace Calculadora
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
            this.lblOper = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numOper2 = new System.Windows.Forms.NumericUpDown();
            this.numOper1 = new System.Windows.Forms.NumericUpDown();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSegue = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnNegar = new System.Windows.Forms.Button();
            this.lblNeg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operando 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operando 2: ";
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.ForeColor = System.Drawing.Color.White;
            this.lblOper.Location = new System.Drawing.Point(144, 88);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(30, 26);
            this.lblOper.TabIndex = 5;
            this.lblOper.Text = "...";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(-18, 184);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(305, 26);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Selecione uma operação";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numOper2
            // 
            this.numOper2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.numOper2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOper2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper2.ForeColor = System.Drawing.Color.White;
            this.numOper2.Location = new System.Drawing.Point(16, 126);
            this.numOper2.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.numOper2.Minimum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            -2147483648});
            this.numOper2.Name = "numOper2";
            this.numOper2.Size = new System.Drawing.Size(120, 32);
            this.numOper2.TabIndex = 8;
            this.numOper2.ValueChanged += new System.EventHandler(this.numOper2_ValueChanged);
            // 
            // numOper1
            // 
            this.numOper1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.numOper1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOper1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper1.ForeColor = System.Drawing.Color.White;
            this.numOper1.Location = new System.Drawing.Point(16, 49);
            this.numOper1.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.numOper1.Minimum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            -2147483648});
            this.numOper1.Name = "numOper1";
            this.numOper1.Size = new System.Drawing.Size(120, 32);
            this.numOper1.TabIndex = 10;
            this.numOper1.ValueChanged += new System.EventHandler(this.numOper1_ValueChanged);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.Transparent;
            this.btnSoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(16, 235);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(35, 37);
            this.btnSoma.TabIndex = 11;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Transparent;
            this.btnDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(57, 278);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(35, 35);
            this.btnDiv.TabIndex = 13;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.Transparent;
            this.btnMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(16, 278);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(35, 35);
            this.btnMult.TabIndex = 15;
            this.btnMult.Text = "×";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Transparent;
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(57, 235);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(35, 37);
            this.btnSub.TabIndex = 17;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Transparent;
            this.btnIgual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgual.Enabled = false;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(98, 235);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(38, 78);
            this.btnIgual.TabIndex = 19;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSegue
            // 
            this.btnSegue.BackColor = System.Drawing.Color.Transparent;
            this.btnSegue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegue.Enabled = false;
            this.btnSegue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegue.Location = new System.Drawing.Point(142, 235);
            this.btnSegue.Name = "btnSegue";
            this.btnSegue.Size = new System.Drawing.Size(35, 37);
            this.btnSegue.TabIndex = 20;
            this.btnSegue.Text = "→";
            this.btnSegue.UseVisualStyleBackColor = false;
            this.btnSegue.Click += new System.EventHandler(this.btnSegue_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.Location = new System.Drawing.Point(183, 278);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(35, 35);
            this.btnLimpa.TabIndex = 21;
            this.btnLimpa.Text = "C";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.Transparent;
            this.btnInvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvert.Location = new System.Drawing.Point(183, 235);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(35, 37);
            this.btnInvert.TabIndex = 22;
            this.btnInvert.Text = "⇵";
            this.btnInvert.UseVisualStyleBackColor = false;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnNegar
            // 
            this.btnNegar.BackColor = System.Drawing.Color.Transparent;
            this.btnNegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNegar.Enabled = false;
            this.btnNegar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegar.Location = new System.Drawing.Point(142, 278);
            this.btnNegar.Name = "btnNegar";
            this.btnNegar.Size = new System.Drawing.Size(35, 35);
            this.btnNegar.TabIndex = 23;
            this.btnNegar.Text = "±";
            this.btnNegar.UseVisualStyleBackColor = false;
            this.btnNegar.Click += new System.EventHandler(this.btnNegar_Click);
            // 
            // lblNeg
            // 
            this.lblNeg.AutoSize = true;
            this.lblNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeg.ForeColor = System.Drawing.Color.White;
            this.lblNeg.Location = new System.Drawing.Point(180, 88);
            this.lblNeg.Name = "lblNeg";
            this.lblNeg.Size = new System.Drawing.Size(0, 20);
            this.lblNeg.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(299, 339);
            this.Controls.Add(this.lblNeg);
            this.Controls.Add(this.btnNegar);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnSegue);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.numOper1);
            this.Controls.Add(this.numOper2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numOper2;
        private System.Windows.Forms.NumericUpDown numOper1;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSegue;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnNegar;
        private System.Windows.Forms.Label lblNeg;
    }
}

