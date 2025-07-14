using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace session6
{
    internal class Program
    {

        #region methods assginment q6,q7
        // public static void minmaxarr(int[] arr , out int min , out int max)
        //{
        //    min = arr[0];
        //    max = arr[1];
        //    for(int i=1;  i <arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //}

        #endregion  
        #region methods assignment q4,q5
        //public static bool isprime(int x)
        //{
        //    if (x <= 1)
        //    {
        //        return false;
        //    }
        //    for (int i = 2; i < x; i++ )
        //    {
        //        if(x % i == 0)
        //        {
        //            return false;
        //        }

        //    }
        //    return true;
        //}
        #endregion

        #region methods Assignment q1,q2,q3

        //
        //public static void change(  int a)
        // {
        //     a = 5;
        //     Console.WriteLine($"before change inside {a}");
        // }

        //public static void change(ref int a)
        //{
        //    a = 5;
        //    Console.WriteLine($"before change inside {a}");
        //} 


        //2

        //public static int sumarr( ref int[]arr)
        //{
        //    Console.WriteLine($"before hashcode => {arr.GetHashCode()} ");
        //    arr = new int[] { 10, 20 };
        //    int sum = 0;
        //    for(int i =0; i<arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //        Console.WriteLine($"after hashcode => {arr.GetHashCode()} ");
        //    Console.WriteLine(sum);
        //}


        //3
        //public static void calc(int x , int y , out int sum , out int sub)
        //{
        //    sum =  x +  y;
        //    sub = x - y;
        //}

        #endregion

        #region methodsdemo
        //public static void printshape()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("$__");
        //    }
        //}
        //public static void printshape(int count , string shape)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(shape);
        //    }
        //}

        //public static void swap( ref int A , ref int B  )
        //{
        //    //Console.WriteLine("======before swapping [inside] ========");
        //    //Console.WriteLine($"a = {A} , b = {B}");

        //    //int temp = A;
        //    //A = B;
        //    //B = temp;
        //    //Console.WriteLine("======after swapping [inside] ========");
        //    //Console.WriteLine($"a = {A} , b = {B}");
        //}


        //public static int sumarr(ref int[] arr)

        //{
        //    Console.WriteLine($"before hashcode => {arr.GetHashCode()} ");
        //    arr[0] = 100;

        //    int sum =0;

        //    for(int i=0; i < arr.Length; i++)
        //    {
        //        sum= sum+ arr[i];

        //    }
        //    return sum;
        //    Console.WriteLine($"after hashcode => {arr.GetHashCode()} ");
        //    Console.WriteLine($"arr[0] => {arr[0]}");

        //}
        //public static void summulti(int x , int y , out int sum , out int multi )
        //{
        //     sum = x + y;
        //     multi = x * y;
        //}



        //public static int sumarr( params int[] arr)
        //{
        //    int sum = 0;
        //    for (int i =0; i<arr.Length; i++)
        //    {
        //        sum += arr[i];

        //    }
        //    return sum;
        //}

        #endregion  // demo
        static void Main(string[] args)
        {

            

            //assignment 
           

            #region q6
            #region q6
            int[] myarr = { 10, 20, 15, 30 };
            minmaxarr(myarr, out int min, out int max);
            Console.WriteLine($"min num {min} ");
            Console.WriteLine($"max num {max} ");


            #endregion
            #endregion
            #region q4,q5
            #region q4 , q5 
            //4 
            //5 
            //Console.WriteLine("enter number");

            //int num = int.Parse(Console.ReadLine());
            //if (isprime(num))
            //{
            //    Console.WriteLine($"this is a prime number {num} ");
            //}
            //else
            //{
            //    Console.WriteLine("not prime number");
            //}

            #endregion
            #endregion
            #region q1 ,q2 q3 ,q
            #region q1 , q2 ,q3
            //q1
            //int x = 7;
            //Console.WriteLine($"before change outside ");
            //change(ref x);
            //Console.WriteLine($"after change outside {x} ");

            // q2
            //int[] myarr = { 3, 4 };
            //Console.WriteLine($"before hashcode outside {myarr.GetHashCode()} ");
            //sumarr(ref myarr);
            //int sum = sumarr( ref myarr);
            //Console.WriteLine(sum);
            //Console.WriteLine(myarr);
            //Console.WriteLine($"after hashcode outside {myarr.GetHashCode()} ");

            // q3
            //int sum;
            //int sub;
            //calc(20, 10, out sum,out sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);

            #endregion
            #endregion


            #region nullable value  type
            #region nullable value  type
            //int? x = null;
            //int y;
            //if (x.HasValue)
            //    y = x.Value;
            //else
            //{
            //    y = 7;
            //}
            //Console.WriteLine(y);
            #endregion
            #endregion
            

            #region boxing and unboxing
            //int x = 10;
            //object obj = x; // boxing
            //// parent = child
            //// safe casting
            //x =  (int) obj; //unboxing
            ////child = parent
            ////unsafe casting
            //Console.WriteLine(x);

            #endregion

            #region functions
            //printshape(22 , "%$");
            //int x = 10, y = 20;
            //Console.WriteLine("======before swapping [outside] ========");
            //Console.WriteLine($"x = {x} , y = {y}");

            //swap(ref x, ref y);
            //Console.WriteLine("======after swapping [outside] ========");
            //Console.WriteLine($"x = {x} , y = {y}");


            //int[] nums = { 10, 20, 30, 40, 50, 60 };
            //Console.WriteLine($"before hashcode => {nums.GetHashCode()} ");
            //int result = sumarr(ref nums);
            //Console.WriteLine($"after hashcode => {nums} ");
            //Console.WriteLine($"result => {result} ");
            //Console.WriteLine(nums[0]);

            //int x = 10, y = 20, sum, multi;
            //summulti(x, y, out _, out multi);
            ////Console.WriteLine(sum);
            //Console.WriteLine(multi);



            //int[] nums = { 20, 40, 60, 80 };
            //int result = sumarr(30,60,200,114,171);
            //Console.WriteLine($"sum of array => {result}");

            #endregion

        }
    }
}
