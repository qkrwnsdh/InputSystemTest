using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResManager : MonoBehaviour
{
    public ItemDrag itemDrag = default;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ResManager �� Assets ���� �������� ���ҽ��� ��� ã�ƿ��� ����.");
        Debug.Log("1��° Call �ؾ� ��.");

        itemDrag.myLogFunc("ResManager ���� �α� ��� ��...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
