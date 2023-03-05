public class task_003 {
    /*
     * Напишите метод, который находит самую длинную строку общего префикса среди массива строк.
     *
     * Если общего префикса нет, вернуть пустую строку "".
     */
    public static void main(String[] args) {
        String[] array = {"abc", "abcsde", "abcssssss", "abceqw", "abcee"};

        String commonPrefix = findCommonPrefix(array);
        System.out.println(commonPrefix);
    }

    static String findCommonPrefix(String[] array) {
        String shotString = array[0];
        for (int i = 1; i < array.length ; i++) {
            if (shotString.length() > array[i].length())
                shotString = array[i];
        }

        String result = "";
        first: for (int index = 0; index < shotString.length(); index++) {
            char firstIndexChar = shotString.charAt(index);
            for (int i = 0; i < array.length; i++) {
                char secondStringChar = array[i].charAt(index);

                if (firstIndexChar != secondStringChar) {
                    break first;
                }
            }
            result += shotString.charAt(index);
        }
        return result;
    }
}
