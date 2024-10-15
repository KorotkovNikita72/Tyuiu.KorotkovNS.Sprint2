using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorotkovNS.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            var res = "";
            var res1 = "";
            res = n switch
            {
                1 => "02",
                2 => "03",
                3 => "04",
                4 => "05",
                5 => "06",
                6 => "07",
                7 => "08",
                8 => "09",
                9 => "09",
                10 => "10",
                11 => "11",
                12 => "12",
                13 => "13",
                14 => "14",
                15 => "15",
                16 => "16",
                17 => "17",
                18 => "18",
                19 => "19",
                20 => "20",
                21 => "21",
                22 => "22",
                23 => "23",
                24 => "24",
                25 => "25",
                26 => "26",
                27 => "27",
                28 => "28",
                29 => "29",
                30 => "30",
                31 => "01"


            };
            res1 = m switch
            {
                1 => "02",
                2 => "03",
                3 => "04",
                4 => "05",
                5 => "06",
                6 => "07",
                7 => "08",
                8 => "09",
                9 => "09",
                10 => "10",
                11 => "11",
                12 => "12",
                _ =>
                    throw new ArgumentException($"Значение m должно юыть от 1 до 12.")

            };
            return res + "." + res1;
        }
    }
}
