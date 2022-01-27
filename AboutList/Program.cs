// Переменная типа List

void showList(List<int> myList)
{
    foreach (var item in myList)
    {
        Console.WriteLine(item);
    }
}

void showDictionary(Dictionary<string,int> MyDictionary)
{
    foreach(var item in MyDictionary)
    {
        Console.WriteLine($"{item.Key} {item.Value}");
    }
}
List<int> numbers = new List<int>();
numbers.Add(5);
numbers.AddRange(new List<int>{5,4,6,7,7});

showList(numbers);

Dictionary<string,int> numbersOfWords = new Dictionary<string, int>();

string str = "111 2222 333 111 555 777 555 777";
string[] words = str.Split(" ");
foreach (string word in words)
{
    if(!numbersOfWords.ContainsKey(word))
    {
    numbersOfWords[word]= 1;
    }
    else 
    { 
        numbersOfWords[word]++;
    }
}
showDictionary(numbersOfWords);