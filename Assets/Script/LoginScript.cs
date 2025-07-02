using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    [SerializeField]
    InputField login;
    [SerializeField]
    InputField password;
    [SerializeField]
    Text loginText;
    [SerializeField]
    Canvas loggedInCanvas;
    [SerializeField]
    Canvas menuCanvas;
    
    void Awake()
    {
        loggedInCanvas.enabled = false;
    }

    public void OnLogin()
    {
        StartCoroutine(GetLoginText());
		GoToLoggedInCanvas ();	 
    }

    public void OnGoBackToMenu()
    {
        menuCanvas.enabled = true;
        GetComponent<Canvas>().enabled = false;
        loggedInCanvas.enabled = false;
    }

    IEnumerator GetLoginText()
    {
        WWWForm form = new WWWForm();
        form.AddField("login", login.text);
        form.AddField("password", password.text);

        WWW www = new WWW("http://localhost/ConnectToDBUsingUnity/GetUserToLogin.php", form);

        yield return www;

        string textArray = www.text;

        loginText.text = textArray;
        
    }

    void GoToLoggedInCanvas()
    {
        GetComponent<Canvas>().enabled = false;
        loggedInCanvas.enabled = true;
    }
    
}
