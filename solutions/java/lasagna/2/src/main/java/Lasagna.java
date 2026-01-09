public class Lasagna {
    public int expectedMinutesInOven() {
        return 40;
    }

    public int remainingMinutesInOven(int actualMins) {
        return expectedMinutesInOven() - actualMins;
    }

    public int preparationTimeInMinutes(int numLayers) {
        return numLayers * 2;
    }

    public int totalTimeInMinutes(int numLayers, int currentMins) {
        int result = currentMins + preparationTimeInMinutes(numLayers);
        return result;
    }
}
