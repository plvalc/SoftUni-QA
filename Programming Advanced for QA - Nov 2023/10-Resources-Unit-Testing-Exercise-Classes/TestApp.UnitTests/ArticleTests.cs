using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        _article = new Article();
    }


    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] article = { "Article Content Author", "Article2 Content2 Author2", "Article3 Content3 Author3" };

        // Act
        Article result = _article.AddArticles(article);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article article = new()
        {
            ArticleList = new()
            {
            new Article {
            Title = "Some title",
            Content = "Some content",
            Author = "Some Author"
            },
            new Article
            {
            Title = "Any title",
            Content = "Any content",
            Author = "Any Author"
            }
            }
        };
        string expected = $"Any title - Any content: Any Author{Environment.NewLine}Some title - Some content: Some Author";

        // Act
        string result = this._article.GetArticleList(article, "title");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article article = new()
        {
            ArticleList = new()
            {
            new Article {
            Title = "Some title",
            Content = "Some content",
            Author = "Some Author"
            },
            new Article
            {
            Title = "Any title",
            Content = "Any content",
            Author = "Any Author"
            }
            }
        };

        // Act
        string result = this._article.GetArticleList(article, "year");

        // Assert
        Assert.That(result, Is.EqualTo(String.Empty));
    }
}
