using System.Collections;

namespace AppRetro
{
    internal class SumOfDigitsInFactorialNumber
    {
        ArrayList v = new ArrayList();
        private void multiply(int x)
        {
            int carry = 0;
            int size = v.Count;
            for (int i = 0; i < size; i++)
            {
                // Calculate res + prev carry
                int res = carry + (int)v[i] * x;

                // updation at ith position
                v[i] = res % 10;
                carry = res / 10;
            }
            while (carry != 0)
            {
                v.Add(carry % 10);
                carry /= 10;
            }
        }

        // Returns sum of digits in n!
        public int findSumOfDigits(int n)
        {
            v.Add(1); // adds 1 to the end

            // One by one multiply i to current vector
            // and update the vector.
            for (int i = 1; i <= n; i++)
                multiply(i);

            // Find sum of digits in vector v[]
            int sum = 0;
            int size = v.Count;
            for (int i = 0; i < size; i++)
                sum += (int)v[i];
            return sum;
        }
    }
}
