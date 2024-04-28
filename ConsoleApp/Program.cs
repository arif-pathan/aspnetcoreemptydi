// See https://aka.ms/new-console-template for more information
Console.WriteLine("IEnumerable, ICollection, IList, List<T>");

string str = "\n\nA list or container that can hold some things is called an IEnumerable. " +
    "All of the elements in the IEnumerable can be iterated through. " +
    "Instead of using a container to hold a list of items, you can only add, delete, update, and so on. " +
    "This form of list container is the most fundamental. " +
    "An IEnumerable just contains an enumerator to assist in iterating over the elements. " +
    "You must iterate over the list's elements to obtain the item count because an " +
    "IEnumerable does not even save the number of things in the list." +
    "\r\n\r\nWhereas, Another collection type that enhances IEnumerable's functionality to add, remove, " +
    "and update elements in the list is called ICollection. The ICollection also keeps track of the number of items it contains, " +
    "so we don't have to loop through every member to determine the overall number of elements. " +
    "It takes O(1) time to retrieve the total item count. ICollection has the following features: " +
    "enumerating the elements, filtering the elements, adding new elements, deleting existing elements, updating existing elements," +
    " and obtaining the number of items in the list that are currently available." +
    "\r\n\r\nIList extends ICollection. In addition to the combined activities of IEnumerable and ICollection, " +
    "an IList can also execute additional operations like adding or removing elements from the middle of a list. " +
    "You can iterate over the elements using a foreach loop or a for a loop." +
    "\r\n\r\nIn case of Strongly typed objects can be found in the List<T> collection, which also has methods for sorting," +
    " searching, and list modification. It belongs to the System.Collections." +
    "Generic namespace and is an ArrayList in generic form. " +
    "The highly typed list of objects represented by this generic list collection class can be accessed by using an " +
    "integer index that begins at 0. It also offers a variety of tools for filtering, organizing, and searching the " +
    "list of things.";


Console.WriteLine(str);


//IEnumerable - Toget count iterate through whole collection, For reading
//    ICollection - add, modify, delete items, Has seperate count property
//    Ilist - add or delete items in between


//    List<T> generics, strongly typed
//    searching sorting filtering