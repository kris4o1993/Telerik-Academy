namespace HumanFactory
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Human pesho = Human.CreateHuman(15);
            Console.WriteLine(pesho.ToString());
        }
    }
}
