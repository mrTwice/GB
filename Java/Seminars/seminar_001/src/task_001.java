public class task_001 {
    public static void main(String[] args) {
        /*
        Дан массив двоичных чисел, например [1,1,0,1,1,1],
        вывести максимальное количество подряд идущих 1.
        */
        int[] array = {1, 1, 0, 1, 1, 1};
        int count = 0;
        int bestCount = 0;
        for (int item : array) {
            if (item == 1) {
                count++;
            }
            else {
                if (count > bestCount) {
                    bestCount = count;
                }
                count = 0;
            }

        }
        if (count > bestCount) {
            bestCount = count;
        }
        System.out.println(bestCount);
    }
}