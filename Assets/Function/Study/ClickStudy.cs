using UnityEngine;
using System.Collections;
public class ClickStudy : MonoBehaviour
{
    int mPressMouseLeft = 0; int mPressMouseRight = 0; int mPressMouseMiddle = 0; void Start() { }
    void Update()
    {         //鼠标按下事件
        if (Input.GetMouseButtonDown(0))
        {            Debug.Log("按下了鼠标左键");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("按下了鼠标右键");
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("按下了鼠标中键");
        }
        //鼠标抬起事件        
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("抬起了鼠标左键");
        }
        if (Input.GetMouseButtonUp(1))
        {
            Debug.Log("抬起了鼠标右键");
        }
        if (Input.GetMouseButtonUp(2))
        {
            Debug.Log("抬起了鼠标中键");
        }
        //鼠标长按事件   
        if (Input.GetMouseButton(0))
        {
            mPressMouseLeft++;
        }        else
        {
            if (mPressMouseLeft > 0)
            {
                Debug.Log("鼠标左键按下的帧数为: " + mPressMouseLeft.ToString());
            }
            mPressMouseLeft = 0;
        }
        if (Input.GetMouseButton(1))
        {
            mPressMouseRight++;
        }
        else
        {
            if (mPressMouseRight > 0)
            {
                Debug.Log("鼠标右键按下的帧数为: " + mPressMouseRight.ToString());
            }
            mPressMouseRight = 0;
        }
        if (Input.GetMouseButton(2))
        {
            mPressMouseMiddle++;
        }
        else
        {
            if (mPressMouseMiddle > 0)
            {
                Debug.Log("鼠标中键按下的帧数为: " + mPressMouseMiddle.ToString());
            }
            mPressMouseMiddle = 0;
        }
        //键盘按下事件 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("按下了空格");
        }
        //键盘抬起事件  
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("抬起了空格");
        }
        //键盘长按事件   
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("空格正在被按下状态");
        }
    }
}
