using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string title = "Go shopping";
        DateTime dateTime = DateTime.Now;

        // Act
        _toDoList.AddTask(title, dateTime);
        string result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[ ] Go shopping - Due: "));
        

    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title = "Go shopping";
        DateTime dateTime = DateTime.Now;

        // Act
        _toDoList.AddTask(title, dateTime);
        _toDoList.CompleteTask(title);
        string result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[✓] Go shopping - Due: "));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string title = "Go shopping";
        DateTime dateTime = DateTime.Now;

        // Act & Assert
        _toDoList.AddTask(title, dateTime);
        Assert.That(() => _toDoList.CompleteTask("Drink beer"), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange
        string expected = "To-Do List:";

        // Act
        string result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string title = "Go shopping";
        DateTime dateTime = DateTime.Now;

        // Act
        _toDoList.AddTask(title, dateTime);
        string result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Does.Contain("[ ] Go shopping - Due: "));
    }
}
