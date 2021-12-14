using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int highScore;
    public string username;
    public string highScoreName;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        Debug.Log("Score: " + highScore);
    }
}

/*[System.Serializable]
class SaveData
{
    public int highScore;
    public int highScoreName;
}

public void SaveScore()
{
    SaveData data = new SaveData();

}
}*/
