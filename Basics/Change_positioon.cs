using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_positioon : MonoBehaviour
{
    //�ƶ��ٶ�
    public float move_speed = 5f;
    // Update is called once per frame
    private void Start()
    {
        //Ϊ�˿������ԣ���������Ϊ��ɫ
        GetComponent<Renderer>().material.color = Color.red;
        
    }
    void Update()
    {
        //��ȡ��������,���·����������õ�����������õ�����
        float horizontalInput = Input.GetAxis("Horizontal");
        //float horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log("H������: " + horizontalInput);
        //��ȡ��������,���·����������õ�����������õ�����
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log("V������" + verticalInput);

        //����λ�ã����·�����Ҹı�λ��
        transform.position = transform.position + new Vector3(horizontalInput * move_speed * Time.deltaTime, verticalInput * move_speed * Time.deltaTime, 0);
        Debug.Log("λ�ã� " + transform.position);
       
    }
}
