using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class PriorityQueue<T> where T : IComparable<T>
    {
        List<T> _heap = new List<T>();

        public void push(T data)
        {
            // 힙의 맨끝에 데이터 삽입
            _heap.Add(data);

            int now = _heap.Count - 1;

            //e도장 꺠기
            while (now > 0)
            {
                int next = (now - 1) / 2;

                if (_heap[now].CompareTo(_heap[next]) < 0)
                    break;

                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                now = next;

            }
        }
        public T Pop()
        {
            // 반환 할
            T ret = _heap[0];

            // 마지막 Data 루트로 이동

            int LastInedx = _heap.Count - 1;
            _heap[0] = _heap[LastInedx];
            _heap.RemoveAt(LastInedx);
            LastInedx--;


            // 역으로 내려가기!
            int now = 0;
            while (true)
            {
                int left = 2 * now + 1;
                int rigth = 2 * now + 2;

                int next = now;
                // 왼쪽 값이 현재값 보다 크면 왼쪽으로 이동
                if (left <= LastInedx && _heap[next].CompareTo(_heap[left]) < 0)
                {
                    next = left;
                }
                if (rigth <= LastInedx && _heap[next].CompareTo(_heap[rigth]) < 0)
                {
                    next = rigth;
                }
                if (next == now)
                {
                    break;
                }

                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                now = next;

            }

            return ret;
        }
        public int Count { get { return _heap.Count; } }

    }
}
