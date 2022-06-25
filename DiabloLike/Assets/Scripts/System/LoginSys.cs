/****************************************************
    文件：LoginSys.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/24 4:46:56
	功能：登录注册业务
*****************************************************/

using UnityEngine;

public class LoginSys : MonoBehaviour 
{
    public static LoginSys Instance = null;
    public LoginWnd loginWnd;
    public void InitSys()
    {
        Instance = this;
        Debug.Log("InitSys Start...");
    }
    //进入登录场景
    public void EnterLogin()
    {
        //TODO
        Debug.Log("EnterLogin Start...");
        ResSvc.Instance.AsyncLoadScene(Constants.SceneLogin, () => {
            loginWnd.gameObject.SetActive(true);
            loginWnd.InitWnd();
            }
        );
        //异步加载场景
        //显示加载进度
        //加载完成后显示场景

    }

} 