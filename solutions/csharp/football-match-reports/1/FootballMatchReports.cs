public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => "UNKNOWN"
    };

    public static string AnalyzeOffField(object report) => report switch
    {
        string s => s,
        int i => $"There are {i} supporters at the match.",
        Foul Foul => Foul.GetDescription(),
        Injury Injury => $"Oh no! {Injury.GetDescription()} Medics are on the field.",
        Incident Incident => Incident.GetDescription(),
        Manager m when m.Club is null => m.Name,
        Manager m => $"{m.Name} ({m.Club})",
        _ => ""
    };
}
