using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackEx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stack stack = new Stack();

        for (int i = 0; i < 5; i++)
        {
            stack.Push(i);
        }

        Debug.Log($"Stack Count : {stack.Count}");
        Debug.Log($"현재 마지막 요소 : {stack.Peek()}");

        object data = stack.Pop();
        Debug.Log($"스택에서 빠져나온 데이터 : {data}");

        Debug.Log($"Stack Count : {stack.Count}");

        stack.Clear();

        Debug.Log($"Stack Count after Clear : {stack.Count}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
