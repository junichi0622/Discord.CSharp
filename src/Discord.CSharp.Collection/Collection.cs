using System.Reflection.Metadata;

namespace Discord.CSharp.Collection
{
    public class Collection<K, V> : Dictionary<K, V> where K : notnull
    {
        public V Ensure(K key, Func<K, Collection<K, V>, V> defaultValueGenerator)
        {
            if (ContainsKey(key))
            {
                return this[key];
            }

            V defaultValue = defaultValueGenerator(key, this);
            this[key] = defaultValue;

            return defaultValue;
        }

        public bool HasAll(params K[] keys)
        {
            return keys.All(ContainsKey);
        }

        public bool HasAny(params K[] keys)
        {
            return keys.Any(ContainsKey);
        }

        public object First(int? amount = null)
        {
            if (!amount.HasValue)
            {
                return Values.FirstOrDefault();
            }

            if (amount < 0)
            {
                return Last(-amount.Value);
            }

            return Values.Take(amount.Value).ToList();
        }

        public object Last(int? amount = null)
        {
            var values = Values.ToList();

            if (!amount.HasValue)
            {
                return Values.LastOrDefault();
            }

            if (amount < 0)
            {
                return First(-amount.Value);
            }

            if (amount == 0)
            {
                return new List<V>();
            }

            return values.Skip(Math.Max(0, values.Count - amount.Value)).ToList();
        }

        public V At(int index)
        {
            var values = this.Values.ToList();

            if (index < 0 || index >= values.Count)
            {
                throw new ArgumentOutOfRangeException(nameof)
            }
        }
    }
}