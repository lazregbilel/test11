namespace GameOfHangma
{
    public class Hangman
    {
        public static List<string> MatchWords = new List<string>();
        List<string> matchWords = new List<string>();

    }
    private static  bool matchwords(string word, string pattern)
    {
        StreamReader words = new StreamReader("C:\\Users\\BilelUni5\\Desktop\\tasks\\words_sorted.txt", true, Encoding.ASCII);


        for (int i=0; i< word.Length is ++)
        {
            char patternchar = pattern[i];
            char wordsch = word[i]
            words.Read(i);

        }if (patternchar != '*')
        {

        if (patternchar != wordsch)
        {
            return false;
        }
            else
            {
                if patternchar[i].containt(words);


            }

            
       
        

    }

    public static void Main(string[] args)
    {
       
        StreamReader words = new StreamReader("C:\\Users\\BilelUni5\\Desktop\\tasks\\words_sorted.txt");
        string word = words.ReadLine(); 

        string pattern = "***dg*";

            List<string> word = matchwords(word, pattern);

            Console.WriteLine(words);
            foreach (string pattern in words)
            {
                Console.WriteLine(word);
            }

    }


}