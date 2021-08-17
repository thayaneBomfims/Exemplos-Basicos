
namespace Exemplo_Desktop
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cleanSingle = new System.Windows.Forms.Button();
            this.cleanAll = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSom = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDeci = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnMult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cleanSingle
            // 
            this.cleanSingle.BackColor = System.Drawing.Color.Gray;
            this.cleanSingle.FlatAppearance.BorderSize = 0;
            this.cleanSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanSingle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cleanSingle.Location = new System.Drawing.Point(3, 165);
            this.cleanSingle.Name = "cleanSingle";
            this.cleanSingle.Size = new System.Drawing.Size(108, 59);
            this.cleanSingle.TabIndex = 1;
            this.cleanSingle.Text = "CE";
            this.cleanSingle.UseVisualStyleBackColor = false;
            this.cleanSingle.Click += new System.EventHandler(this.btnSingle);
            // 
            // cleanAll
            // 
            this.cleanAll.BackColor = System.Drawing.Color.Gray;
            this.cleanAll.FlatAppearance.BorderSize = 0;
            this.cleanAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cleanAll.Location = new System.Drawing.Point(113, 165);
            this.cleanAll.Name = "cleanAll";
            this.cleanAll.Size = new System.Drawing.Size(218, 59);
            this.cleanAll.TabIndex = 2;
            this.cleanAll.Text = "C";
            this.cleanAll.UseVisualStyleBackColor = false;
            this.cleanAll.Click += new System.EventHandler(this.btnClean);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Gray;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDiv.Location = new System.Drawing.Point(333, 226);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(108, 59);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.Div);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.Location = new System.Drawing.Point(223, 226);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(108, 59);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNum);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.Location = new System.Drawing.Point(113, 226);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(108, 59);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNum);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.Location = new System.Drawing.Point(3, 226);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(108, 59);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNum);
            // 
            // btnSom
            // 
            this.btnSom.BackColor = System.Drawing.Color.Gray;
            this.btnSom.FlatAppearance.BorderSize = 0;
            this.btnSom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSom.Location = new System.Drawing.Point(333, 287);
            this.btnSom.Name = "btnSom";
            this.btnSom.Size = new System.Drawing.Size(108, 59);
            this.btnSom.TabIndex = 11;
            this.btnSom.Text = "+";
            this.btnSom.UseVisualStyleBackColor = false;
            this.btnSom.Click += new System.EventHandler(this.Som);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Location = new System.Drawing.Point(223, 287);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(108, 59);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNum);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.Location = new System.Drawing.Point(113, 287);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(108, 59);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNum);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.Location = new System.Drawing.Point(3, 287);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(108, 59);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNum);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Gray;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSub.Location = new System.Drawing.Point(333, 349);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(108, 59);
            this.btnSub.TabIndex = 15;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.Sub);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.Location = new System.Drawing.Point(223, 349);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(108, 59);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNum);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Location = new System.Drawing.Point(113, 349);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(108, 59);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNum);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Location = new System.Drawing.Point(3, 349);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(108, 59);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNum);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.HotPink;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResult.Location = new System.Drawing.Point(224, 411);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(218, 59);
            this.btnResult.TabIndex = 19;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnRes);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.Location = new System.Drawing.Point(113, 411);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(108, 59);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNum);
            // 
            // btnDeci
            // 
            this.btnDeci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
            this.btnDeci.FlatAppearance.BorderSize = 0;
            this.btnDeci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeci.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeci.Location = new System.Drawing.Point(3, 411);
            this.btnDeci.Name = "btnDeci";
            this.btnDeci.Size = new System.Drawing.Size(108, 59);
            this.btnDeci.TabIndex = 16;
            this.btnDeci.Text = ",";
            this.btnDeci.UseVisualStyleBackColor = false;
            this.btnDeci.Click += new System.EventHandler(this.btnVirg);
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.DimGray;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtValor.Location = new System.Drawing.Point(4, 51);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(437, 76);
            this.txtValor.TabIndex = 20;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.Gray;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMult.Location = new System.Drawing.Point(333, 165);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(108, 59);
            this.btnMult.TabIndex = 21;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.Mult);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 22;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(445, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDeci);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSom);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.cleanAll);
            this.Controls.Add(this.cleanSingle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cleanSingle;
        private System.Windows.Forms.Button cleanAll;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSom;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDeci;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Label label1;
    }
}

