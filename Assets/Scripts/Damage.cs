using UnityEngine;
using UnityEngine.UI;
public class Damage : MonoBehaviour
{
    public float HP = 100.0f;
    public Image HP_Bar;
    public Image Restart_Img;
    public Image Complete_Img;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Under Attack!");
       
        HP -= 25.0f;
        HP_Bar.fillAmount = HP / 100.0f;
        if(HP <= 0)
        {
            Restart_Img.gameObject.SetActive(true);
        }
    }
    private void Update()
    {
        if(GMScript.Monster_Num >= 10)
        {
            Complete_Img.gameObject.SetActive(true);
        }
    }
}
