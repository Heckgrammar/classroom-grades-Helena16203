namespace BlankCSDotNet8
{
    internal class Program
    {
        //define structures and functions here
        struct Student
        {
            public string name;
            public int studentID;
            public int formGroup;
            public Student(string nameGiven, int studentIDgiven, int formGroupGiven)
            {
                name = nameGiven;
                studentID = studentIDgiven;
                formGroup = formGroupGiven;
            }
        }
        static void Main(string[] args)
        {
            //implementation goes in here
            int studentCount = 0;

            Console.WriteLine("How many students do you want to store?");
            int MAX_STUDENTS = Convert.ToInt32(Console.ReadLine());
            String [,] students = new string [MAX_STUDENTS,2];


            for (int i = 0; i < MAX_STUDENTS; i++)
            {
                Console.WriteLine("What is student " + (i+1) + "s name?");
                string NAME = Console.ReadLine();
                students[i, 0] = NAME;
                Console.WriteLine("What is student " + (i + 1) + "s ID?");
                string ID = Console.ReadLine();
                students[i, 1] = ID;
                Console.WriteLine("What is student " + (i+1) + "s form group?");
                string FORMGROUP = Console.ReadLine();
                students[i, 2] = FORMGROUP; 
            }

            Console.WriteLine("How many subjects do you want?");
            int maxSubjects = Convert.ToInt32(Console.ReadLine());
            string[,] Subjects = new string[maxSubjects,MAX_STUDENTS];
            for (int i = 0; i < MAX_STUDENTS; i++)
              {
                for (int j = 0; j < maxSubjects; j++)
                {
                    Console.WriteLine("What did " + students[i,0] + "score in subject " + j);
                    Subjects[i, j] = Console.ReadLine();
                }
            }
        }
    }
}
