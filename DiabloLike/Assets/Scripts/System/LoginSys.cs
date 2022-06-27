/****************************************************
    文件：LoginSys.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/24 4:46:56
	功能：登录注册业务
*****************************************************/

using UnityEngine;

public class LoginSys : SystemRoot
{
    public static LoginSys Instance = null;
    public LoginWnd loginWnd;
    public override void InitSys()
    {
        base.InitSys();
        Instance = this;
        Debug.Log("InitSys Start...");
    }
    //进入登录场景
    public void EnterLogin()
    {
        //TODO
        Debug.Log("EnterLogin Start...");
            resSvc.AsyncLoadScene(Constants.SceneLogin, () => {
                loginWnd.SetWndState();
                audioSvc.PlayBGAudio(Constants.BGLogin);
                GameRoot.AddTips("Load Done");
                GameRoot.AddTips("Load DoneX");
                GameRoot.AddTips("Load DoneXX");
            }
        );
        //异步加载场景
        //显示加载进度
        //加载完成后显示场景

    }

} 