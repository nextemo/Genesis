namespace CalcMethod
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.chckAdd = new System.Windows.Forms.CheckBox();
            this.chckSub = new System.Windows.Forms.CheckBox();
            this.chckMul = new System.Windows.Forms.CheckBox();
            this.chckDiv = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(17, 23);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(108, 59);
            this.txtInput.TabIndex = 0;
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput2.Location = new System.Drawing.Point(151, 23);
            this.txtInput2.Multiline = true;
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(108, 59);
            this.txtInput2.TabIndex = 1;
            this.txtInput2.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(283, 23);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(108, 59);
            this.txtOutput.TabIndex = 2;
            // 
            // chckAdd
            // 
            this.chckAdd.AutoSize = true;
            this.chckAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckAdd.Location = new System.Drawing.Point(82, 101);
            this.chckAdd.Name = "chckAdd";
            this.chckAdd.Size = new System.Drawing.Size(49, 35);
            this.chckAdd.TabIndex = 3;
            this.chckAdd.Text = "+";
            this.chckAdd.UseVisualStyleBackColor = true;
            this.chckAdd.CheckedChanged += new System.EventHandler(this.chckAdd_CheckedChanged);
            // 
            // chckSub
            // 
            this.chckSub.AutoSize = true;
            this.chckSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckSub.Location = new System.Drawing.Point(151, 101);
            this.chckSub.Name = "chckSub";
            this.chckSub.Size = new System.Drawing.Size(42, 35);
            this.chckSub.TabIndex = 4;
            this.chckSub.Text = "-";
            this.chckSub.UseVisualStyleBackColor = true;
            // 
            // chckMul
            // 
            this.chckMul.AutoSize = true;
            this.chckMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckMul.Location = new System.Drawing.Point(222, 101);
            this.chckMul.Name = "chckMul";
            this.chckMul.Size = new System.Drawing.Size(43, 33);
            this.chckMul.TabIndex = 5;
            this.chckMul.Text = "x";
            this.chckMul.UseVisualStyleBackColor = true;
            // 
            // chckDiv
            // 
            this.chckDiv.AutoSize = true;
            this.chckDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckDiv.Location = new System.Drawing.Point(283, 101);
            this.chckDiv.Name = "chckDiv";
            this.chckDiv.Size = new System.Drawing.Size(39, 33);
            this.chckDiv.TabIndex = 6;
            this.chckDiv.Text = "/";
            this.chckDiv.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(151, 160);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 49);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(283, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(17, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 49);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 232);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chckDiv);
            this.Controls.Add(this.chckMul);
            this.Controls.Add(this.chckSub);
            this.Controls.Add(this.chckAdd);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.CheckBox chckAdd;
        private System.Windows.Forms.CheckBox chckSub;
        private System.Windows.Forms.CheckBox chckMul;
        private System.Windows.Forms.CheckBox chckDiv;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

