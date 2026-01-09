class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeUsed) {
        return ExpectedMinutesInOven() - timeUsed;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numLayers) {
        return numLayers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numLayers, int timeSpentOven) {
        int total = PreparationTimeInMinutes(numLayers) + timeSpentOven;
        return total;
    }
}
