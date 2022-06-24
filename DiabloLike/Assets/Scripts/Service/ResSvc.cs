/****************************************************
    文件：ResSvc.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/24 4:47:27
	功能：资源加载服务
*****************************************************/

using UnityEngine;
using UnityEngine.SceneManagement;

public class ResSvc : MonoBehaviour 
{
    public static ResSvc Instance = null;
    public void InitSvc()
    {
        Instance = this;
        Debug.Log("Init ResSvc...");
    }

    public void AsyncLoadScene(string SceneName)
    {
        SceneManager.LoadSceneAsync(SceneName);
    }

}