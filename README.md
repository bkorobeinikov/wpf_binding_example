# wpf_binding_example

nuget package: MVVMLight 

MainWindowViewModel - viewmodel class, that binds to DataContext of MainWindow (see MainWindow.cs file)

Because we've set DataContext, we can all kind of "magic" stuff in MainWindow.xaml:

<TextBox Text="{Binding Input}" /> - binds to string property from MainWindowViewModel.cs
<Button Command="{Binding ValidateCmd}">Validate</Button> - which will trigger Validate function from MainWindowViewModel.cs

--------------------

ListBox binds to "List" property of type ObservableCollection, that collection implements INotifyCollectionChanged interface
so each time you modify collection (add, remove, replace items) WPF UI gonna be notified about that, and ListBox will update iteself automaically.
