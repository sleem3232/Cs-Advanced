using System.Collections;

namespace Cs_Advanced
{
    internal class Foreach
    {
        public void Run()
        {
            int sum = 0;
            int[] arr = new int[100];
            foreach (int i in arr)
            {
                sum += i;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += i;
            }

        }
        public void RunMyItems()
        {
            Items items = new Items();
            string str = "";
            foreach (var item in items)
            {
                str += item.ToString();
            }
        }
    }
    public class Items : IEnumerable, IEnumerator
    {
        string[] list = { "a", "b", "c" };
        int idx = 0;
        public object Current
        {
            get { return list[idx]; }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (idx < list.Length - 1)
            {
                idx++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            idx = 0;
        }
    }
}
