class RemoteControlCar
{
    public int Battery = 100;
    private int Driven = 0;
    private int Speed;
    private int BatteryDrain;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.Speed = speed;
        this.BatteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => Battery < BatteryDrain;

    public int DistanceDriven() => Driven;

    public void Drive()
    {
        if (BatteryDrained())
            return;
        Driven += Speed;
        Battery -= BatteryDrain;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int Distance;

    public RaceTrack(int distance)
    {
        Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
            car.Drive();
        return car.DistanceDriven() >= Distance;
    }
}
