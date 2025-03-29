using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class ArrayListEx : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        ArrayList arrayList = new ArrayList();

        // 요소가 저장되는 인덱스 반환
        Debug.Log(arrayList.Add(10));
        // Debug.Log(arrayList.Add(12.3f));

        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(2);
        data.Add(3);
        arrayList.AddRange(data);

        arrayList.Insert(2, 4);
        PrintArrayList(arrayList);
        

        // integer only
        arrayList.Sort();

        PrintArrayList(arrayList);

        arrayList.Remove(10);
        arrayList.RemoveAt(0);
        PrintArrayList(arrayList);

        arrayList.Clear();
        PrintArrayList(arrayList);
        Debug.Log(arrayList.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintArrayList(ArrayList list)
    {
        Debug.Log("===================");
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log($"list [{i}] = {list[i]}");
        }
    }
}
