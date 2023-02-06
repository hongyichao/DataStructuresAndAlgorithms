using LinearStructures.HashTable;

namespace LinearStructures
{
    public class HashTableDemo
    {
        public static void Run()
        {
            MyHashTable myHashTable = new MyHashTable();

            var firstNonRepeatedChar = myHashTable.FindFirstNonRepeatedCharacter("a green apple");
            Console.WriteLine(firstNonRepeatedChar);

            var firstRepeatedChar = myHashTable.FindFirstRepeatedCharacter("a green apple");
            Console.WriteLine(firstRepeatedChar);

            MyHashTable myHashTable2 = new MyHashTable(5);

            myHashTable2.Put(1, "Test1");
            myHashTable2.Put(2, "Test2");
            myHashTable2.Put(3, "Test3");
            myHashTable2.Put(6, "Test6");

            Console.WriteLine(myHashTable2.Get(1));
            Console.WriteLine(myHashTable2.Get(2));
            Console.WriteLine(myHashTable2.Get(3));
            Console.WriteLine(myHashTable2.Get(6));

            myHashTable2.Remove(6);
            Console.WriteLine(myHashTable2.Get(6));

            Console.WriteLine("*********** HashTable exercise ***************");

            HashTableExercise hashTableExercise = new HashTableExercise();

            var twoSumOutcome = hashTableExercise.twoSum(new int[] { 1, 2, 3, 5, 7, 8, 13 }, 8);

            Console.WriteLine(string.Join(",", twoSumOutcome));

            var mostFreqOutcome = hashTableExercise.mostFrequent(new int[] { 1, 2, 3, 1, 4, 5, 5, 6, 7, 7, 7 });

            Console.WriteLine(mostFreqOutcome);

            var countPairsOfDiffOutcome = hashTableExercise.countPairsWithDiff(new int[] { 1, 7, 5, 9, 2, 12, 3 }, 2);

            Console.WriteLine(countPairsOfDiffOutcome);

            Console.WriteLine("************* HashTable exercise 2 **************");

            var hashtableExe2 = new HashTableExercise(5);

            hashtableExe2.Put(1, "test1");
            hashtableExe2.Put(2, "test2");
            hashtableExe2.Put(3, "test3");
            hashtableExe2.Put(5, "test4");
            hashtableExe2.Put(6, "test5");
            hashtableExe2.Put(4, "test6");

            Console.WriteLine(hashtableExe2.ToString());

            Console.WriteLine(hashtableExe2.Get(13));

            hashtableExe2.Remove(11);

            Console.WriteLine(hashtableExe2.ToString());
        }
    }
}

