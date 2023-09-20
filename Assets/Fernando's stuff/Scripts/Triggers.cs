using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{

    public GameObject btn_look;
    public GameObject btn_stoplook;
    public GameObject img_clipboard;
    public GameObject Adamdoc1;
    public GameObject Adamdoc2;
    public GameObject Eviedoc1;
    public GameObject Eviedoc2;
    
    


    void Start()
    {

        btn_look.SetActive(false);
        btn_stoplook.SetActive(false);
        img_clipboard.SetActive(false);

    }


    public void Clipboard()
    {
        if (img_clipboard.activeInHierarchy)
        {

            img_clipboard.SetActive(false);
            btn_stoplook.SetActive(false);



        }
        else
        {

            img_clipboard.SetActive(true);
            btn_look.SetActive(false);
            btn_stoplook.SetActive(true);

        }

    }

    

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("clipboardAdamdoc1"))
        {
            btn_look.SetActive(true);
        }

        if (other.gameObject.CompareTag("clipboardAdamdoc2"))
        {
            btn_look.SetActive(true);
        }

        if (other.gameObject.CompareTag("clipboardEviedoc1"))
        {
            btn_look.SetActive(true);
        }

        if (other.gameObject.CompareTag("clipboardEviedoc2"))
        {
            btn_look.SetActive(true);
        }

    }


    void OnTriggerExit(Collider other)
    {



        if (other.gameObject.CompareTag("clipboardAdamdoc1"))
        {
            btn_look.SetActive(false);
            btn_stoplook.SetActive(false);
            img_clipboard.SetActive(false);
        }

        if (other.gameObject.CompareTag("clipboardAdamdoc2"))
        {
            btn_look.SetActive(false);
            btn_stoplook.SetActive(false);
            img_clipboard.SetActive(false);
        }

        if (other.gameObject.CompareTag("clipboardEviedoc1"))
        {
            btn_look.SetActive(false);
            btn_stoplook.SetActive(false);
            img_clipboard.SetActive(false);
        }

        if (other.gameObject.CompareTag("clipboardEviedoc2"))
        {
            btn_look.SetActive(false);
            btn_stoplook.SetActive(false);
            img_clipboard.SetActive(false);
        }

    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("clipboardAdamdoc1"))
        {

            Adamdoc1.SetActive(true);
            Adamdoc2.SetActive(false);
            Eviedoc1.SetActive(false);
            Eviedoc2.SetActive(false);

            if (btn_stoplook.activeInHierarchy)
            {

                btn_look.SetActive(false);

            }
            else
            {

                btn_look.SetActive(true);

            }

        }

        if (other.gameObject.CompareTag("clipboardAdamdoc2"))
        {

            Adamdoc1.SetActive(false);
            Adamdoc2.SetActive(true);
            Eviedoc1.SetActive(false);
            Eviedoc2.SetActive(false);

            if (btn_stoplook.activeInHierarchy)
            {

                btn_look.SetActive(false);

            }
            else
            {

                btn_look.SetActive(true);

            }

        }

        if (other.gameObject.CompareTag("clipboardEviedoc1"))
        {

            Adamdoc1.SetActive(false);
            Adamdoc2.SetActive(false);
            Eviedoc1.SetActive(true);
            Eviedoc2.SetActive(false);

            if (btn_stoplook.activeInHierarchy)
            {

                btn_look.SetActive(false);

            }
            else
            {

                btn_look.SetActive(true);

            }

        }

        if (other.gameObject.CompareTag("clipboardEviedoc2"))
        {

            Adamdoc1.SetActive(false);
            Adamdoc2.SetActive(false);
            Eviedoc1.SetActive(false);
            Eviedoc2.SetActive(true);

            if (btn_stoplook.activeInHierarchy)
            {

                btn_look.SetActive(false);

            }
            else
            {

                btn_look.SetActive(true);

            }

        }
    }

    public void LoadMenu(string menu)
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Jogo to load: " + menu);
        SceneManager.LoadScene(menu);

    }

}
