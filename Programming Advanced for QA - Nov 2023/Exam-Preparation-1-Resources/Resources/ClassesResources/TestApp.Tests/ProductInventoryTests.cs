using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string product = "milk";
        double price = 2.30;
        int quantity = 3;
        string inventory = $"Product Inventory:{Environment.NewLine}milk - Price: $2.30 - Quantity: 3";

        // Act
        this._inventory.AddProduct(product, price, quantity);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(inventory));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        string inventory = $"Product Inventory:";

        // Act
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(inventory));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string product = "eggs";
        double price = 0.30;
        int quantity = 5;
        string inventory = $"Product Inventory:{Environment.NewLine}eggs - Price: $0.30 - Quantity: 5";

        // Act
        this._inventory.AddProduct(product, price, quantity);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(inventory));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        double expected = 0;

        // Act
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string product = "milk";
        double price = 2.30;
        int quantity = 3;
        double expected = 6.8999999999999995d;

        // Act
        this._inventory.AddProduct(product, price, quantity);
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
