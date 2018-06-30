using Layout.Models;
using NLipsum.Core;
using System;
using System.Collections.Generic;

namespace Layout
{
    public class GeradorFeed
    {
        public static IEnumerable<Feed> ListaFeed()
        {
            var random = new Random();

            var lista = new List<Feed>();

            var count = random.Next(30);
            for (int i = 0; i < count; i++)
            {
                if(random.NextDouble() >= 0.5) {
                    lista.Add(new Feed
                    {
                        Users = Users(),
                        LikesCount = Likes(),
                        Audience = random.NextDouble() >= 0.5 ? "friends.png" : "world.png",
                        PostBody = LipsumGenerator.GenerateHtml(1),
                        PostTime = random.Next(5, 59).ToString(),
                        SharedsCount = random.Next(100).ToString(),
                        PostCount = random.Next(200).ToString(),
                        IsAngryLike = random.NextDouble() >= 0.5,
                        IsCoolLike = random.NextDouble() >= 0.5,
                        IsCryLike = random.NextDouble() >= 0.5,
                        IsHeart = random.NextDouble() >= 0.5,
                        IsKkkLike = random.NextDouble() >= 0.5,
                        IsOhLike = random.NextDouble() >= 0.5,
                    });
                } else {
                    lista.Add(new FeedWithImage
                    {
                        Users = Users(),
                        LikesCount = Likes(),
                        Audience = random.NextDouble() >= 0.5 ? "friends.png" : "world.png",
                        PostBody = LipsumGenerator.GenerateHtml(1),
                        PostTime = random.Next(5, 59).ToString(),
                        SharedsCount = random.Next(100).ToString(),
                        PostCount = random.Next(200).ToString(),
                        IsAngryLike = random.NextDouble() >= 0.5,
                        IsCoolLike = random.NextDouble() >= 0.5,
                        IsCryLike = random.NextDouble() >= 0.5,
                        IsHeart = random.NextDouble() >= 0.5,
                        IsKkkLike = random.NextDouble() >= 0.5,
                        IsOhLike = random.NextDouble() >= 0.5,
                    });
                }


                lista.Add(new Feed
                {
                    Users = Users(),
                    LikesCount = Likes(),
                    Audience = random.NextDouble() >= 0.5 ? "friends.png" : "world.png",
                    PostBody = LipsumGenerator.GenerateHtml(1),
                    PostTime = random.Next(5, 59).ToString(),
                    SharedsCount = random.Next(100).ToString(),
                    PostCount = random.Next(200).ToString(),
                    IsAngryLike = random.NextDouble() >= 0.5,
                    IsCoolLike = random.NextDouble() >= 0.5,
                    IsCryLike = random.NextDouble() >= 0.5,
                    IsHeart = random.NextDouble() >= 0.5,
                    IsKkkLike = random.NextDouble() >= 0.5,
                    IsOhLike = random.NextDouble() >= 0.5,
                });
            }

            return lista;
        }

        public static string Users()
        {
            var lorium = new LipsumGenerator();
            var random = new Random();

            var lista = new List<string>();

            for (int i = 0; i < 2; i++)
            {
                var s = string.Empty;
                var r = random.Next(2, 4);
                for (int j = 0; j <= r; j++)
                {
                    s = $"{s} {lorium.RandomWord()}";
                }
                lista.Add(s);
            }

            string users = string.Empty;
            foreach (var user in lista)
            {
                users = $"{users} > {user}";
            }

            return users;
        }

        public static string Likes()
        {
            var lorium = new LipsumGenerator();
            var random = new Random();
            var likes = string.Empty;

            if (random.NextDouble() >= 0.5)
            {
                switch (random.Next(4))
                {
                    case 1:
                        likes = $"{lorium.RandomWord()} e outras {random.Next(50)} pessoas reagiram";
                        break;
                    case 2:
                        likes = $"{lorium.RandomWord()} {lorium.RandomWord()} e outras {random.Next(50)} pessoas reagiram";
                        break;
                    case 3:
                        likes = $"{lorium.RandomWord()} {lorium.RandomWord()} {lorium.RandomWord()} e outras {random.Next(50)} pessoas reagiram";
                        break;
                    default:
                        likes = $"{lorium.RandomWord()} {lorium.RandomWord()} e outras {random.Next(50)} pessoas reagiram";
                        break;
                }
            }
            else
            {
                likes = random.Next(50).ToString();
            }

            return likes;
        }
    }
}
