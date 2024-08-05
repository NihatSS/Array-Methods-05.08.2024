//using System.Text;

//StringBuilder stringBuilder = new StringBuilder();


//stringBuilder.Append("salam");
//stringBuilder.Append(" sagol");

//Console.WriteLine(stringBuilder);



//int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 6, 5, 4, 3, 2, 1 };

//int[] arr2 = new int[8];

//int[] arr3 = new int[8] {1,2,3,4,5,6,7,8};



//Console.WriteLine(arr1.Contains(6));

//var res = Array.FindAll(arr1, m => m == 8);

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}


//var res =Array.Exists(arr1, m => m == 9);

//var res = Array.IndexOf(arr1 , 3);
//Console.WriteLine(res);

//var res = Array.LastIndexOf(arr1 , 5);
//Console.WriteLine(res);

int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 6, 5, 4, 3, 2, 1 };

//int[] arr2 = new int[8];

//Array.Copy(arr1, arr2, arr2.Length);

//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}

//Array.Resize(ref arr2, arr1.Length);

//Console.WriteLine(arr2.Length);

//Console.WriteLine(arr1.Sum());

//Console.WriteLine(arr1.Average());

//Array.Sort(arr1);
//Array.Reverse(arr1);

//foreach (var item in arr1)
//{
//    Console.WriteLine(item);
//}

string[] names = { "Nihat", "Ferdi", "Aqil", "Valeh", "Hemid", "Nergiz", "Fadile","Terxan" };

//var res = names.OrderBy(m => m).ToArray();

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

//var res = names.OrderByDescending(m => m).ToArray();
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}







//Parametr olaraq string qebul eden metod yazmalisiz.
//Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. (Cavid gelirse , ekranda divaC gorsensin).

//1)
static void ReverseString(string word)
{
    string reverseword = "";
    for (int i = word.Length-1;  i>=0; i--)
    {
        reverseword += word[i];
    }
    Console.WriteLine(reverseword);
}

ReverseString("Nihat");


//2)
//static void ReverseString(string word)
//{
//    char[] reverseWord = word.ToCharArray();
//    Array.Reverse(reverseWord);
//    Console.WriteLine(reverseWord);
//}
//ReverseString("Nihat");

//String qebul eden bir method yazirsiz. Hemin method qebul etdiyi stringin ilk herfini boyuk yazdirmalidir.
//(salam gelirse ekranda Salam gostermelidir)


static void GetWord(string word)
{
    string result = char.ToUpper(word[0]) + word.Substring(1);
    Console.WriteLine(result);
}

GetWord("nihat");


