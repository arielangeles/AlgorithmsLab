using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public class Hashtable
    {
        private Item?[] items;
        private int count;

        public int Capacity
        {
            get
            {
                return this.items.Length;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public Item this[string key]
        {
            get
            {
                int hashValue = this.GetHashValue(key);
                if (this.items[hashValue] != null)
                {
                    Item temporaryItem = this.items[hashValue].Value;
                    if (temporaryItem.Key == key)
                    {
                        return temporaryItem;
                    }
                    return this.GetItemDuplicateHash(hashValue, key);
                }
                return default;
            }
        }

        public Hashtable(int capacity)
        {
            this.items = new Item?[capacity];
            for (int i = 0; i < this.Capacity; i++)
            {
                this.items[i] = null;
            }
            this.Count = 0;
        }

        public void Add(string key, string value)
        {
            Item temporaryItem;
            temporaryItem.Key = key;
            temporaryItem.Value = value;
            int hashValue = this.GetHashValue(temporaryItem.Key);
            if (this.items[hashValue] == null)
            {
                this.items[hashValue] = temporaryItem;
                return;
            }
            this.AddItemDuplicateHash(hashValue, temporaryItem);
            this.Count++;
        }

        private int GetHashValue(string key)
        {
            int hashValue = 0;
            char[] valueCharacters = key.ToCharArray();
            for (int i = 0; i < valueCharacters.Length; i++)
            {
                hashValue += (int)Char.ToLower(valueCharacters[i]);
                hashValue += (int)Char.ToLower(valueCharacters[i]);
            }
            hashValue *= 733;
            return (hashValue - this.Capacity) % this.Capacity;
        }

        private Item GetItemDuplicateHash(int hashValue, string key)
        {
            // Open Addressing Method
            for (int i = hashValue + 1; (i < this.items.Length && this.items[i] != null); i++)
            {
                if (this.items[i].Value.Key == key)
                {
                    return this.items[i].Value;
                }
            }
            return default;
        }

        private void AddItemDuplicateHash(int hashValue, Item item)
        {
            for (int i = hashValue + 1; i < this.items.Length; i++)
            {
                if (this.items[i] == null)
                {
                    this.items[i] = item;
                    return;
                }
            }
            throw new Exception("There's no space for this item in this hashtable.");
        }
    }
}
