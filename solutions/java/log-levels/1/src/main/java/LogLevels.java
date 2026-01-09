public class LogLevels {
    
    public static String message(String logLine) {
        int index = logLine.indexOf(" ");
        String msg = logLine.substring(index + 1);
        String trimmedString = msg.trim();
        return trimmedString;
    }

    public static String logLevel(String logLine) {
        String result = logLine.replaceAll("\\s", "");
        int index = logLine.indexOf("]");
        String msg = logLine.substring(1, index).toLowerCase();
        return msg;
    }

    public static String reformat(String logLine) {
        String removeWhitespace = logLine.replaceAll("\\s", " ");
        String trimStr = removeWhitespace.strip();
        int index = trimStr.indexOf("]");
        String removeLog = trimStr.substring(1, index).toLowerCase();
        // System.out.println(index);
        String msg = trimStr.substring(index + 2);
        String finalStr = msg + " (" + removeLog + ")";
        String finalFinal = finalStr.strip();
        return finalFinal;
    }
}
