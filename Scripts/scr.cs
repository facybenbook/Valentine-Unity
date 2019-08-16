using UnityEngine;
using UnityEngine.UI;

public class scr : MonoBehaviour {
    public Text pressEnter;
    public GameObject turnOffCam;
    public GameObject turnOnCam;
    public GameObject card;

    void Start()
    {
        Cursor.visible = false;
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
    }

    void OnTriggerEnter(Collider other)
    {
        pressEnter.color = new Color(225, 225, 225, 255);
    }

    private void OnTriggerExit(Collider other)
    {
        pressEnter.color = new Color(225, 225, 225, 0);
    }

    private void Update()
    {
        if (Input.GetButtonUp("Submit") && pressEnter.color.a == 255)
        {
            turnOffCam.SetActive(false);
            turnOnCam.SetActive(true);
            card.GetComponent<Animator>().SetBool("StartAnima", true);
            pressEnter.color = new Color(225, 225, 225, 0);
        }
    }
}
