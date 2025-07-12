using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities.
    // Expected Result: Dequeue returns highest priority first, then next highest, then lowest.
    // Defect(s) Found: Loop skipped last item; item wasn't removed after dequeue
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        // Assert.Fail("Implement the test case and then remove this.");


        Assert.AreEqual("High", priorityQueue.Dequeue());   // 10
        Assert.AreEqual("Medium", priorityQueue.Dequeue()); // 5
        Assert.AreEqual("Low", priorityQueue.Dequeue());    // 1
    }
    [TestMethod]
    // Scenario: Enqueue multiple values with the same priority
    // Expected Result: They are dequeued in the order they were added (FIFO)
    // Defect(s) Found: Comparison favored later items due to >= instead of >
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 5);


        // Assert.Fail("Implement the test case and then remove this.");

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    public void TestPriorityQueue_EmptyQueue_Throws()
    {
        var queue = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
    }
}