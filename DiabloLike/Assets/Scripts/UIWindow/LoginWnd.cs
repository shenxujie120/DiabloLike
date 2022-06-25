/****************************************************
    文件：LoginWnd.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/26 4:40:31
	功能：登录注册界面
*****************************************************/

using UnityEngine;
using UnityEngine.UI;

public class LoginWnd : MonoBehaviour 
{
    public InputField iptAcct;
    public InputField iptPwd;
    public Button btnEnter;
    public Button btnNotice;

    public void InitWnd() {
        //获取本地存储的账号密码
        if (PlayerPrefs.HasKey("Acct") && PlayerPrefs.HasKey("Pwd"))
        {
            //iptAcct.text = PlayerPrefs.GetString("Acct");
            //iptPwd.text = PlayerPrefs.GetString("Pwd");
        }
        else 
        {
            //iptAcct.text = "";
            //iptPwd.text = "";
        }
    }

    //TO 存储输入的账号和密码

}