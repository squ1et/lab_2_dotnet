using System;

namespace lab_2
{
    internal class Array1D
    {
        public bool error = false;
        private string[] a;
        private int length = 5;
        private char filterLetter;

        public int Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                {
                    length = value;
                    a = new string[length];
                }
                else
                {
                    error = true;
                }
            }
        }

        public string this[int i]
        {
            get
            {
                if (0 <= i && i < length) return a[i];
                else
                {
                    error = true;
                    return null;
                }
            }
            set
            {
                if (0 <= i && i < length) a[i] = value;
                else
                {
                    error = true;
                }
            }
        }

        public Array1D()
        {
            a = new string[length];
        }

        public Array1D(string[] arr)
        {
            a = arr;
        }

        public Array1D(int size)
        {
            Length = size;

            if (Length > 10)
            {
                error = true;
                return;
            }

            string[] names = { "Олександр", "Іван", "Михайло", "Вова", "Сергій",
                               "Дмитро", "Владислав", "Олег", "Володимир", "Максим" };

            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = names[rnd.Next(names.Length)];
            }
        }

        public char FilterLetter
        {
            get { return filterLetter; }
            set { filterLetter = value; }
        }

        public string Show
        {
            get
            {
                var result = a.Where(name => name.StartsWith(filterLetter.ToString(), StringComparison.OrdinalIgnoreCase));

                if (!result.Any())
                    return $"Немає імен на літеру '{filterLetter}'";

                return string.Join(", ", result);
            }
        }
    }
}
