using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace CollectionViewSample;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        MyItems.Add(MyItem.Create());
        MyItems.Add(MyItem.Create());
        MyItems.Add(MyItem.Create());
    }

    public ObservableCollection<MyItem> MyItems { get; set; } = [];


    [RelayCommand]
    void AddItem()
    {
        MyItems.Add(MyItem.Create());
    }

    [RelayCommand]
    void InsertItem()
    {
        MyItems.Insert(0, MyItem.Create());
    }

    [RelayCommand]
    void InsertBeforLast()
    {
        if (MyItems.Count > 1)
        {
            MyItems.Insert(MyItems.Count - 1, MyItem.Create());
        }
    }

    [RelayCommand]
    void RemoveItemBeforeLast()
    {
        if (MyItems.Count > 1)
        {
            MyItems.RemoveAt(MyItems.Count - 2);
        }
    }

    [RelayCommand]
    void RemoveFirstItem()
    {
        if (MyItems.Count > 0)
        {
            MyItems.RemoveAt(0);
        }
    }
}
