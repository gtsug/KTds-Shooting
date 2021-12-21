using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간에 한번씩 적을 생성하고 싶다.
// 필요속성 : 적공장, 생성시간, 경과시간
public class EnemyGOD : MonoBehaviour
{
    // 필요속성 : 적공장, 생성시간, 경과시간
    public GameObject enemyFactory;
    public float createTime = 2;
    float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 일정시간에 한번씩 적을 생성하고 싶다.
        // 1. 시간이 흘렀으니까
        // 2. 생성시간이 됐으니까
        // 3. 적이 있어야 한다. (생성)
        // 4. 적을 배치하고 싶다.
    }
}
