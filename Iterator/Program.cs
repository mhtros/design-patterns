using Iterator.Collections;
using Iterator.Iterators;

var array = new IterableArray<int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
var simpleIterator = array.CreateIterator<SimpleIterator<int>>();
var backAndForthIterator = array.CreateIterator<BackAndForthAlternatelyIterator<int>>();

while (simpleIterator.HasMore())
{
    var item = simpleIterator.Next();
    Console.Write($"{item}, ");
}

Console.WriteLine("\n---");

while (backAndForthIterator.HasMore())
{
    var item = backAndForthIterator.Next();
    Console.Write($"{item}, ");
}

Console.WriteLine("\n---");
backAndForthIterator.Reset();

while (backAndForthIterator.HasMore())
{
    var item = backAndForthIterator.Next();
    Console.Write($"{item}, ");
}