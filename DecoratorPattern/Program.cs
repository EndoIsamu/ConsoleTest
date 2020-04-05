using System;

namespace DecoratorPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var article = default(Article);
            var valid = false;
            
            do
            {
                Console.Write("読みたい記事はニュース？ブログ？： n/b > ");
                switch (Console.ReadLine())
                {
                    case "n": 
                        article = new News("きのこの山がたけのこの里の売り上げを大きく上回りました。");
                        valid = true; break;
                    case "b":
                        article = new Blog("きのこの山は今日もいい天気だ。");
                        valid = true; break;
                }
            } while (!valid);

            valid = false;
            do
            {
                Console.Write("あなたはきのこ派？たけのこ派？： k/t > ");
                switch (Console.ReadLine())
                {
                    case "k": 
                        article = new HappyFooter(new HappyHeader(article));
                        article = NeedEmphasize("大好き？") ? new HappyHeader(article) : article;
                        valid = true; break;
                    case "t":
                        article = new SadHeader(article);
                        article = NeedEmphasize("きのこの山は大嫌い？") ? new SadFooter(article) : article;
                        valid = true; break;
                }
            } while (!valid);
            
            article.Render();
        }
        
        private static bool NeedEmphasize(string question)
        {
            do
            {
                Console.Write($"{question}： y/n > ");
                switch (Console.ReadLine())
                {
                    case "y": return true;
                    case "n": return false;
                }
            } while (true);
        }
    }
    
    public class HappyHeader : ArticleDecorator
    {
        public HappyHeader(Article article) : base(article)
        {
        }

        public override void Render()
        {
            Console.Write("【朗報】");
            article.Render();
        }
    }

    public class SadHeader : ArticleDecorator
    {
        public SadHeader(Article article) : base(article)
        {
        }

        public override void Render()
        {
            Console.Write("【悲報】");
            article.Render();
        }
    }

    public class HappyFooter : ArticleDecorator
    {
        public HappyFooter(Article article) : base(article)
        {
        }

        public override void Render()
        {
            article.Render();
            Console.WriteLine("明日もお楽しみに！");
        }
    }

    public class SadFooter : ArticleDecorator
    {
        public SadFooter(Article article) : base(article)
        {
        }

        public override void Render()
        {
            article.Render();
            Console.WriteLine("やってらんねぇぜ！");
        }
    }

    public abstract class ArticleDecorator : Article
    {
        protected readonly Article article;

        protected ArticleDecorator(Article article) : base(article.content)
        {
            this.article = article;
        }

        public abstract override void Render();
    }

    public abstract class Article
    {
        public readonly string content;
        
        protected Article(string content)
        {
            this.content = content;
        }
        
        public abstract void Render();
    }

    public class News : Article
    {
        public News(string content) : base(content) { }

        public override void Render()
        {
            Console.WriteLine($"本日のニュースです： {content}");
        }
    }
    
    public class Blog : Article
    {
        public Blog(string content) : base(content) { }

        public override void Render()
        {
            Console.WriteLine($"今日のブログ ： {content}");
        }
    }
}