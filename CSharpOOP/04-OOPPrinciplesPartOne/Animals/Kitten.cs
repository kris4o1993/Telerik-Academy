﻿namespace Animals
{
    class Kitten : Cat, ISound
    {
        public Kitten(string name, int age)
            :base(name, age, "Female")
        {

        }
    }
}
