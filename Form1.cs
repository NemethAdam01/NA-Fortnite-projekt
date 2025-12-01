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
            string namesBe = File.ReadAllText("names.txt",Encoding.UTF8);
            string weaponBe  = File.ReadAllText("weapons.txt", Encoding.UTF8);
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
                    players[i].cosmetics.Add(cosmetics[rnd.Next(0,cosmetics.Count)]);
                }
                for (int k = 0; k < 5; k++)
                {
                    players[i].weapons.Add(weapons[rnd.Next(0,weapons.Count)]);
                }
            }
            
            


        }
    }
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int Shield { get; set; }
        public List<string> cosmetics = new List<string>();
        public List<Weapon> weapons = new List<Weapon>();
        public Player(string nev)
        {
            Random rnd = new Random();
            Name = nev;
            Level = rnd.Next(1, 201);
            HP = rnd.Next(1, 101);
            Shield = rnd.Next(1, 101);
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
