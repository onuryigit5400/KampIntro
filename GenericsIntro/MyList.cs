using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constructor->yapıcı metot (class ile aynı isimli olur)
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)    //item->eleman
        {
            T[] tempArray = items;      //elemanların referans numarasını tutmak için geçici dizi oluşturduk
            items = new T[items.Length+1];      //dizinin eleman sayısını bir artırdık
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
