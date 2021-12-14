using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UsernameScript : MonoBehaviour
{
    public TMP_InputField inputField;
    public static string playerName;

    public void OnEntry()
    {
        playerName = inputField.GetComponent<TMP_InputField>().text;
        ScoreManager.instance.username = playerName;
        //Debug.Log(playerName);

    }
}
