import java.util.Map;

class SqueakyClean {
    static String clean(String identifier) {
        String step1 = convertLeetspeak(identifier);
        String step2 = replaceWhiteSpace(step1);
        String step3 = converKebab(step2);
        return removeNonChars(step3);
    }

    private static String convertLeetspeak(String input) {
        Map<Character, Character> map = Map.of(
                '4', 'a',
                '3', 'e',
                '0', 'o',
                '1', 'l',
                '7', 't'
        );

        StringBuilder result = new StringBuilder();
        for (char c : input.toCharArray()) {
            if (map.containsKey(c)) {
                result.append(map.get(c));
            } else {
                result.append(c);
            }
        }
        return result.toString();
    }

    private static String replaceWhiteSpace(String input) {
        return input.replace(' ', '_');
    }

    private static String converKebab(String input) {
        StringBuilder result = new StringBuilder();
        boolean capitalizeNext = false;

        for (char c : input.toCharArray()) {
            if (c == '-') {
                capitalizeNext = true;
            } else if (capitalizeNext) {
                result.append(Character.toUpperCase(c));
                 capitalizeNext = false;
            } else {
                result.append(c);
            }
        }
        return result.toString();
    }

    private static String removeNonChars(String input) {
        StringBuilder result = new StringBuilder();

        for (char c : input.toCharArray()) {
            if (Character.isLetter(c) || c == '_') {
                result.append(c);
            }
        }

        return result.toString();
    }
}
