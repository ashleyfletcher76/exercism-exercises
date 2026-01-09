public class JedliksToyCar {

    private int distance = 0;
    private int batteryLeft = 100;
    
    public static JedliksToyCar buy() {
        return new JedliksToyCar();
    }

    public String distanceDisplay() {
        return "Driven " + distance + " meters";
    }

    public String batteryDisplay() {
        if (batteryLeft <= 0)
            return "Battery empty";
        return "Battery at " + batteryLeft + "%";
    }

    public void drive() {
        if (batteryLeft <= 0)
            return ;
        distance += 20;
        batteryLeft -= 1;
    }
}
