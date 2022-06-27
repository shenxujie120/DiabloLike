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
    //定义单例
    public static GameRoot Instance = null;
    public LoadingWnd loadingWnd;
    public DynamicWnd dynamicWnd;

    private void Start()
    {
        //加载时设置好
        Instance = this;
        DontDestroyOnLoad(this);
        Debug.Log("Game Start...");
        ClearUIRoot();
        Init();
    }

    private void ClearUIRoot()
    {
        Transform canvas = transform.Find("Canvas");
        for(int i = 0; i < canvas.childCount; i++)
        {
            canvas.GetChild(i).gameObject.SetActive(false);
        }
        dynamicWnd.SetWndState();
    }


    private void Init()
    {
        //服务模块加载
        ResSvc res = GetComponent<ResSvc>();
        res.InitSvc();

        AudioSvc au = GetComponent<AudioSvc>();
        au.InitSvc();

        //登录注册系统初始化
        LoginSys login = GetComponent<LoginSys>();
        login.InitSys();
        //进入登录界面并加载UI
        login.EnterLogin();
        //加载后新场景后GameRoot被卸载掉了，但由于都挂载上面不能卸载
    }

    public static void AddTips(string str)
    {
        Instance.dynamicWnd.AddTips(str);
    }

}