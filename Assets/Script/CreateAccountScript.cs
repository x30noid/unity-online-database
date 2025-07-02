using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateAccountScript : MonoBehaviour
{
    [SerializeField]
    InputField login;
    [SerializeField]
    InputField password;
    [SerializeField]
    InputField email;
    [SerializeField]
    Canvas menuCanvas;
    
    public void OnCreateAccount()
    {
        WWWForm form = new WWWForm();
        form.AddField("login", login.text);
        form.AddField("password", password.text);
        form.AddField("email", email.text);

        WWW www = new WWW("http://localhost/ConnectToDBUsingUnity/InsertUserIntoDB.php", form);

        login.text = "";
        password.text = "";
        email.text = "";
    }
    public void OnGoBackToMenu()
    {
        menuCanvas.enabled = true;
        GetComponent<Canvas>().enabled = false;
    }

}
