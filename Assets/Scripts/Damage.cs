using UnityEngine;
using UnityEngine.UI;
public class Damage : MonoBehaviour
{
    public float HP = 100.0f;
    public Image HP_Bar;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Under Attack!");
        HP -= 25.0f;
        HP_Bar.fillAmount = HP / 100.0f;
    }
}
