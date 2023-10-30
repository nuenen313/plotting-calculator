namespace calculate
{
    partial class Form3
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
            this.button_quadratic = new System.Windows.Forms.Button();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_quadratic
            // 
            this.button_quadratic.AutoSize = true;
            this.button_quadratic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_quadratic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_quadratic.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_quadratic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_quadratic.Location = new System.Drawing.Point(62, 125);
            this.button_quadratic.Name = "button_quadratic";
            this.button_quadratic.Size = new System.Drawing.Size(292, 64);
            this.button_quadratic.TabIndex = 44;
            this.button_quadratic.Text = "Calculate roots";
            this.button_quadratic.UseVisualStyleBackColor = false;
            this.button_quadratic.Click += new System.EventHandler(this.button_quadratic_Click);
            // 
            // textBox_a
            // 
            this.textBox_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.textBox_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_a.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_a.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_a.Location = new System.Drawing.Point(50, 60);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.ShortcutsEnabled = false;
            this.textBox_a.Size = new System.Drawing.Size(66, 41);
            this.textBox_a.TabIndex = 37;
            this.textBox_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_a.TextChanged += new System.EventHandler(this.textBox_a_TextChanged);
            this.textBox_a.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBox_c
            // 
            this.textBox_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.textBox_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_c.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_c.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_c.Location = new System.Drawing.Point(284, 60);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.ShortcutsEnabled = false;
            this.textBox_c.Size = new System.Drawing.Size(70, 41);
            this.textBox_c.TabIndex = 39;
            this.textBox_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_c.TextChanged += new System.EventHandler(this.textBox_c_TextChanged);
            this.textBox_c.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_c_KeyDown);
            // 
            // textBox_b
            // 
            this.textBox_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.textBox_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_b.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_b.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_b.Location = new System.Drawing.Point(171, 60);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.ShortcutsEnabled = false;
            this.textBox_b.Size = new System.Drawing.Size(65, 41);
            this.textBox_b.TabIndex = 38;
            this.textBox_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_b.TextChanged += new System.EventHandler(this.textBox_b_TextChanged);
            this.textBox_b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_b_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(242, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 43);
            this.label4.TabIndex = 43;
            this.label4.Text = "c:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(123, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 43);
            this.label3.TabIndex = 42;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 43);
            this.label2.TabIndex = 41;
            this.label2.Text = "a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "Quadratic equation solver\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textEditor
            // 
            this.textEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.textEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textEditor.ForeColor = System.Drawing.SystemColors.Window;
            this.textEditor.Location = new System.Drawing.Point(9, 230);
            this.textEditor.Multiline = true;
            this.textEditor.Name = "textEditor";
            this.textEditor.ReadOnly = true;
            this.textEditor.Size = new System.Drawing.Size(382, 51);
            this.textEditor.TabIndex = 45;
            this.textEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEditor.TextChanged += new System.EventHandler(this.textEditor_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(411, 270);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.button_quadratic);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.Name = "Form3";
            this.Text = "Quadratic equation solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_quadratic;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEditor;
    }
}