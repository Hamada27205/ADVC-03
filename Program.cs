namespace AssignmentADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1

            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];

            //foreach (int grade in grades) Console.WriteLine(grade);
            //Console.WriteLine("===================================");
            //Console.WriteLine("Count");
            //Console.WriteLine(grades.Count);
            //Console.WriteLine("===================================");
            //Console.WriteLine("The First And The Last");
            //Console.WriteLine(grades[0]);
            //Console.WriteLine(grades[7]);
            //Console.WriteLine("===================================");
            //Console.WriteLine("Sort");
            //grades.Sort();
            //foreach (int grade in grades) Console.WriteLine(grade);
            //Console.WriteLine("===================================");
            //Console.WriteLine("the first grade above 90");
            //int First = grades.Find(N => N > 90);
            //Console.WriteLine(First);
            //Console.WriteLine("===================================");
            //Console.WriteLine("Get all grades below 75 (failing grades)");
            //List<int> failingGrades = grades.FindAll(N => N < 75);
            //foreach (int grade in failingGrades) Console.WriteLine(grade);

            //Console.WriteLine("===================================");
            //Console.WriteLine("Remove all failing grades (below 75)");
            //grades.RemoveAll(N => N < 75);
            //foreach (int grade in grades) Console.WriteLine(grade);
            //Console.WriteLine("===================================");
            //Console.WriteLine("Check if any grade equals 100");
            //bool Hundred = grades.Any(N => N == 100);
            //Console.WriteLine(Hundred);
            //Console.WriteLine("===================================");
            //Console.WriteLine("Create a List<string> where each grade becomes Grade: X");
            //List<string> Grades = grades.Select(N =>  $"Grade: {N}").ToList();
            //foreach (string grade in Grades) Console.WriteLine(grade);

            #endregion

            #region Exercise 2

            //SortedDictionary<int, string> leaderboard = new();
            //leaderboard.Add(500 , "Ahmed");
            //leaderboard.Add(200 , "Sara");
            //leaderboard.Add(800 , "Ali");
            //leaderboard.Add(350 , "Mona");

            //foreach (var player in leaderboard) Console.WriteLine($"{player.Key} = {player.Value}");
            //Console.WriteLine("===================================");
            //var firstEntry = leaderboard.First();
            //Console.WriteLine($"First Key: {firstEntry.Key}");
            //Console.WriteLine($"First Value: {firstEntry.Value}");
            //Console.WriteLine("===================================");
            //bool result = leaderboard.ContainsKey(500);
            //Console.WriteLine(result);
            //Console.WriteLine("===================================");
            //leaderboard.TryGetValue(999, out string? value);
            //Console.WriteLine(value);
            //Console.WriteLine("===================================");
            //leaderboard.Remove(200);

            //foreach (var entry in leaderboard)
            //    Console.WriteLine($"{entry.Key} = {entry.Value}");

            #endregion

            #region Exercise 3

            //Dictionary<string, string> phoneBook = new()
            //{
            //    ["Ahmed"] = "0100111",
            //    ["Sara"] = "0122222",
            //    ["Ali"] = "0155555",
            //    ["Mona"] = "0188888"
            //};

            //phoneBook["Omar"] = "0199999";

            //foreach(var phone in phoneBook) Console.WriteLine(phone); 
            //Console.WriteLine("===================================");


            //try
            //{
            //    phoneBook.Add("Ahmed", "0111111");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //Console.WriteLine("===================================");

            //bool added = phoneBook.TryAdd("Ahmed", "0111111");
            //Console.WriteLine(added);
            //Console.WriteLine("===================================");

            //bool exists = phoneBook.ContainsKey("Khaled");
            //Console.WriteLine(exists);
            //Console.WriteLine("===================================");

            //string number = phoneBook.TryGetValue("Khaled", out string? result) ? result : "Not Found";
            //Console.WriteLine(number);
            //Console.WriteLine("===================================");

            //Console.WriteLine(string.Join(", ", phoneBook.Keys));
            //Console.WriteLine(string.Join(", ", phoneBook.Values));

            #endregion

            #region Exercise 4

            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            //Console.WriteLine(emails.Count); // هنا هيطبع 2 لان StringComparer.OrdinalIgnoreCase يتعامل ان كل الاسماء زي بعض حتي لو كانت اغليتها فيها حورف capital ,small هيشوفها زي يعض
            //Console.WriteLine("===================================");

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            //HashSet<int> UnionSet = new(setA);
            //UnionSet.UnionWith(setB);
            //foreach (int x in UnionSet) Console.WriteLine(x);
            //Console.WriteLine("===================================");
            //HashSet<int> result = new HashSet<int>(setA);
            //result.IntersectWith(setB);
            //foreach (int num in result) Console.WriteLine(num);
            //Console.WriteLine("===================================");
            //HashSet<int> result2 = new(setA);
            //result.ExceptWith(setB);
            //foreach (int num in result2) Console.WriteLine(num);
            //Console.WriteLine("===================================");
            //HashSet<int> subset = new HashSet<int> { 1, 2 };
            //bool isSubset = subset.IsSubsetOf(setA);
            //Console.WriteLine(isSubset);

            #endregion

        }
    }
}
