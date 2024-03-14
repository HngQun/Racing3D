using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Update()
    {
        screenTime();
    }

    public void screenTime()
    {
        timeText.SetText(Mathf.FloorToInt(GameManager.Instance.timeOver).ToString());
    }

    public void playAgain(){
        SceneManager.LoadScene("Game");
    }

    public void backMenu(){
        SceneManager.LoadScene("Menu");
    }
}
