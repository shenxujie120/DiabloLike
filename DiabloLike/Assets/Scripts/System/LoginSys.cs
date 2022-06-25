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
    public void InitSys()
    {
        Debug.Log("InitSys Start...");
    }
    //进入登录场景
    public void EnterLogin()
    {
        //TODO
        GameRoot.Instance.loadingWnd.gameObject.SetActive(true);
        GameRoot.Instance.loadingWnd.InitWnd();

        Debug.Log("EnterLogin Start...");
        ResSvc.Instance.AsyncLoadScene(Constants.SceneLogin);
        //异步加载场景
        GameRoot.Instance.loadingWnd.gameObject.SetActive(true);
        //显示加载进度
        //加载完成后显示场景

    }
} 