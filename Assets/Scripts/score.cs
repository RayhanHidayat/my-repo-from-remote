using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // Showing text in UI text player position
        scoreText.text = player.position.z.ToString("0");
    }
}
