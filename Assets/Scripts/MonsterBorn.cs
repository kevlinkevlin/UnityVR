using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBorn : MonoBehaviour
{
    public GameObject Born_0;
    public float X_min,X_max,Z_min,Z_max;
   
    public void Born()
    {
        StartCoroutine(BornObject());
    }

    IEnumerator BornObject()
    {
        int Num = 0;

        while(true)
        {
            Num++;
            float rand_X = Random.Range(X_min,X_max);
            float rand_Z = Random.Range(Z_min,Z_max);
            Vector3 rand_pos = new Vector3(transform.position.x + rand_X,transform.position.y,transform.position.z + rand_Z); 
            Debug.Log("開始產生怪物");
            GameObject clone = Instantiate(Born_0,rand_pos,transform.rotation);
            clone.SetActive(true);
            yield return new WaitForSeconds(1);
        }
        
    }
}
