﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using FormsTimer = System.Windows.Forms.Timer;
namespace Gra___programowanie_wizualne_5
{

    public partial class Form3 : Form
    {
        private Settings settings;
        private Button[,] przyciski;
        private string[,] zawartosc;
        private int znalezioneDydelfy = 0;
        private System.Windows.Forms.Timer timer;
        private int czasDoKonca;
        private Dictionary<Button, FormsTimer> krokodyleTimery = new Dictionary<Button, FormsTimer>();
        public Form3(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            this.Text = "Gdzie jest Dydelf?";
            this.Size = new Size(settings.columns * 60 + 40, settings.rows * 60 + 100);
            InitTimer();
            UtworzPlansze();
        }

        private void InitTimer()
        {
            czasDoKonca = settings.time;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            czasDoKonca--;
            this.Text = $"Pozostały czas: {czasDoKonca}s";

            if (czasDoKonca <= 0)
            {
                timer.Stop();
                MessageBox.Show("Czas się skończył! Przegrałeś.");
                this.Close();
            }
        }

        private void UtworzPlansze()
        {
            przyciski = new Button[settings.rows, settings.columns];
            zawartosc = new string[settings.rows, settings.columns];

            var panel = new Panel
            {
                Location = new Point(10, 10),
                Size = new Size(settings.columns * 60, settings.rows * 60)
            };
            this.Controls.Add(panel);

            var rand = new Random();
            var pola = new List<Point>();
            for (int y = 0; y < settings.rows; y++)
                for (int x = 0; x < settings.columns; x++)
                    pola.Add(new Point(x, y));

            void Rozmiesc(string typ, int ile)
            {
                for (int i = 0; i < ile; i++)
                {
                    int index = rand.Next(pola.Count);
                    var p = pola[index];
                    zawartosc[p.Y, p.X] = typ;
                    pola.RemoveAt(index);
                }
            }

            Rozmiesc("D", settings.LiczbaDydelfow);
            Rozmiesc("S", settings.LiczbaSzopow);
            Rozmiesc("K", settings.LiczbaKrokodyli);

            for (int y = 0; y < settings.rows; y++)
            {
                for (int x = 0; x < settings.columns; x++)
                {
                    var btn = new Button
                    {
                        Size = new Size(50, 50),
                        Location = new Point(x * 60, y * 60),
                        BackColor = Color.Gray,
                        Tag = new Point(x, y)
                    };
                    btn.Click += PoleKlikniete;
                    przyciski[y, x] = btn;
                    panel.Controls.Add(btn);
                }
            }
        }

        private void PoleKlikniete(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var p = (Point)btn.Tag;
            string typ = zawartosc[p.Y, p.X];

            if (!btn.Enabled) return;

            switch (typ)
            {
                case null:
                    btn.BackColor = Color.LightGray;
                    btn.Enabled = false;
                    break;

                case "D":
                    btn.BackColor = Color.Green;
                    btn.Text = "D";
                    btn.Enabled = false;
                    znalezioneDydelfy++;
                    if (znalezioneDydelfy == settings.LiczbaDydelfow)
                    {
                        timer.Stop();
                        MessageBox.Show("Wygrałeś! Znalazłeś wszystkie Dydelfy!");
                        this.Close();
                    }
                    break;

                case "S":
                    btn.BackColor = Color.Brown;
                    btn.Text = "S";
                    btn.Enabled = false;
                    ZamknijSzopa(p.X, p.Y);
                    break;

                case "K":
                    if (btn.BackColor == Color.Red && krokodyleTimery.TryGetValue(btn, out FormsTimer existingTimer))
                    {
                        existingTimer.Stop();
                        krokodyleTimery.Remove(btn);

                        btn.BackColor = Color.LightGray;
                        btn.Text = "";
                        btn.Enabled = true;

                        MessageBox.Show("Udało ci się uciec przed krokodylem!");
                        break;
                    }

                  
                    btn.BackColor = Color.Red;
                    btn.Text = "K";
                    btn.Enabled = true;

                    FormsTimer krokTimer = new FormsTimer { Interval = 2000 };

                    krokTimer.Tick += (s, ev) =>
                    {
                        krokTimer.Stop();
                        if (krokodyleTimery.ContainsKey(btn))
                        {
                            krokodyleTimery.Remove(btn);
                            timer.Stop();
                            MessageBox.Show("Zaatakował cię krokodyl! Przegrałeś.");
                            Close();
                        }
                    };

                    krokodyleTimery[btn] = krokTimer;
                    krokTimer.Start();
                    break;
            }

            }

        private void ZamknijSzopa(int x, int y)
        {

           
            var sasiednie = new List<Point>();

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = x + dx;
                    int ny = y + dy;

                    if ((dx != 0 || dy != 0) && nx >= 0 && ny >= 0 && nx < settings.columns && ny < settings.rows)
                    {
                        sasiednie.Add(new Point(nx, ny));
                    }
                }
            }

            foreach (var pt in sasiednie)
            {
                var btn = przyciski[pt.Y, pt.X];
                if (!btn.Enabled) continue; 

                string oryginalnaZawartosc = zawartosc[pt.Y, pt.X];

                btn.Text = "?";
                btn.BackColor = Color.DarkGray;

                var timer = new System.Windows.Forms.Timer { Interval = 1000 };
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    btn.Text = "";
                    btn.BackColor = Color.Gray;
                };
                timer.Start();
            }

        }
    }
}













