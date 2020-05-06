using System;

namespace ClassLibraryArr
{
    public class ArrayList<T> : IList<T>
    {
        T[] arrList = Array.Empty<T>();
        int NumberOfElements;

        public override string ToString()// Вывод списка на экран
        {
            string showlist = "List: ";
            for (int i = 0; i < NumberOfElements; i++)
            {
                showlist += arrList[i] + " ";
            }
            showlist += "\n";
            return showlist;
        }

        private T[] UpdateList() //Обновляем массив (увеличиваем на 100)
        {
            T[] updateArr = new T[arrList.Length + 100];
            Array.Copy(arrList, updateArr, arrList.Length);
            return updateArr;
        }

        public void Add(T newElement) // Добавление элемента
        {
            if (NumberOfElements == arrList.Length) 
                arrList = UpdateList();
            arrList[NumberOfElements] = newElement;
            NumberOfElements += 1;
        }

        public void RemoveAt(int index) // Удаление элемента по его номеру
        {
            if (arrList.Length < 1)
                throw new EmptyList("Список пуст");
            if (index > NumberOfElements || index < 0) 
                throw new NoIndexException("Такого индекса нет");
            arrList[index] = default;
            for (int i = index; i < arrList.Length - 1; i++)
                arrList[i] = arrList[i + 1];
            NumberOfElements -= 1;
        }

        public void Remove(T newElement) // Удаление элемента по его значению
        {
            if (arrList.Length < 1)
                throw new EmptyList("Список пуст");
            int index = IndexOf(newElement);
            arrList[index] = default;
            for (int i = index; i < arrList.Length - 1; i++)
                arrList[i] = arrList[i + 1];
            NumberOfElements -= 1;
        }

        public void Clear() //очистить массив
        {
            for (int i = 0; i < NumberOfElements; i++)
            {
                arrList[i] = default;
            }
        }

        public void Insert(T newElement, int index) // Вставка элемента
        {
            if (index > NumberOfElements - 1 || index < 0)
                throw new NoIndexException("Такого индекса нет");
            if (NumberOfElements == arrList.Length)
                arrList = UpdateList();
            NumberOfElements += 1;
            for (int i = NumberOfElements - 1; i > index; i--)
                arrList[i] = arrList[i - 1];
            arrList[index] = newElement;
        }

        public bool Contains(T newElement) // Проверяет содержится ли элемент в списке
        {
            for (int i = 0; i < NumberOfElements; i++)
            {
                if (arrList[i].Equals(newElement))
                    return true;
            }
            return false;
        }

        public int IndexOf(T newElement) // Нахождние номера элемента по введенному значению
        {
            for (int i = 0; i < NumberOfElements; i++)
            {
                if (arrList[i].Equals(newElement))
                    return i;
            }
            return -1;
        }

        public IList<T> SubList(int fromIndex, int toIndex) //Создание нового списка от элемента до элемента
        {

            if (NumberOfElements < toIndex || fromIndex < 0 || toIndex < 0 || fromIndex > NumberOfElements)
                throw new NoElementException("Такого индекса нет");
            ArrayList<T> UpdateList = new ArrayList<T>();
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
            return NumberOfElements;
        }

        public ArrayList(T[] arr)
        {
            arrList = arr;
            for (int i = 0; i < arr.Length; i++)
            {
                arrList[i] = arr[i];
            }
            NumberOfElements = arr.Length;
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
            return GetHashCode();
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

    public class NoElementException : ExceptionList
    {
        public NoElementException(string Message) : base(Message)
        { }
    }

    public class NoIndexException : ExceptionList
    {
        public NoIndexException(string Message) : base(Message)
        { }
    }

    public class EmptyList : ExceptionList
    {
        public EmptyList(string Message) : base(Message)
        { }
    }
}