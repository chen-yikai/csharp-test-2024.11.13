namespace _2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.cut = new System.Windows.Forms.Button();
            this.stone = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.winloseStateShow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetGame = new System.Windows.Forms.Button();
            this.userShow = new System.Windows.Forms.Label();
            this.npcShow = new System.Windows.Forms.Label();
            this.countShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.Location = new System.Drawing.Point(224, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(98, 21);
            this.title.TabIndex = 0;
            this.title.Text = "猜拳遊戲";
            // 
            // cut
            // 
            this.cut.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cut.Location = new System.Drawing.Point(84, 85);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(87, 49);
            this.cut.TabIndex = 1;
            this.cut.Text = "剪刀";
            this.cut.UseVisualStyleBackColor = true;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // stone
            // 
            this.stone.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stone.Location = new System.Drawing.Point(231, 85);
            this.stone.Name = "stone";
            this.stone.Size = new System.Drawing.Size(87, 49);
            this.stone.TabIndex = 2;
            this.stone.Text = "石頭";
            this.stone.UseVisualStyleBackColor = true;
            this.stone.Click += new System.EventHandler(this.stone_Click);
            // 
            // paper
            // 
            this.paper.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.paper.Location = new System.Drawing.Point(372, 85);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(87, 49);
            this.paper.TabIndex = 3;
            this.paper.Text = "布";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // winloseStateShow
            // 
            this.winloseStateShow.AutoSize = true;
            this.winloseStateShow.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.winloseStateShow.Location = new System.Drawing.Point(33, 225);
            this.winloseStateShow.Name = "winloseStateShow";
            this.winloseStateShow.Size = new System.Drawing.Size(60, 24);
            this.winloseStateShow.TabIndex = 4;
            this.winloseStateShow.Text = "勝負";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(127, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "玩家出了:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(127, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "電腦出了:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(127, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "勝負統計:";
            // 
            // resetGame
            // 
            this.resetGame.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resetGame.Location = new System.Drawing.Point(459, 337);
            this.resetGame.Name = "resetGame";
            this.resetGame.Size = new System.Drawing.Size(71, 38);
            this.resetGame.TabIndex = 8;
            this.resetGame.Text = "重猜";
            this.resetGame.UseVisualStyleBackColor = true;
            this.resetGame.Click += new System.EventHandler(this.resetGame_Click);
            // 
            // userShow
            // 
            this.userShow.AutoSize = true;
            this.userShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userShow.Location = new System.Drawing.Point(214, 191);
            this.userShow.Name = "userShow";
            this.userShow.Size = new System.Drawing.Size(0, 16);
            this.userShow.TabIndex = 9;
            // 
            // npcShow
            // 
            this.npcShow.AutoSize = true;
            this.npcShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.npcShow.Location = new System.Drawing.Point(214, 233);
            this.npcShow.Name = "npcShow";
            this.npcShow.Size = new System.Drawing.Size(0, 16);
            this.npcShow.TabIndex = 10;
            // 
            // countShow
            // 
            this.countShow.AutoSize = true;
            this.countShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countShow.Location = new System.Drawing.Point(214, 288);
            this.countShow.Name = "countShow";
            this.countShow.Size = new System.Drawing.Size(0, 16);
            this.countShow.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 387);
            this.Controls.Add(this.countShow);
            this.Controls.Add(this.npcShow);
            this.Controls.Add(this.userShow);
            this.Controls.Add(this.resetGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winloseStateShow);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.stone);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Button stone;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Label winloseStateShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetGame;
        private System.Windows.Forms.Label userShow;
        private System.Windows.Forms.Label npcShow;
        private System.Windows.Forms.Label countShow;
    }
}

