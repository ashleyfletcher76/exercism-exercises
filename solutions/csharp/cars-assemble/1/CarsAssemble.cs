static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
            return 0;
        else if (speed >= 1.0 && speed <= 4.0)
            return 1.0;
        else if (speed >= 5.0 && speed <= 8.0)
            return 0.9;
        else if (speed == 9.0)
            return 0.8;
        else 
            return 0.77;
    }
    
    public static double ProductionRatePerHour(int speed) => (SuccessRate(speed) * 221) * speed;

    public static int WorkingItemsPerMinute(int speed) => (int) ProductionRatePerHour(speed) / 60;
}
