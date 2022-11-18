using System;

namespace Delegates_Classwork {
    class Program {
        static void Main(string[] args)
        {        //public delegate bool CheckNums(int num);

            //public delegate void ChangeString(string str, int age);

            //public delegate int StringLength(string str);

            static void Main(string[] args)
            {
                #region Nullable
                //string name = null;
                //Person person = null;

                //string name = null;
                //string text = name;

                //int? a = null;
                //Console.WriteLine(a);

                //Test test = new Test();
                //Console.WriteLine(test.Id);
                #endregion

                #region Delegate-Bool-Predicate
                //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //Console.WriteLine(SumNums(CheckNumsGreaterThanFour, nums));


                //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                //var result = nums.FindAll(m => m > 4);
                //var result = nums.FindAll(m => m % 2 == 0);
                //var result = nums.FindAll(m => m % 2 == 1);
                //var result = nums.FindAll(m => m % 2 == 0 && m > 6);

                //var result = nums.FindAll(CheckNumsGreaterThanFour);

                //List<int> nums = new List<int> { 1, 5, 10, 88, 21, 32, 42, 53, 63 };

                //var result = SumOfNumsDividedInto21(CheckNumsDividedInto21, nums);

                //Console.WriteLine(result);

                //var result = nums.FindAll(m => m % 21 == 0).Sum(m => m);

                //Console.WriteLine(result);
                #endregion

                #region Delegate-Void-Action
                //ShowString(StringToUpper, "Ali", 88);

                //ChangeString func = new ChangeString(StringToUpper);

                //func += StringToLower;
                //func.Invoke("Ali", 88);

                //Action<string, int> action = StringToUpper;
                //action.Invoke("Ali", 88);

                //ShowString(StringToUpper, "Ali", 88);

                //ShowPowerOfNums(CalculatePower, 4, 2);

                //Action<int, int> func = CalculatePower;
                //func.Invoke(4, 2);
                #endregion

                #region Delegate-ReturnType-Func
                //Console.WriteLine(ShowStringLength(GetStringLength,"Ali"));

                //Func<string, int> func = GetStringLength;
                //Console.WriteLine(func.Invoke("Ali"));

                //Console.WriteLine(ShowFactorial(GetFactorial, 5));

                //Func<int, int> func = GetFactorial;
                //Console.WriteLine(func.Invoke(4));
                #endregion
            }

            #region Nullable
            //public static string GetData(int? id)
            //{
            //    if (id is null)
            //    {
            //        return "Not found";
            //    }
            //    return "";
            //}
            #endregion

            #region Delegate-Bool-Predicate

            //public static bool CheckNumsDividedInto21(int num)
            //{
            //    return num % 21 == 0;
            //}

            //public static int SumOfNumsDividedInto21(Predicate<int> func, List<int> list)
            //{
            //    int sum = 0;

            //    foreach (var item in list)
            //    {
            //        if (func(item))
            //        {
            //            sum += item;
            //        }
            //    }

            //    return sum;
            //}



            //public static bool CheckOddNums(int num)
            //{
            //    return num % 2 == 1;
            //}
            //public static bool CheckEvenNums(int num)
            //{
            //    return num % 2 == 0;
            //}
            //public static bool CheckNumsGreaterThanFour(int num)
            //{
            //    return num > 4;
            //}


            //public static int SumNums(Predicate<int> func, int[] arr)
            //{
            //    int sum = 0;

            //    foreach (var item in arr)
            //    {
            //        if (func(item))
            //        {
            //            sum += item;
            //        }
            //    }

            //    return sum;
            //}

            //public static int EvenNums(int[] arr)
            //{
            //    int sum = 0;

            //    foreach (var item in arr)
            //    {
            //        if (item % 2 == 0)
            //        {
            //            sum += item;
            //        }
            //    }

            //    return sum;
            //}

            //public static int NumsGreaterThanFour(int[] arr)
            //{
            //    int sum = 0;

            //    foreach (var item in arr)
            //    {
            //        if (item > 4)
            //        {
            //            sum += item;
            //        }
            //    }

            //    return sum;
            //}
            #endregion

            #region Delegate-Void-Action
            //public static void StringToLower(string str, int age)
            //{
            //    Console.WriteLine(str.ToLower() + " " + age);
            //}

            //public static void StringToUpper(string str, int age)
            //{
            //    Console.WriteLine(str.ToUpper() + " " + age);
            //}


            //public static void ShowString(Action<string, int> func, string str, int age)
            //{
            //    func(str, age);
            //}

            //public static void CalculatePower(int num, int power)
            //{
            //    Console.WriteLine(Math.Pow(num, power));
            //}

            //public static void ShowPowerOfNums(Action<int, int> func, int num, int power)
            //{
            //    func(num, power);
            //}
            #endregion

            #region Delegate-ReturnType-Func
            //public static int GetStringLength(string str)
            //{
            //    return str.Length;
            //}

            //public static int ShowStringLength(Func<string, int> func, string str)
            //{
            //    return func(str);
            //}

            //public static int GetFactorial(int num)
            //{
            //    int result = 1;

            //    while (num != 1)
            //    {
            //        result *= num;
            //        num -= 1;
            //    }

            //    return result;
            //}

            //public static int ShowFactorial(Func<int, int> func, int num)
            //{
            //    return func(num);
            //}
            #endregion
        }

    }
}
