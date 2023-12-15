using System;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        string sender = "Ivan";
        string msg = "Good morning!";
        string expected = $"Chat Room Messages:{Environment.NewLine}Ivan: Good morning! - Sent at ";

        // Act
        _chatRoom.SendMessage(sender, msg);
        string result = _chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain(expected));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange
        string expected = string.Empty;

        // Act
        string result = _chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        //// Arrange
        //string sender = "Ivan";
        //string msg = "Good morning!";
        //string sender2 = "Petar";
        //string msg2 = "Coffee?";
        //string expected = $"Chat Room Messages:{Environment.NewLine}Ivan: Good morning! - Sent at 15.12.2023 ã.{Environment.NewLine}Petar: Coffee? - Sent at 15.12.2023 ã.";

        //// Act
        //_chatRoom.SendMessage(sender, msg);
        //_chatRoom.SendMessage(sender2, msg2);
        //string result = _chatRoom.DisplayChat();

        //// Assert
        //Assert.That(result, Is.EqualTo(expected));        

        // Arrange
        string sender = "Ivan";
        string msg = "Good morning!";
        string sender2 = "Petar";
        string msg2 = "Coffee?";
        string expected = $"Chat Room Messages:{Environment.NewLine}Ivan: Good morning! - Sent at ";
        string expected2 = $"Petar: Coffee? - Sent at ";

        // Act
        _chatRoom.SendMessage(sender, msg);
        _chatRoom.SendMessage(sender2, msg2);
        string result = _chatRoom.DisplayChat();

        // Assert
        Assert.That(result, Does.Contain(expected));
        Assert.That(result, Does.Contain(expected2));
    }
}
