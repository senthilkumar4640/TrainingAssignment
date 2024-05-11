using System;
using System.Linq;
namespace MaximumofConsecutiveNumbersinArray;
class Program
{
    public static void Main(string[] args)
    {

            //     string value = Console.ReadLine();
            //     int size = value.Length;
            //     char[] array = new char[size];
            //     for(int i=0;i<size;i++)
            //     {
            //         array[i]=value[i];
            //     }
                
            //     string res="";
            //     foreach(char i in value)
            //     {
            //         if(!res.Contains(i))
            //         {
            //             res = res + i;
            //         }
            //     }
            //     char[] resArray = res.ToCharArray();
            //    // Console.WriteLine(res);
            //     int count =0;
            //     for(int i=0;i<resArray.Length;i++)
            //     {
            //         for(int j=0;j<array.Length-1;j++)
            //     {
            //         if(array[i] == resArray[j])
            //         {
            //             count++;
            //             Console.Write(resArray[i]+""+count);
                        
            //         }
                    
            //     }
            //     count =0;
            //     }
                
               



                // for(int i=0;i<size;i++)
                // {
                //     if(array[i] == array[i]);
                // }


                string value = Console.ReadLine();
                int index = int.Parse(Console.ReadLine());
                string subStr = Console.ReadLine();

                string[] valueArray = value.Split(' ');
                string[] subStrArray = subStr.Split(' ');
                
                string res = "";
                string res1 ="";
                string res2="";
                for(int i=0;i<index;i++)
                {
                    res = res + valueArray[i] + " ";
                }
                for(int i=0;i<subStrArray.Length;i++)
                {
                    res1 = res1 + subStrArray[i] + " ";
                }
                for(int i=index;i<valueArray.Length;i++)
                {
                    res2 = res2 + valueArray[i] + " ";
                }

                Console.Write(res + res1 + res2);
    }
}
    
