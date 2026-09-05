namespace basics_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer_01
            Book book = new Book();
            //book.Pasword = "1234";  This line will cause a compilation error because Pasword is private
            #endregion
            #region answer_02
            Console.WriteLine(book.copiesInStock); // This line is valid because copiesInStock is internal and accessible within the same assembly
            #endregion
            #region answer_03
            book.Title = "C# basics";
            Console.WriteLine(book.Title);
            #endregion
            #region answer_04
            book.Genre = Genure.Science;
            Console.WriteLine(book.Genre);
            #endregion
            #region answer_05
            Console.WriteLine((int)Genure.Fiction);
            Console.WriteLine((int)Genure.NonFiction);
            Console.WriteLine((int)Genure.Science);
            #endregion
            #region answer_06
            int genreNumber = 1;
            Genure genre = (Genure)genreNumber;
            Console.WriteLine(genre);
            #endregion
            #region answer_07
            Genure _genre = Genure.Fiction;
            Console.WriteLine(_genre.ToString());
            #endregion

        }
    }
}
