namespace Calculator_App
{
    partial class calculator
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
            TxtBox = new TextBox();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            delBtn = new Button();
            dotBtn = new Button();
            equalBtn = new Button();
            num0 = new Button();
            multiplyBtn = new Button();
            subtractBtn = new Button();
            divideBtn = new Button();
            addBtn = new Button();
            clearBtn = new Button();
            num4 = new Button();
            num3 = new Button();
            num1 = new Button();
            num2 = new Button();
            percentageBtn = new Button();
            lnBtn = new Button();
            powerBtn = new Button();
            binBtn = new Button();
            decimalBtn = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            cubeBtn = new Button();
            logBtn = new Button();
            factorialBtn = new Button();
            button33 = new Button();
            hexBtn = new Button();
            octBtn = new Button();
            button36 = new Button();
            expBtn = new Button();
            piBtn = new Button();
            sinBtn = new Button();
            cosBtn = new Button();
            tanBtn = new Button();
            button12 = new Button();
            num5 = new Button();
            num6 = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.BorderStyle = BorderStyle.FixedSingle;
            TxtBox.Cursor = Cursors.IBeam;
            TxtBox.Font = new Font("Cascadia Code SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBox.Location = new Point(310, 32);
            TxtBox.Multiline = true;
            TxtBox.Name = "TxtBox";
            TxtBox.PlaceholderText = "0";
            TxtBox.ReadOnly = true;
            TxtBox.RightToLeft = RightToLeft.No;
            TxtBox.Size = new Size(371, 51);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            TxtBox.TextChanged += TxtBox_TextChanged;
            // 
            // num9
            // 
            num9.BackColor = Color.Gray;
            num9.Cursor = Cursors.Hand;
            num9.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num9.ForeColor = SystemColors.ButtonHighlight;
            num9.Location = new Point(240, 220);
            num9.Name = "num9";
            num9.Size = new Size(105, 75);
            num9.TabIndex = 6;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = false;
            num9.Click += num9_Click;
            num9.StyleChanged += num1_Click;
            // 
            // num8
            // 
            num8.BackColor = Color.Gray;
            num8.Cursor = Cursors.Hand;
            num8.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num8.ForeColor = SystemColors.ButtonHighlight;
            num8.Location = new Point(130, 220);
            num8.Name = "num8";
            num8.Size = new Size(105, 75);
            num8.TabIndex = 7;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = false;
            num8.Click += num8_Click;
            num8.StyleChanged += num1_Click;
            // 
            // num7
            // 
            num7.BackColor = Color.Gray;
            num7.Cursor = Cursors.Hand;
            num7.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num7.ForeColor = SystemColors.ButtonHighlight;
            num7.Location = new Point(18, 220);
            num7.Name = "num7";
            num7.Size = new Size(105, 75);
            num7.TabIndex = 8;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = false;
            num7.Click += num7_Click;
            num7.StyleChanged += num1_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.Gray;
            delBtn.Cursor = Cursors.Hand;
            delBtn.Font = new Font("Wingdings", 18F, FontStyle.Bold, GraphicsUnit.Point, 2);
            delBtn.ForeColor = SystemColors.ButtonHighlight;
            delBtn.ImageAlign = ContentAlignment.BottomCenter;
            delBtn.Location = new Point(130, 137);
            delBtn.Margin = new Padding(0);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(105, 75);
            delBtn.TabIndex = 25;
            delBtn.Text = "Õ\r\n\r\n\r\n\r\n";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            delBtn.StyleChanged += num1_Click;
            // 
            // dotBtn
            // 
            dotBtn.BackColor = Color.Gray;
            dotBtn.Cursor = Cursors.Hand;
            dotBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            dotBtn.ForeColor = SystemColors.ButtonHighlight;
            dotBtn.Location = new Point(130, 466);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(105, 75);
            dotBtn.TabIndex = 13;
            dotBtn.Text = ".";
            dotBtn.UseVisualStyleBackColor = false;
            dotBtn.Click += dotBtn_Click;
            dotBtn.StyleChanged += num1_Click;
            // 
            // equalBtn
            // 
            equalBtn.BackColor = Color.Gray;
            equalBtn.Cursor = Cursors.Hand;
            equalBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            equalBtn.ForeColor = SystemColors.ButtonHighlight;
            equalBtn.Location = new Point(240, 466);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(213, 75);
            equalBtn.TabIndex = 12;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = false;
            equalBtn.Click += equalBtn_Click;
            equalBtn.StyleChanged += num1_Click;
            // 
            // num0
            // 
            num0.BackColor = Color.Gray;
            num0.Cursor = Cursors.Hand;
            num0.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num0.ForeColor = SystemColors.ButtonHighlight;
            num0.Location = new Point(18, 466);
            num0.Name = "num0";
            num0.Size = new Size(105, 75);
            num0.TabIndex = 11;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = false;
            num0.Click += num0_Click;
            num0.StyleChanged += num1_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.BackColor = Color.Gray;
            multiplyBtn.Cursor = Cursors.Hand;
            multiplyBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            multiplyBtn.ForeColor = SystemColors.ButtonHighlight;
            multiplyBtn.Location = new Point(348, 220);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(105, 75);
            multiplyBtn.TabIndex = 17;
            multiplyBtn.Text = "x";
            multiplyBtn.UseVisualStyleBackColor = false;
            multiplyBtn.Click += multiplyBtn_Click;
            multiplyBtn.StyleChanged += num1_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.BackColor = Color.Gray;
            subtractBtn.Cursor = Cursors.Hand;
            subtractBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            subtractBtn.ForeColor = SystemColors.ButtonHighlight;
            subtractBtn.Location = new Point(348, 304);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(105, 75);
            subtractBtn.TabIndex = 16;
            subtractBtn.Text = "-";
            subtractBtn.UseVisualStyleBackColor = false;
            subtractBtn.Click += subtractBtn_Click;
            subtractBtn.StyleChanged += num1_Click;
            // 
            // divideBtn
            // 
            divideBtn.BackColor = Color.Gray;
            divideBtn.Cursor = Cursors.Hand;
            divideBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            divideBtn.ForeColor = SystemColors.ButtonHighlight;
            divideBtn.Location = new Point(348, 137);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(105, 75);
            divideBtn.TabIndex = 20;
            divideBtn.Text = "/";
            divideBtn.UseVisualStyleBackColor = false;
            divideBtn.Click += divideBtn_Click;
            divideBtn.StyleChanged += num1_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Gray;
            addBtn.Cursor = Cursors.Hand;
            addBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            addBtn.ForeColor = SystemColors.ButtonHighlight;
            addBtn.Location = new Point(348, 387);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(105, 75);
            addBtn.TabIndex = 19;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            addBtn.StyleChanged += num1_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Gray;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            clearBtn.ForeColor = SystemColors.ButtonHighlight;
            clearBtn.Location = new Point(18, 137);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(105, 75);
            clearBtn.TabIndex = 22;
            clearBtn.Text = "C";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            clearBtn.StyleChanged += num1_Click;
            // 
            // num4
            // 
            num4.BackColor = Color.Gray;
            num4.Cursor = Cursors.Hand;
            num4.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num4.ForeColor = SystemColors.ButtonHighlight;
            num4.Location = new Point(18, 304);
            num4.Name = "num4";
            num4.Size = new Size(105, 75);
            num4.TabIndex = 27;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = false;
            num4.Click += num4_Click;
            num4.StyleChanged += num1_Click;
            // 
            // num3
            // 
            num3.BackColor = Color.Gray;
            num3.Cursor = Cursors.Hand;
            num3.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num3.ForeColor = SystemColors.ButtonHighlight;
            num3.Location = new Point(240, 387);
            num3.Name = "num3";
            num3.Size = new Size(105, 75);
            num3.TabIndex = 26;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = false;
            num3.Click += num3_Click;
            num3.StyleChanged += num1_Click;
            // 
            // num1
            // 
            num1.BackColor = Color.Gray;
            num1.Cursor = Cursors.Hand;
            num1.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num1.ForeColor = SystemColors.ButtonHighlight;
            num1.Location = new Point(18, 387);
            num1.Name = "num1";
            num1.Size = new Size(105, 75);
            num1.TabIndex = 25;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = false;
            num1.ForeColorChanged += num1_Click;
            num1.Click += num1_Click;
            num1.StyleChanged += num1_Click;
            // 
            // num2
            // 
            num2.BackColor = Color.Gray;
            num2.Cursor = Cursors.Hand;
            num2.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num2.ForeColor = SystemColors.ButtonHighlight;
            num2.Location = new Point(130, 387);
            num2.Name = "num2";
            num2.Size = new Size(105, 75);
            num2.TabIndex = 24;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = false;
            num2.Click += num2_Click;
            num2.StyleChanged += num1_Click;
            // 
            // percentageBtn
            // 
            percentageBtn.BackColor = Color.Gray;
            percentageBtn.Cursor = Cursors.Hand;
            percentageBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            percentageBtn.ForeColor = SystemColors.ButtonHighlight;
            percentageBtn.Location = new Point(240, 137);
            percentageBtn.Name = "percentageBtn";
            percentageBtn.Size = new Size(105, 75);
            percentageBtn.TabIndex = 23;
            percentageBtn.Text = "CE";
            percentageBtn.UseVisualStyleBackColor = false;
            percentageBtn.Click += percentageBtn_Click;
            percentageBtn.StyleChanged += num1_Click;
            // 
            // lnBtn
            // 
            lnBtn.BackColor = Color.Gray;
            lnBtn.Cursor = Cursors.Hand;
            lnBtn.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnBtn.ForeColor = SystemColors.ButtonHighlight;
            lnBtn.Location = new Point(513, 466);
            lnBtn.Name = "lnBtn";
            lnBtn.Size = new Size(95, 75);
            lnBtn.TabIndex = 46;
            lnBtn.Text = "In";
            lnBtn.UseVisualStyleBackColor = false;
            lnBtn.Click += lnBtn_Click;
            // 
            // powerBtn
            // 
            powerBtn.BackColor = Color.Gray;
            powerBtn.Cursor = Cursors.Hand;
            powerBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            powerBtn.ForeColor = SystemColors.ButtonHighlight;
            powerBtn.Location = new Point(715, 223);
            powerBtn.Name = "powerBtn";
            powerBtn.Size = new Size(95, 75);
            powerBtn.TabIndex = 45;
            powerBtn.Text = "^";
            powerBtn.UseVisualStyleBackColor = false;
            powerBtn.Click += powerBtn_Click;
            // 
            // binBtn
            // 
            binBtn.BackColor = Color.Gray;
            binBtn.Cursor = Cursors.Hand;
            binBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            binBtn.ForeColor = SystemColors.ButtonHighlight;
            binBtn.Location = new Point(513, 385);
            binBtn.Name = "binBtn";
            binBtn.Size = new Size(95, 75);
            binBtn.TabIndex = 44;
            binBtn.Text = "Bin";
            binBtn.UseVisualStyleBackColor = false;
            binBtn.Click += opBracketBtn_Click;
            // 
            // decimalBtn
            // 
            decimalBtn.BackColor = Color.Gray;
            decimalBtn.Cursor = Cursors.Hand;
            decimalBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            decimalBtn.ForeColor = SystemColors.ButtonHighlight;
            decimalBtn.Location = new Point(614, 385);
            decimalBtn.Name = "decimalBtn";
            decimalBtn.Size = new Size(95, 75);
            decimalBtn.TabIndex = 43;
            decimalBtn.Text = "Dec";
            decimalBtn.UseVisualStyleBackColor = false;
            decimalBtn.Click += decimalBtn_Click;
            // 
            // button27
            // 
            button27.BackColor = Color.Gray;
            button27.Cursor = Cursors.Hand;
            button27.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            button27.ForeColor = SystemColors.ButtonHighlight;
            button27.Location = new Point(715, 142);
            button27.Name = "button27";
            button27.Size = new Size(95, 75);
            button27.TabIndex = 42;
            button27.Text = "sqrt";
            button27.UseVisualStyleBackColor = false;
            button27.Click += button27_Click;
            // 
            // button28
            // 
            button28.BackColor = Color.Gray;
            button28.Cursor = Cursors.Hand;
            button28.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            button28.ForeColor = SystemColors.ButtonHighlight;
            button28.Location = new Point(513, 142);
            button28.Name = "button28";
            button28.Size = new Size(95, 75);
            button28.TabIndex = 41;
            button28.Text = "inv";
            button28.UseVisualStyleBackColor = false;
            button28.Click += button28_Click;
            // 
            // button29
            // 
            button29.BackColor = Color.Gray;
            button29.Cursor = Cursors.Hand;
            button29.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            button29.ForeColor = SystemColors.ButtonHighlight;
            button29.Location = new Point(813, 142);
            button29.Name = "button29";
            button29.Size = new Size(95, 75);
            button29.TabIndex = 40;
            button29.Text = "x^2";
            button29.UseVisualStyleBackColor = false;
            button29.Click += button29_Click;
            // 
            // cubeBtn
            // 
            cubeBtn.BackColor = Color.Gray;
            cubeBtn.Cursor = Cursors.Hand;
            cubeBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            cubeBtn.ForeColor = SystemColors.ButtonHighlight;
            cubeBtn.Location = new Point(513, 223);
            cubeBtn.Name = "cubeBtn";
            cubeBtn.Size = new Size(95, 75);
            cubeBtn.TabIndex = 39;
            cubeBtn.Text = "x^3";
            cubeBtn.UseVisualStyleBackColor = false;
            cubeBtn.Click += cubeBtn_Click;
            // 
            // logBtn
            // 
            logBtn.BackColor = Color.Gray;
            logBtn.Cursor = Cursors.Hand;
            logBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            logBtn.ForeColor = SystemColors.ButtonHighlight;
            logBtn.Location = new Point(813, 304);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(95, 75);
            logBtn.TabIndex = 38;
            logBtn.Text = "log";
            logBtn.UseVisualStyleBackColor = false;
            logBtn.Click += logBtn_Click;
            // 
            // factorialBtn
            // 
            factorialBtn.BackColor = Color.Gray;
            factorialBtn.Cursor = Cursors.Hand;
            factorialBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            factorialBtn.ForeColor = SystemColors.ButtonHighlight;
            factorialBtn.Location = new Point(614, 465);
            factorialBtn.Name = "factorialBtn";
            factorialBtn.Size = new Size(95, 75);
            factorialBtn.TabIndex = 37;
            factorialBtn.Text = "n!";
            factorialBtn.UseVisualStyleBackColor = false;
            factorialBtn.Click += factorialBtn_Click;
            // 
            // button33
            // 
            button33.BackColor = Color.Gray;
            button33.Cursor = Cursors.Hand;
            button33.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button33.ForeColor = SystemColors.ButtonHighlight;
            button33.Location = new Point(614, 142);
            button33.Name = "button33";
            button33.Size = new Size(95, 75);
            button33.TabIndex = 36;
            button33.Text = "Mod";
            button33.UseVisualStyleBackColor = false;
            button33.Click += button33_Click;
            // 
            // hexBtn
            // 
            hexBtn.BackColor = Color.Gray;
            hexBtn.Cursor = Cursors.Hand;
            hexBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            hexBtn.ForeColor = SystemColors.ButtonHighlight;
            hexBtn.Location = new Point(715, 385);
            hexBtn.Name = "hexBtn";
            hexBtn.Size = new Size(95, 75);
            hexBtn.TabIndex = 35;
            hexBtn.Text = "Hex";
            hexBtn.UseVisualStyleBackColor = false;
            hexBtn.Click += hexBtn_Click;
            // 
            // octBtn
            // 
            octBtn.BackColor = Color.Gray;
            octBtn.Cursor = Cursors.Hand;
            octBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            octBtn.ForeColor = SystemColors.ButtonHighlight;
            octBtn.Location = new Point(813, 385);
            octBtn.Name = "octBtn";
            octBtn.Size = new Size(95, 75);
            octBtn.TabIndex = 34;
            octBtn.Text = "Oct";
            octBtn.UseVisualStyleBackColor = false;
            octBtn.Click += octBtn_Click;
            // 
            // button36
            // 
            button36.BackColor = Color.Gray;
            button36.Cursor = Cursors.Hand;
            button36.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button36.ForeColor = SystemColors.ButtonHighlight;
            button36.Location = new Point(614, 223);
            button36.Name = "button36";
            button36.Size = new Size(95, 75);
            button36.TabIndex = 33;
            button36.Text = "x^1/3";
            button36.UseVisualStyleBackColor = false;
            button36.Click += button36_Click;
            // 
            // expBtn
            // 
            expBtn.BackColor = Color.Gray;
            expBtn.Cursor = Cursors.Hand;
            expBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            expBtn.ForeColor = SystemColors.ButtonHighlight;
            expBtn.Location = new Point(813, 223);
            expBtn.Name = "expBtn";
            expBtn.Size = new Size(95, 75);
            expBtn.TabIndex = 32;
            expBtn.Text = "e^x";
            expBtn.UseVisualStyleBackColor = false;
            expBtn.Click += expBtn_Click;
            // 
            // piBtn
            // 
            piBtn.BackColor = Color.Gray;
            piBtn.Cursor = Cursors.Hand;
            piBtn.Font = new Font("Cascadia Code SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            piBtn.ForeColor = SystemColors.ButtonHighlight;
            piBtn.Location = new Point(715, 465);
            piBtn.Name = "piBtn";
            piBtn.Size = new Size(95, 75);
            piBtn.TabIndex = 31;
            piBtn.Text = "π\r\n";
            piBtn.UseVisualStyleBackColor = false;
            piBtn.Click += piBtn_Click;
            // 
            // sinBtn
            // 
            sinBtn.BackColor = Color.Gray;
            sinBtn.Cursor = Cursors.Hand;
            sinBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            sinBtn.ForeColor = SystemColors.ButtonHighlight;
            sinBtn.Location = new Point(513, 304);
            sinBtn.Name = "sinBtn";
            sinBtn.Size = new Size(95, 75);
            sinBtn.TabIndex = 30;
            sinBtn.Text = "sin";
            sinBtn.UseVisualStyleBackColor = false;
            sinBtn.Click += sinBtn_Click;
            // 
            // cosBtn
            // 
            cosBtn.BackColor = Color.Gray;
            cosBtn.Cursor = Cursors.Hand;
            cosBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            cosBtn.ForeColor = SystemColors.ButtonHighlight;
            cosBtn.Location = new Point(614, 304);
            cosBtn.Name = "cosBtn";
            cosBtn.Size = new Size(95, 75);
            cosBtn.TabIndex = 29;
            cosBtn.Text = "cos";
            cosBtn.UseVisualStyleBackColor = false;
            cosBtn.Click += cosBtn_Click;
            // 
            // tanBtn
            // 
            tanBtn.BackColor = Color.Gray;
            tanBtn.Cursor = Cursors.Hand;
            tanBtn.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            tanBtn.ForeColor = SystemColors.ButtonHighlight;
            tanBtn.Location = new Point(715, 304);
            tanBtn.Name = "tanBtn";
            tanBtn.Size = new Size(95, 75);
            tanBtn.TabIndex = 28;
            tanBtn.Text = "tan";
            tanBtn.UseVisualStyleBackColor = false;
            tanBtn.Click += tanBtn_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Gray;
            button12.Cursor = Cursors.Hand;
            button12.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Location = new Point(813, 465);
            button12.Name = "button12";
            button12.Size = new Size(95, 75);
            button12.TabIndex = 47;
            button12.Text = "%";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // num5
            // 
            num5.BackColor = Color.Gray;
            num5.Cursor = Cursors.Hand;
            num5.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num5.ForeColor = SystemColors.ButtonHighlight;
            num5.Location = new Point(130, 304);
            num5.Name = "num5";
            num5.Size = new Size(105, 75);
            num5.TabIndex = 48;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = false;
            num5.Click += num5_Click;
            num5.StyleChanged += num1_Click;
            // 
            // num6
            // 
            num6.BackColor = Color.Gray;
            num6.Cursor = Cursors.Hand;
            num6.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            num6.ForeColor = SystemColors.ButtonHighlight;
            num6.Location = new Point(240, 304);
            num6.Name = "num6";
            num6.Size = new Size(105, 75);
            num6.TabIndex = 49;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = false;
            num6.Click += num6_Click;
            num6.StyleChanged += num1_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(930, 560);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(button12);
            Controls.Add(lnBtn);
            Controls.Add(powerBtn);
            Controls.Add(binBtn);
            Controls.Add(decimalBtn);
            Controls.Add(button27);
            Controls.Add(button28);
            Controls.Add(button29);
            Controls.Add(cubeBtn);
            Controls.Add(logBtn);
            Controls.Add(factorialBtn);
            Controls.Add(button33);
            Controls.Add(hexBtn);
            Controls.Add(octBtn);
            Controls.Add(button36);
            Controls.Add(expBtn);
            Controls.Add(piBtn);
            Controls.Add(sinBtn);
            Controls.Add(cosBtn);
            Controls.Add(tanBtn);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num1);
            Controls.Add(num2);
            Controls.Add(percentageBtn);
            Controls.Add(clearBtn);
            Controls.Add(divideBtn);
            Controls.Add(addBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(subtractBtn);
            Controls.Add(delBtn);
            Controls.Add(dotBtn);
            Controls.Add(equalBtn);
            Controls.Add(num0);
            Controls.Add(num7);
            Controls.Add(num8);
            Controls.Add(num9);
            Controls.Add(TxtBox);
            Name = "calculator";
            Text = "Form1";
            Load += calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button delBtn;
        private Button dotBtn;
        private Button equalBtn;
        private Button num0;
        private Button multiplyBtn;
        private Button subtractBtn;
        private Button divideBtn;
        private Button addBtn;
        private Button clearBtn;
        private Button num4;
        private Button num3;
        private Button num1;
        private Button num2;
        private Button percentageBtn;
        private Button lnBtn;
        private Button powerBtn;
        private Button binBtn;
        private Button decimalBtn;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button cubeBtn;
        private Button logBtn;
        private Button factorialBtn;
        private Button button33;
        private Button hexBtn;
        private Button octBtn;
        private Button button36;
        private Button expBtn;
        private Button piBtn;
        private Button sinBtn;
        private Button cosBtn;
        private Button tanBtn;
        private Button button12;
        private Button num5;
        private Button num6;
    }
}
