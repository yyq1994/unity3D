using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_positioon : MonoBehaviour
{
    //移动速度
    public float move_speed = 5f;
    // Update is called once per frame
    private void Start()
    {
        //为了看着明显，设置物体为红色
        GetComponent<Renderer>().material.color = Color.red;
        
    }
    void Update()
    {
        //获取横轴输入,按下方向键，←会得到负数，→会得到正数
        float horizontalInput = Input.GetAxis("Horizontal");
        //float horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log("H坐标轴: " + horizontalInput);
        //获取纵轴输入,按下方向键，↑会得到负数，↓会得到正数
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log("V坐标轴" + verticalInput);

        //更新位置，按下方向键灰改变位置
        transform.position = transform.position + new Vector3(horizontalInput * move_speed * Time.deltaTime, verticalInput * move_speed * Time.deltaTime, 0);
        Debug.Log("位置： " + transform.position);
       
    }
}
