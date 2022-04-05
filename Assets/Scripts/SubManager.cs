using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubManager : MonoBehaviour
{
    UIText uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GameObject.Find("Name Text").GetComponent<UIText>();
    }

    // Update is called once per frame
    void Update()
    {
        if (uiText != null)
        {
            NewNameFilled(uiText.playerName);
        }
    }

    public static SubManager Instance;

    public string PlayerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void NewNameFilled(string playerName)
    {
        SubManager.Instance.PlayerName = playerName;
    }
}
