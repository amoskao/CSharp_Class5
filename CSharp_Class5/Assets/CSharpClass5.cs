#region my

/*using UnityEngine;

public class CSharpClass5 : MonoBehaviour
{
    public int A = 1, B = 20, C = 19;

    public GameObject Wall;

    public int[] scores = { 10, 55, 66, 35, 88, 15, 23, 36, 26, 26, 12, 20,54,30,55 };

    private void Start()
    {
        if (A < 5)
        {
            Debug.Log("執行判斷式...");
            A++;
            Debug.Log("A 為:"+A);
        }
        Debug.Log("在迴圈下方的敘述!");
        while (B > 10)
        {
            Debug.Log("執行 While 迴圈...");
            B--;
            Debug.Log("B 為:" + B);
        }
        Debug.Log("在迴圈下方的敘述!");
        do
        {
            Debug.Log("執行 do 迴圈...");
            C--;
            Debug.Log("C 為:" + C);
        } while (C > 5);
        Debug.Log("在迴圈下方的敘述!");
        for (int D = 1; D < 5; D++)
        {
            Debug.Log("<color=lime>執行 for 迴圈...</color>");
            Debug.Log("<color=lime>D 為:" + D + "</color>");
        }
        Debug.Log("在迴圈下方的敘述!");
        //巢狀迴圈:初始值名稱不可相同 i換成j
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 4; i++)
            {
                /*實例化，將物件生成於場景上
                //類似NEW 但會顯示在場景上
                //Instantiate(Wall);
                //多載(物件，座標，角度)
                //Quaternion 4元(x, y, z, w)
                //Quaternion.identity 零角度*/
                /*Instantiate(Wall, new Vector3(i * 1.5f, j*1.5F, 0), Quaternion.identity);

            }
        }
        Debug.Log("在迴圈下方的敘述!");

        //9*9乘法表
        for (int q = 2; q < 10; q++)
        {
            for (int w = 1; w < 10; w++)
            {
                int ANS = q * w;
                Debug.Log("<color=#edc938><size=10><b>" + q +  " * "  + w + " = " + ANS + "</b></size></color>");
            }
        }
        Debug.Log("在迴圈下方的敘述!");

        //使用 for
        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log("for 迴圈輸出分數：" + scores[i]);
        }
        
        //使用 foreach
        foreach (var score in scores)
        {
            Debug.Log("foreach 迴圈輸出分數：" + score);
        }

        //使用goto
        for (int i = 1; i < 10; i++)
        {
            if (i == 5) goto talk;
            {
                Debug.Log("<color=red>迴圈："+ i + "</color>");
            }
        }
    //標記
    talk:
        Debug.Log("<color=red>我在標記內</color>");
        Debug.Log("<color=red>嗨</color>");

        //使用 break
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("數字" + i);
            if (i == 5)
            {
                break;
            }
        }
        Debug.Log("在迴圈下方的敘述!");

        //使用 continue
        for (int i = 1; i <= 10; i++)
        {
            if (i == 10) continue;
            Debug.Log("迴圈執行第幾次：" + i);
        }

        Debug.Log("迴圈外的程式~");
        //使用 return
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("數字" + i);
            if (i == 5)
            {
                return;
            }
        }
        Debug.Log("在迴圈下方的敘述!");


        
    }


}
#endregion 