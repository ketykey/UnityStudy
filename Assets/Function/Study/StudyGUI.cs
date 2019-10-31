using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyGUI : MonoBehaviour
{
    public Texture tex;
    string editName;
    string editPassword;
    float toolBarValue0;
    float toolBarValue1;
    void Start()
    {
        editName = "input your name";
        editPassword = "input your password";
        toolBarValue0 = 0;
        toolBarValue1 = 0;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "learn GUI");//字符串显示在屏幕上
        GUI.DrawTexture(new Rect(10, 50, 100, 80), tex);//绘制贴图

        //检测按钮
        if (GUI.Button(new Rect(10, 200, 100, 30), "普通按钮")) {
            Debug.Log("push the button.");
        }
        //检测连续按钮
        if (GUI.RepeatButton(new Rect(10, 250, 100, 30), "连续按钮")) {
            Debug.Log("pushing button now!!");
        }

        //设置文本输入框
        editName = GUI.TextField(new Rect(150, 40, 200, 30), editName, 15);
        editPassword = GUI.PasswordField(new Rect(150,80,200,30),editPassword,"*"[0],15);

        //垂直和水平滑动条
        toolBarValue0 = GUI.VerticalSlider(new Rect(200, 200, 30, 100), toolBarValue0, 100, 0);
        toolBarValue1 = GUI.HorizontalSlider(new Rect(200, 180, 100, 30), toolBarValue1, 0, 100);
    }
}
