using System;
using System.Text;

namespace ClassLibraryArr
{
    public class ArrayList<T> : IList<T>
    {
        T[] arrList = Array.Empty<T>();
        int numberOfElements;

        public override string ToString() // Вывод списка на экран
        {
            StringBuilder showlist = new StringBuilder("List: ");
            for (int i = 0; i < numberOfElements; i++)
            {
                showlist.Append (" {arrList[i]}");
            }
            showlist.Append("\n");
            return showlist.ToString();
        }

        private T[] UpdateList() //Обновляем массив (увеличиваем на 100)
        {
            T[] updateArr = new T[arrList.Length + 100];
            Array.Copy(arrList, updateArr, arrList.Length);
            return updateArr;
        }

        public void Add(T newElement) // Добавление элемента
        {
            if (numberOfElements == arrList.Length) 
                arrList = UpdateList();
            if(newElement!=null)
                arrList[numberOfElements] = newElement;
            else throw new NullElementException("Нельзя добавить значение null");
            numberOfElements += 1;
        }

        public void RemoveAt(int index) // Удаление элемента по его номеру
        {
            if (arrList.Length < 1)
                throw new EmptyListException("Список пуст");
            if (index > numberOfElements || index < 0) 
                throw new NoIndexException("Такого индекса нет");
            arrList[index] = default;
            for (int i = index; i < arrList.Length - 1; i++)
                arrList[i] = arrList[i + 1];
            numberOfElements -= 1;
        }

        public void Remove(T newElement) // Удаление элемента по его значению
        {
            if (arrList.Length < 1)
                throw new EmptyListException("Список пуст");
            int index = IndexOf(newElement);
            arrList[index] = default;
            for (int i = index; i < arrList.Length - 1; i++)
                arrList[i] = arrList[i + 1];
            numberOfElements -= 1;
        }

        public void Clear() //очистить массив
        {
            for (int i = 0; i < numberOfElements; i++)
            {
                arrList[i] = default;
            }
        }

        public void Insert(T newElement, int index) // Вставка элемента
        {
            if (index > numberOfElements - 1 || index < 0)
                throw new NoIndexException("Такого индекса нет");
            if (numberOfElements == arrList.Length)
                arrList = UpdateList();
            numberOfElements += 1;
            for (int i = numberOfElements - 1; i > index; i--)
                arrList[i] = arrList[i - 1];
            arrList[index] = newElement;
        }

        public bool Contains(T newElement) // Проверяет содержится ли элемент в списке
        {
            for (int i = 0; i < numberOfElements; i++)
            {
                if (arrList[i].Equals(newElement))
                    return true;
            }
            return false;
        }

        public int IndexOf(T newElement) // Нахождние номера элемента по введенному значению
        {
            for (int i = 0; i < numberOfElements; i++)
            {
                if (arrList[i].Equals(newElement))
                    return i;
            }
            return -1;
        }

        public IList<T> SubList(int fromIndex, int toIndex) //Создание нового списка от элемента до элемента
        {

            if (numberOfElements < toIndex || fromIndex < 0 || toIndex < 0 || fromIndex > numberOfElements)
                throw new NoIndexException("Такого индекса нет");
            ArrayList<T> UpdateList = new ArrayList<T>(); //TODO скопировать массив
            for (int i = fromIndex; i <= toIndex; i++)
                UpdateList.Add(arrList[i]);
            return UpdateList;
        }

        public T this[int index] // Нахождние номера элемента по введенному номеру 
        {
            get
            {
                return arrList[index];
            }
            set
            {
                arrList[index] = value;
            }
        }

        public int Length()
        {
            return numberOfElements;
        }

        public ArrayList(T[] arr)
        {
            arrList = arr;
            for (int i = 0; i < arr.Length; i++)
            {
                arrList[i] = arr[i];
            }
            numberOfElements = arr.Length;
        }

        public ArrayList()
        { }

        public override bool Equals(object obj)
        {
            ArrayList<T> expectedList = (ArrayList<T>)obj;
            if (obj.GetType() != GetType()) return false;
            bool result = true;
            for (int i = 0; i < expectedList.Length(); i++)
            {
                if (expectedList[i].Equals(this[i]))
                    result = true;
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public override int GetHashCode()
        {
            int hashCode=0;
            for (int i=0; i<numberOfElements-1;i++)
            {
                hashCode^=arrList[i].GetHashCode();
            }
            return hashCode;
        }
    }

    public interface IList<T>
    {
        string ToString();
        void Add(T newElement);
        void RemoveAt(int index);
        void Remove(T newElement);
        void Clear();
        void Insert(T newElement, int index);
        bool Contains(T newElement);
        int IndexOf(T newElement);
        IList<T> SubList(int fromIndex, int toIndex);
        T this[int index] { get; set; }
        int Length();
    }

    public class ExceptionList : Exception
    {
        public ExceptionList(string Message) : base(Message)
        { }
    }

    public class NoIndexException : ExceptionList
    {
        public NoIndexException(string Message) : base(Message)
        { }
    }

    public class EmptyListException : ExceptionList
    {
        public EmptyListException(string Message) : base(Message)
        { }
    }

    public class NullElementException : ExceptionList
    {
        public NullElementException(string Message) : base(Message)
        { }
    }
}