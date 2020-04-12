using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{

    public Text defaultselecttxt;

    public GameObject skin1;
    
    public GameObject skin1locked;
    public GameObject skin1adbtn;

    public GameObject skin1selectbtn;

    public Text skin1selecttxt;

    // Start is called before the first frame update
    void Start()
    {
      if((PlayerPrefs.GetInt("unlocked")== 1)){
            skin1locked.SetActive(false);
            skin1.SetActive(true);
            skin1adbtn.SetActive(false);
            skin1selectbtn.SetActive(true);
      }
      if((PlayerPrefs.GetInt("unlocked")==2)){
          PlayerPrefs.SetInt("Skintype", 1);
          skin1locked.SetActive(true);
          skin1.SetActive(false);
          skin1adbtn.SetActive(true);
          skin1selectbtn.SetActive(false);
          defaultselecttxt.text = "Selected";


      }
    }

    // Update is called once per frame
    void Update()
    {
        if((PlayerPrefs.GetInt("Skintype")==1)){
        skin1locked.SetActive(true);
        skin1.SetActive(false);
        defaultselecttxt.text = "selected";
        skin1selecttxt.text = "select";
        }
        if((PlayerPrefs.GetInt("unlocked")==2)){
            PlayerPrefs.SetInt("Skintype", 1);
          skin1locked.SetActive(true);
          skin1.SetActive(false);
          skin1adbtn.SetActive(true);
          skin1selectbtn.SetActive(false);
          defaultselecttxt.text = "Selected";


      }
       if((PlayerPrefs.GetInt("updateunlock")== 1)){
            skin1locked.SetActive(false);
            skin1.SetActive(true);
            skin1adbtn.SetActive(false);
            skin1selectbtn.SetActive(true);
      }
    }


    public void defaultselect()
    {
        PlayerPrefs.SetInt("Skintype", 1);
        defaultselecttxt.text = "selected";
        skin1selecttxt.text = "select";
         if((PlayerPrefs.GetInt("unlocked")== 1)){
            skin1locked.SetActive(false);
            skin1.SetActive(true);
            skin1adbtn.SetActive(false);
            skin1selectbtn.SetActive(true);
      }
    }

    public void skin1select()
    {
        PlayerPrefs.SetInt("Skintype", 2);
        PlayerPrefs.SetInt("unlocked", 1);
    }

    public void skin1selected(){
        PlayerPrefs.SetInt("Skintype",2);
        skin1selecttxt.text = "selected";
        defaultselecttxt.text = "select";

    }
}
