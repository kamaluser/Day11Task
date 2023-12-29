using System;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Day11Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int verilmisEded = 5;
            KvadrataYukselt(ref verilmisEded);
            Console.WriteLine(verilmisEded); // Task 1


            int[] nums = { 2, 4, 5, 7, 8 };
            ArrayinElementlerininKvadrati(ref nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            } // Task 2

            string text = "Hikmet Abbasov";
            RemoveSpace(ref text);
            Console.WriteLine(text); // Task 3

            int[] intArr = { 1, 2, 3, 4, 5 };
            int num = 6;
            AddElementToArray(ref intArr, num);
            for (int i = 0;i < intArr.Length;i++)
            {
                Console.WriteLine(intArr[i]);
            } // Task 4
        }

        // 1. Verilmiş ədədi kvadratına yüksəldən metod. (Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)

        static void KvadrataYukselt(ref int eded)
        {
            eded = eded * eded;
        }


        // 2. Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod

        static void ArrayinElementlerininKvadrati(ref int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
        }

        // 3. Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq
        // hala gətirən metod.Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız varsa onu yaratdigimiz
        // metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.

        static void RemoveSpace(ref string text)
        {
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]!=' ')
                {
                    newText += text[i];
                }
            }
            text = newText;
        }

        // 4. Parameter olaraq integer array variable-i ve bir integer value qebul eden
        // ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.
        // Misal üçün int[] nums = {1,5,7} deyə bir variable-mız var.yazdığımız metodu çağırıb
        // arqument olaraq nums və 3 göndərsək nums arrayının dəyəri  {1,5,7,3} olmalıdır.

        static void AddElementToArray(ref int[] intArr, int num)
        {
            int[] newArr = new int[intArr.Length + 1];
            int index = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                newArr[index] = intArr[i];
                index++;
            }
            newArr[intArr.Length] = num;
            intArr = newArr;
        }
    }
}
