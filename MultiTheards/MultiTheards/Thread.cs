public class Thread
{
    public static void Main(string[] args)
    {
        #region Thread
        //ThreadStart threadStart1 = new ThreadStart(PrintDataFirst);
        //Thread thread1 = new Thread(threadStart1);
        //thread1.Start();

        //ThreadStart threadStart2 = new ThreadStart(PrintDataSecond);
        //Thread thread2 = new Thread(threadStart2);
        //thread2.Start();
        //Thread threadFirst = new Thread(PrintDataFirst);
        //threadFirst.Start();

        //Thread threadSecond = new Thread(PrintDataSecond);
        //threadSecond.Start();


        //Thread threadFirst = new Thread(() => {
        //    while (true)
        //    {
        //        Console.WriteLine("Первичный");

        //        Thread.Sleep(40);
        //    }

        //});

        //threadFirst.Start();
        //Thread threadSecond = new Thread(() => {
        //    while (true)
        //    {
        //        Console.WriteLine("\tВторичный");

        //        Thread.Sleep(40);
        //    }

        //});

        //threadSecond.Start();

        //new Thread(() => {
        //    while (true)
        //    {
        //        Console.WriteLine("Первичный");

        //        Thread.Sleep(40);
        //    }

        //}).Start();
        //string obj = "Первичный";


        //ParameterizedThreadStart ob1 = new ParameterizedThreadStart(PrintDataFirst);
        //Thread thread1 = new Thread(ob1);
        //thread1.Start("Первичный");

        //ParameterizedThreadStart ob2 = new ParameterizedThreadStart(PrintDataSecond);
        //Thread thread2 = new Thread(ob2);
        //thread2.Start("\tВторичный");

        //Thread thread = new Thread(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Привет");

        //    }
        //});

        //thread.IsBackground = false; // ЖДЕТ
        //thread.IsBackground = true;  // НЕ ЖДЕТ
        //thread.Start();

        //Thread.Sleep(5000);


        //ThreadPool.QueueUserWorkItem((param) =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Привет");

        //    }
        //}
        //);
        //Thread.Sleep(1000);

        //ThreadPool.QueueUserWorkItem((param) =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Пока");

        //    }
        //}
        //);
        //Thread.Sleep(1000);

        //Console.ReadLine();
        #endregion

        // Action action = () =>
        // {
        //     while (true)
        //     {
        //         Console.WriteLine("First");
        //     }
        // };

        // Task task = new Task(action);

        // task.Start();

        // Console.ReadLine();

        // Task.Run(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("\tSecond");
        //    }
        //});
        // Console.ReadLine();


        //Task task = new Task(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Hello");
        //    }
        //});
        //task.Start();
        //Console.ReadLine();

        

    }


    #region
    //public static void PrintDataFirst()
    //{
    //    while (true)
    //    {
    //        Console.WriteLine("Первичный");
    //        Thread.Sleep(40);

    //    }

    //}
    //public static void PrintDataSecond()
    //{

    //    while (true)
    //    {
    //        Console.WriteLine("\tВторичный");

    //        Thread.Sleep(40);
    //    }

    //}


    //public static void PrintDataFirst(object text)
    //{
    //    while (true)
    //    {
    //        Console.WriteLine(text.ToString());
    //        Thread.Sleep(40);
    //    }
    //}
    //public static void PrintDataSecond(object text)
    //{
    //    while (true)
    //    {
    //        Console.WriteLine(text.ToString());
    //        Thread.Sleep(40);
    //    }
    //}

    #endregion

}