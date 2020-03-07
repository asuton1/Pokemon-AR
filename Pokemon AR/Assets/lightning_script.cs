using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightning_script : MonoBehaviour
{
    public GameObject lightning, lightning1;
   

   public void LightningOn()
    {
        lightning1.SetActive(true);
        lightning.SetActive(true);
      
    }

    public void LightningOff()
    {
       lightning1.SetActive(false);
        lightning.SetActive(false);
      
    }


}

