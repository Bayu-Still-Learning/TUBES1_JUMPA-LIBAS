using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class BotKetiga : Bot
{
    static void Main(string[] args) => new BotKetiga().Start();
    BotKetiga() : base(BotInfo.FromFile("BotKetiga.json")) { }

    int moveDir = 1;

    public override void Run()
    {
        BodyColor = Color.Navy;
        GunColor = Color.Cyan;


        while (IsRunning)
        {
            Forward(100 * moveDir);
            TurnGunRight(360);
        }
    }

    public override void OnScannedBot(ScannedBotEvent e)
    {
        double distance = DistanceTo(e.X, e.Y);
        double power = distance < 300 ? 3 : distance < 500 ? 2 : 1;

        double gunTurn = GunBearingTo(e.X, e.Y);
        TurnGunRight(gunTurn);
        Fire(power);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        moveDir *= -1;
        Back(20);
        TurnRight(90);
    }

    public override void OnHitBot(HitBotEvent e)
    {
        Fire(3);
        Back(50);
        moveDir *= -1;
    }

    public override void OnHitByBullet(HitByBulletEvent e)
    {
        TurnRight(30 * moveDir);
        moveDir *= -1;
    }
}