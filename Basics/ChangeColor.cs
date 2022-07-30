using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //起始颜色
        //获得渲染组件，材料，颜色，设置为绿色
        GetComponent<Renderer>().material.color = Color.green;
        
    }

    // Update is called once per frame
    void Update()
    {
        //更新颜色
        //如果按下键1，颜色变为红色
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        //如果按住键1并且按下Y键，颜色变为黄色
        if (Input.GetKey(KeyCode.Alpha1)&&Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        //如果按住键1并且按下B键，颜色变为蓝色
        if (Input.GetKey(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        //如果按住键1并且按下G键，颜色变为灰色
        if (Input.GetKey(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }
        //如果按住键1并且按下G键，颜色变为灰色
        if (Input.GetKey(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.Alpha0))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

    }

}
