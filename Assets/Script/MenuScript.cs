using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    Canvas loginCanvas;
    [SerializeField]
    Canvas createAccountCanvas;

    void Awake()
    {
        loginCanvas.enabled = false;
        createAccountCanvas.enabled = false;
	}
	public void OnLogin()
    {
        loginCanvas.enabled = true;
        GetComponent<Canvas>().enabled = false;
    }
    public void OnCreateAccount()
    {
        createAccountCanvas.enabled = true;
        GetComponent<Canvas>().enabled = false;
    }
}
