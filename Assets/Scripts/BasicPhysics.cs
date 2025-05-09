using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicPhysics : MonoBehaviour
{
    public Vector2 vectorForce = new Vector2(9, 9);
    public float torqueAdditive = 60;
    public float jumpForce = 20;

    Vector3 screenPoint;
    Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (SceneManager.GetActiveScene().name.CompareTo("AngryBallScene") == 0)
            {
                _ClickToRemoveTether();

            }
            else 
            {
                _ClickToJump();
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            _ClickReloadScene();
        }
    }

    public void _ClickToJump()
    {
    }
    public void _ClickToRemoveTether()
    {
    }
    public void _ClickReloadScene()
    {
    }

}