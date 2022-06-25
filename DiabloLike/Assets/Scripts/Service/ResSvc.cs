/****************************************************
    文件：ResSvc.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/24 4:47:27
	功能：资源加载服务
*****************************************************/

using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ResSvc : MonoBehaviour 
{
    public static ResSvc Instance = null;
    public void InitSvc()
    {
        Instance = this;
        Debug.Log("Init ResSvc...");
    }

    private Action prgCB = null;
    public void AsyncLoadScene(string SceneName,Action loaded)
    {
        //加载进度界面
        GameRoot.Instance.loadingWnd.gameObject.SetActive(true);
        GameRoot.Instance.loadingWnd.InitWnd();

        AsyncOperation sceneAsync=SceneManager.LoadSceneAsync(SceneName);
        //委托指向
        prgCB = ()=>{
            float val = sceneAsync.progress;
            GameRoot.Instance.loadingWnd.SetProgress(val);
            if (val == 1)
            {
                if (loaded!=null)
                {
                    loaded();
                }
                sceneAsync = null;
                prgCB = null;
                GameRoot.Instance.loadingWnd.gameObject.SetActive(false);
            }
        };
    }

    public void Update()
    {
        if (prgCB != null)
        {
            prgCB();
        }
    }

}