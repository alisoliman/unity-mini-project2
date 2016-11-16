using UnityEngine;

public class Player : MonoBehaviour {
    private float movementSpeed = 0;
    private Animator anim;
    public float turningSpeed = 60;


    // Use this for initialization
    void Start () {
        anim =  GetComponent<Animator>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            movementSpeed += .1f;
            anim.SetBool("WalkBack", false);
        }
        else {
            if (Input.GetKey(KeyCode.S)){
                movementSpeed += .1f;
                anim.SetBool("WalkBack", true);

            }
            else {
                if (movementSpeed > 0) {
                    movementSpeed -= .2f;
                }
            }
        }

        if (Input.GetKey(KeyCode.D)) {
          transform.Translate(Vector3.forward* Time.deltaTime);
            transform.Rotate(Vector3.up *150 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) {
          transform.Translate(Vector3.forward* Time.deltaTime);
            transform.Rotate(Vector3.down *150 * Time.deltaTime);
        }


        anim.SetFloat("speed", movementSpeed);
    }
}
