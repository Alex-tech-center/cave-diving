using UnityEngine;

public class Parallax : MonoBehaviour
{
    public enum Layer
    {
        Foreground, Midground, Background
    }
    public static float speed = 1f;

    public static float GetSpeed(Layer layer)
    {
        switch (layer)
        {
            case Layer.Foreground:
                return speed * 2;
            case Layer.Midground:
                return speed * 1f;
            case Layer.Background:
                return speed * 0.1f;
            default:
                return speed * 1;
        }
    }
}
public class ParallaxLayer : MonoBehaviour
{
    public Transform[] tiles;

    public float up = -19f;
    public Vector3 down = new Vector3(0f, 19f, 0f);

    public Parallax.Layer layer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].position += Vector3.up * Time.deltaTime * Parallax.GetSpeed(layer);

            if (tiles[i].position.y >= up)
            {
                tiles[i].position = down;
            }
        }
    }
}

