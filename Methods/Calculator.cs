namespace Methods
{
    public class Calculator
    {
        // a method with varying nubmer of parameters
        public int Add(int n1, int n2) { return 0; }
        public int Add(int n1, int n2, int n3) { return 0; }
        public int Add(int n1, int n2, int n3, int n4) { return 0; }

        // a better way is using an int[]
        public int Add1(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += sum;
            }

            return sum;
        }

        // using the params modifier
        public int Add2(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

    }
}
