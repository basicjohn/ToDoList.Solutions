using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      string description = "Walk the dog.";
      Item testItem = new Item(description);
      Assert.AreEqual(typeof(Item), testItem.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "Walk the dog.";
      Item testItem = new Item("Walk the dog.");
      string result = testItem.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      string updatedDescription = "Do the dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      Assert.AreEqual(updatedDescription, result);
    }
  }
}



//take in amount of bread int

//take in amount of pastries int

//calculate some crap

//
