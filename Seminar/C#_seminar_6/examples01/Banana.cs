namespace Bag1
{
    public class Banana
    {
        # region РџРѕР»СЏ_Р_РЎРІР№РѕР№СЃС‚РІР°
        public int weight = 20;
        private string name = "Banana";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }

        }
        public int Count { get; set; }
        private string Color = "yellow";
        # endregion

        public void Print()
        {
            Console.WriteLine(GetBananaInfo());
        }

        private string GetBananaInfo()
        {
            return $"Р‘Р°РЅР°РЅ СЃ РЅР°Р·РІР°РЅРёРµРј {Name}, С†РІРµС‚РѕРј {Color}, РІРµСЃРѕРј {weight} Рё РєРѕР»РёС‡РµСЃС‚РІРѕРј {Count}";
        }

        public void Main2()
        {
            int[] array = GetArray(5);
        }

        public int[] GetArray(int size)
        {
            int[] array = new int[size];
            FillArray(array, 1);

        }

        public void FillArray(int[] array, int pow)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Math.Pow(rand.Next(0, 11), pow));
            }
        }
    }
}
