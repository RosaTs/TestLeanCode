using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    public interface IStack<T>
    {
        int Count { get; }
        int GetLength();//求栈的长度
        bool IsEmpty();
        void Clear();//清空操作

        void Push(T item);

        T Pop();//出栈操作
        T Peek();//取栈顶元素
    }
    //顺序栈
    class MyStack<T> : IStack<T>
    {
        T[] a;
        int top = -1;
        int size = 10;
        
        public MyStack()
        {
            a = new T[size];
        }
        public int Count => top+1;
       
        public void Clear()
        {
            top = -1;
        }

        public int GetLength()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            if (top==-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Peek()
        {
            if (top >= 0)
            {
                T temp = a[top];
                return temp;
            }
            else
            {
                Console.WriteLine("栈为空无法删除");
                return default(T);
            }
        }

        public T Pop()
        {
            if (top>=0)
            {
                T temp = a[top];
                //a[top] = default(T);
                top--;
                return temp;
            }
            else
            {
                Console.WriteLine("栈为空无法删除");
                return default(T);
            }
        }
        /// <summary>
        /// 入栈
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            //自动扩容
            if (top + 1>this.size-1)
            {
                this.size = this.size * 2;//容量扩大一倍
                T[] temp = new T[size];

                for (int i = 0; i < a.Length; i++)
                {
                    temp[i] = a[i]; //将数组a 的值都赋值过去
                }
                a = new T[size];//重新构建一个数组a
                for (int i = 0; i < temp.Length; i++)
                {
                    a[i] = temp[i]; //扩容后将数据取回来
                }
                a[top + 1] = item;
                top++;
            }
            else
            {
                a[top + 1] = item;
                top++;
            }
          
        }
    }
}
