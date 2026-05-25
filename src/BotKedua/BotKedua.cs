using System;
using System.Drawing;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class BotKedua : Bot
{
    static void Main(string[] args) => new BotKedua().Start();
    BotKedua() : base(BotInfo.FromFile("BotKedua.json")) { }

    public override void Run()
    {
        BodyColor = Color.Black;
        GunColor = Color.Lime;
        RadarColor = Color.Lime;
        BulletColor = Color.Lime;

        while (IsRunning)
        {
            TurnRadarRight(360);
        }
    }

    public override void OnScannedBot(ScannedBotEvent e)
    {
        double firePower = 3.0;
        double bulletSpeed = 20 - 3 * firePower;

        double distance = DistanceTo(e.X, e.Y);
        double travelTime = distance / bulletSpeed;

        double enemyHeadingRad = e.Direction * Math.PI / 180.0;
        double predictedX = e.X + Math.Sin(enemyHeadingRad) * e.Speed * travelTime;
        double predictedY = e.Y + Math.Cos(enemyHeadingRad) * e.Speed * travelTime;

        predictedX = Math.Max(18, Math.Min(ArenaWidth - 18, predictedX));
        predictedY = Math.Max(18, Math.Min(ArenaHeight - 18, predictedY));

        double gunAngle = GunBearingTo(predictedX, predictedY);
        TurnGunRight(gunAngle);

        if (Math.Abs(gunAngle) < 5)
            Fire(firePower);

        double radarAngle = RadarBearingTo(e.X, e.Y);
        TurnRadarRight(radarAngle * 2);
    }

    public override void OnHitWall(HitWallEvent e)
    {
        Back(30);
        TurnRight(90);
    }

    public override void OnHitByBullet(HitByBulletEvent e)
    {
        TurnRight(60);
        Forward(80);
    }
}