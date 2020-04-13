
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem FireEffect;
    private AudioSource FireSound;
    private RaycastHit rayHit;

    private void Start()
    {
        FireSound = GetComponent<AudioSource>(); 
    }

    public void FireEvent()
    {
        if(Physics.Raycast(transform.position,transform.forward,out rayHit,100f))
        {
            FireEffect.transform.position = rayHit.point;
            FireEffect.transform.rotation = Quaternion.Euler(270,0,0);
            FireEffect.Stop();
            FireEffect.Play();
            FireSound.Stop();
            FireSound.Play();
        }
        if(rayHit.transform.tag == "Enemy")
        {
            Debug.Log("Hit!");
        }

    }
}
