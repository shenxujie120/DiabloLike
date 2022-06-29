/****************************************************
    文件：LoginWnd.cs
	作者：shenx
    邮箱: shenxujie120@126.com
    日期：2022/6/26 4:40:31
	功能：登录注册界面
*****************************************************/

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginWnd : WindowRoot 
{
    public TMP_InputField iptAcct;
    public TMP_InputField iptPwd;
    public Button btnEnter;
    public Button btnNotice;

    protected override void InitWnd() {
        base.InitWnd();
        //获取本地存储的账号密码
        if (PlayerPrefs.HasKey("Acct") && PlayerPrefs.HasKey("Pwd"))
        {
            iptAcct.text = PlayerPrefs.GetString("Acct");
            iptPwd.text=PlayerPrefs.GetString("Pwd");
            //SetText(iptAcct., PlayerPrefs.GetString("Acct"));
            //SetText(iptPwd.GetComponent<TMP_Text>(), PlayerPrefs.GetString("Pwd"));
        }
        else 
        {
            iptAcct.text = "xiao9";
            iptPwd.text = "nimama";
        }
    }

    //TO 存储输入的账号和密码
    public void ClickLoginBtn()
    {
        //播放登录音效
        audioSvc.PlayUIAudio(Constants.UILoginBtn);
        
        string Acct = iptAcct.text;
        string Pwd = iptPwd.text;
        //记录缓存
        if (Acct!= "" &&  Pwd!= "")
        {
            PlayerPrefs.SetString("Acct",Acct);
            PlayerPrefs.SetString("Pwd", Pwd);

            //发送网络请求
            LoginSys.Instance.RspLogin();
        }
        else
        {
            GameRoot.AddTips("账号或密码不能为空");
        }



    }

}