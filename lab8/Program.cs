namespace lab8
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Write what program you need 1 - Fraction , 2 - ComplexNumbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    cs1.task_1();
                    break;
                case 2:
                    cs2.task_2();
                    break;
            }
            //cs3.task_3();
            
        }
    }
}