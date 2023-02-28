namespace ConsoleApp17
{
    class Article
    {
        public Person Autor { get; set; }
        public string NameOfArticle { get; set; }
        public double Rating { get; set;}
        public Article(Person a, string b, double c) 
        {
            Autor = a;
            NameOfArticle = b;
            Rating = c;
        }
        public Article()
        {
            Autor = new Person();
            NameOfArticle = "Имя статьи";
            Rating = 5.0;
        }
        public Article(Article art)
        {
            Autor = art.Autor;
            NameOfArticle = art.NameOfArticle;
            Rating = art.Rating;
        }
        public override string ToString()
        {
            return $"Автор:\n{Autor.ToString()}\nНазвание статьи: {NameOfArticle}\nРейтинг: {Rating}\n";
        }
    }
}
