namespace lab_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

//4. Створіть масив з п'яти прізвищ і виведіть їх на екран ті з них, які починаються з певної букви, яка вводиться з клавіатури.
//Створіть двовимірний цілочисельний масив А [1..10, 1..7] і знайдіть суму всіх його елементів, що мають обидва непарних індекса.