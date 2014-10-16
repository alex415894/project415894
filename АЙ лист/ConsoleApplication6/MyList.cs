using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    
    
    public class MyList : IList
    {
        object[] contents = new object[4];
        
        int count;

        public MyList()
        {
            count = 0;
         }
        
        public int Add(object value)
        {
            if (count < contents.Length)
            {
                contents[count] = value;
                count++;

                return (count - 1);
            }
            else
            {
                Array.Resize(ref contents, contents.Length * 2);
                
            }

            return count - 1;
        }

        public void Clear()
        {
           count = 0;
        }

        public bool Contains(object value)
        {
            bool inList = false;
            
            for (int i = 0; i < count; i++)
            {
                if (contents[i] == value)
                {
                    inList = true;
                    break;
                }
            }
            
            return inList;
        }

        public int IndexOf(object value)
        {
            int itemIndex = -1;
            for (int i = 0; i < Count; i++)
            {
                if (contents[i] == value)
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }

        public void Insert(int index, object value)
        {
            if ((count + 1 <= contents.Length) && (index < Count) && (index >= 0))
            {
                count++;

                for (int i = Count - 1; i > index; i--)
                {
                    contents[i] = contents[i - 1];
                }
                contents[index] = value;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < count))
            {
                for (int i = index; i < count - 1; i++)
                {
                    contents[i] = contents[i + 1];
                }
                count--;
            }
        }

        public object this[int index]
        {
            get
            {
                return contents[index];
            }
            set
            {
                contents[index] = value;
            }
        }

        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < count; i++)
            {
                array.SetValue(contents[i], j);
                j++;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public object SyncRoot
        {
            get
            {
                return this;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return null;
        }
       
       

    }

    public class  MyIEnumerator : IEnumerator 
    {
     MyList Items = new MyList(object value) 
 
MyIEnumerator enumerator = MyList.GetEnumerator();
 
while(enumerator.MoveNext())
        {
    string itm  = enumerator.Current;
 
    Console.WriteLine(itm);
      

             }
 
}

//Array.Resize(ref contents, contents.Length + 1);


//private Person[] _people;
//    public People(Person[] pArray)
//    {
//        _people = new Person[pArray.Length];

//        for (int i = 0; i < pArray.Length; i++)
//        {
//            _people[i] = pArray[i];
//        }
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//       return (IEnumerator) GetEnumerator();
//    }

//    public PeopleEnum GetEnumerator()
//    {
//        return new PeopleEnum(_people);
//    }
