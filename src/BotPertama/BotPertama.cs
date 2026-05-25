using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class BotPertama : Bot
{
    static void Main(string[] args) => new BotPertama().Start();
    BotPertama() : base(BotInfo.FromFile("BotPertama.json")) { }

    double enemyX, enemyY, enemySpeed, enemyHeading;
    bool enemySeen = false;

    public override void Run()
    {
        BodyColor = Color.DarkRed;
        GunColor = Color.OrangeRed;
        BulletColor = Color.Yellow;

        while (IsRunning)
        {
            TurnGunRight(360); // terus scan
        }
    }

    public override void OnScannedBot(ScannedBotEvent e)
    {
        enemyX = e.X;
        enemyY = e.Y;
        enemySpeed = e.Speed;
        enemyHeading = e.Direction;
        enemySeen = true;

        // Hitung sudut ke musuh
        double angleToEnemy = BearingTo(e.X, e.Y);
        TurnLeft(angleToEnemy); // badan langsung ke musuh
        Forward(DistanceTo(e.X, e.Y) * 0.5); // kejar setengah jarak

        // Tembak sekencang mungkin
        double distance = DistanceTo(e.X, e.Y);
        double firePower = distance < 200 ? 3 : distance < 400 ? 2 : 1;
        Fire(firePower);
    }

    public override void OnHitBot(HitBotEvent e)
    {
        // Nabrak musuh = tembak maksimal
        Fire(3);
        Back(50);
        TurnRight(30);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        Back(40);
        TurnRight(45);
    }

    public override void OnHitByBullet(HitByBulletEvent e)
    {
        // Dodge ke kanan saat kena tembak
        TurnRight(45);
        Forward(60);
    }
}