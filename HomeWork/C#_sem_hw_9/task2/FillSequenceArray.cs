namespace MySequenceArray
{
    class SequenceArray
    {
        public static int[] FillSequenceArray(int m, int n)
        {
            List<int> sequence = new List<int>();
            if (m < n)
            {
                for (int i = m; i <= n; i++)
                {
                    sequence.Add(i);
                }
            }
            else
            {
                for (int i = m; i >= n; i--)
                {
                    sequence.Add(i);
                }
            }
            int[] sequenceArray = sequence.ToArray();
            return sequenceArray;
        }
    }
}