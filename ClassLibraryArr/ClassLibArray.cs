using System;

namespace ClassLibraryArr
{
    public class ArrayList<T>
    {
        private struct Element
        {
            public T info;
        }
        T[] arrList = Array.Empty<T>();
        private readonly Element[] List = new Element[100]; // Массив элементов для списка

        public void ShowList() // Вывод списка на экран      
        {
            Console.WriteLine("Получившийся список: ");
            for (int i = 0; i < arrList.Length; i++)
            {
                Console.Write(List[i].info + " ");
            }
            Console.WriteLine();
        }

        public T[] AddUpdate()
        {
            if (arrList.Length == 100)
                throw new ExceptionList("Достигнута максимальная длина списка");
            T[] updateArr = new T[arrList.Length + 1];
            for (int i = 0; i < arrList.Length; i++)
                updateArr[i] = arrList[i];
            return updateArr;
        }

        public void Add(T newElement) // Добавление элемента
        {
            arrList = AddUpdate();
            List[arrList.Length - 1].info = newElement;
        }

        public T[] RemoveUpdate()
        {
            T[] updateArr = new T[arrList.Length - 1];
            for (int i = 0; i < arrList.Length - 1; i++)
                updateArr[i] = arrList[i];
            return updateArr;
        }

        public void RemoveAt(int index) // Удаление элемента по его номеру
        {
            if (arrList.Length < 1)
                throw new ExceptionList("Список пуст");
            List[index].info = default;
            for (int i = index; i < arrList.Length; i++)
                List[i].info = List[i + 1].info;
            arrList = RemoveUpdate();
        }

        public void Remove(T newElement) // Удаление элемента по его значению
        {
            if (arrList.Length < 1)
                throw new ExceptionList("Список пуст");
            int index = IndexOf(newElement);
            List[index].info = default;
            for (int i = index; i < arrList.Length; i++)
                List[i].info = List[i + 1].info;
            arrList = RemoveUpdate();
        }

        public void Clear() //очистить массив
        {
            for (int i = 0; i < arrList.Length; i++)
            {
                List[i].info = default;
            }
        }

        public void Insert(T newElement, int index) // Вставка элемента
        {
            arrList = AddUpdate();
            for (int i = arrList.Length; i > index; i--)
                List[i].info = List[i - 1].info;
            List[index].info = newElement;
        }

        public bool Contains(T newElement) // Проверяет содержится ли элемент в списке
        {
            for (int i = 0; i < arrList.Length; i++)
            {
                if (List[i].info.Equals(newElement) == true)
                    return true;
            }
            return false;
        }

        public int IndexOf(T newElement) // Нахождние номера элемента по введенному значению
        {
            for (int i = 0; i < arrList.Length; i++)
            {
                if (List[i].info.Equals(newElement) == true)
                    return i;
            }
            throw new ExceptionList("Такого элемента в списке нет");
        }

        public ArrayList<T> SubList(int fromIndex, int toIndex)
        {
            if (arrList.Length < toIndex || fromIndex < 0)
                throw new ExceptionList("Такого индекса нет");
            ArrayList<T> UpdateList = new ArrayList<T>();
            for (int i = fromIndex; i <= toIndex; i++)
                UpdateList.Add(List[i].info);
            return UpdateList;
        }

        public T ValueOf(int index) // Нахождние номера элемента по введенному значению
        {
            if (index < arrList.Length)
                return List[index].info;
            throw new ExceptionList("Такого элемента в списке нет");
        }

        public int ListLength()
        {
            return arrList.Length;
        }

        public ArrayList(T[] arr)
        {
            arrList = arr;
            for (int i = 0; i < arr.Length; i++)
            {
                List[i].info = arr[i];
            }
        }

        public ArrayList()
        { }
    }

    public class ExceptionList : Exception //Класс для описания пользовательского типа ошибок
    {
        public ExceptionList(string Message) : base(Message) //Вызываем конструктор базового класса
        { }
    }
}