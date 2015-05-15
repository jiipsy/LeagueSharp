﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;
using LeagueSharp;
using LeagueSharp.Common;
using UnderratedAIO.Helpers;
namespace RandomUlt
{
    class Program
    {
        public static Menu config;
        public static Orbwalking.Orbwalker orbwalker;
        public static LastPositions positions;
        public static readonly Obj_AI_Hero player = ObjectManager.Player;

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        static void Game_OnGameLoad(EventArgs args)
        {
            if (!(player.ChampionName == "Ezreal" || player.ChampionName == "Jinx" || player.ChampionName == "Draven" ||
                player.ChampionName == "Ashe"))
            {
                return;
            }
            config = new Menu("RandomUlt Beta", "RandomUlt Beta", true);
            Menu RandomUltM = new Menu("Options", "Options");
            positions = new LastPositions(RandomUltM);
            config.AddSubMenu(RandomUltM);
            config.AddItem(new MenuItem("RandomUlt ", "by Soresu"));
            config.AddToMainMenu();
            Notifications.AddNotification(new Notification("RandomUlt by Soresu", 3000, true).SetTextColor(Color.Peru));
        }
    }
}
