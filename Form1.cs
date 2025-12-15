using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NA_Fortnite_projekt
{
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        public static List<Player> players = new List<Player>();
        public static List<Weapon> weapons = new List<Weapon>();
        public static List<string> cosmetics = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string namesBe = File.ReadAllText("names.txt", Encoding.UTF8);
            string weaponBe = File.ReadAllText("weapons.txt", Encoding.UTF8);
            string cosmeticsBe = File.ReadAllText("items.txt", Encoding.UTF8);
            List<string> nevek = new List<string>();
            foreach (var item in namesBe.Split(','))
            {
                nevek.Add(item);
            }
            foreach (var item in cosmeticsBe.Split(','))
            {
                cosmetics.Add(item);
            }
            foreach (var item in weaponBe.Split(';'))
            {
                weapons.Add(new Weapon(item));
            }
            for (int i = 0; i < 8; i++)
            {
                players.Add(new Player(nevek[rnd.Next(0, nevek.Count)]));
                for (int j = 0; j < 3; j++)
                {
                    players[i].cosmetics.Add(cosmetics[rnd.Next(0, cosmetics.Count)]);
                }
                for (int k = 0; k < 5; k++)
                {
                    players[i].weapons.Add(weapons[rnd.Next(0, weapons.Count)]);
                }
            }
            
            button1.Text = $"{players[0].Name}";
            button2.Text = $"{players[1].Name}";
            button3.Text = $"{players[2].Name}";
            button4.Text = $"{players[3].Name}";
            button5.Text = $"{players[4].Name}";
            button6.Text = $"{players[5].Name}";
            button7.Text = $"{players[6].Name}";
            button8.Text = $"{players[7].Name}";

            
        }

        
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_ammo_1.Text = "";
            lbl_ammo_2.Text = "";
            lbl_ammo_3.Text = "";
            lbl_ammo_4.Text = "";
            lbl_ammo_5.Text = "";


            rtb_items.Clear();

            lbl_Name.Text = $"{players[0].Name}";
            lbl_Level.Text = $"{players[0].Level}";
            lbl_HP.Text = $"{players[0].HP}";
            lbl_Shield.Text = $"{players[0].Shield}";
            foreach (var item in players[0].weapons)
            {
                rtb_items.Text += $"{item.Name}\n";
            }
            foreach (var item in players[0].cosmetics)
            {
                rtb_items.Text += $"{item}\n";
            }
            pb_item_1.Image = Image.FromFile($"{players[0].weapons[0].Name}.jpg");
            pb_item_2.Image = Image.FromFile($"{players[0].weapons[1].Name}.jpg");
            pb_item_3.Image = Image.FromFile($"{players[0].weapons[2].Name}.jpg");
            pb_item_4.Image = Image.FromFile($"{players[0].weapons[3].Name}.jpg");
            pb_item_5.Image = Image.FromFile($"{players[0].weapons[4].Name}.jpg");

            lbl_ammo_1.Text += $"{players[0].weapons[0].CurrentAmmo}/{players[0].weapons[0].MagazineSize}";
            lbl_ammo_2.Text += $"{players[0].weapons[1].CurrentAmmo}/{players[0].weapons[1].MagazineSize}";
            lbl_ammo_3.Text += $"{players[0].weapons[2].CurrentAmmo}/{players[0].weapons[2].MagazineSize}";
            lbl_ammo_4.Text += $"{players[0].weapons[3].CurrentAmmo}/{players[0].weapons[3].MagazineSize}";
            lbl_ammo_5.Text += $"{players[0].weapons[4].CurrentAmmo}/{players[0].weapons[4].MagazineSize}";

            lbl_item1.Text = players[0].cosmetics[0];
            lbl_item2.Text = players[0].cosmetics[1];
            lbl_item3.Text = players[0].cosmetics[2];
            pb_cosmetic1.Image = Image.FromFile($"{players[0].cosmetics[0]}.png");
            pb_cosmetic2.Image = Image.FromFile($"{players[0].cosmetics[1]}.png");
            pb_cosmetic3.Image = Image.FromFile($"{players[0].cosmetics[2]}.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_ammo_1.Text = "";
            lbl_ammo_2.Text = "";
            lbl_ammo_3.Text = "";
            lbl_ammo_4.Text = "";
            lbl_ammo_5.Text = "";


            rtb_items.Clear();

            lbl_Name.Text = $"{players[1].Name}";
            lbl_Level.Text = $"{players[1].Level}";
            lbl_HP.Text = $"{players[1].HP}";
            lbl_Shield.Text = $"{players[1].Shield}";
            foreach (var item in players[1].weapons)
            {
                rtb_items.Text += $"{item.Name}\n";
            }
            foreach (var item in players[1].cosmetics)
            {
                rtb_items.Text += $"{item}\n";
            }
            pb_item_1.Image = Image.FromFile($"{players[1].weapons[0].Name}.jpg");
            pb_item_2.Image = Image.FromFile($"{players[1].weapons[1].Name}.jpg");
            pb_item_3.Image = Image.FromFile($"{players[1].weapons[2].Name}.jpg");
            pb_item_4.Image = Image.FromFile($"{players[1].weapons[3].Name}.jpg");
            pb_item_5.Image = Image.FromFile($"{players[1].weapons[4].Name}.jpg");

            lbl_ammo_1.Text += $"{players[1].weapons[0].CurrentAmmo}/{players[1].weapons[0].MagazineSize}";
            lbl_ammo_2.Text += $"{players[1].weapons[1].CurrentAmmo}/{players[1].weapons[1].MagazineSize}";
            lbl_ammo_3.Text += $"{players[1].weapons[2].CurrentAmmo}/{players[1].weapons[2].MagazineSize}";
            lbl_ammo_4.Text += $"{players[1].weapons[3].CurrentAmmo}/{players[1].weapons[3].MagazineSize}";
            lbl_ammo_5.Text += $"{players[1].weapons[4].CurrentAmmo}/{players[1].weapons[4].MagazineSize}";

            lbl_item1.Text = players[1].cosmetics[0];
            lbl_item2.Text = players[1].cosmetics[1];
            lbl_item3.Text = players[1].cosmetics[2];
            pb_cosmetic1.Image = Image.FromFile($"{players[1].cosmetics[0]}.png");
            pb_cosmetic2.Image = Image.FromFile($"{players[1].cosmetics[1]}.png");
            pb_cosmetic3.Image = Image.FromFile($"{players[1].cosmetics[2]}.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_ammo_1.Text = "";
            lbl_ammo_2.Text = "";
            lbl_ammo_3.Text = "";
            lbl_ammo_4.Text = "";
            lbl_ammo_5.Text = "";


            rtb_items.Clear();

            lbl_Name.Text = $"{players[2].Name}";
            lbl_Level.Text = $"{players[2].Level}";
            lbl_HP.Text = $"{players[2].HP}";
            lbl_Shield.Text = $"{players[2].Shield}";
            foreach (var item in players[2].weapons)
            {
                rtb_items.Text += $"{item.Name}\n";
            }
            foreach (var item in players[2].cosmetics)
            {
                rtb_items.Text += $"{item}\n";
            }
            pb_item_1.Image = Image.FromFile($"{players[2].weapons[0].Name}.jpg");
            pb_item_2.Image = Image.FromFile($"{players[2].weapons[1].Name}.jpg");
            pb_item_3.Image = Image.FromFile($"{players[2].weapons[2].Name}.jpg");
            pb_item_4.Image = Image.FromFile($"{players[2].weapons[3].Name}.jpg");
            pb_item_5.Image = Image.FromFile($"{players[2].weapons[4].Name}.jpg");

            lbl_ammo_1.Text += $"{players[2].weapons[0].CurrentAmmo}/{players[2].weapons[0].MagazineSize}";
            lbl_ammo_2.Text += $"{players[2].weapons[1].CurrentAmmo}/{players[2].weapons[1].MagazineSize}";
            lbl_ammo_3.Text += $"{players[2].weapons[2].CurrentAmmo}/{players[2].weapons[2].MagazineSize}";
            lbl_ammo_4.Text += $"{players[2].weapons[3].CurrentAmmo}/{players[2].weapons[3].MagazineSize}";
            lbl_ammo_5.Text += $"{players[2].weapons[4].CurrentAmmo}/{players[2].weapons[4].MagazineSize}";

            lbl_item1.Text = players[2].cosmetics[0];
            lbl_item2.Text = players[2].cosmetics[1];
            lbl_item3.Text = players[2].cosmetics[2];
            pb_cosmetic1.Image = Image.FromFile($"{players[2].cosmetics[0]}.png");
            pb_cosmetic2.Image = Image.FromFile($"{players[2].cosmetics[1]}.png");
            pb_cosmetic3.Image = Image.FromFile($"{players[2].cosmetics[2]}.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl_ammo_1.Text = "";
            lbl_ammo_2.Text = "";
            lbl_ammo_3.Text = "";
            lbl_ammo_4.Text = "";
            lbl_ammo_5.Text = "";


            rtb_items.Clear();

            lbl_Name.Text = $"{players[3].Name}";
            lbl_Level.Text = $"{players[3].Level}";
            lbl_HP.Text = $"{players[3].HP}";
            lbl_Shield.Text = $"{players[3].Shield}";
            foreach (var item in players[3].weapons)
            {
                rtb_items.Text += $"{item.Name}\n";
            }
            foreach (var item in players[3].cosmetics)
            {
                rtb_items.Text += $"{item}\n";
            }
            pb_item_1.Image = Image.FromFile($"{players[3].weapons[0].Name}.jpg");
            pb_item_2.Image = Image.FromFile($"{players[3].weapons[1].Name}.jpg");
            pb_item_3.Image = Image.FromFile($"{players[3].weapons[2].Name}.jpg");
            pb_item_4.Image = Image.FromFile($"{players[3].weapons[3].Name}.jpg");
            pb_item_5.Image = Image.FromFile($"{players[3].weapons[4].Name}.jpg");

            lbl_ammo_1.Text += $"{players[3].weapons[0].CurrentAmmo}/{players[3].weapons[0].MagazineSize}";
            lbl_ammo_2.Text += $"{players[3].weapons[1].CurrentAmmo}/{players[3].weapons[1].MagazineSize}";
            lbl_ammo_3.Text += $"{players[3].weapons[2].CurrentAmmo}/{players[3].weapons[2].MagazineSize}";
            lbl_ammo_4.Text += $"{players[3].weapons[3].CurrentAmmo}/{players[3].weapons[3].MagazineSize}";
            lbl_ammo_5.Text += $"{players[3].weapons[4].CurrentAmmo}/{players[3].weapons[4].MagazineSize}";

            lbl_item1.Text = players[3].cosmetics[0];
            lbl_item2.Text = players[3].cosmetics[1];
            lbl_item3.Text = players[3].cosmetics[2];
            pb_cosmetic1.Image = Image.FromFile($"{players[3].cosmetics[0]}.png");
            pb_cosmetic2.Image = Image.FromFile($"{players[3].cosmetics[1]}.png");
            pb_cosmetic3.Image = Image.FromFile($"{players[3].cosmetics[2]}.png");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbl_ammo_1.Text = "";
            lbl_ammo_2.Text = "";
            lbl_ammo_3.Text = "";
            lbl_ammo_4.Text = "";
            lbl_ammo_5.Text = "";


            rtb_items.Clear();

            lbl_Name.Text = $"{players[4].Name}";
            lbl_Level.Text = $"{players[4].Level}";
            lbl_HP.Text = $"{players[4].HP}";
            lbl_Shield.Text = $"{players[4].Shield}";
            foreach (var item in players[4].weapons)
            {
                rtb_items.Text += $"{item.Name}\n";
            }
            foreach (var item in players[4].cosmetics)
            {
                rtb_items.Text += $"{item}\n";
            }
            pb_item_1.Image = Image.FromFile($"{players[4].weapons[0].Name}.jpg");
            pb_item_2.Image = Image.FromFile($"{players[4].weapons[1].Name}.jpg");
            pb_item_3.Image = Image.FromFile($"{players[4].weapons[2].Name}.jpg");
            pb_item_4.Image = Image.FromFile($"{players[4].weapons[3].Name}.jpg");
            pb_item_5.Image = Image.FromFile($"{players[4].weapons[4].Name}.jpg");

            lbl_ammo_1.Text += $"{players[4].weapons[0].CurrentAmmo}/{players[4].weapons[0].MagazineSize}";
            lbl_ammo_2.Text += $"{players[4].weapons[1].CurrentAmmo}/{players[4].weapons[1].MagazineSize}";
            lbl_ammo_3.Text += $"{players[4].weapons[2].CurrentAmmo}/{players[4].weapons[2].MagazineSize}";
            lbl_ammo_4.Text += $"{players[4].weapons[3].CurrentAmmo}/{players[4].weapons[3].MagazineSize}";
            lbl_ammo_5.Text += $"{players[4].weapons[4].CurrentAmmo}/{players[4].weapons[4].MagazineSize}";

            lbl_item1.Text = players[4].cosmetics[0];
            lbl_item2.Text = players[4].cosmetics[1];
            lbl_item3.Text = players[4].cosmetics[2];
            pb_cosmetic1.Image = Image.FromFile($"{players[4].cosmetics[0]}.png");
            pb_cosmetic2.Image = Image.FromFile($"{players[4].cosmetics[1]}.png");
            pb_cosmetic3.Image = Image.FromFile($"{players[4].cosmetics[2]}.png");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbl_ammo_1.Text = "";
            lbl_ammo_2.Text = "";
            lbl_ammo_3.Text = "";
            lbl_ammo_4.Text = "";
            lbl_ammo_5.Text = "";


            rtb_items.Clear();

            lbl_Name.Text = $"{players[5].Name}";
            lbl_Level.Text = $"{players[5].Level}";
            lbl_HP.Text = $"{players[5].HP}";
            lbl_Shield.Text = $"{players[5].Shield}";
            foreach (var item in players[5].weapons)
            {
                rtb_items.Text += $"{item.Name}\n";
            }
            foreach (var item in players[5].cosmetics)
            {
                rtb_items.Text += $"{item}\n";
            }
            pb_item_1.Image = Image.FromFile($"{players[5].weapons[0].Name}.jpg");
            pb_item_2.Image = Image.FromFile($"{players[5].weapons[1].Name}.jpg");
            pb_item_3.Image = Image.FromFile($"{players[5].weapons[2].Name}.jpg");
            pb_item_4.Image = Image.FromFile($"{players[5].weapons[3].Name}.jpg");
            pb_item_5.Image = Image.FromFile($"{players[5].weapons[4].Name}.jpg");

            lbl_ammo_1.Text += $"{players[5].weapons[0].CurrentAmmo}/{players[5].weapons[0].MagazineSize}";
            lbl_ammo_2.Text += $"{players[5].weapons[1].CurrentAmmo}/{players[5].weapons[1].MagazineSize}";
            lbl_ammo_3.Text += $"{players[5].weapons[2].CurrentAmmo}/{players[5].weapons[2].MagazineSize}";
            lbl_ammo_4.Text += $"{players[5].weapons[3].CurrentAmmo}/{players[5].weapons[3].MagazineSize}";
            lbl_ammo_5.Text += $"{players[5].weapons[4].CurrentAmmo}/{players[5].weapons[4].MagazineSize}";

            lbl_item1.Text = players[5].cosmetics[0];
            lbl_item2.Text = players[5].cosmetics[1];
            lbl_item3.Text = players[5].cosmetics[2];
            pb_cosmetic1.Image = Image.FromFile($"{players[5].cosmetics[0]}.png");
            pb_cosmetic2.Image = Image.FromFile($"{players[5].cosmetics[1]}.png");
            pb_cosmetic3.Image = Image.FromFile($"{players[5].cosmetics[2]}.png");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbl_ammo_1.Text = "";
            lbl_ammo_2.Text = "";
            lbl_ammo_3.Text = "";
            lbl_ammo_4.Text = "";
            lbl_ammo_5.Text = "";


            rtb_items.Clear();

            lbl_Name.Text = $"{players[6].Name}";
            lbl_Level.Text = $"{players[6].Level}";
            lbl_HP.Text = $"{players[6].HP}";
            lbl_Shield.Text = $"{players[6].Shield}";
            foreach (var item in players[6].weapons)
            {
                rtb_items.Text += $"{item.Name}\n";
            }
            foreach (var item in players[6].cosmetics)
            {
                rtb_items.Text += $"{item}\n";
            }
            pb_item_1.Image = Image.FromFile($"{players[6].weapons[0].Name}.jpg");
            pb_item_2.Image = Image.FromFile($"{players[6].weapons[1].Name}.jpg");
            pb_item_3.Image = Image.FromFile($"{players[6].weapons[2].Name}.jpg");
            pb_item_4.Image = Image.FromFile($"{players[6].weapons[3].Name}.jpg");
            pb_item_5.Image = Image.FromFile($"{players[6].weapons[4].Name}.jpg");

            lbl_ammo_1.Text += $"{players[6].weapons[0].CurrentAmmo}/{players[6].weapons[0].MagazineSize}";
            lbl_ammo_2.Text += $"{players[6].weapons[1].CurrentAmmo}/{players[6].weapons[1].MagazineSize}";
            lbl_ammo_3.Text += $"{players[6].weapons[2].CurrentAmmo}/{players[6].weapons[2].MagazineSize}";
            lbl_ammo_4.Text += $"{players[6].weapons[3].CurrentAmmo}/{players[6].weapons[3].MagazineSize}";
            lbl_ammo_5.Text += $"{players[6].weapons[4].CurrentAmmo}/{players[6].weapons[4].MagazineSize}";

            lbl_item1.Text = players[6].cosmetics[0];
            lbl_item2.Text = players[6].cosmetics[1];
            lbl_item3.Text = players[6].cosmetics[2];
            pb_cosmetic1.Image = Image.FromFile($"{players[6].cosmetics[0]}.png");
            pb_cosmetic2.Image = Image.FromFile($"{players[6].cosmetics[1]}.png");
            pb_cosmetic3.Image = Image.FromFile($"{players[6].cosmetics[2]}.png");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbl_ammo_1.Text = "";
            lbl_ammo_2.Text = "";
            lbl_ammo_3.Text = "";
            lbl_ammo_4.Text = "";
            lbl_ammo_5.Text = "";


            rtb_items.Clear();

            lbl_Name.Text = $"{players[7].Name}";
            lbl_Level.Text = $"{players[7].Level}";
            lbl_HP.Text = $"{players[7].HP}";
            lbl_Shield.Text = $"{players[7].Shield}";
            foreach (var item in players[7].weapons)
            {
                rtb_items.Text += $"{item.Name}\n";
            }
            foreach (var item in players[7].cosmetics)
            {
                rtb_items.Text += $"{item}\n";
            }
            pb_item_1.Image = Image.FromFile($"{players[7].weapons[0].Name}.jpg");
            pb_item_2.Image = Image.FromFile($"{players[7].weapons[1].Name}.jpg");
            pb_item_3.Image = Image.FromFile($"{players[7].weapons[2].Name}.jpg");
            pb_item_4.Image = Image.FromFile($"{players[7].weapons[3].Name}.jpg");
            pb_item_5.Image = Image.FromFile($"{players[7].weapons[4].Name}.jpg");

            lbl_ammo_1.Text += $"{players[7].weapons[0].CurrentAmmo}/{players[7].weapons[0].MagazineSize}";
            lbl_ammo_2.Text += $"{players[7].weapons[1].CurrentAmmo}/{players[7].weapons[1].MagazineSize}";
            lbl_ammo_3.Text += $"{players[7].weapons[2].CurrentAmmo}/{players[7].weapons[2].MagazineSize}";
            lbl_ammo_4.Text += $"{players[7].weapons[3].CurrentAmmo}/{players[7].weapons[3].MagazineSize}";
            lbl_ammo_5.Text += $"{players[7].weapons[4].CurrentAmmo}/{players[7].weapons[4].MagazineSize}";

            lbl_item1.Text = players[7].cosmetics[0];
            lbl_item2.Text = players[7].cosmetics[1];
            lbl_item3.Text = players[7].cosmetics[2];
            pb_cosmetic1.Image = Image.FromFile($"{players[7].cosmetics[0]}.png");
            pb_cosmetic2.Image = Image.FromFile($"{players[7].cosmetics[1]}.png");
            pb_cosmetic3.Image = Image.FromFile($"{players[7].cosmetics[2]}.png");
        }

        private void btn_sort_kills_Click(object sender, EventArgs e)
        {
            rtb_leader.Clear();
            var sortedByKills = players
                .OrderByDescending(p => p.Kills)
                .ToList();

            int position = 1;
            foreach (var p in sortedByKills)
            {
                rtb_leader.AppendText($"{position}. {p.Name}\t Kills: {p.Kills}\n");
                position++;
            }
        }

        private void btn_sort_hp_Click(object sender, EventArgs e)
        {
            rtb_leader.Clear();
            var sortedByKills = players
                .OrderByDescending(p => p.HP)
                .ToList();

            int position = 1;
            foreach (var p in sortedByKills)
            {
                rtb_leader.AppendText($"{position}. {p.Name}\t HP: {p.HP}\n");
                position++;
            }
        }

        private void btn_sort_xp_Click(object sender, EventArgs e)
        {
            rtb_leader.Clear();
            var sortedByKills = players
                .OrderByDescending(p => p.XP)
                .ToList();

            int position = 1;
            foreach (var p in sortedByKills)
            {
                rtb_leader.AppendText($"{position}. {p.Name}\t XP: {p.XP}\n");
                position++;
            }
        }
    }
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int Shield { get; set; }
        public int Kills { get; set; }
        public int XP { get; set; }
        public List<string> cosmetics = new List<string>();
        public List<Weapon> weapons = new List<Weapon>();
        
        public Player(string nev)
        {
            Random rnd = new Random();
            Name = nev;
            Level = rnd.Next(1, 201);
            HP = rnd.Next(1, 101);
            Shield = rnd.Next(1, 101);
            Kills = rnd.Next(0, 12);
            XP = Level * 80000;
        }
    }
    public class Weapon
    {
        public string Name { get; set; }
        public int MagazineSize { get; set; }
        public int CurrentAmmo { get; set; }
        public Weapon(string sor)
        {
            Random rnd = new Random();
            Name = sor.Split(',')[0];
            MagazineSize = int.Parse(sor.Split(',')[1]);
            CurrentAmmo = rnd.Next(0, MagazineSize + 1);
        }
    }
}
