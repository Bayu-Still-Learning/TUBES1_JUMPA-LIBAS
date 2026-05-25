using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class BotKeempat : Bot
{
    static void Main(string[] args) => new BotKeempat().Start();
    BotKeempat() : base(BotInfo.FromFile("BotKeempat.json")) { }

    int turnDir = 1;
    Random rng = new Random();

    public override void Run()
    {
        BodyColor = Color.DarkMagenta;
        GunColor = Color.HotPink;
        BulletColor = Color.White;

        while (IsRunning)
        {
            TurnRight(rng.Next(30, 90) * turnDir);
            Forward(rng.Next(50, 150));
            TurnGunRight(360);
            Fire(1);
        }
    }

    public override void OnScannedBot(ScannedBotEvent e)
    {
        double d = DistanceTo(e.X, e.Y);
        Fire(d < 150 ? 3 : 2);
        turnDir *= -1;
        TurnRight(45 * turnDir);
    }

    public override void OnHitByBullet(HitByBulletEvent e)
    {
        turnDir *= -1;
        TurnRight(60 * turnDir);
        Forward(100);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        Back(50);
        TurnRight(rng.Next(45, 135));
    }
}