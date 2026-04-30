using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyStack
    {
        Queue<int> q1 { get; set; }
        Queue<int> q2 { get; set; }
        public MyStack()
        {
          
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        public void Push(int x)
        {
            q1.Append(x);
        }

        public int Pop()
        {
            return q1.Count > 0 ?  q1.Dequeue():0;
        }

        public int Top()
        {
           return q1.Count>0? q1.Last():-1;
        }

        public bool Empty()
        {if(q1.Count>0)
            q1.Clear();
            return q1.Count == 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
