using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed = 20;
    int offscreen = 0;
    public KeyCode FirstUp;
    public KeyCode FirstDown;
    public KeyCode FirstLeft;
    public KeyCode FirstRight;
    public float tiltAngle;
    bool gameIsPaused = false;
    float smooth = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            offscreen++;
            if (offscreen > 3)
            {
                if (transform.position.y >= 0)
                {
                    transform.position = new Vector3(7, 2, 0);
                }
                else
                {
                    transform.position = new Vector3(7, -2, 0);
                }
            }
        }
        if (Input.GetKey(FirstUp))
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * MovementSpeed;
        }
        else if (Input.GetKey(FirstDown))
        {
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime * MovementSpeed;
        }
        /*else if (Input.GetKey(FirstLeft))
        {
            float tiltAroundZ = 1 * tiltAngle;
            Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
        else if (Input.GetKey(FirstRight))
        {
            float tiltAroundZ = 1 * -tiltAngle;
            Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
        */else if (Input.GetKey(KeyCode.R))
        {
            //SceneManager.LoadScene("TwoPlayer");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
