namespace LinearStructures.HashTable
{
    public class HashTableExercise
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        HashSet<int> hashSet = new HashSet<int>();

        private string[] items;

        public HashTableExercise() { }

        public HashTableExercise(int capacity)
        {
            items = new string[capacity];
        }

        public void Put(int key, string val)
        {
            for (int i = 0; i < items.Length; i++)
            {
                var index = (key + i) % items.Length;

                if (items[index] == null)
                {
                    items[index] = val;
                    return;
                }
            }
        }

        public string Get(int key)
        {
            for (int i = 0; i < items.Length; i++)
            {
                var index = (key + i) % items.Length;

                if (items[index] != null)
                {
                    return items[index];
                }
            }

            return null;
        }

        public void Remove(int key)
        {
            for (int i = 0; i < items.Length; i++)
            {
                var index = (key + i) % items.Length;

                if (items[index] != null)
                {
                    items[index] = null;
                    return;
                }
            }

            return;
        }

        public override string ToString()
        {
            return string.Join(", ", items);
        }


        //input 1,2,3,5,8,13 target = 8
        public int[] twoSum(int[] numbers, int target)
        {
            hashSet.Clear();

            foreach (var n in numbers)
            {
                var complement = target - n;
                if (hashSet.Contains(complement))
                {
                    hashSet.TryGetValue(complement, out int actualVal);
                    return new int[] { n, actualVal };
                }

                hashSet.Add(n);
            }

            return null;
        }

        public int mostFrequent(int[] numbers)
        {
            dic.Clear();

            foreach (var n in numbers)
            {
                if (dic.ContainsKey(n))
                {
                    dic[n]++;
                }
                else
                {
                    dic.Add(n, 1);
                }
            }

            var maxCount = -1;

            var mostFreq = -1;

            foreach (var i in dic)
            {
                if (i.Value > maxCount)
                {
                    maxCount = i.Value;
                    mostFreq = i.Key;
                }

            }

            return mostFreq;
        }

        //Input: [1, 7, 5, 9, 2, 12, 3] K=2
        //Output: 4
        //We have four pairs with difference 2: (1, 3), (3, 5), (5, 7), (7, 9)
        public int countPairsWithDiff(int[] numbers, int difference)
        {
            var count = 0;

            hashSet.Clear();


            foreach (var n in numbers)
            {
                hashSet.Add(n);
            }

            foreach (var n in numbers)
            {
                if (hashSet.Contains(n + difference))
                {
                    count++;
                }

                if (hashSet.Contains(n - difference))
                {
                    count++;
                }

                hashSet.Remove(n);
            }

            return count;
        }
    }
}
