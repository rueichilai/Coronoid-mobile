using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCoronaMan : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity =1;
    private Rigidbody2D rb;

    public Score scoreText;
    public ParticleSystem particleLauncher;

    public ParticleSystem fireParticles;

    public ParticleSystem deathParticles;
    private bool istriggered = false;

    public GameObject gameOver;

    public GameObject skin1;

    AudioSource audioclip;







    void Start()
    {
        audioclip = GetComponent<AudioSource>();
        audioclip.Stop();
        gameOver.SetActive(false);
        PlayerPrefs.GetInt("Skintype");
        if((PlayerPrefs.GetInt("Skintype")==1)){
            skin1.SetActive(false);
            
        }
         if((PlayerPrefs.GetInt("Skintype")==2)){
             skin1.SetActive(true);
            
        }
        
        particleLauncher.Stop();
        deathParticles.Stop();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            //Jump  
            rb.velocity = Vector2.up * velocity;
            particleLauncher.Play();
            audioclip.Play();
        
        }
        else {
            particleLauncher.Stop();
            audioclip.Stop();
        }
   }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("column")){
            if( istriggered ==false){
                istriggered = true;
                scoreText.ScoreUp();
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        istriggered = false;
    }


    
    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("pipe") || collision.gameObject.CompareTag("spikyspiky"))
        {
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            Time.timeScale = 0.5f;
             Destroy(); 
            StartCoroutine(freeze());

        }

    }

    public void Destroy()
    {
        
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        skin1.SetActive(false);
        GetComponent<Renderer>().enabled = false;
        fireParticles.GetComponent<ParticleSystemRenderer>().enabled = false;
      
  
    }
     public IEnumerator freeze(){
        Destroy(deathParticles);
        particleLauncher.Stop();
        yield return new WaitForSeconds(0.16f);
        Time.timeScale = 0;
        //Destroy(deathParticles, 0.2f);
        //deathParticles.GetComponent<Renderer>().enabled = false;
        gameOver.SetActive(true);
          //if(gameOver.activeInHierarchy){
               // Destroy(deathParticles);
               // deathParticles.GetComponent<ParticleSystem>().Stop(); 
               // deathParticles.Stop();
               // deathParticles.GetComponent<Renderer>().enabled = false;
               // Destroy(gameObject);
                //deathParticles.Stop(); 
            //}
        Destroy(gameObject);

     }

       
    
}
