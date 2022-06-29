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
    public CreateWnd createWnd;
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
            }
        );
    }

    public void RspLogin()
    {
        GameRoot.AddTips("成功登陆");
        //打开角色创建
        createWnd.SetWndState();
        //关闭登录
        loginWnd.SetWndState(false);
    }

} 