using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Colission : MonoBehaviour
{
    IEnumerator OnTriggerEnter (Collider colliderInfo){
        System.Random rand = new System.Random();
        var fileNumber = rand.Next(0,20);
        MeshRenderer Frame1 = null;
        Material frame1Material = null;
        MeshRenderer Frame2 = null;
        Material frame2Material = null;
        MeshRenderer Frame3 = null;
        Material frame3Material = null;
        MeshRenderer Frame4 = null;
        Material frame4Material = null;
        if (colliderInfo.gameObject.tag == "Trigger"){
            Frame1 = GameObject.Find("Quad1").GetComponent<MeshRenderer>();
            frame1Material = Resources.Load<Material>("PolyLine" + fileNumber.ToString());
            Frame2 = GameObject.Find("Quad2").GetComponent<MeshRenderer>();
            frame2Material = Resources.Load<Material>("PixelArt" + fileNumber.ToString());
            Frame3 = GameObject.Find("Quad3").GetComponent<MeshRenderer>();
            frame3Material = Resources.Load<Material>("Poisson" + fileNumber.ToString());
            Frame4 = GameObject.Find("Quad4").GetComponent<MeshRenderer>();
            frame4Material = Resources.Load<Material>("Recam" + fileNumber.ToString());
            Frame1.material = frame1Material;
            Frame2.material = frame2Material;
            Frame3.material = frame3Material;
            Frame4.material = frame4Material;
            colliderInfo.gameObject.GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds (2);
            colliderInfo.gameObject.GetComponent<Collider>().enabled = true;
        }
        else if (colliderInfo.gameObject.tag == "Trigger1"){
            Frame1 = GameObject.Find("Quad1").GetComponent<MeshRenderer>();
            frame1Material = Resources.Load<Material>("PolyLine" + fileNumber.ToString());
            Frame1.material = frame1Material;
            colliderInfo.gameObject.GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds (2);
            colliderInfo.gameObject.GetComponent<Collider>().enabled = true;
        }
        else if (colliderInfo.gameObject.tag == "Trigger2"){
            Frame2 = GameObject.Find("Quad2").GetComponent<MeshRenderer>();
            frame2Material = Resources.Load<Material>("PixelArt" + fileNumber.ToString());
            Frame2.material = frame2Material;
            colliderInfo.gameObject.GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds (2);
            colliderInfo.gameObject.GetComponent<Collider>().enabled = true;
        }
        else if (colliderInfo.gameObject.tag == "Trigger3"){
            Frame3 = GameObject.Find("Quad3").GetComponent<MeshRenderer>();
            frame3Material = Resources.Load<Material>("Poisson" + fileNumber.ToString());
            Frame3.material = frame3Material;
            colliderInfo.gameObject.GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds (2);
            colliderInfo.gameObject.GetComponent<Collider>().enabled = true;
        }
        else if (colliderInfo.gameObject.tag == "Trigger4"){
            Frame4 = GameObject.Find("Quad4").GetComponent<MeshRenderer>();
            frame4Material = Resources.Load<Material>("Recam" + fileNumber.ToString());
            Frame4.material = frame4Material;
            colliderInfo.gameObject.GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds (2);
            colliderInfo.gameObject.GetComponent<Collider>().enabled = true;
        }

    }
}
