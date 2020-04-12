using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerScript : MonoBehaviour
{

    
    public GameObject menu;
    public GameObject statsPage;

    public GameObject storePage;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(true);
        statsPage.SetActive(false);
        storePage.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void STATS()
    {
        menu.SetActive(false);
        statsPage.SetActive(true);
        storePage.SetActive(false);

    }

    public void RETURNMENU()
    {

        menu.SetActive(true);
        statsPage.SetActive(false);    
        storePage.SetActive(false);


    }

    public void STORE()
    {

        menu.SetActive(false);
        statsPage.SetActive(false);
        storePage.SetActive(true);

    }
}
