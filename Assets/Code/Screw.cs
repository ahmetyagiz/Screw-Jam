using UnityEngine;

public class Screw : MonoBehaviour
{
    [SerializeField] private Joint2D joint;  // �iviyle ili�kili olan FixedJoint2D'yi buraya ba�la

    public void DestroyNail()
    {
        // �ivi yok oldu�unda ba�lant�y� kald�r
        if (joint != null)
        {
            Destroy(joint);
        }
        // Daha sonra �iviyi yok et
        Destroy(gameObject);
    }
}