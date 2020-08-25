using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Множество (реализовано в виде массива)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Set<T> where T: IComparable
    {
        int size;       // размер множества
        int count;      // кол-во заполненных элементов
        T[] data;

        public Set() { }

        public Set(int size)
        {
            this.size = size;
            count = 0;

            if (size > 0)
                data = new T[size];
        }

        public Set(T[] data)
        {
            this.data = data;
            size = data.Length;
            count = data.Length;
        }

        public int GetSize() { return size; }
        public int GetCount() { return count; }

        public T GetValue(int index)
        {
            if (index >= 0 && index < count)
                return data[index];
            return default(T);
        }

        public int GetIndex(T value)
        {
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < count; i++)
                if (data[i].CompareTo(value) == 0)
                    return true;
            return false;
        }

        public void Add(T value)
        {
            int index = GetIndex(value);

            if (index == -1)
            {
                if (count < size) { data[count] = value; count++; }
                else
                {
                    T[] temp = new T[size];
                    for (int i = 0; i < size; i++)
                        temp[i] = data[i];

                    data = new T[size + 1];
                    for (int i = 0; i < size; i++)
                        data[i] = temp[i];

                    data[size] = value;
                    size += 1; count += 1;
                }
            }
        }

        public Set<T> Copy()
        {
            Set<T> temp = new Set<T>(size);

            for (int i = 0; i < count; i++)
                temp.Add(data[i]);
            return temp;
        }

        public T[] ToArray()
        {
            var temp = new T[size];

            for (int i = 0; i < size; i++)
                temp[i] = data[i];

            return temp;
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index > size)
                throw new ArgumentOutOfRangeException();

            Add(default(T));
            for (int i = size - 1; i > index; i--)
                data[i] = data[i - 1];
            data[index] = value;
        }

        public void RemoveAtIndex(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = index; i < count - 1; i++)
                    data[i] = data[i + 1];
                data[count - 1] = default(T);
                count -= 1;
            }
        }

        public void Remove(T value)
        {
            if (GetIndex(value) >= 0)
                RemoveAtIndex(GetIndex(value));
        }

        public Set<T> Union(Set<T> set)
        {
            Set<T> union = this.Copy();

            for (int i = 0; i < set.GetCount(); i++)
            {
                if (!union.Contains(set.data[i]))
                    union.Add(set.data[i]);
            }
            return union;
        }

        public Set<T> Intersection(Set<T> set)
        {
            Set<T> intersection = new Set<T>(size);

            for (int i = 0; i < set.GetCount(); i++)
            {
                if (Contains(set.data[i]))
                    intersection.Add(set.data[i]);
            }
            return intersection;
        }

        public Set<T> Difference(Set<T> set)
        {
            Set<T> difference = this.Copy();

            foreach (T value in set.data)
                difference.Remove(value);

            return difference;
        }

        public Set<T> SymmetricDifference(Set<T> set)
        {
            Set<T> symDifference = new Set<T>(this.size);

            for (int i = 0; i < set.GetCount(); i++)
            {
                if (Contains(set.data[i]))
                    symDifference.Remove(set.data[i]);
            }
            return symDifference;
        }

        public List<Set<T>> Combinations() // сочетание без повторений
        {
            List<Set<T>> list = new List<Set<T>>();

            for (int i = 0; i < Math.Pow(2, count); i++)
            {
                Set<T> temp = new Set<T>(count);

                int y = i;
                for (int j = 0; j < count; j++)
                {
                    int x = y;
                    y = y / 2;
                    if ((x - 2 * y) == 1)
                        temp.Add(data[j]);
                }
                list.Add(temp);
            }
            return list;
        }

        public void View()
        {
            Console.Write("{ ");
            string print = String.Empty;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    print = data[i] + ", ";
                    if (i == count - 1)
                    {
                        print = data[i].ToString();
                    }
                    Console.Write(print);
                }
            }
            Console.Write(" }\n");
            //return print;
        }

        public override string ToString()
        {
            string print = String.Empty;
            print += "{ ";
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (i == count - 1)
                    {
                        print += data[i] + "";
                        break;
                    }
                    print += data[i] + ", ";
                }
            }
            print += " }";
            return print;
        }
    }
}
