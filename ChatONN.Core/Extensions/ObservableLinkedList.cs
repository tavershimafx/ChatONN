using System.Collections;
using System.Collections.Specialized;

namespace ChatONN.Core.ViewModels
{
    public class ObservableLinkedList : INotifyCollectionChanged, IEnumerable
    {
        //private LinkedList<ChatMessageViewModel> privateList;
        private List<ChatMessageViewModel> privateList= new List<ChatMessageViewModel>();

        #region Public methods
        public int Count
        {
            get { return privateList.Count; }
        }

        public ChatMessageViewModel First
        {
            get { return privateList.First(); }
        }

        public ChatMessageViewModel Last
        {
            get { return privateList.Last(); }
        }
        #endregion

        #region Constructors
        public ObservableLinkedList()
        {
             
        }

        public ObservableLinkedList(IEnumerable<ChatMessageViewModel> collection)
        {
            for (int i = 0; i < collection.Count(); i++)
            {
                var item = collection.ElementAt(i);
                if (i != 0)
                {
                    item.Previous = collection.ElementAt(i - 1);
                }

                if (i != collection.Count() - 1)
                {
                    item.Next = collection.ElementAt(i + 1);
                }

                privateList.Add(item);
            }
        }
        #endregion

        //#region LinkedList<ChatMessageViewModel> Composition
        //public LinkedListNode<ChatMessageViewModel> AddAfter(LinkedListNode<ChatMessageViewModel> prevNode, ChatMessageViewModel value)
        //{
        //    LinkedListNode<ChatMessageViewModel> ret = privateList.AddAfter(prevNode, value);
        //    OnNotifyCollectionChanged();
        //    return ret;
        //}

        //public void AddAfter(LinkedListNode<ChatMessageViewModel> node, LinkedListNode<ChatMessageViewModel> newNode)
        //{
        //    privateList.AddAfter(node, newNode);
        //    OnNotifyCollectionChanged();
        //}

        //public LinkedListNode<ChatMessageViewModel> AddBefore(LinkedListNode<ChatMessageViewModel> node, ChatMessageViewModel value)
        //{
        //    LinkedListNode<ChatMessageViewModel> ret = privateList.AddBefore(node, value);
        //    OnNotifyCollectionChanged();
        //    return ret;
        //}

        //public void AddBefore(LinkedListNode<ChatMessageViewModel> node, LinkedListNode<ChatMessageViewModel> newNode)
        //{
        //    privateList.AddBefore(node, newNode);
        //    OnNotifyCollectionChanged();
        //}

        //public LinkedListNode<ChatMessageViewModel> AddFirst(ChatMessageViewModel value)
        //{
        //    LinkedListNode<ChatMessageViewModel> ret = privateList.AddFirst(value);
        //    OnNotifyCollectionChanged();
        //    return ret;
        //}

        //public void AddFirst(LinkedListNode<ChatMessageViewModel> node)
        //{
        //    privateList.AddFirst(node);
        //    OnNotifyCollectionChanged();
        //}

        //public LinkedListNode<ChatMessageViewModel> AddLast(ChatMessageViewModel value)
        //{
        //    LinkedListNode<ChatMessageViewModel> ret = privateList.AddLast(value);
        //    OnNotifyCollectionChanged();
        //    return ret;
        //}

        //public void AddLast(LinkedListNode<ChatMessageViewModel> node)
        //{
        //    privateList.AddLast(node);
        //    OnNotifyCollectionChanged();
        //}

        //public void Clear()
        //{
        //    privateList.Clear();
        //    OnNotifyCollectionChanged();
        //}

        //public bool Contains(ChatMessageViewModel value)
        //{
        //    return privateList.Contains(value);
        //}

        //public void CopyTo(ChatMessageViewModel[] array, int index)
        //{
        //    privateList.CopyTo(array, index);
        //}

        //public bool LinkedListEquals(object obj)
        //{
        //    return privateList.Equals(obj);
        //}

        //public LinkedListNode<ChatMessageViewModel> Find(ChatMessageViewModel value)
        //{
        //    return privateList.Find(value);
        //}

        //public LinkedListNode<ChatMessageViewModel> FindLast(ChatMessageViewModel value)
        //{
        //    return privateList.FindLast(value);
        //}

        //public Type GetLinkedListType()
        //{
        //    return privateList.GetType();
        //}

        //public bool Remove(ChatMessageViewModel value)
        //{
        //    bool ret = privateList.Remove(value);
        //    OnNotifyCollectionChanged();
        //    return ret;
        //}

        //public void Remove(LinkedListNode<ChatMessageViewModel> node)
        //{
        //    privateList.Remove(node);
        //    OnNotifyCollectionChanged();
        //}

        //public void RemoveFirst()
        //{
        //    privateList.RemoveFirst();
        //    OnNotifyCollectionChanged();
        //}

        //public void RemoveLast()
        //{
        //    privateList.RemoveLast();
        //    OnNotifyCollectionChanged();
        //}
        //#endregion

        #region INotifyCollectionChanged Members

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public void OnNotifyCollectionChanged()
        {
            if (CollectionChanged != null)
            {
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return privateList.GetEnumerator();
        }

        #endregion
    }

}