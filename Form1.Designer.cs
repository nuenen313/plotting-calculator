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
            this.button_add = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_backspace = new System.Windows.Forms.Button();
            this.button_sin = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button_tg = new System.Windows.Forms.Button();
            this.button_ctg = new System.Windows.Forms.Button();
            this.button_pi = new System.Windows.Forms.Button();
            this.button_e = new System.Windows.Forms.Button();
            this.button_quadratic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEditor
            // 
            this.textEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.textEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textEditor.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textEditor.Location = new System.Drawing.Point(9, 6);
            this.textEditor.Multiline = true;
            this.textEditor.Name = "textEditor";
            this.textEditor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEditor.ShortcutsEnabled = false;
            this.textEditor.Size = new System.Drawing.Size(399, 117);
            this.textEditor.TabIndex = 0;
            this.textEditor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button1.Location = new System.Drawing.Point(90, 373);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 75);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Button2
            // 
            this.Button2.AutoSize = true;
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button2.Location = new System.Drawing.Point(171, 373);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 75);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button3
            // 
            this.Button3.AutoSize = true;
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button3.Location = new System.Drawing.Point(252, 373);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 75);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button5
            // 
            this.Button5.AutoSize = true;
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button5.Location = new System.Drawing.Point(171, 292);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 75);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Button4
            // 
            this.Button4.AutoSize = true;
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button4.Location = new System.Drawing.Point(90, 292);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 75);
            this.Button4.TabIndex = 6;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Button9
            // 
            this.Button9.AutoSize = true;
            this.Button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button9.Location = new System.Drawing.Point(252, 211);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(75, 75);
            this.Button9.TabIndex = 11;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button10.Location = new System.Drawing.Point(171, 453);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(75, 75);
            this.Button10.TabIndex = 10;
            this.Button10.Text = "0";
            this.Button10.UseVisualStyleBackColor = false;
            this.Button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Button8
            // 
            this.Button8.AutoSize = true;
            this.Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button8.Location = new System.Drawing.Point(171, 211);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(75, 75);
            this.Button8.TabIndex = 9;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Button7
            // 
            this.Button7.AutoSize = true;
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button7.Location = new System.Drawing.Point(90, 211);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(75, 75);
            this.Button7.TabIndex = 8;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Button6
            // 
            this.Button6.AutoSize = true;
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button6.Location = new System.Drawing.Point(252, 292);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(75, 75);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_comma
            // 
            this.button_comma.AutoSize = true;
            this.button_comma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_comma.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_comma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_comma.Location = new System.Drawing.Point(252, 453);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(75, 75);
            this.button_comma.TabIndex = 12;
            this.button_comma.Text = ".";
            this.button_comma.UseVisualStyleBackColor = false;
            this.button_comma.Click += new System.EventHandler(this.button_comma_Click);
            // 
            // button_add
            // 
            this.button_add.AutoSize = true;
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_add.Location = new System.Drawing.Point(9, 130);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 75);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.AutoSize = true;
            this.button_subtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_subtract.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_subtract.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_subtract.Location = new System.Drawing.Point(90, 130);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(75, 75);
            this.button_subtract.TabIndex = 15;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = false;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.AutoSize = true;
            this.button_multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_multiply.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_multiply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_multiply.Location = new System.Drawing.Point(171, 130);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(75, 75);
            this.button_multiply.TabIndex = 16;
            this.button_multiply.Text = "×";
            this.button_multiply.UseVisualStyleBackColor = false;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_divide.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_divide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_divide.Location = new System.Drawing.Point(252, 130);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(75, 75);
            this.button_divide.TabIndex = 17;
            this.button_divide.Text = "÷";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_equals
            // 
            this.button_equals.AutoSize = true;
            this.button_equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_equals.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_equals.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_equals.Location = new System.Drawing.Point(333, 453);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(75, 75);
            this.button_equals.TabIndex = 18;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = false;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_clear
            // 
            this.button_clear.AutoSize = true;
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_clear.Location = new System.Drawing.Point(9, 372);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 75);
            this.button_clear.TabIndex = 19;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_backspace
            // 
            this.button_backspace.AutoSize = true;
            this.button_backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backspace.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_backspace.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_backspace.Location = new System.Drawing.Point(9, 211);
            this.button_backspace.Name = "button_backspace";
            this.button_backspace.Size = new System.Drawing.Size(75, 75);
            this.button_backspace.TabIndex = 20;
            this.button_backspace.Text = "←";
            this.button_backspace.UseVisualStyleBackColor = false;
            this.button_backspace.Click += new System.EventHandler(this.button_backspace_Click);
            // 
            // button_sin
            // 
            this.button_sin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_sin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_sin.Location = new System.Drawing.Point(333, 130);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(75, 75);
            this.button_sin.TabIndex = 21;
            this.button_sin.Text = "sin";
            this.button_sin.UseVisualStyleBackColor = false;
            this.button_sin.Click += new System.EventHandler(this.button_sin_Click);
            // 
            // button_cos
            // 
            this.button_cos.AutoSize = true;
            this.button_cos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_cos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_cos.Location = new System.Drawing.Point(333, 211);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(75, 75);
            this.button_cos.TabIndex = 22;
            this.button_cos.Text = "cos";
            this.button_cos.UseVisualStyleBackColor = false;
            this.button_cos.Click += new System.EventHandler(this.button_cos_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(9, 292);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 75);
            this.button11.TabIndex = 23;
            this.button11.Text = "±";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_tg
            // 
            this.button_tg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_tg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_tg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_tg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_tg.Location = new System.Drawing.Point(333, 292);
            this.button_tg.Name = "button_tg";
            this.button_tg.Size = new System.Drawing.Size(75, 75);
            this.button_tg.TabIndex = 24;
            this.button_tg.Text = "tan";
            this.button_tg.UseVisualStyleBackColor = false;
            this.button_tg.Click += new System.EventHandler(this.button_tg_Click);
            // 
            // button_ctg
            // 
            this.button_ctg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_ctg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ctg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ctg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ctg.Location = new System.Drawing.Point(333, 373);
            this.button_ctg.Name = "button_ctg";
            this.button_ctg.Size = new System.Drawing.Size(75, 75);
            this.button_ctg.TabIndex = 25;
            this.button_ctg.Text = "cot";
            this.button_ctg.UseVisualStyleBackColor = false;
            this.button_ctg.Click += new System.EventHandler(this.button_ctg_Click);
            // 
            // button_pi
            // 
            this.button_pi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_pi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_pi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_pi.Location = new System.Drawing.Point(90, 453);
            this.button_pi.Name = "button_pi";
            this.button_pi.Size = new System.Drawing.Size(75, 75);
            this.button_pi.TabIndex = 27;
            this.button_pi.Text = "π";
            this.button_pi.UseVisualStyleBackColor = false;
            this.button_pi.Click += new System.EventHandler(this.button_pi_Click);
            // 
            // button_e
            // 
            this.button_e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_e.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_e.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_e.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_e.Location = new System.Drawing.Point(9, 453);
            this.button_e.Name = "button_e";
            this.button_e.Size = new System.Drawing.Size(75, 75);
            this.button_e.TabIndex = 28;
            this.button_e.Text = "e";
            this.button_e.UseVisualStyleBackColor = false;
            this.button_e.Click += new System.EventHandler(this.button_e_Click);
            // 
            // button_quadratic
            // 
            this.button_quadratic.AutoSize = true;
            this.button_quadratic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button_quadratic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_quadratic.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_quadratic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_quadratic.Location = new System.Drawing.Point(9, 535);
            this.button_quadratic.Name = "button_quadratic";
            this.button_quadratic.Size = new System.Drawing.Size(399, 62);
            this.button_quadratic.TabIndex = 37;
            this.button_quadratic.Text = "Quadratic equation";
            this.button_quadratic.UseVisualStyleBackColor = false;
            this.button_quadratic.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(417, 607);
            this.Controls.Add(this.button_quadratic);
            this.Controls.Add(this.button_e);
            this.Controls.Add(this.button_pi);
            this.Controls.Add(this.button_ctg);
            this.Controls.Add(this.button_tg);
            this.Controls.Add(this.button_cos);
            this.Controls.Add(this.button_sin);
            this.Controls.Add(this.button_backspace);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_add);
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
            this.Controls.Add(this.button11);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
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
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_backspace;
        private System.Windows.Forms.Button button_sin;
        private System.Windows.Forms.Button button_cos;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button_tg;
        private System.Windows.Forms.Button button_ctg;
        private System.Windows.Forms.Button button_pi;
        private System.Windows.Forms.Button button_e;
        private System.Windows.Forms.Button button_quadratic;
    }
}

