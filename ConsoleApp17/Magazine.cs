using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp17
{
    class Magazine
    {
        private string _name;
        private Frequency _frequn= new Frequency();
        private DateTime _exitdate;
        private int _tirage;
        private List<Article> _articles = new();
        public Magazine()
        {
            _name = "О жизни студента";
            _frequn = Frequency.Monthly;
            _exitdate = new DateTime(2001,01,21);
            _tirage = 1;
            _articles.Add(new Article());
        }
        public Magazine(string name, Frequency frequn, DateTime exitdate, int tirage)
        {
            _name = name;
            _frequn = frequn;
            _exitdate = exitdate;
            _tirage = tirage;
        }
        public string Name
        { get { return _name;} set { _name = value;} }
        public Frequency Frequn { get { return _frequn; } set { _frequn = value; } }
        public DateTime Exitdate { get { return _exitdate; } set { _exitdate = value; } }
        public int Tirage { get { return _tirage; } set { _tirage = value;} }
        public List<Article> Articles
        {
            get
            {
                List<Article> cln = new List<Article>(_articles.Count);

                _articles.ForEach((item) =>
                {
                    cln.Add(new Article(item));
                });
                return cln;
            }
        }
        public double MidRate
        { get { int i; double b =0;for (i = 0; i < _articles.Count; i++) { b = _articles[i].Rating + b; } return b / _articles.Count; } }
        public bool this[Frequency index]
        {
            get => _frequn==index;
        }
        public void AddArticles(params Article[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                _articles.Add(values[i]);
            }
        }
        public override string ToString()
        {
            StringBuilder resultstring = new StringBuilder();
            resultstring.Append($"Название журнала: {_name.ToString()}\nПериодичность выхода: {_frequn.ToString()}\nТираж: {_tirage.ToString()}\nДата выхода: {_exitdate.Day.ToString()}.{_exitdate.Month.ToString()}.{_exitdate.Year.ToString()}\nСтатьи:\n");
            foreach (var article in _articles) 
            {
            resultstring.Append($"\n{article.ToString()}");
            }
            return resultstring.ToString();
        }
        public virtual string ToShortString()
        {
            StringBuilder resultstring = new StringBuilder();
            resultstring.Append($"Название журнала: {_name.ToString()}\nПериодичность выхода: {_frequn.ToString()}\nТираж: {_tirage.ToString()}\nДата выхода: {_exitdate.Day.ToString()}.{_exitdate.Month.ToString()}.{_exitdate.Year.ToString()}\n\nСредний рейтинг: {MidRate.ToString()}\n");
            return resultstring.ToString();
        }
    }
}
