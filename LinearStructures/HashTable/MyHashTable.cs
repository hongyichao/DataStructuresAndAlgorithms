namespace LinearStructures.HashTable
{
    public class MyHashTable
    {
        private Dictionary<char, int> dic = new Dictionary<char, int>();
        private HashSet<char> hashSet = new HashSet<char>();

        private LinkedList<KeyValuePair<int, string>>[] itemChains;

        public MyHashTable() { }

        public MyHashTable(int capacity)
        {
            itemChains = new LinkedList<KeyValuePair<int, string>>[capacity];
        }

        public void Put(int key, string val)
        {
            var index = key % itemChains.Length;

            if (itemChains[index] == null)
            {
                itemChains[index] = new LinkedList<KeyValuePair<int, string>>();
            }

            var myItem = new KeyValuePair<int, string>(key, val);
            itemChains[index].AddFirst(myItem);
        }

        public string Get(int key)
        {
            var index = key % itemChains.Length;

            if (itemChains[index] != null)
            {
                foreach (var i in itemChains[index])
                {
                    if (i.Key == key)
                        return i.Value;
                }
            }

            return "Nothing!!!!!!";
        }

        public void Remove(int key)
        {
            var index = key % itemChains.Length;

            if (itemChains[index] != null)
            {
                foreach (var i in itemChains[index])
                {
                    if (i.Key == key)
                    {
                        itemChains[index].Remove(i);
                        break;
                    }
                }
            }
        }


        public char FindFirstNonRepeatedCharacter(string str)
        {
            dic.Clear();

            foreach (var c in str)
            {
                if (!dic.ContainsKey(c))
                    dic.Add(c, 0);
                else
                    dic[c]++;
            }

            foreach (var i in dic)
            {
                if (i.Value == 0)
                    return i.Key;
            }

            return '\0';
        }

        public char FindFirstRepeatedCharacter(string str)
        {
            hashSet.Clear();

            foreach (var c in str)
            {
                if (hashSet.Add(c))
                    return c;
            }

            return '\0';
        }
    }
}

