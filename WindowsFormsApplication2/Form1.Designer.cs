namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Equals = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.num0 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.π = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Negetive = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.skinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deualtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.e = new System.Windows.Forms.Button();
            this.State_button = new System.Windows.Forms.Button();
            this.Cot = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ContextMenuStrip = this.contextMenuStrip2;
            this.textBox2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(2, 91);
            this.textBox2.MaxLength = 29;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(505, 230);
            this.textBox2.TabIndex = 0;
            this.textBox2.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip2.DropShadowEnabled = false;
            this.contextMenuStrip2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 70);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // Equals
            // 
            this.Equals.BackColor = System.Drawing.SystemColors.Control;
            this.Equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Equals.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Equals.ForeColor = System.Drawing.Color.Black;
            this.Equals.Location = new System.Drawing.Point(438, 547);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(69, 44);
            this.Equals.TabIndex = 1;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = false;
            this.Equals.Click += new System.EventHandler(this.button_Equal);
            this.Equals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.SystemColors.Control;
            this.Addition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addition.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Addition.ForeColor = System.Drawing.Color.Black;
            this.Addition.Location = new System.Drawing.Point(438, 502);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(69, 44);
            this.Addition.TabIndex = 2;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.button_Addition);
            this.Addition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // Subtraction
            // 
            this.Subtraction.BackColor = System.Drawing.SystemColors.Control;
            this.Subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Subtraction.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Subtraction.ForeColor = System.Drawing.Color.Black;
            this.Subtraction.Location = new System.Drawing.Point(438, 457);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(69, 44);
            this.Subtraction.TabIndex = 3;
            this.Subtraction.Text = "−";
            this.Subtraction.UseVisualStyleBackColor = false;
            this.Subtraction.Click += new System.EventHandler(this.button_Subtraction);
            this.Subtraction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // Multiplication
            // 
            this.Multiplication.BackColor = System.Drawing.SystemColors.Control;
            this.Multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiplication.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Multiplication.ForeColor = System.Drawing.Color.Black;
            this.Multiplication.Location = new System.Drawing.Point(438, 412);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(69, 44);
            this.Multiplication.TabIndex = 4;
            this.Multiplication.Text = "×";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.Click += new System.EventHandler(this.button_Multiplication);
            this.Multiplication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // Decimal
            // 
            this.Decimal.BackColor = System.Drawing.SystemColors.Control;
            this.Decimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Decimal.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Decimal.ForeColor = System.Drawing.Color.Black;
            this.Decimal.Location = new System.Drawing.Point(368, 547);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(69, 44);
            this.Decimal.TabIndex = 6;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = false;
            this.Decimal.Click += new System.EventHandler(this.button_decimal);
            this.Decimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(2, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(505, 65);
            this.textBox1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.DropShadowEnabled = false;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Copy";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.Control;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num0.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num0.ForeColor = System.Drawing.Color.Black;
            this.num0.Location = new System.Drawing.Point(298, 547);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(69, 44);
            this.num0.TabIndex = 8;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.button_0);
            this.num0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.Control;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num1.ForeColor = System.Drawing.Color.Black;
            this.num1.Location = new System.Drawing.Point(228, 502);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(69, 44);
            this.num1.TabIndex = 9;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.button_1);
            this.num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.Control;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num2.ForeColor = System.Drawing.Color.Black;
            this.num2.Location = new System.Drawing.Point(298, 502);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(69, 44);
            this.num2.TabIndex = 10;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.button_2);
            this.num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.Control;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num3.ForeColor = System.Drawing.Color.Black;
            this.num3.Location = new System.Drawing.Point(368, 502);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(69, 44);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.button_3);
            this.num3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.Control;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num4.ForeColor = System.Drawing.Color.Black;
            this.num4.Location = new System.Drawing.Point(228, 457);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(69, 44);
            this.num4.TabIndex = 12;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.button_4);
            this.num4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.Control;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num5.ForeColor = System.Drawing.Color.Black;
            this.num5.Location = new System.Drawing.Point(298, 457);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(69, 44);
            this.num5.TabIndex = 13;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.button_5);
            this.num5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.Control;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num6.ForeColor = System.Drawing.Color.Black;
            this.num6.Location = new System.Drawing.Point(368, 457);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(69, 44);
            this.num6.TabIndex = 14;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.button_6);
            this.num6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.Control;
            this.num7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num7.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num7.ForeColor = System.Drawing.Color.Black;
            this.num7.Location = new System.Drawing.Point(228, 412);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(69, 44);
            this.num7.TabIndex = 15;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.button_7);
            this.num7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.Control;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num8.ForeColor = System.Drawing.Color.Black;
            this.num8.Location = new System.Drawing.Point(298, 412);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(69, 44);
            this.num8.TabIndex = 16;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.button_8);
            this.num8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.Control;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num9.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.num9.ForeColor = System.Drawing.Color.Black;
            this.num9.Location = new System.Drawing.Point(368, 412);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(69, 44);
            this.num9.TabIndex = 17;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.button_9);
            this.num9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // Backspace
            // 
            this.Backspace.BackColor = System.Drawing.SystemColors.Control;
            this.Backspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backspace.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Backspace.ForeColor = System.Drawing.Color.Black;
            this.Backspace.Location = new System.Drawing.Point(438, 322);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(69, 44);
            this.Backspace.TabIndex = 18;
            this.Backspace.Text = "←";
            this.Backspace.UseVisualStyleBackColor = false;
            this.Backspace.Click += new System.EventHandler(this.button_Backspace);
            this.Backspace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // π
            // 
            this.π.BackColor = System.Drawing.SystemColors.Control;
            this.π.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.π.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.π.ForeColor = System.Drawing.Color.Black;
            this.π.Location = new System.Drawing.Point(298, 367);
            this.π.Name = "π";
            this.π.Size = new System.Drawing.Size(69, 44);
            this.π.TabIndex = 20;
            this.π.Text = "π";
            this.π.UseVisualStyleBackColor = false;
            this.π.Click += new System.EventHandler(this.button_π);
            // 
            // Factorial
            // 
            this.Factorial.BackColor = System.Drawing.SystemColors.Control;
            this.Factorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Factorial.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Factorial.ForeColor = System.Drawing.Color.Black;
            this.Factorial.Location = new System.Drawing.Point(228, 367);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(69, 44);
            this.Factorial.TabIndex = 21;
            this.Factorial.Text = "n!";
            this.Factorial.UseVisualStyleBackColor = false;
            this.Factorial.Click += new System.EventHandler(this.button_Factorial);
            // 
            // Negetive
            // 
            this.Negetive.BackColor = System.Drawing.SystemColors.Control;
            this.Negetive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Negetive.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Negetive.ForeColor = System.Drawing.Color.Black;
            this.Negetive.Location = new System.Drawing.Point(228, 547);
            this.Negetive.Name = "Negetive";
            this.Negetive.Size = new System.Drawing.Size(69, 44);
            this.Negetive.TabIndex = 22;
            this.Negetive.Text = "±";
            this.Negetive.UseVisualStyleBackColor = false;
            this.Negetive.Click += new System.EventHandler(this.button21_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.SystemColors.Control;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Division.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Division.ForeColor = System.Drawing.Color.Black;
            this.Division.Location = new System.Drawing.Point(438, 367);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(69, 44);
            this.Division.TabIndex = 24;
            this.Division.Text = "÷";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.button_Division);
            this.Division.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // Percentage
            // 
            this.Percentage.BackColor = System.Drawing.SystemColors.Control;
            this.Percentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Percentage.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Percentage.ForeColor = System.Drawing.Color.Black;
            this.Percentage.Location = new System.Drawing.Point(368, 367);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(69, 44);
            this.Percentage.TabIndex = 25;
            this.Percentage.Text = "%";
            this.Percentage.UseVisualStyleBackColor = false;
            this.Percentage.Click += new System.EventHandler(this.button_Percentage);
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.SystemColors.Control;
            this.Power.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Power.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Power.ForeColor = System.Drawing.Color.Black;
            this.Power.Location = new System.Drawing.Point(155, 457);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(72, 44);
            this.Power.TabIndex = 26;
            this.Power.Text = "x^y";
            this.Power.UseVisualStyleBackColor = false;
            this.Power.Click += new System.EventHandler(this.button_Power);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Control;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(368, 322);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(69, 44);
            this.Clear.TabIndex = 33;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.button_Clear);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skinToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            // 
            // skinToolStripMenuItem
            // 
            this.skinToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.skinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deualtToolStripMenuItem,
            this.dToolStripMenuItem,
            this.whiteToolStripMenuItem});
            this.skinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.skinToolStripMenuItem.Name = "skinToolStripMenuItem";
            this.skinToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.skinToolStripMenuItem.Text = "Skin";
            // 
            // deualtToolStripMenuItem
            // 
            this.deualtToolStripMenuItem.Name = "deualtToolStripMenuItem";
            this.deualtToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deualtToolStripMenuItem.Text = "Defualt";
            this.deualtToolStripMenuItem.Click += new System.EventHandler(this.deualtToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.dToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.dToolStripMenuItem.Text = "Dark";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.whiteToolStripMenuItem.Text = "Blue";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.SystemColors.Control;
            this.e.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.e.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.e.ForeColor = System.Drawing.Color.Black;
            this.e.Location = new System.Drawing.Point(298, 322);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(69, 44);
            this.e.TabIndex = 35;
            this.e.Text = "℮";
            this.e.UseVisualStyleBackColor = false;
            this.e.Click += new System.EventHandler(this.button_e);
            // 
            // State_button
            // 
            this.State_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.State_button.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State_button.ForeColor = System.Drawing.Color.Black;
            this.State_button.Location = new System.Drawing.Point(228, 322);
            this.State_button.Margin = new System.Windows.Forms.Padding(2);
            this.State_button.Name = "State_button";
            this.State_button.Size = new System.Drawing.Size(69, 44);
            this.State_button.TabIndex = 47;
            this.State_button.Text = "1st";
            this.State_button.UseVisualStyleBackColor = true;
            this.State_button.Click += new System.EventHandler(this.State);
            // 
            // Cot
            // 
            this.Cot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cot.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cot.ForeColor = System.Drawing.Color.Black;
            this.Cot.Location = new System.Drawing.Point(155, 547);
            this.Cot.Margin = new System.Windows.Forms.Padding(2);
            this.Cot.Name = "Cot";
            this.Cot.Size = new System.Drawing.Size(72, 44);
            this.Cot.TabIndex = 46;
            this.Cot.Text = "Cot";
            this.Cot.UseVisualStyleBackColor = true;
            this.Cot.Click += new System.EventHandler(this.CoTangent);
            // 
            // Cos
            // 
            this.Cos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cos.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cos.ForeColor = System.Drawing.Color.Black;
            this.Cos.Location = new System.Drawing.Point(155, 502);
            this.Cos.Margin = new System.Windows.Forms.Padding(2);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(72, 44);
            this.Cos.TabIndex = 45;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.CoSinus);
            // 
            // Tan
            // 
            this.Tan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tan.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Tan.ForeColor = System.Drawing.Color.Black;
            this.Tan.Location = new System.Drawing.Point(82, 547);
            this.Tan.Margin = new System.Windows.Forms.Padding(2);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(72, 44);
            this.Tan.TabIndex = 44;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.Tangent);
            // 
            // Sin
            // 
            this.Sin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Sin.ForeColor = System.Drawing.Color.Black;
            this.Sin.Location = new System.Drawing.Point(82, 502);
            this.Sin.Margin = new System.Windows.Forms.Padding(2);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(72, 44);
            this.Sin.TabIndex = 43;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sinus);
            // 
            // exp
            // 
            this.exp.BackColor = System.Drawing.SystemColors.Control;
            this.exp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exp.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exp.ForeColor = System.Drawing.Color.Black;
            this.exp.Location = new System.Drawing.Point(120, 367);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(107, 44);
            this.exp.TabIndex = 48;
            this.exp.Text = "exp(x)";
            this.exp.UseVisualStyleBackColor = false;
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.SystemColors.Control;
            this.ln.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ln.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ln.ForeColor = System.Drawing.Color.Black;
            this.ln.Location = new System.Drawing.Point(142, 412);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(85, 44);
            this.ln.TabIndex = 49;
            this.ln.Text = "ln(x)";
            this.ln.UseVisualStyleBackColor = false;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(507, 592);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.State_button);
            this.Controls.Add(this.Cot);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.e);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Negetive);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.π);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.textBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.94D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button π;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Negetive;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Button Percentage;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ToolStripMenuItem skinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Button Equals;
        private System.Windows.Forms.ToolStripMenuItem deualtToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button State_button;
        private System.Windows.Forms.Button Cot;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

