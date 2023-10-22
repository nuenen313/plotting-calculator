namespace calculate
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textEditor = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.button_comma = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_backspace = new System.Windows.Forms.Button();
            this.button_sin = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEditor
            // 
            this.textEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.textEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditor.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditor.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textEditor.Location = new System.Drawing.Point(-4, -2);
            this.textEditor.Multiline = true;
            this.textEditor.Name = "textEditor";
            this.textEditor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEditor.Size = new System.Drawing.Size(367, 77);
            this.textEditor.TabIndex = 0;
            this.textEditor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Black;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button1.Location = new System.Drawing.Point(-4, 81);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 75);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Black;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button2.Location = new System.Drawing.Point(67, 81);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 75);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Black;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button3.Location = new System.Drawing.Point(139, 81);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 75);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Black;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button5.Location = new System.Drawing.Point(280, 81);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 75);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Black;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button4.Location = new System.Drawing.Point(208, 81);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 75);
            this.Button4.TabIndex = 6;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.Black;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button9.Location = new System.Drawing.Point(208, 153);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(75, 75);
            this.Button9.TabIndex = 11;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.Black;
            this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button10.Location = new System.Drawing.Point(280, 153);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(75, 75);
            this.Button10.TabIndex = 10;
            this.Button10.Text = "0";
            this.Button10.UseVisualStyleBackColor = false;
            this.Button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.Black;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button8.Location = new System.Drawing.Point(139, 153);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(75, 75);
            this.Button8.TabIndex = 9;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Black;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button7.Location = new System.Drawing.Point(67, 153);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(75, 75);
            this.Button7.TabIndex = 8;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Black;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button6.Location = new System.Drawing.Point(-4, 153);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(75, 75);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_comma
            // 
            this.button_comma.BackColor = System.Drawing.Color.Black;
            this.button_comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_comma.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_comma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_comma.Location = new System.Drawing.Point(-4, 225);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(75, 75);
            this.button_comma.TabIndex = 12;
            this.button_comma.Text = ",";
            this.button_comma.UseVisualStyleBackColor = false;
            this.button_comma.Click += new System.EventHandler(this.button_comma_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ControlText;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_exit.Location = new System.Drawing.Point(-4, 378);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(78, 44);
            this.button_exit.TabIndex = 13;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Black;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_add.Location = new System.Drawing.Point(67, 225);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 75);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.BackColor = System.Drawing.Color.Black;
            this.button_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_subtract.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_subtract.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_subtract.Location = new System.Drawing.Point(139, 225);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(75, 75);
            this.button_subtract.TabIndex = 15;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = false;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.BackColor = System.Drawing.Color.Black;
            this.button_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_multiply.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_multiply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_multiply.Location = new System.Drawing.Point(208, 225);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(75, 75);
            this.button_multiply.TabIndex = 16;
            this.button_multiply.Text = "×";
            this.button_multiply.UseVisualStyleBackColor = false;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.Color.Black;
            this.button_divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_divide.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_divide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_divide.Location = new System.Drawing.Point(280, 225);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(75, 75);
            this.button_divide.TabIndex = 17;
            this.button_divide.Text = "÷";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_equals
            // 
            this.button_equals.BackColor = System.Drawing.Color.Black;
            this.button_equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_equals.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_equals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_equals.Location = new System.Drawing.Point(-4, 297);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(75, 75);
            this.button_equals.TabIndex = 18;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = false;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Black;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_clear.Location = new System.Drawing.Point(67, 297);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 75);
            this.button_clear.TabIndex = 19;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_backspace
            // 
            this.button_backspace.BackColor = System.Drawing.Color.Black;
            this.button_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backspace.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_backspace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_backspace.Location = new System.Drawing.Point(139, 297);
            this.button_backspace.Name = "button_backspace";
            this.button_backspace.Size = new System.Drawing.Size(75, 75);
            this.button_backspace.TabIndex = 20;
            this.button_backspace.Text = "⌫";
            this.button_backspace.UseVisualStyleBackColor = false;
            this.button_backspace.Click += new System.EventHandler(this.button_backspace_Click);
            // 
            // button_sin
            // 
            this.button_sin.BackColor = System.Drawing.Color.Black;
            this.button_sin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_sin.Location = new System.Drawing.Point(208, 297);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(75, 75);
            this.button_sin.TabIndex = 21;
            this.button_sin.Text = "sin";
            this.button_sin.UseVisualStyleBackColor = false;
            this.button_sin.Click += new System.EventHandler(this.button_sin_Click);
            // 
            // button_cos
            // 
            this.button_cos.BackColor = System.Drawing.Color.Black;
            this.button_cos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cos.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_cos.Location = new System.Drawing.Point(280, 297);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(75, 75);
            this.button_cos.TabIndex = 22;
            this.button_cos.Text = "cos";
            this.button_cos.UseVisualStyleBackColor = false;
            this.button_cos.Click += new System.EventHandler(this.button_cos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(358, 432);
            this.ControlBox = false;
            this.Controls.Add(this.button_cos);
            this.Controls.Add(this.button_sin);
            this.Controls.Add(this.button_backspace);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_comma);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textEditor);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEditor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button button_comma;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_backspace;
        private System.Windows.Forms.Button button_sin;
        private System.Windows.Forms.Button button_cos;
    }
}

