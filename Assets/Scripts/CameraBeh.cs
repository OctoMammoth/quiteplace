using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBeh : MonoBehaviour
{
    public GameObject Sphere;
    public Material WinMat;
    private bool quite = false;
    public GameObject quitePlace;
    public AudioClip quiteAudio;
    public GameObject sprite;
    public Sprite OK;

    void natura()
    {
        if (quite == false) {
            AudioSource asd = quitePlace.AddComponent<AudioSource>();
            asd.clip = quiteAudio;
            asd.loop = true;
            asd.Play();

        }
        quite = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger")
        {
            Debug.Log("WIN");
            Sphere.GetComponent<MeshRenderer>().material = WinMat;
            sprite.GetComponent<SpriteRenderer>().sprite = OK;
            natura();
        }
    }   
    //private void OnTriggerExit(Collider other)
    //{

    //    if (other.gameObject.tag == "Trigger")
    //    {
    //        Debug.Log("WIN");
    //    }
    //}
}
