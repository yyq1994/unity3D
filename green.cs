using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //��ʼ��ɫ
        //�����Ⱦ��������ϣ���ɫ������Ϊ��ɫ
        GetComponent<Renderer>().material.color = Color.green;
        
    }

    // Update is called once per frame
    void Update()
    {
        //������ɫ
        //������¼�1����ɫ��Ϊ��ɫ
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        //�����ס��1���Ұ���Y������ɫ��Ϊ��ɫ
        if (Input.GetKey(KeyCode.Alpha1)&&Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        //�����ס��1���Ұ���B������ɫ��Ϊ��ɫ
        if (Input.GetKey(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        //�����ס��1���Ұ���G������ɫ��Ϊ��ɫ
        if (Input.GetKey(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }
        //�����ס��1���Ұ���G������ɫ��Ϊ��ɫ
        if (Input.GetKey(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.Alpha0))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

    }

}
