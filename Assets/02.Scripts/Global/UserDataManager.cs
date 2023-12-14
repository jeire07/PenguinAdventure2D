using UnityEngine;

public class UserDataManager : MonoBehaviour
{
    public static UserDataManager Instance;

    public UserData userData;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GetExp()
    {

    }

    public void LevelUp()
    {

    }
}
