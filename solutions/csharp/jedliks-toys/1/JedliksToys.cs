class RemoteControlCar
{    
    public int Battery = 100;
    public int Driven = 0;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {Driven} meters";

    public string BatteryDisplay()
    {
        if (Battery <= 0)
            return "Battery empty";
        return $"Battery at {Battery}%";
    }

    public void Drive()
    {
        if (Battery <= 0)
            return ;
        Driven += 20;
        Battery--;
    }
}
