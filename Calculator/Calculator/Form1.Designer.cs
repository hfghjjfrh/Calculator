namespace Calculator
{
    partial class calcform
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calcform));
            this.ac = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.wari = new System.Windows.Forms.Button();
            this.kake = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.電卓の終了EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小数点以下の設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桁ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.桁ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.桁ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.色設定CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ダークDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ホワイトWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ブルーBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.度ラジアン切り替えToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ラジアンradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.電卓についてHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siso = new System.Windows.Forms.Label();
            this.squared = new System.Windows.Forms.Button();
            this.gya = new System.Windows.Forms.Button();
            this.par = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.log10 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.syousu = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ac.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ac.Location = new System.Drawing.Point(12, 273);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(70, 156);
            this.ac.TabIndex = 0;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = false;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.c.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c.Location = new System.Drawing.Point(12, 191);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(70, 69);
            this.c.TabIndex = 1;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.seven.Location = new System.Drawing.Point(88, 104);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(70, 70);
            this.seven.TabIndex = 7;
            this.seven.Tag = "number";
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.four.Location = new System.Drawing.Point(88, 190);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(70, 70);
            this.four.TabIndex = 6;
            this.four.Tag = "number";
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.one.Location = new System.Drawing.Point(88, 273);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(70, 70);
            this.one.TabIndex = 5;
            this.one.Tag = "number";
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.zero.Location = new System.Drawing.Point(88, 359);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(70, 70);
            this.zero.TabIndex = 4;
            this.zero.Tag = "number";
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.eight.Location = new System.Drawing.Point(164, 104);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(70, 70);
            this.eight.TabIndex = 11;
            this.eight.Tag = "number";
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.five.Location = new System.Drawing.Point(164, 190);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(70, 70);
            this.five.TabIndex = 10;
            this.five.Tag = "number";
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.two.Location = new System.Drawing.Point(164, 273);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(70, 70);
            this.two.TabIndex = 9;
            this.two.Tag = "number";
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dot.Location = new System.Drawing.Point(164, 359);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(70, 70);
            this.dot.TabIndex = 8;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nine.Location = new System.Drawing.Point(240, 104);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(70, 70);
            this.nine.TabIndex = 15;
            this.nine.Tag = "number";
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.six.Location = new System.Drawing.Point(240, 190);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(70, 70);
            this.six.TabIndex = 14;
            this.six.Tag = "number";
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.three.Location = new System.Drawing.Point(240, 273);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(70, 70);
            this.three.TabIndex = 13;
            this.three.Tag = "number";
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.equal.Location = new System.Drawing.Point(240, 359);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(70, 70);
            this.equal.TabIndex = 12;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // wari
            // 
            this.wari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.wari.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.wari.Location = new System.Drawing.Point(316, 104);
            this.wari.Name = "wari";
            this.wari.Size = new System.Drawing.Size(70, 70);
            this.wari.TabIndex = 19;
            this.wari.Text = "÷";
            this.wari.UseVisualStyleBackColor = false;
            this.wari.Click += new System.EventHandler(this.wari_Click);
            // 
            // kake
            // 
            this.kake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kake.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kake.Location = new System.Drawing.Point(316, 190);
            this.kake.Name = "kake";
            this.kake.Size = new System.Drawing.Size(70, 70);
            this.kake.TabIndex = 18;
            this.kake.Text = "×";
            this.kake.UseVisualStyleBackColor = false;
            this.kake.Click += new System.EventHandler(this.kake_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.minus.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minus.Location = new System.Drawing.Point(316, 273);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(70, 70);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plus.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plus.Location = new System.Drawing.Point(316, 359);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(70, 70);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.White;
            this.display.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.display.Location = new System.Drawing.Point(0, 28);
            this.display.MaxLength = 13;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(462, 71);
            this.display.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.設定SToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.電卓の終了EToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 電卓の終了EToolStripMenuItem
            // 
            this.電卓の終了EToolStripMenuItem.Name = "電卓の終了EToolStripMenuItem";
            this.電卓の終了EToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.電卓の終了EToolStripMenuItem.Text = "電卓の終了(&E)";
            this.電卓の終了EToolStripMenuItem.Click += new System.EventHandler(this.電卓の終了EToolStripMenuItem_Click);
            // 
            // 設定SToolStripMenuItem
            // 
            this.設定SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.小数点以下の設定ToolStripMenuItem,
            this.色設定CToolStripMenuItem,
            this.度ラジアン切り替えToolStripMenuItem});
            this.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
            this.設定SToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.設定SToolStripMenuItem.Text = "設定(&S)";
            // 
            // 小数点以下の設定ToolStripMenuItem
            // 
            this.小数点以下の設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.桁ToolStripMenuItem,
            this.桁ToolStripMenuItem1,
            this.桁ToolStripMenuItem2,
            this.桁ToolStripMenuItem3});
            this.小数点以下の設定ToolStripMenuItem.Name = "小数点以下の設定ToolStripMenuItem";
            this.小数点以下の設定ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.小数点以下の設定ToolStripMenuItem.Text = "小数点設定(&S)";
            this.小数点以下の設定ToolStripMenuItem.Click += new System.EventHandler(this.小数点以下の設定ToolStripMenuItem_Click);
            // 
            // 桁ToolStripMenuItem
            // 
            this.桁ToolStripMenuItem.Name = "桁ToolStripMenuItem";
            this.桁ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.桁ToolStripMenuItem.Tag = "keta";
            this.桁ToolStripMenuItem.Text = "1桁";
            this.桁ToolStripMenuItem.Click += new System.EventHandler(this.桁ToolStripMenuItem_Click);
            // 
            // 桁ToolStripMenuItem1
            // 
            this.桁ToolStripMenuItem1.Name = "桁ToolStripMenuItem1";
            this.桁ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.桁ToolStripMenuItem1.Tag = "keta";
            this.桁ToolStripMenuItem1.Text = "2桁";
            this.桁ToolStripMenuItem1.Click += new System.EventHandler(this.桁ToolStripMenuItem1_Click);
            // 
            // 桁ToolStripMenuItem2
            // 
            this.桁ToolStripMenuItem2.Name = "桁ToolStripMenuItem2";
            this.桁ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.桁ToolStripMenuItem2.Tag = "keta";
            this.桁ToolStripMenuItem2.Text = "3桁";
            this.桁ToolStripMenuItem2.Click += new System.EventHandler(this.桁ToolStripMenuItem2_Click);
            // 
            // 桁ToolStripMenuItem3
            // 
            this.桁ToolStripMenuItem3.Name = "桁ToolStripMenuItem3";
            this.桁ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.桁ToolStripMenuItem3.Tag = "keta";
            this.桁ToolStripMenuItem3.Text = "4桁";
            this.桁ToolStripMenuItem3.Click += new System.EventHandler(this.桁ToolStripMenuItem3_Click);
            // 
            // 色設定CToolStripMenuItem
            // 
            this.色設定CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ダークDToolStripMenuItem,
            this.ホワイトWToolStripMenuItem,
            this.ブルーBToolStripMenuItem});
            this.色設定CToolStripMenuItem.Name = "色設定CToolStripMenuItem";
            this.色設定CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.色設定CToolStripMenuItem.Text = "デザイン設定(&C)";
            // 
            // ダークDToolStripMenuItem
            // 
            this.ダークDToolStripMenuItem.Name = "ダークDToolStripMenuItem";
            this.ダークDToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ダークDToolStripMenuItem.Text = "ダーク(&D)";
            this.ダークDToolStripMenuItem.Click += new System.EventHandler(this.ダークDToolStripMenuItem_Click);
            // 
            // ホワイトWToolStripMenuItem
            // 
            this.ホワイトWToolStripMenuItem.Name = "ホワイトWToolStripMenuItem";
            this.ホワイトWToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ホワイトWToolStripMenuItem.Text = "ホワイト(&W)";
            this.ホワイトWToolStripMenuItem.Click += new System.EventHandler(this.ホワイトWToolStripMenuItem_Click);
            // 
            // ブルーBToolStripMenuItem
            // 
            this.ブルーBToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ブルーBToolStripMenuItem.Name = "ブルーBToolStripMenuItem";
            this.ブルーBToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ブルーBToolStripMenuItem.Text = "ブルー(&B)";
            this.ブルーBToolStripMenuItem.Click += new System.EventHandler(this.ブルーBToolStripMenuItem_Click);
            // 
            // 度ラジアン切り替えToolStripMenuItem
            // 
            this.度ラジアン切り替えToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.度ToolStripMenuItem,
            this.ラジアンradToolStripMenuItem});
            this.度ラジアン切り替えToolStripMenuItem.Name = "度ラジアン切り替えToolStripMenuItem";
            this.度ラジアン切り替えToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.度ラジアン切り替えToolStripMenuItem.Text = "度・ラジアン切り替え";
            // 
            // 度ToolStripMenuItem
            // 
            this.度ToolStripMenuItem.Name = "度ToolStripMenuItem";
            this.度ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.度ToolStripMenuItem.Text = "度(°)";
            this.度ToolStripMenuItem.Click += new System.EventHandler(this.度ToolStripMenuItem_Click);
            // 
            // ラジアンradToolStripMenuItem
            // 
            this.ラジアンradToolStripMenuItem.Name = "ラジアンradToolStripMenuItem";
            this.ラジアンradToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ラジアンradToolStripMenuItem.Text = "ラジアン(rad)";
            this.ラジアンradToolStripMenuItem.Click += new System.EventHandler(this.ラジアンradToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.電卓についてHToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // 電卓についてHToolStripMenuItem
            // 
            this.電卓についてHToolStripMenuItem.Name = "電卓についてHToolStripMenuItem";
            this.電卓についてHToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.電卓についてHToolStripMenuItem.Text = "電卓について(&A)";
            this.電卓についてHToolStripMenuItem.Click += new System.EventHandler(this.電卓についてHToolStripMenuItem_Click);
            // 
            // siso
            // 
            this.siso.AutoSize = true;
            this.siso.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.siso.Location = new System.Drawing.Point(478, 36);
            this.siso.Name = "siso";
            this.siso.Size = new System.Drawing.Size(0, 33);
            this.siso.TabIndex = 26;
            // 
            // squared
            // 
            this.squared.BackColor = System.Drawing.Color.Silver;
            this.squared.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.squared.Location = new System.Drawing.Point(392, 104);
            this.squared.Name = "squared";
            this.squared.Size = new System.Drawing.Size(70, 70);
            this.squared.TabIndex = 30;
            this.squared.Text = "X^Y";
            this.squared.UseVisualStyleBackColor = false;
            this.squared.Click += new System.EventHandler(this.squared_Click);
            // 
            // gya
            // 
            this.gya.BackColor = System.Drawing.Color.Silver;
            this.gya.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gya.Location = new System.Drawing.Point(392, 190);
            this.gya.Name = "gya";
            this.gya.Size = new System.Drawing.Size(70, 70);
            this.gya.TabIndex = 29;
            this.gya.Text = "1/x";
            this.gya.UseVisualStyleBackColor = false;
            this.gya.Click += new System.EventHandler(this.gya_Click);
            // 
            // par
            // 
            this.par.BackColor = System.Drawing.Color.Silver;
            this.par.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.par.Location = new System.Drawing.Point(392, 273);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(70, 70);
            this.par.TabIndex = 28;
            this.par.Text = "%";
            this.par.UseVisualStyleBackColor = false;
            this.par.Click += new System.EventHandler(this.par_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.Color.Silver;
            this.sqrt.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sqrt.Location = new System.Drawing.Point(392, 359);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(70, 70);
            this.sqrt.TabIndex = 27;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.Silver;
            this.sin.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sin.Location = new System.Drawing.Point(472, 105);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(70, 70);
            this.sin.TabIndex = 34;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.Color.Silver;
            this.cos.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cos.Location = new System.Drawing.Point(472, 191);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(70, 70);
            this.cos.TabIndex = 33;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // tan
            // 
            this.tan.BackColor = System.Drawing.Color.Silver;
            this.tan.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tan.Location = new System.Drawing.Point(472, 274);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(70, 70);
            this.tan.TabIndex = 32;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = false;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // log10
            // 
            this.log10.BackColor = System.Drawing.Color.Silver;
            this.log10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.log10.Location = new System.Drawing.Point(472, 360);
            this.log10.Name = "log10";
            this.log10.Size = new System.Drawing.Size(70, 70);
            this.log10.TabIndex = 31;
            this.log10.Text = "log10";
            this.log10.UseVisualStyleBackColor = false;
            this.log10.Click += new System.EventHandler(this.log10_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.back.Location = new System.Drawing.Point(12, 105);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 70);
            this.back.TabIndex = 35;
            this.back.Tag = "number";
            this.back.Text = "Del";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // syousu
            // 
            this.syousu.AutoSize = true;
            this.syousu.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.syousu.Location = new System.Drawing.Point(343, 6);
            this.syousu.Name = "syousu";
            this.syousu.Size = new System.Drawing.Size(99, 18);
            this.syousu.TabIndex = 36;
            this.syousu.Text = "小数点以下：2桁";
            // 
            // calcform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 441);
            this.Controls.Add(this.syousu);
            this.Controls.Add(this.back);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.log10);
            this.Controls.Add(this.squared);
            this.Controls.Add(this.gya);
            this.Controls.Add(this.par);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.siso);
            this.Controls.Add(this.display);
            this.Controls.Add(this.wari);
            this.Controls.Add(this.kake);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.six);
            this.Controls.Add(this.three);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.five);
            this.Controls.Add(this.two);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.c);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 400);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 480);
            this.MinimumSize = new System.Drawing.Size(570, 480);
            this.Name = "calcform";
            this.Tag = "number";
            this.Text = "電卓";
            this.Load += new System.EventHandler(this.calcform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button wari;
        private System.Windows.Forms.Button kake;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 電卓の終了EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 電卓についてHToolStripMenuItem;
        private System.Windows.Forms.Label siso;
        private System.Windows.Forms.ToolStripMenuItem 設定SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小数点以下の設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色設定CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ダークDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ホワイトWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桁ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 桁ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 桁ToolStripMenuItem3;
        private System.Windows.Forms.Button squared;
        private System.Windows.Forms.Button gya;
        private System.Windows.Forms.Button par;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button log10;
        private System.Windows.Forms.ToolStripMenuItem 度ラジアン切り替えToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ラジアンradToolStripMenuItem;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ToolStripMenuItem ブルーBToolStripMenuItem;
        private System.Windows.Forms.Label syousu;
    }
}

