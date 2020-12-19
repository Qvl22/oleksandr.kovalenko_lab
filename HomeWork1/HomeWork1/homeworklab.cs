using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class DigitalRoot
    {
        public static int FindDigitalRoot(int input)
        {
            int sum = 0;
            string inputToStr = input.ToString();

            do
            {
                sum = 0;

                for (int i = 0; i < inputToStr.Length; i++)
                {
                    sum += int.Parse(inputToStr[i].ToString());
                }

                inputToStr = sum.ToString();

            } while (sum.ToString().Length != 1);

            return sum;
        }
    }
    class ListFilter
    {
        public static List<object> FilterList(List<object> inputList)
        {
            List<object> newList = inputList.FindAll(i => i.GetType() != typeof(string)).ToList();

            return newList;
        }
    }
    class FindLetter
    {

        public static char FirstNonRepeatingLetter(string input)
        {
            bool fl = true;

            for (int i = 0; i < input.Length; i++)
            {
                fl = true;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i].ToString().ToUpper() == input[j].ToString().ToUpper() && i != j)
                    {
                        fl = !fl;
                        break;
                    }
                }
                if (fl)
                    return input[i];
            }
            return ' ';
        }
    }
    class FindPairs
    {

        public static int PairsFinderFunction(int[] input)
        {
            int max = input.Max();
            int pairsCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] + input[j] == max && i != j)
                        pairsCounter++;
                }
            }

            return pairsCounter / 2;
        }
    }
    class FriendListSorter
    {
        class Friend
        {
            public string Name;
            public string Surname;

            public Friend(string _Name, string _Surname)
            {
                Name = _Name;
                Surname = _Surname;
            }
        }


        public static string Sorter(string input)
        {
            string[] FriendList = input.ToUpper().Split(';');              // массив строк с парой имя - фамилия

            List<Friend> guests = new List<Friend>(FriendList.Length);

            for (int i = 0; i < FriendList.Length; i++)
            {
                string[] temp = FriendList[i].Split(':');
                guests.Add(new Friend(temp[0], temp[1]));                  // создаю и заполняю список друзей
            }

            FriendList = new string[FriendList.Length];
            for (int i = 0; i < FriendList.Length; i++)
            {
                FriendList[i] = guests[i].Surname + " " + guests[i].Name;  // меняю имя и фамилию местами для сортировки
            }


            FriendList = FriendList.OrderBy(f => f).ToArray();             // сортирую

            for (int i = 0; i < FriendList.Length; i++)
            {
                FriendList[i] = "(" + FriendList[i].Replace(" ", ", ") + ")";  // превожу в вид (имя, фамилия)
            }

            string result = String.Join("", FriendList);                    // объединяю в строку

            return result;
        }
    }
    class NumberToIPConverter
    {
        public static string Convert(UInt32 input)
        {
            int[,] inputToBinary = new int[4, 2 * sizeof(UInt32)];
            UInt32 numerator = input;
            uint denominator = 2;
            for (int i = 3; i >= 0; i--)
            {
                for (int j = inputToBinary.GetLength(1) - 1; j >= 0; j--)
                {
                    inputToBinary[i, j] = (int)(numerator % denominator);
                    numerator /= denominator;
                }
            }


            string[] arrayToDecimal = new string[4];
            for (int sum = 0, i = 0; i < arrayToDecimal.Length; i++)
            {
                sum = 0;
                for (int j = 0; j < 8; j++)
                {
                    sum += int.Parse((inputToBinary[i, j] * Math.Pow(2, 7 - j)).ToString());
                }
                arrayToDecimal[i] = sum.ToString();
            }

            string result = string.Join(".", arrayToDecimal);

            return result;
        }
    }
    class RearrangeDigits
    {
        public static int Rearrange(int input)
        {
            int k = 0, smallest;
            string inputToStr = input.ToString();
            int[] digitsArray = new int[inputToStr.Length];

            for (int i = 0; i < digitsArray.Length; i++)
            {
                digitsArray[i] = int.Parse(inputToStr[i].ToString());                // перевожу число в массив цифр
            }

            int[] newDigitsArray = new int[digitsArray.Length];
            Array.Copy(digitsArray, newDigitsArray, digitsArray.Length);

            for (k = newDigitsArray.Length - 1; k > 0; k--)
            {
                if (newDigitsArray[k] > newDigitsArray[k - 1])
                {
                    break;
                }
            }

            if (k == 0)
                return -1;

            smallest = k;
            int minMax = k - 1;
            for (int i = k + 1; i < newDigitsArray.Length; i++)
            {
                if (newDigitsArray[i] > newDigitsArray[minMax] && newDigitsArray[i] < newDigitsArray[smallest])
                {
                    smallest = i;
                }
            }

            int temp = newDigitsArray[smallest];
            newDigitsArray[smallest] = newDigitsArray[minMax];
            newDigitsArray[minMax] = temp;

            for (int i = k; i < newDigitsArray.Length - 1; i++)
            {
                for (int j = i + 1; j < newDigitsArray.Length; j++)
                {
                    if (newDigitsArray[i] > newDigitsArray[j])
                    {
                        temp = newDigitsArray[i];
                        newDigitsArray[i] = newDigitsArray[j];
                        newDigitsArray[j] = temp;
                    }
                }
            }

            int result = int.Parse(String.Join("", newDigitsArray));

            return result;
        }
    }

}
