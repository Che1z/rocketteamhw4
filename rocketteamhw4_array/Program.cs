namespace rocketteamhw4_array;


class Program
{
    static void Main(string[] args)
    {

        //Q1: 利用一維陣列求10個數字的計算平均值。

        //double[] tenNumber = new double[10];
        //for (int i = 0; i < tenNumber.Length; i++)
        //{
        //    Console.WriteLine("請輸入數字");

        //    tenNumber[i] = Convert.ToDouble(Console.ReadLine());
        //}
        //double sum = 0;
        //double avg;
        //foreach (double ele in tenNumber) {
        //    sum += ele;
        //}
        //avg = sum / tenNumber.Length;
        //Console.WriteLine($"平均數值為：{avg}");

        //Q2: 利用一維陣列求10個數字的最大值。

        //double[] tenNumber = new double[10];
        //for (int i = 0; i < tenNumber.Length; i++)
        //{
        //    Console.WriteLine("請輸入數字");

        //    tenNumber[i] = Convert.ToDouble(Console.ReadLine());
        //}
        //double max = tenNumber[0];
        //for (int j = 1; j < tenNumber.Length; j++)
        //{
        //    if (tenNumber[j] > max) {
        //        max = tenNumber[j];
        //    }
        //}

        //Console.WriteLine($"最大數值為：{max}");

        //Q3: 輸入10個數字至A[]，再輸入x，
        //        判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，
        //        若不存在，則告知不存在。

        //double[] tenArray = new double[10];
        //for (int i = 0; i < tenArray.Length; i++)
        //{
        //    Console.WriteLine("請輸入數字：");
        //    tenArray[i] = Convert.ToDouble(Console.ReadLine());
        //}

        //Console.WriteLine("請輸入檢查數字：");
        //bool exists = false;
        //double userinput = Convert.ToDouble(Console.ReadLine());
        //for (int j = 0; j < tenArray.Length; j++)
        //{
        //    if (userinput == tenArray[j])
        //    {
        //        exists = true;
        //        Console.WriteLine($"該數字存在且位於{j}處");
        //        break;
        //    }
        //}
        //if (exists == false) {
        //    Console.WriteLine("該數字不存在");
        //}

        // Q4:兩個二維矩陣相加。以陣列模擬矩陣，求兩個2乘3的二維矩陣相加之
        // 結果，第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，
        // 最後將C矩陣內容顯示出來。

        //int[,] ArrayA = new int[2, 3];
        //int[,] ArrayB = new int[2, 3];
        //int[,] ArrayC = new int[2, 3];
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.WriteLine("請賦予值");
        //        ArrayA[i,j] = Convert.ToInt32(Console.ReadLine());
        //    }

        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.WriteLine("請賦予值");
        //        ArrayB[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }

        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        ArrayC[i, j] = ArrayA[i, j] + ArrayB[i, j];
        //    }
        //}
        //foreach (int itemx in ArrayC) {
        //    Console.WriteLine(item);
        //}

        //Q: 兩個矩陣相乘。求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的
        //    C矩陣，最後將C矩陣的內容顯示出來。
        //int[,] ArrayA = new int[2, 3];
        //int[,] ArrayB = new int[3, 1];
        //int[,] ArrayC = new int[2, 1];
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.WriteLine("請賦予值");
        //        ArrayA[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 1; j++)
        //    {
        //        Console.WriteLine("請賦予值");
        //        ArrayB[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 1; j++)
        //    {
        //        for (int z = 0; z < 3; z++)
        //        {
        //            ArrayC[i, j] += ArrayA[i, z] * ArrayB[z, j];
        //        }
        //    }
        //}

        //foreach (int ele in ArrayC) {
        //    Console.WriteLine(ele);
        //}


        //Q: 寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，
        //如A[i] > 5，則令A[i] = A[i] - 5，否則A[i] = A[i] + 5。
        //double[] tenArray = new double[10];
        //for (int i = 0; i < tenArray.Length; i++)
        //{
        //    Console.WriteLine("請輸入數字");
        //    tenArray[i] = Convert.ToDouble(Console.ReadLine());
        //}

        //for (int i = 0; i < tenArray.Length; i++)
        //{
        //    if (tenArray[i] > 5)
        //    {
        //        tenArray[i] -= 5;
        //    }
        //    else {
        //        tenArray[i] += 5;
        //    }
        //}
        //foreach (double ele in tenArray) {
        //    Console.WriteLine(ele);
        //}


        //Q: 寫一程式，將10個數字讀入A陣列，對每一個數字，
        //    令A[i] = A[i] + i。
        //double[] tenArray = new double[10];
        //for (int i = 0; i < tenArray.Length; i++)
        //{
        //    Console.WriteLine($"請輸入數字{i+1}");
        //    tenArray[i] = Convert.ToDouble(Console.ReadLine());
        //    tenArray[i] += i;
        //}

        //foreach (double ele in tenArray) {
        //    Console.WriteLine(ele);
        //}

        //Q: 將10個數字讀入A陣列，並建立一個B陣列，
        //    如A[i]>= 0，令B[i] = 1，否則令B[i] = 0。


        //double[] tenArray = new double[10];
        //for (int i = 0; i < tenArray.Length; i++)
        //{
        //    Console.WriteLine($"請輸入數字{i + 1}");
        //    tenArray[i] = Convert.ToDouble(Console.ReadLine());
        //}
        //double[] tenArrayB = new double[10];
        //for (int i = 0; i < tenArrayB.Length; i++)
        //{
        //    if (tenArray[i] >= 0)
        //    {
        //        tenArrayB[i] = 1;
        //    }
        //    else {
        //        tenArrayB[i] = 0;
        //    }
        //}
        //foreach (double ele in tenArrayB) {
        //    Console.WriteLine(ele);
        //}



        //Q: 將15數字存入3X5的二維陣列A中，求每一行及每一列數字的和

        //int[,] arrayA = new int[3, 5];
        //for (int i = 0; i < arrayA.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arrayA.GetLength(1); j++)
        //    {
        //        Console.WriteLine($"請輸入的數字");
        //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        ////列的總和
        //for (int i = 0; i < arrayA.GetLength(0); i++)
        //{
        //    double sumRow = 0;
        //    for (int j = 0; j < arrayA.GetLength(1); j++)
        //    {
        //        sumRow += arrayA[i, j];
        //    }
        //    Console.WriteLine($"第{i + 1}列的總和是{sumRow}");

        //}

        ////行的總和
        //for (int i = 0; i < arrayA.GetLength(1); i++)
        //{
        //    double sumColumn = 0;
        //    for (int j = 0; j < arrayA.GetLength(0); j++)
        //    {
        //        sumColumn += arrayA[j, i];
        //    }
        //    Console.WriteLine($"第{i + 1}行的總和是{sumColumn}");
        //}




        ////Q: 寫一程式，將15數字存入3X5的二維陣列A中，
        ////   求每一行及每一列數字的最小值。

        //int[,] arrayA = new int[3, 5];
        //// 賦予數值
        //for (int i = 0; i < arrayA.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arrayA.GetLength(1); j++)
        //    {
        //        Console.WriteLine("請輸入數字");
        //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}

        //// 每列最小值
        //for (int i = 0; i < arrayA.GetLength(0); i++)
        //{
        //    int min = arrayA[i, 0];

        //    for (int j = 0; j < arrayA.GetLength(1); j++)
        //    {
        //        if (arrayA[i, j] < min)
        //        {
        //            min = arrayA[i, j];
        //        }
        //    }
        //    Console.WriteLine($"第{i + 1}列的最小值{min}");
        //}

        //// 每行最小值
        //for (int i = 0; i < arrayA.GetLength(1); i++)
        //{
        //    int min = arrayA[0, i];

        //    for (int j = 0; j < arrayA.GetLength(0); j++)
        //    {
        //        if (arrayA[j, i] < min)
        //        {
        //            min = arrayA[j, i];
        //        }
        //    }
        //    Console.WriteLine($"第{i + 1}行的最小值{min}");
        //}

        ////Q: 寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。
        ////    求ai + bi，i = 1到i = 5

        //double[] arrayA = new double[5];
        //double[] arrayB = new double[5];
        //double[] arrayC = new double[5];
        //for (int i = 0; i < arrayA.Length; i++)
        //{
        //    double userinput;
        //    Console.WriteLine($"請輸入A陣列的第{i + 1}數字");
        //    arrayA[i] = Convert.ToDouble(Console.ReadLine());
        //}
        //for (int i = 0; i < arrayB.Length; i++)
        //{
        //    double userinput;
        //    Console.WriteLine($"請輸入B陣列的第{i + 1}數字");
        //    arrayB[i] = Convert.ToDouble(Console.ReadLine());
        //}
        //for (int i = 0; i < arrayA.Length; i++)
        //{
        //    arrayC[i] = arrayA[i] + arrayB[i];
        //    Console.WriteLine($"a{i+1}+b{i+1}為{arrayC[i]}");
        //}

        //Q: 輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。
        //    令x為a中的最大值，令y為b中的最大值，求x與y中較小者。

        //先分別找arrayA和arrayB的最大值，再比較

        //double[] arrayA = new double[5];
        //double[] arrayB = new double[5];
        //for (int i = 0; i < arrayA.Length; i++)
        //{
        //    Console.WriteLine($"請輸入arrayA的第{i+1}個數字");
        //    arrayA[i] = Convert.ToDouble(Console.ReadLine());

        //}
        //for (int i = 0; i < arrayB.Length; i++)
        //{
        //    Console.WriteLine($"請輸入arrayB的第{i+1}個數字");
        //    arrayB[i] = Convert.ToDouble(Console.ReadLine());

        //}
        //// 找出arrayA和arrayB的最大值
        //double arrayAMax = arrayA[0];
        //double arrayBMax = arrayB[0];
        //for (int i = 0; i < arrayA.Length; i++)
        //{

        //    if (arrayA[i] > arrayAMax) {
        //        arrayAMax = arrayA[i];
        //    }
        //    if (arrayB[i] > arrayBMax)
        //    {
        //        arrayBMax = arrayB[i];
        //    }
        //}
        //if (arrayAMax > arrayBMax)
        //{
        //    Console.WriteLine($"最大值為arrayA的{arrayAMax}");
        //}
        //else {
        //    Console.WriteLine($"最大值為arrayB的{arrayBMax}");
        //}


    }

}


