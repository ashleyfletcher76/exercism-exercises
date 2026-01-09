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
        String msg = message(logLine);
        String log = logLevel(logLine);

        String finalMsg = msg + " (" + log + ")";
        return finalMsg;
    }
}
