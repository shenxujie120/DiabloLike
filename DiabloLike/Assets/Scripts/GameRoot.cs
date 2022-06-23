/****************************************************
    文件：GameRoot.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/24 4:46:38
	功能：游戏入口
*****************************************************/

using UnityEngine;

public class GameRoot : MonoBehaviour 
{
    private void Start()
    {
        Debug.Log("Game Start...");

        Init();
    }

    private void Init()
    {
        //服务模块加载
        ResSvc res = GetComponent<ResSvc>();
        res.InitSvc();
        //登录注册系统初始化
        LoginSys login = GetComponent<LoginSys>();
        login.InitSys();
        //进入登录界面并加载UI
        login.EnterLogin();
    }
}