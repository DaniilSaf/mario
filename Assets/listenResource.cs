using UnityEngine;

public interface IFloat
{
    void Use(float f);
}

public class listenResource : MonoBehaviour
{
    public string m_res = "gold";
    private IFloat[] users;

    private void Start()
    {
        Resource.Find(m_res).ChangeEvent += UseValue;
        users = GetComponentsInChildren<IFloat>();

        
    }
    private void UseValue(float value)
    {
        foreach (var user in users)
            user.Use(value);
    }
}
