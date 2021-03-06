using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotLinkedList.Model
{
    public class Item<T> 
    {
        private T data = default(T);

        private Item<T> next = null;

        public T Data
        {
            get { return data; }
            set
            {
                if (data != null)
                {
                    data = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(value));
                }
            }
        }

        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }


    }
}
