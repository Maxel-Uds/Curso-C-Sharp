namespace param
{
    public class Calculadora
    {
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++) {
                sum = sum + numbers[i];
            }
            return sum;
        }
    }
}