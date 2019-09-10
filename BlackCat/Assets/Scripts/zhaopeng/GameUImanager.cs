using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUImanager : MonoBehaviour
{
    public Text Number;
    public GameObject Backpanel;
    public GameObject panel;
    public Toggle tglsound;
    public Animator anim;
    private bool paused;
    private bool In = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            Number.text = BlackCatController.Count.ToString();
        }
        catch (System.Exception)
        {

        }
        
    }

    public void Pause()
    {
        paused = !paused;
        panel.SetActive(paused);
        Time.timeScale = paused ? 0 : 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Sample_zp");
        Time.timeScale = 1;
    }


    public void PLAY()
    {
        SceneManager.LoadScene("Choose");
    }

    public void Setting_Click()
    {
        anim.enabled = true;
        anim.SetBool("In", In);
    }

    public void Volume_Changed(float Volume)
    {
        tglsound.isOn = Volume == 0 ? true : false;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Boss1()
    {
        SceneManager.LoadScene("");
        Time.timeScale = 1;
    }

    public void Boss2()
    {
        SceneManager.LoadScene("");
        Time.timeScale = 1;
    }

    public void Level32()
    {
        SceneManager.LoadScene("");
        Time.timeScale = 1;
    }

    public void Level45()
    {
        SceneManager.LoadScene("");
        Time.timeScale = 1;
    }
}
