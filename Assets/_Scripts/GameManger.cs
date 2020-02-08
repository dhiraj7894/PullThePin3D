using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public GameObject End, replay,continu, bad;
    public string[] level;

    // Start is called before the first frame update
    void Start()
    {
        End.SetActive(false);
        replay.SetActive(false);
        continu.SetActive(false);
        bad.SetActive(false);
    }

    public void setActiveEnd()
    {
        StartCoroutine(setActive());
    }
    IEnumerator setActive()
    {
        yield return new WaitForSeconds(1.0f);
        End.SetActive(true);
        continu.SetActive(true);
        bad.SetActive(true);
        replay.SetActive(false);

    }
    public void setActiveRep()
    {
        StartCoroutine(setActiveRE());
    }
    IEnumerator setActiveRE()
    {
        yield return new WaitForSeconds(1.0f);
        End.SetActive(true);
        replay.SetActive(true);
        bad.SetActive(false);
    }


    public void loadSenceLevel2()
    {
        SceneManager.LoadScene(level[1]);
    }
    public void loadSenceLevel3()
    {
        SceneManager.LoadScene(level[2]);
    }
    public void loadSenceLevel()
    {
        SceneManager.LoadScene(level[0]);
    }
    public void loadSenceLevel4()
    {
        SceneManager.LoadScene(level[3]);
    }

}
