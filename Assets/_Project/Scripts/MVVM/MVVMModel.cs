namespace Assets._Project.Scripts.MVVM
{
    public class MVVMModel
    {
        public readonly ReactiveProperty<int> IntValue = new();
        public readonly ReactiveProperty<string> StringValue = new();
    }
}
