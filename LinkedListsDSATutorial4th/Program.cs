//Linked lists
using LinkedListsDSATutorial4th;
//data stores the data and the .next is the reference to the next node
Node node1 = new Node();
node1.Data = 43;

Node node2 = new Node();
node2.Data = 1412432;

Node node3 = new Node();
node3.Data = 241;

Node node4 = new Node();
node4.Data = 7462;

Node node5 = new Node();
node5.Data = 6457;

Node node6 = new Node();
node6.Data = 85;

node1.Next = node2;

node2.Next = node3;

node3.Next = node4;

node4.Next = node5;

node5.Next = node6;

node6.Next = null;


LinkedList linkedList = new LinkedList();

linkedList.InsertFirst(1);
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);

linkedList.DeleteFirst();
linkedList.DeleteFirst();


linkedList.InsertLast(9999);
linkedList.InsertLast(838838);

linkedList.DisplayList();

Console.WriteLine(linkedList.test);




