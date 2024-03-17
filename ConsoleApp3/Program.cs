// 1.temperator
//int temperator = 22;
//if (temperator <=15 ){ Console.WriteLine("hava soyuqdu"); }
//if (temperator > 15) { Console.WriteLine("hava isdidi"); }



// 2.ayin gunleri
//string month = "yanvar";
//switch (month)
//{
//    case "yanvar":
//        Console.WriteLine("bu ayda 31 gun var");
//        break;
//    case "mart":
//        Console.WriteLine("bu ayda 31 gun var");
//        break;
//    case "may":
//        Console.WriteLine("bu ayda 31 gun var");
//        break;
//    case "iyul":
//        Console.WriteLine("bu ayda 31 gun var");
//        break;
//    case "avgust":
//        Console.WriteLine("bu ayda 31 gun var");
//        break;
//    case "oktyabr":
//        Console.WriteLine("bu ayda 31 gun var");
//        break;
//    case "dekabr":
//        Console.WriteLine("bu ayda 31 gun var");
//        break;
//    case "aprel":
//        Console.WriteLine("bu ayda 30 gun var");
//        break;
//    case "iyun":
//        Console.WriteLine("bu ayda 30 gun var");
//        break;
//    case "sentyabr":
//        Console.WriteLine("bu ayda 30 gun var");
//        break;
//    case "noyabr":
//        Console.WriteLine("bu ayda 30 gun var");
//        break;
//    case "fevral":
//        Console.WriteLine("bu ayda 28 gun var");
//        break;
//}





// 3. faktorial
//int num = 5;
//int hasil = 1;
//for (int i = 1; i <= num; i++)
//{
//    hasil = hasil * i;
//}
//Console.WriteLine(hasil);





//4.musbet ededin sade ve murekkeb olmaqi
//int num = 13;
//int count = 0;
//for (int i = 2; i < num; i++)
//{
//   if (num % i == 0)
//    {
//        count++;
//    } 
//}
//if (count != 0)
//{
//    Console.WriteLine("eded murekkebdir");
//}
//else if (num == 2 || num == 1)
//{
//    Console.WriteLine("ne sade ne murekkebdir");
//}
//else
//{
//    Console.WriteLine("eded sadedir");
//}




// 5.arraydaki tek ededlerin cemi 
//int[] arr = { 2, 3, 12, 5, 11 };
//int sum = 0;
//for (int i = 0;i < arr.Length; i++)
//{
//    if (arr[i]% 2 != 0)
//    {
//        sum = sum + arr[i];        
//    }
//}
//Console.WriteLine(sum);





//6. arraydaki en boyuk eded
//int[] arr = { 2, 3, 12, 5, 11 };
//int maxnum = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] >maxnum)
//    {
//        maxnum = arr[i];
//    }
//}
//Console.WriteLine(maxnum);



// 7)3  reqemli ededin reqemlerinin  bir birine ferqli olmaqo yoxlama
//int num = 313;
//int one = num / 100;
//int two = (num / 10) / 10;
//int three = num % 10;
//if (one == two || one == three|| two == three){ Console.WriteLine(" mertebeler ferqli deil"); }
//else { Console.WriteLine("mertebler ferqlidi"); }





//8.2 in quveti
//int num = 17;
//int count = 0;
//while (num > 1)
//{
//    num /= 2; 
//    count++; 
//}Console.WriteLine( count );



// 9.ededin reqemlerinin cemi 
//int num = 231;
//int sum = 0;
//while (num > 0)
//{
//    int one = num % 10;
//    sum += one;
//    num /= 10;
//}
//Console.WriteLine(sum);




// 10 .arraydaki en kicik element
//int[] arr = { 2, 3, 12, 5, 11 };
//int min = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < min)
//    {
//        min=arr[i];
//    }
//}
//Console.WriteLine(min);




// 11.arrayda nece reqem oldugun tapin
//int[] arr = { 2, -3, 7,12, 5, 11 };
//int count =0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if ( arr[i]>=0 && arr[i]<10 )
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);




//12.iki  reqemli ededin teklik ve onluq muqayise etmek
//int num = 62;
//int onluq = num / 10;
//int teklik  = num % 10;
//if (onluq > teklik)
//{
//    Console.WriteLine("onluq teklikden boyukdur");
//}
//else if (onluq == teklik)
//{
//    Console.WriteLine("beraberdi");
//}
//else
//{
//    Console.WriteLine("teklik onluqdan  boyukdur");
//}



//13.arraydaki kicik elementle boyukun yerini deismey 
//int[] arr = { 2, 3, 12, 5, 11 };
//int min = 0;
//int max = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[max] > arr[i])
//    {
//        max = i;
//    }
//    if (arr[min] < arr[i])
//    { min = i; } 
//}
//arr[max] = arr[max] + arr[min]; 
//arr[min] = arr[max] - arr[min];
//arr[max] = arr[max] - arr[min];
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}




// 14. necemertebeli oldugun tapmaq
//int num = 30420;
//int count = 0;
//while (num > 0)
//{ count++;
//   num = num / 10;
//   Console.WriteLine(  count);
//}



// 15.    4 reqemli ededin eveline 7 sonuna  8 elave edin
//int num = 3333;
//int vurma = 800000 + num*10 + 2;
//Console.WriteLine(vurma);



//16.eyni ededi sonuna elave etmey 123=123123
//int num = 123;
//int eded = num * 1000 + num;
//Console.WriteLine(eded);



//17.   3 reqemli ededin sonuna 7 elaeve edib 7 faizin tap
//int num = 777;
//int eded = (num * 10 + 7) * 7 / 100;
//Console.WriteLine(eded);


//18 cut tek oldugun tapo
//int num = 14;
//if (num %2== 0)
//{
//    Console.WriteLine("eded cutdur");
//}
//else
//{
//    Console.WriteLine("eded tekdir");
//}

//19.  3 ve 7 bolunen
//int num = 21;
//if (num % 21 == 0)
//{
//    Console.WriteLine("3 ve 7 ye bolunur");
//}



//20. iki ededen boyunu tap
//int one = 10;
//int two = 20;
//if (one > two) { Console.WriteLine("one twodan boyukdur"); }
//else { Console.WriteLine("two onedan  boyukdur"); }


//21 ab106 oldugunu yoxla
//string[] arr = { "AB120", "AB130", "AB126", "AB420", "AB106", "AB160" };
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == "AB106")
//    {
//        count++;
//    }
//}
//if (count != 0)
//{
//    Console.WriteLine("AB106 arrayda var");
//}
//else
//{
//    Console.WriteLine("arrayda yoxdur");
//}




// 22. 1 den m dek edlerden 15 bolneni tap
//int num = 2;
//int onenum = 50;
//int count = 0;
//for (int i = num; i < onenum; i++)
//{
//    if (i % 15 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);




/////////////////////////////////////////////////////////

//1.Ədədlərdən ibarət İki array verilib. Hər iki arrayda mövcud olan elementleri ekrana çıxaran alqoritm
//(Məsələn {4,5,9,11,15} ve {1,5,13,15}   hər ikisində 5 və 15 var bunlar ekrana cixmalidir)

int[] arr1 = { 4, 5, 9, 11, 15 };
int[] arr2 = { 1, 5, 4, 15 };
for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            Console.WriteLine(arr1[i]);
        }
    }
}







//.Siralanmamish array verilir. Verilen arrayi sort edin misal: input {5, 2, 3} output {2, 3, 5}
//int[] arr = { 5, 2, 3 }; 
//for (int i = 0; i < arr.Length - 1; i++)
//{
//    for (int j = 0; j < arr.Length - i - 1; j++)
//    {
//        if (arr[j] > arr[j + 1])
//        {
//            int eded = arr[j];   
//            arr[j] = arr[j + 1];
//            arr[j + 1] = eded;
//        }
//    }
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}



// ikinci usul


//int[] arr = { 5, 2, 3 };
//Array.Sort(arr);
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i]);
//}