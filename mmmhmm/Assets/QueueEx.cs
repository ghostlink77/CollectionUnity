using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueEx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Queue queue = new Queue();

        for (int i = 0; i < 5; i++)
        {
            queue.Enqueue(i);
        }

        Debug.Log($"Queue Count : {queue.Count}");
        Debug.Log($"현재 0번 요소 : {queue.Peek()}");

        object data = queue.Dequeue();
        Debug.Log($"큐에서 빠져나온 데이터 : {data}");

        Debug.Log($"Queue Count : {queue.Count}");

        queue.Clear();

        Debug.Log($"Queue Count after Clear : {queue.Count}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
