using System;
using System.Collections.Generic;

namespace Learn90.FitAndFinishFeatures
{
    public class Extension_GetEnumerator_support_for_foreach_loops
    {
        public static void Test()
        {
            var customCollection = new CustomCollection<int>();
            customCollection.Add(1);
            customCollection.Add(2);
            customCollection.Add(3);
            // Iterating over CustomCollection using foreach loop
            foreach (var item in customCollection)
            {
                Console.WriteLine(item);
            }
        }
        private class CustomCollection<T>
        {
            private readonly List<T> items = new List<T>();
            public void Add(T item)
            {
                items.Add(item);
            }
            public CustomCollectionEnumerator<T> GetEnumerator() // Custom GetEnumerator method
            {
                return new CustomCollectionEnumerator<T>(items);
            }
        }

        // Custom enumerator for the CustomCollection class
        private class CustomCollectionEnumerator<T>
        {
            private readonly List<T> _items;
            private int _position = -1;
            public CustomCollectionEnumerator(List<T> list)
            {
                _items = list;
            }
            public bool MoveNext()
            {
                _position++;
                return (_position < _items.Count);
            }
            public T Current
            {
                get
                {
                    try
                    {
                        return _items[_position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}