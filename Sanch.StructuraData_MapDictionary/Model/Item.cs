using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.StructuraData_MapDictionary.Model
{
    public class Item<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Item(TKey key, TValue value)
        {
            //проверка
            Key = key;
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
