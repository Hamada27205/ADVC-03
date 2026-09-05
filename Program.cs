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

        }
    }
}
