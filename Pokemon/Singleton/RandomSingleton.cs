using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Singleton
{
    public class RandomSingleton
    {
        private static RandomSingleton _instance;
        private Random _random;

        private RandomSingleton() { 
            _random = new Random();
        }

        public static RandomSingleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new RandomSingleton();
            }

            return _instance;
        }

        public int GetRandomInteger(int maxValue)
        {
            return _random.Next(maxValue);
        }

        public int GetRandomInteger(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }
    }
}
