        public static int Sum_of_3_and_5_multipliers(int range)
        {
            int i,sum = 0;
            for(i = 0; i < range; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
