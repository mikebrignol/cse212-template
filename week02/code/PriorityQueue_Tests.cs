
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities.
    // The item with the highest priority is added last.
    // Expected Result: Items are dequeued in descending priority order.
    // Defect(s) Found: Original code did not examine the last item in
    // the queue and did not remove dequeued items.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Apple", 1);
        priorityQueue.Enqueue("Banana", 3);
        priorityQueue.Enqueue("Orange", 5);

        Assert.AreEqual("Orange", priorityQueue.Dequeue());
        Assert.AreEqual("Banana", priorityQueue.Dequeue());
        Assert.AreEqual("Apple", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add three items with the same priority.
    // Expected Result: Items are dequeued in the same order they were added.
    // Defect(s) Found: Original code used >= when comparing priorities,
    // causing later items with equal priority to be selected first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Mike", 5);
        priorityQueue.Enqueue("John", 5);
        priorityQueue.Enqueue("Sarah", 5);

        Assert.AreEqual("Mike", priorityQueue.Dequeue());
        Assert.AreEqual("John", priorityQueue.Dequeue());
        Assert.AreEqual("Sarah", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty priority queue.
    // Expected Result: InvalidOperationException with the message
    // "The queue is empty."
    // Defect(s) Found: Verify that the empty queue requirement is handled.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}
