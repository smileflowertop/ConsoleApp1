using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class  Program
    {
        

            /*将5000000条记录写入到ArrayList并将数据在读取出来的工作做5编

         其中写入和读取ArrayList的工作就是装箱拆箱的工作

         最后计算出执行这个方法所消耗的时间*/

            private static void RunUnbox()

            {

                int count;

                DateTime startTime = DateTime.Now;

                ArrayList myArrayList = new ArrayList();

                List<int> myTlist = new List<int>();

                for (int i = 5; i > 0; i--)                                                   //重复5次测试

                {

                    myArrayList.Clear();

                    for (count = 0; count < 5000000; count++)     //将值类型加入myArrayList数组

                        myArrayList.Add(count);                                      //装箱

                    int j;                                                                         //重新得到值

                    for (count = 0; count < 5000000; count++)

                        j = (int)myArrayList[count];                       //拆箱

                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine("使用装箱拆箱的数组-- 开始时间 {0}\n结束时间 {1}\n 花费时间{2} ", startTime, endTime,endTime-startTime);

            }                                                                                               //输出结果

            /*将5000000条记录写入到泛型List集合中并将数据在读取出来的工作做5编

       其中写入和读取List集合的工作不需要装箱与拆箱

       最后计算出执行这个方法所消耗的时间*/

            private static void RunNoUnbox()

            {

                int count;

                DateTime startTime = DateTime.Now;

                List<int> myTlist = new List<int>();

                for (int i = 5; i > 0; i--)                                                   //重复5次测试

                {

                    myTlist.Clear();

                    for (count = 0; count < 5000000; count++)     //将值类型加入泛型数组

                        myTlist.Add(count);

                    int j;                                                                         //重新得到值

                    for (count = 0; count < 5000000; count++)

                        j = myTlist[count];

                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine("使用泛型 -- 开始时间 {0}\n结束时间 {1}\n花费时间 {2}", startTime, endTime,endTime-startTime);

            }                                                                                //输出结果
            static void Main(string[] args)
            {
                RunUnbox();                                                           //调用装箱拆箱的RunUnbox方法。

                RunNoUnbox();                                                     //调用使用泛型的RunNoUnbox方法。

                Console.WriteLine("请输入任意键，结束运行");

                Console.ReadLine();


            var datas = new byte[] { 1, 2, 3, 4, 5, 110, 125, 210, 220, 250, 255 };
            var str = Convert.ToBase64String(datas);
            var bytes = Convert.FromBase64String(str);

            //person p = new person();
            //p.numberA = 1;

            //person p2 = p;
            //p2.numberA = 2;
            //Console.WriteLine("p的值是{0}，p2的值是{1}",p.numberA,p2.numberA);

            //student s = new student();
            //s.numberB = 15;

            //student s2 = s;
            //s2.numberB = 16;
            //Console.WriteLine("s的值是{0}，s2的值是{1}",s.numberB,s2.numberB);

            //people pe = new people();
            //pe.strName = "zhangsai123";
            //pe.strName = "123";
            //Console.WriteLine(pe.strName);
            //people.nAge = 12;
            //people.nAge = 13;
            //Console.WriteLine(people.nAge);


            //for (int a = 1; a <= 10; a++)
            //{
            //    if (a==3)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(a);
            //}

            //int b = 3;
            //for (int a = 1; a <= 10; a++)
            //{
            //    if (a==5)
            //    {
            //        continue;
            //       // Console.WriteLine("到5了");
            //    }
            //    Console.WriteLine(a);
            //}

            //ArrayList list =new ArrayList();
            // list.Add("zhangsai");
            // list.Add(123);
            // list.Add(DateTime.Now);
            // for (int a = 0; a < list.Count; a++)
            // {
            //     Console.WriteLine(list[a].GetType());
            // }











        }

            public int Add(object value)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(object value)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(Array array, int index)
            {
                throw new NotImplementedException();
            }

            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public int IndexOf(object value)
            {
                throw new NotImplementedException();
            }

            public void Insert(int index, object value)
            {
                throw new NotImplementedException();
            }

            public void Remove(object value)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }
        }

        class people
        {
            //静态成员变量
            public static int nAge;
            public static void Run()
            {
                Console.WriteLine("我会奔跑！");
            }
            //实例成员变量
            public string strName;
            public void Sing()
            {
                Console.WriteLine("我会唱歌");
            }
        }

        class person
        {
            public int numberA;
        }

        struct student
        {
            public int numberB;
        }
    }
