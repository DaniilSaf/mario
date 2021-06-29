using UnityEngine;

public class Drain : MonoBehaviour
{
    public string m_ResourceName = "playerwater";
    public float m_DrainSpeed = 1;

    private Resource m_Resource;
    private void Start()
    {
        m_Resource= Resource.Find(m_ResourceName);  
    }

    // Update is called once per frame
    void Update()
    {
        m_Resource.Change(-m_DrainSpeed * Time.deltaTime);  
    }
}
