import java.util.Map;
import java.util.HashMap;

class SqueakyClean {
    static String clean(String identifier) {
        Map<Character, Character> map = new HashMap<>();
        map.put('4', 'a');
        map.put('3', 'e');
        map.put('0', 'o');
        map.put('1', 'l');
        map.put('7', 't');

        StringBuilder temp = new StringBuilder();
        for (char c : identifier.toCharArray()) {
            if (map.containsKey(c)) {
                temp.append(map.get(c));
            } else if (Character.isWhitespace(c)) {
                temp.append('_');
            } else if (Character.isLetterOrDigit(c)) {
                temp.append(c);
            } else if (c == '-') {
                temp.append(c);
            }
        }

        String result = temp.toString();
        while(result.contains("-")) {
            int index = result.indexOf("-");
            if (index + 1 < result.length()) {
                char nextChar = Character.toUpperCase(result.charAt(index + 1));
                result = result.substring(0, index) + nextChar + result.substring(index + 2);
            } else {
                result = result.substring(0, index);
            }
        }
        return result;
    }
}
