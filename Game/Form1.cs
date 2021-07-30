using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Models.Heroes;
using Game.Models.Enemies;
using Game.Models.Items;


namespace Game
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChooseHero();
        }

        public int buttonPressed;

        private void button1_Click(object sender, EventArgs e)                    
        {
            buttonPressed = 1;
            label1.Text = "Hero FIRST!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonPressed = 2;
            label1.Text = "Hero SECOND!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonPressed = 3;
            label1.Text = "Hero THIRD!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        Hero mainhero = new("BASIC", 50, 1, 5, 1, 0);

        public void ChooseHero()
        {
            switch (buttonPressed)
            {
                case 1:
                    {
                        mainhero = new("Billy", 100, 1, 10, 1, 10);
                        break;
                    }
                case 2:
                    {
                        mainhero = new("Van", 110, 1.2, 5, 0.9, 0);
                        break;
                    }
                case 3:
                    {
                        mainhero = new("Grommash Hellscream", 90, 0.9, 10, 1.2, 15);
                        break;
                    }
            }
        }

        public static Enemy RandomEnemy()
        {
            Enemy enemy1 = new Enemy("\"rat\"", 10, 3, 0);
            Enemy enemy2 = new Enemy("\"poisoned rat\"", 15, 5, 1);
            Enemy enemy3 = new Enemy("\"goblin\"", 50, 10, 0);

            Enemy[] enemyArray = { enemy1, enemy2, enemy3 };

            Random random = new();
            Enemy target = enemyArray[random.Next(0, enemyArray.Length)];

            return target;
        }

        public int enemiesCount = 0;
        
        public void OneBattle()
        {
            Enemy target = RandomEnemy();
            label2.Text += $"\nThe enemy {target.Name} gonna fight with you!";

            while (target.HP > 0)
            {
                mainhero.Attack(target);
                label2.Text += $"\n{mainhero.Name} attacked {target.Name} on {mainhero.Damage} HP. ";

                if (target.HP <= 0)
                {
                    label2.Text += "Enemy has died.\n";
                    enemiesCount++;
                    break;
                }

                if (target.HP > 0)
                {
                    label2.Text += $"Enemy's left HP = {target.HP}";
                    target.Attack(mainhero);
                    label2.Text += $"\nEnemy {target.Name} attacked you on {target.Damage} HP.";

                    if (mainhero.HP <= 0)
                    {
                        mainhero.HP = 0;
                        label2.Text += $"{mainhero.Name}'s left HP = {mainhero.HP}. {mainhero.Name} died.\n";
                        break;
                    }

                    label2.Text += $"{mainhero.Name}'s left HP = {mainhero.HP}\n";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChooseHero();

            label1.Text = "Game began!";
            label2.Text += "\n";

            while (mainhero.HP > 0)
            {
                OneBattle();
            }

            label2.Text += $"\nGame over! In your adventure you killed {enemiesCount} enemies.";
        }
    }
}
