using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] gameType = { "剪刀","石頭","布" };
        int[] gameState = {0,0,0};

        private void cut_Click(object sender, EventArgs e)
        {
            updateGame(0);
        }

        private void stone_Click(object sender, EventArgs e)
        {
            updateGame(1);
        }

        private void paper_Click(object sender, EventArgs e)
        {
            updateGame(2);
        }

        void updateGame(int user)
        {
            Random random = new Random();
            int npc = random.Next(gameType.Length);
            // --type
            // 0 -> 剪刀
            // 1 -> 石頭
            // 2 -> 布
            // --state
            // 0 -> safe
            // 1 -> win
            // 2 -> lose
            userShow.Text = gameType[user];
            npcShow.Text = gameType[npc];
            int currentState = 0;
            if(npc == user)
            {
                currentState = 0;
            }
            else
            {
                switch (npc)
                {
                    case 0:
                        currentState = user == 1 ? 1 : 2;
                        break;
                    case 1:
                        currentState = user == 0 ? 2 : 1;
                        break;
                    case 2:
                        currentState = user == 1 ? 2 : 1;
                        break;
                }
            }
            gameState[currentState]++;
            winloseStateShow.Text = currentState == 0 ? "平手" : currentState == 1 ? "勝" : "負";
            countShow.Text = $"你贏了{gameState[1]}次 電腦贏了{gameState[2]}次 平手{gameState[0]}次";
        }

        private void resetGame_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < gameState.Length;i++)
            {
                gameState[i] = 0;
            }
            winloseStateShow.Text = "勝負";
            countShow.Text = string.Empty;
            npcShow.Text = string.Empty;
            userShow.Text = string.Empty;
        }
    }
}